using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SquareEquation_ASP.Models
{
    public class SquareEquationViewModel
    {
        public SquareEquationViewModel()
        {

        }

        public SquareEquationViewModel(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;

            Discriminant = Math.Pow(b, 2) - 4 * a * c;

            if (Discriminant < 0)
            {
                X1 = null;
                X2 = null;
            }
            else if (Discriminant == 0)
            {
                X1 = (-b + Math.Sqrt(Discriminant)) / (2 * a);
                X2 = null;
            }
            else if (Discriminant > 0)
            {
                X1 = (-b + Math.Sqrt(Discriminant)) / (2 * a);
                X2 = (-b - Math.Sqrt(Discriminant)) / (2 * a);
            }
        }

        public int Id { get; set; }

        public double A { get; set; }

        public double B { get; set; }

        public double C { get; set; }

        public double Discriminant { get; set; }

        public double? X1 { get; set; }

        public double? X2 { get; set; }
    }
}