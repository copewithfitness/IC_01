using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class Data
    {
        private float weight;
        private float result;

        public float Weight
        {
            get { return weight; }
            set
            {
                if (value >= 0)
                {
                    weight = value;
                }
                else
                {
                    weight = 0;
                }
            }
        }
        public float Result
        {
            get { return result; }
            set
            {
                if (value >= 0)
                {
                    result = value;
                }
                else
                {
                    result = 0;
                }
            }
        }
        public Data()        // Constructor
        {
            weight = 0;
            result = 0;
        }
        public Data(float weight) => this.weight = weight;
        public override string ToString() => "Weight = " + weight.ToString() + "\nResult = " + result.ToString();
    }
}
