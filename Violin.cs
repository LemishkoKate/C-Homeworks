using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoRepository
{
    public class Violin : Instruments
    {
        public Violin(string name, string description) : base(name, description) { }

        public override void Sound()
        {
            Console.WriteLine("Sound: beep ");
        }
        public override void Show()
        {
            Console.WriteLine("Instrument: " + Name);
        }
        public override void Desc()
        {
            Console.WriteLine("Description: " + Description);
        }
        public override void History()
        {
            Console.WriteLine("History: bla bla bla");
        }
    }
}
