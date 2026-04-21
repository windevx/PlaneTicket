using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanMemberClass
{
    internal class PlaneTicket
    {
        // Mendeklarasikan backing fields (variabel private)
        private string _origin;
        private string _destination;
        private int _cost;
        private string _currency;

        public string Origin
        {
            get // get accessor
            {
                return _origin;
            }
            set // set accessor
            {
                _origin = value;
            }
        }

        public string Destination
        {
            get // get accessor
            {
                return _destination;
            }
            set // set accessor
            {
                _destination = value;
            }
        }

        public int Cost
        {
            get // get accessor
            {
                return _cost;
            }
            set // set accessor
            {
                _cost = value;
            }
        }

        public string Currency
        {
            get // get accessor
            {
                return _currency;
            }
            set // set accessor
            {
                _currency = value;
            }
        }
    }
}