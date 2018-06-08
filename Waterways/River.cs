using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waterways
{
    class River
    {
        private int depth;
        private int pollution;
        private string name;
        private bool depthAlert;
        private bool polAlert;

        public bool DepthAlert
        {
            get { return this.depthAlert; }
            set { this.depthAlert = value; }
        }

        public bool PolAlert
        {
            get { return this.polAlert; }
            set { this.polAlert = value; }
        }
        public int Depth
        {
            get { return this.depth; }
            set { this.depth = value; }
        }
        public int Pollution
        {
            get { return this.pollution; }
            set { this.pollution = value; }
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public River()
        {
            //default constructor
        }

        public River(string name, int depth, int pollution)
        {
            this.Name = name;
            this.Depth = depth;
            this.Pollution = pollution;
        }

        public void GetStatus()
        {
            Depth++;
            if (Depth > 25)
            {
                DepAlert(true);
            }
            else
            {
                DepAlert(false);
            }
            Pollution++;
            if (Pollution > 5)
            {
                PlAlert(true);
            }
            else
            {
                PlAlert(false);
            }
        }

        public bool DepAlert(bool status)
        {
            DepthAlert = status;
            return DepthAlert;
        }
        public bool PlAlert(bool status)
        {
            PolAlert = status;
            return PolAlert;
        }

        public int SetDepth(int num)
        {
            this.Depth = num;
            return Depth;
        }
        public int SetPol(int num)
        {
            this.Pollution = num;
            return Pollution;
        }

        public string SetName(string name)
        {
            this.Name = name;
            return Name;
        }

    }
}
