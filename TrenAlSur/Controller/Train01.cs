using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrenAlSur.Model;

namespace TrenAlSur.Controller
{
    public class Train01 : TrainBase
    {
        public Train01(string nametrain, int capacity, int passanger, int numberstation) : base(nametrain, capacity, passanger, numberstation)
        {
            NameTrain = nametrain;
            CapacityTrain = capacity;
            NumberStations = numberstation;
            CurrentPassangers = passanger;
        }

        public override string NameTrain { get ; set ; }
        public override int CapacityTrain { get ; set ; }
        public override int NumberStations { get; set; }
        public int CurrentPassangers { get; set; }
        public int NewPassangers { get; set; }
        public int TotalPassangers { get; set; }

        public override void ArribarEstacion()
        {
            NumberStations += 1;
            DescenderPasajeros();
            SubirPasajeros();
            int PasajerosSuben = new Random().Next(0, CapacityTrain - CurrentPassangers);
            Console.WriteLine("Going to the next Station");
        }

        public override bool SubirPasajeros()
        {
            if(NewPassangers < 0)
            {
                Console.WriteLine("Write a valid number");
               
            } 

            if (NewPassangers > (CapacityTrain - CurrentPassangers))
            {
                Console.WriteLine("There's no seats for the passengers");
                return false;
            }
            else
            {
                CurrentPassangers += NewPassangers;
                Console.WriteLine($"Just now there are {CurrentPassangers} passengers");
                TotalPassangers += CurrentPassangers;
                return true;
            }
        }
        public override void DescenderPasajeros()
        {
            Console.WriteLine($"There were {CurrentPassangers} Passangers");
            int divide = CurrentPassangers / 2;
            Console.WriteLine($"Now There are {divide} Passangers");

        }
        public override decimal PasajerosPorEstacion()
        {
            decimal total = TotalPassangers / NumberStations;
            return total;
        }
    }
}
