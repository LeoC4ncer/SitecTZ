using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Windows.Forms.Design;
using System.Xml.Linq;

namespace SitecTZ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int numberOfRKK = 0;
        public int numberOfAppeals = 0;
        long timeOfRKK = 0;
        long timeOfAppleance = 0;
        long timeOfUpdate = 0;
        string currentDate = "";
        List<Responsable> responsablePersons = new List<Responsable>();

        private void readFile(string fileName, bool isAppeal)
        {
            using (StreamReader sr = new StreamReader(fileName))
            {
                string line = sr.ReadLine();

                while (line != null)
                {
                    string initials = "";
                    if (isAppeal)
                        numberOfAppeals++;
                    else
                        numberOfRKK++;

                    int tabIndex = line.IndexOf('\t');
                    string superVisor = line.Substring(0, tabIndex);
                    if (superVisor.Equals("Климов Сергей Александрович"))
                    {
                        Regex regex = new Regex(@"\w+\s\w\.\w\.");

                        Match match = regex.Match(line);
                        initials = match.Value.Trim();
                    }
                    else
                    {
                        Regex regex = new Regex(@"\w+");
                        MatchCollection matchesName = regex.Matches(superVisor);
                        initials = matchesName[0].Value + " " + (matchesName[1].Value).Substring(0, 1) + "." + (matchesName[2].Value).Substring(0, 1) + ".";
                    }
                    UpdateResponsableList(initials, isAppeal);

                    line = sr.ReadLine();
                }
            }
        }

        private void UpdateResponsableList(string initials, bool isAppeal)
        {
            bool personAlreadyResponsable = false;

            foreach (Responsable responsablePerson in responsablePersons)
            {
                if (responsablePerson.Initials == initials)
                {
                    personAlreadyResponsable = true;
                    if (isAppeal)
                        responsablePerson.Appeals++;

                    else
                        responsablePerson.RKK++;
                    break;
                }
            }

            if (!personAlreadyResponsable)
            {
                if (isAppeal)
                    responsablePersons.Add(new Responsable(initials, 1, 0));
                else
                    responsablePersons.Add(new Responsable(initials, 0, 1));
            }
        }

        private void removeResponsablePersons(List<Responsable> responsablePersonsToRemove)
        {
            foreach (Responsable responsablePerson in responsablePersonsToRemove)
            {
                responsablePersons.Remove(responsablePerson);
            }
        }

        private void buttonOpenAppealsFile_Click(object sender, EventArgs e)
        {
            if (openAppealsFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            numberOfAppeals = 0;
            List<Responsable> responsablePersonsToRemove = new List<Responsable>();
            foreach (Responsable responsablePerson in responsablePersons)
            {
                responsablePerson.Appeals = 0;
                if (responsablePerson.RKK == 0)
                    responsablePersonsToRemove.Add(responsablePerson);
            }
            removeResponsablePersons(responsablePersonsToRemove);

            string fileName = openAppealsFileDialog1.FileName;
            labelFileNameOFAppeals.Text = fileName;
            readFile(fileName, true);

            labelNumberOfAppeals.Text = numberOfAppeals.ToString();
            labelNumberOfSummery.Text = (numberOfAppeals + numberOfRKK).ToString();

            stopwatch.Stop();
            timeOfAppleance = stopwatch.ElapsedMilliseconds;
            labelTimeOfAppeals.Text = timeOfAppleance.ToString();
            labelTimeofALL.Text = (timeOfAppleance + timeOfRKK + timeOfUpdate).ToString();
        }

        private void buttonOpenRKKFile_Click(object sender, EventArgs e)
        {
            if (openRKKFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            numberOfRKK = 0;
            List<Responsable> responsablePersonsToRemove = new List<Responsable>();
            foreach (Responsable responsablePerson in responsablePersons)
            {
                responsablePerson.RKK = 0;
                if (responsablePerson.Appeals == 0)
                    responsablePersonsToRemove.Add(responsablePerson);
            }
            removeResponsablePersons(responsablePersonsToRemove);

            string fileName = openRKKFileDialog1.FileName;
            labelFileNameOfRKK.Text = fileName;
            readFile(fileName, false);

            labelNumberOfRKK.Text = numberOfRKK.ToString();
            labelNumberOfSummery.Text = (numberOfAppeals + numberOfRKK).ToString();
            stopwatch.Stop();
            timeOfRKK = stopwatch.ElapsedMilliseconds;
            labelTimeOfRKK.Text = timeOfRKK.ToString();
            labelTimeofALL.Text = (timeOfAppleance + timeOfRKK + timeOfUpdate).ToString();
        }

        private void DataGridUpdate()
        {
            dataGridView1.Rows.Clear();
            int i = 1;
            foreach (Responsable responsablePerson in responsablePersons)
            {
                string[] rows = { i.ToString(), responsablePerson.Initials,
                    responsablePerson.RKK.ToString(), responsablePerson.Appeals.ToString(), responsablePerson.Summary.ToString() };
                dataGridView1.Rows.Add(rows);

                i++;
            }
        }

        private void Sort()
        {
            switch (comboBoxSort.SelectedIndex)
            {
                case (int)SortBy.Name:
                    responsablePersons.Sort((x, y) => x.Initials.CompareTo(y.Initials));
                    break;

                case (int)SortBy.RKK:
                    responsablePersons.Sort((x, y) =>
                    {
                        int ret = (y.RKK < x.RKK) ? -1 : ((y.RKK == x.RKK) ? 0 : 1);
                        return ret != 0 ? ret : y.Appeals.CompareTo(x.Appeals);
                    });
                    break;

                case (int)SortBy.Appeals:
                    responsablePersons.Sort((x, y) =>
                    {
                        int ret = (y.Appeals < x.Appeals) ? -1 : ((y.Appeals == x.Appeals) ? 0 : 1);
                        return ret != 0 ? ret : y.RKK.CompareTo(x.RKK);
                    });
                    break;

                case (int)SortBy.Summary:
                    responsablePersons.Sort((x, y) =>
                    {
                        int ret = (y.Summary < x.Summary) ? -1 : ((y.Summary == x.Summary) ? 0 : 1);
                        return ret != 0 ? ret : y.RKK.CompareTo(x.RKK);
                    });
                    break;
            }

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            Sort();

            DataGridUpdate();

            stopwatch.Stop();
            timeOfUpdate = stopwatch.ElapsedMilliseconds;
            labelTimeOfUpdate.Text = timeOfUpdate.ToString();
            labelTimeofALL.Text = (timeOfAppleance + timeOfRKK + timeOfUpdate).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxSort.SelectedIndex = 0;
            DateTime thisDay = DateTime.Today;
            currentDate = thisDay.ToShortDateString();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            string fileName = saveFileDialog1.FileName;
            Sort();
            using (StreamWriter sw = new StreamWriter(fileName))
            {
                sw.WriteLine("Справка о неисполненных документах и обращениях граждан");
                sw.WriteLine("Не исполнено в срок " + (numberOfAppeals + numberOfRKK).ToString() + " документов, из них:"); ;
                sw.WriteLine("- количество неисполненных входящих документов: " + numberOfRKK.ToString() + ";");
                sw.WriteLine("- количество неисполненных письменных обращений граждан: " + numberOfAppeals.ToString() + ";");
                sw.WriteLine("Сортировка: " + comboBoxSort.Text + ".");
                sw.WriteLine("");
                sw.WriteLine("N№ п.п.\t" + "Ответственный исполнитель\t" + "Количество неисполненных\t" +
                    "Количество неисполненных    \t" + "Общее количество");
                sw.WriteLine("       \t" + "                         \t" + "входящих документов    \t\t" + "письменных обращений граждан\t" + "документов и обращений");
                int i = 1;
                foreach (Responsable responsablePerson in responsablePersons)
                {
                    //string row = i.ToString() + "\t" + responsablePerson.Initials + "\t\t\t" + responsablePerson.RKK.ToString() + "\t\t\t\t" +
                    //    responsablePerson.Appeals.ToString() + "\t\t\t\t" + responsablePerson.Summary.ToString();\
                    string row = i.ToString();
                    row = row.PadRight(8, ' ');
                    row += responsablePerson.Initials;
                    row = row.PadRight(40, ' ');
                    row += responsablePerson.RKK.ToString();
                    row = row.PadRight(72, ' ');
                    row += responsablePerson.Appeals.ToString();
                    row = row.PadRight(104, ' ');
                    row += responsablePerson.Summary.ToString();
                    sw.WriteLine(row);

                    i++;
                }
                sw.WriteLine("");
                sw.WriteLine("Дата составления справки:\t" + currentDate);
            }
        }

        enum SortBy
        {
            Name,
            RKK,
            Appeals,
            Summary
        }
    }
}