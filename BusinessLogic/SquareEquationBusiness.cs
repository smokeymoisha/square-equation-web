using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class SquareEquationBusiness
    {
        public SquareEquationBusiness()
        {

        }

        public SquareEquationBusiness(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;

            Discriminant = GetDiscriminant();

            X1 = GetFirstRoot();
            X2 = GetSecondRoot();
        }

        public int Identificator { get; set; }

        public double A { get; set; }

        public double B { get; set; }

        public double C { get; set; }

        public double Discriminant { get; set; }

        public double? X1 { get; set; }

        public double? X2 { get; set; }

        public double GetDiscriminant()
        {
            return Math.Pow(B, 2) - 4 * A * C;
        }

        public double? GetFirstRoot()
        {
            if (Discriminant < 0)
            {
                return null;
            }
            else if (Discriminant == 0)
            {
                return (-B + Math.Sqrt(Discriminant)) / (2 * A);
            }
            else
            {
                return (-B + Math.Sqrt(Discriminant)) / (2 * A);
            }
        }

        public double? GetSecondRoot()
        {
            if (Discriminant < 0)
            {
                return null;
            }
            else if (Discriminant == 0)
            {
                return null;
            }
            else
            {
                return (-B - Math.Sqrt(Discriminant)) / (2 * A);
            }
        }
    }
}
