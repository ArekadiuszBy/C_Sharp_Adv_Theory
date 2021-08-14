using System;

namespace AccessModifiers2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Methods prog2 = new Methods();

            prog2.creditCard = "1231241345431";
            prog2.Number = "1232131231213213123";

            prog2.Age = 200;        //Won't set age, because >99
            prog2._age = 200;       //Set age to 200 

        }



        private void Priv()
        {
            Console.WriteLine("");
        }

        protected void Prot()
        {

        }
        internal void Inte()
        {

        }

        public void Publ() { }

        protected internal void ProtInt() { }

        private protected void PrivProt() { }



    }

    
}
