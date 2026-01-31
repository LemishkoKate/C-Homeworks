using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoRepository
{
    public abstract class Instruments
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Instruments(string name, string description)  
        {
            Name = name;
            Description = description;
        }
        public abstract void Sound();
        public abstract void Show();
        public abstract void Desc();
        public abstract void History();
    }
}
