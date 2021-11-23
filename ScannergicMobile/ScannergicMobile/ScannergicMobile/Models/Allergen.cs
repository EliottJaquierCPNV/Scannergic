using System;
using System.Collections.Generic;
using System.Text;

namespace ScannergicMobile.Models
{
    public class Allergen
    {
        private int id;

        public int Id
        {
            get { return id; }
        }

        private string name;

        public string Name
        {
            get { return name; }
        }

        public Allergen(int id,string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
