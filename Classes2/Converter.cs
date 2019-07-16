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

        public double UahToUsd(double uah)
        {
            return uah / _usd;
        }

        public double UahToEur(double uah)
        {
            return uah / _eur;
        }

        public double UahToRub(double uah)
        {
            return uah / _rub;
        }

        public double UsdToUah(double usd)
        {
            return _usd * usd;
        }

        public double EurToUah(double eur)
        {
            return _eur * eur;
        }

        public double RubToUah(double rub)
        {
            return _rub * rub;
        }
    }
}
