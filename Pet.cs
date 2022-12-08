using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual_Assignment_11
{
    internal class Pet
    {
        private string name;
        private string type;
        private decimal age;

        public Pet(string name, string type, decimal age)
        {
            this.name = name;
            this.type = type;
            this.age = age;
        }

        public string Name { get => name; set => name = value; }
        public string Type { get => type; set => type = value; }
        public decimal Age { get => age; set => age = value; }
    }
}
