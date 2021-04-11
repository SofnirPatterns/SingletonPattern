using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ChocolateBoiler chocolateBoiler = ChocolateBoiler.GetInstance();
            chocolateBoiler.Fill();
            ChocolateBoiler anotherChocolateBoiler = ChocolateBoiler.GetInstance();
            anotherChocolateBoiler.Drain();
            chocolateBoiler.Boil();
            chocolateBoiler.Drain();
            Console.ReadKey();
        }

        public class ChocolateBoiler
        {
            private static ChocolateBoiler ChocolateBoilerUniqueInstance;
            private bool Empty;
            private bool Boiled;

            public static ChocolateBoiler GetInstance()
            {
                if(ChocolateBoilerUniqueInstance == null)
                {
                    ChocolateBoilerUniqueInstance = new ChocolateBoiler();
                }

                return ChocolateBoilerUniqueInstance;
            }

            private ChocolateBoiler()
            {
                this.Empty = true;
                this.Boiled = false;
            }

            public void Fill()
            {
                if (this.Empty)
                {
                    Console.WriteLine("Fill");
                    this.Empty = false;
                    this.Boiled = false;
                }
            }

            public void Drain()
            {
                if(!this.Empty && this.Boiled)
                {
                    Console.WriteLine("Drain");
                    this.Empty = true;                    
                }
            }

            public void Boil()
            {                
                if (!this.Empty && !this.Boiled)
                {
                    Console.WriteLine("Boil");
                    this.Boiled = true;
                }
            }            
        }
    }
}