using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace пятое
{
    internal class Pet
    {
        public string name;
        public int energy;
        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("ошибка");
                }
                else
                {
                    name = value;
                }
            }
        }
        public int Energy
        {
            get { return energy; }
            set
            {
                if (value < 0 && value > 100)
                {
                    Console.WriteLine("ошибка");
                }
                else
                {
                    energy = value;
                }
            }
        }

        public Pet(string name, int energy)
        {
            Name = name;
            Energy = energy;
        }
        public void Play()
        {
            int play = energy - 20;
            if (play < 0 || play > 100)
            {
                Console.WriteLine("нельзя так сделать");
            }
            else
            {

                Console.WriteLine($"{name} играет, энергия: {play}");
            }
        }
        public void Rest()
        {
            int rest = energy + 30;
            if (rest > 100 || rest < 0)
            {
                Console.WriteLine("невозможно");
            }
            else
            {
                Console.WriteLine($"{name} отдыхает, энергия: {rest}");
            }
        }
        static void Main(string[] args)
        {
            Pet pet = new Pet("милфа", 60);
            pet.Play();
            pet.Rest();
        }
    }
}
