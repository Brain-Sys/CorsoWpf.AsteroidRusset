using System;

namespace CorsoWpf.AsteroidRusset.DomainModel
{
    public class Sample
    {
        static Random rnd = new Random((int)DateTime.Now.Ticks);

        public int ID { get; set; }
        public int Weight { get; set; }
        public string Code { get; set; }

        public Sample()
        {
            this.ID = rnd.Next(0, 4500000);
            this.Weight = rnd.Next(1, 9000);
            this.Code = string.Concat("Code ", rnd.Next(1, 60000000));
        }

        public override string ToString()
        {
            return Code;
        }
    }
}