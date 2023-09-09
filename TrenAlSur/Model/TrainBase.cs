using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrenAlSur.Model
{
    public abstract class TrainBase
    {
        private int capacity;
        private int numberstation;

        public abstract string NameTrain { get; set; }
        public abstract int CapacityTrain { get; set; }
        public abstract int NumberStations { get; set; }
        public int CurrentPassangers { get; set; }


        public TrainBase(string nametrain, int passanger, int capacity, int numberstation)
        {
            NameTrain = nametrain;
            CapacityTrain = capacity;
            NumberStations = numberstation;
            CurrentPassangers = passanger;
        }

        public abstract void ArribarEstacion();
        public abstract bool SubirPasajeros();
        public abstract void DescenderPasajeros();
        public abstract decimal PasajerosPorEstacion();

    }

}
