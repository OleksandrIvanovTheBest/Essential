using System;
using System.Collections.Generic;
using System.Text;

namespace Classes2
{
    //1
    internal class Converter
    {
        private readonly double _usd, _eur, _rub;
        
        public Converter(double usd, double eur, double rub)
        {
            _usd = usd;
            _eur = eur;
            _rub = rub;
        }

        public double UahToUsd(double uahValue)
        {
            return uahValue / _usd;
        }

        public double UahToEur(double uahValue)
        {
            return uahValue / _eur;
        }

        public double UahToRub(double uahValue)
        {
            return uahValue / _rub;
        }

        public double UsdToUah(double usdValue)
        {
            return _usd * usdValue;
        }

        public double EurToUah(double eurValue)
        {
            return _eur * eurValue;
        }

        public double RubToUah(double rubValue)
        {
            return _rub * rubValue;
        }
    }
}
