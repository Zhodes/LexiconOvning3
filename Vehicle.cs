using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconOvning3
{
    abstract class Vehicle
    {
        private string? brand;
        private string? model;
        private int year;
        private double weight;

        public string Brand {
            get 
            { return brand; }
            set
            {
                if (2<=value.Length && value.Length<=20)brand = value;
            }
        }
        public string Model
        {
            get
            { return model; }
            set
            {
                if (2 <= value.Length && value.Length <= 20) brand = value;
                else { }
            }
        }
        public int Year
        {
            get
            { return year; }
            set
            {
                if (year >= 1886 && year <= DateTime.Now.Year) year = value;
            }
        }

        public double Weight
        {
            get { return weight; }
            set
            {
                if (weight > 0) weight = value;
            }
        }

        protected virtual void StartEngine()
        {
            throw new NotImplementedException();
        }

        protected virtual void Stats()
        {
            throw new NotImplementedException();
        }
    }
}
