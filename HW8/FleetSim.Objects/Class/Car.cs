using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FleetSim.Objects.Interface;
using FleetSim.Objects.Enum;

namespace FleetSim.Objects.Class
{
    public class Car : Vehicle
    {
        private int Year;
        private string Make;
        private string Model;
        public Car()
        {
            _Mileage = 0;
            _LastServicedMileage = 0;
        }
            
        public int _Year
        {
            get
            {
                return this.Year;
            }
            set
            {
                Year=value;
            }
        }
        public string _Make
        {
            get
            {
                return this.Make;
            }
            set
            {
                Make=value;
            }
        }
        public string _Model
        {
            get
            {
                return this.Model;
            }
            set
            {
                Model = value;
            }
        } 
           public Car(int year, string make, string model)
           {
            _Year = year;
            _Make = make;
            _Model = model;
           }
        public Car(int year, string make, string model, CarColors color)
        {
            _Year = year;
            _Make = make;
            _Model = model;
            Color = color;
        }

    }

}

