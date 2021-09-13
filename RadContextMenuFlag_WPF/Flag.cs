using System;
using System.Collections.Generic;
using System.Text;

namespace RadContextMenuFlag_WPF
{
    public class Flag
    {
        private string country;
        private string source;

        public Flag()
        {
            this.country = null;
            this.source = null;
        }

        public Flag(string country, string source)
        {
            this.country = country;
            this.source = source;
        }

        public string Country
        {
            get { return country; }
            set { country = value; }
        }
        public string Source
        {
            get { return source; }
            set { source = value; }
        }


    }
}
