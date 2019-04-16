using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FleetSim.Objects.Enum;

namespace FleetSim.Objects.Class
{
    public class Vehicle
    {
        private string Vin;
        private int Mileage;
        private CarColors Colors;
        private DateTime LastServicedDate;
        private int LastServicedMileage;
        public Vehicle()
        {
            Guid guid = Guid.NewGuid();
            Vin = guid.ToString();
            LastServicedDate = DateTime.Today;
        }

        public string _Vin
        {
            get
            {
                return this.Vin;
            }
            set
            {
                this.Vin = value;
            }
        }
        public int _Mileage
        {
            get
            {
                return this.Mileage;
            }
            set
            {
                this.Mileage = value;
                Mileage = value;
            }
        }
        public CarColors Color
        { get; set; }

        public DateTime _LastServicedDate
        {
            get
            {
                return this.LastServicedDate;
            }
            set
            {
                value = DateTime.Now;
            }
        }
        public int _LastServicedMileage
        {
            get
            {
                return this.LastServicedMileage;
            }
            set
            {
                LastServicedMileage = value;
            }
        }
        public void TuneUp()

        {
            if (Mileage - _LastServicedMileage >= 30000)
            {
                _LastServicedMileage = Mileage;
                Console.WriteLine("Vehicle tuned up at  " + _LastServicedMileage);
            }

            if (Mileage >= 100000)
            {
                EngineRebuild();
            }
            
             void EngineRebuild()
            {
                _Mileage = 0;
                _LastServicedMileage = 0;
                Console.WriteLine("Engine Rebuilt on" + _LastServicedDate);



            }
        }
    }
}



