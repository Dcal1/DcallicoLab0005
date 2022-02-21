using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DcallicoLab0005
{
    internal class Math
        
    {
        public string _SideA;
        public string _SideB;
        private string _Answer;

        public Math()
        {
            _SideA = "Enter side A";
            _SideB = "Enter side B";
        }
        public string Answer
        { 
            get 
            { 
                return _Answer; 
            } 
            set 
            { 
                _Answer = value; 
            } 
        }
        public static double Squared(double _SideA, double _SideB)
        {
            double c= (_SideA * _SideA) + (_SideB * _SideB);
            return c;
        }
    }
}
