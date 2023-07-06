using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SitecTZ
{
    internal class Responsable
    {
        private string initials;
        private int numberOfAppeals = 0;
        private int numberOfRKK = 0;

        public Responsable(string initials, int numberOfAppeals, int numberOfRKK)
        {
            this.initials = initials;
            this.numberOfAppeals = numberOfAppeals;
            this.numberOfRKK = numberOfRKK;
        }

        public string Initials
        {
            get { return initials; }
            set { initials = value; }
        }

        public int Appeals
        {
            get { return numberOfAppeals; }
            set { numberOfAppeals = value; }
        }

        public int RKK
        {
            get { return numberOfRKK; }
            set { numberOfRKK = value; }
        }

        public int Summary
        {
            get { return numberOfAppeals + numberOfRKK; }
        }
    }
}
