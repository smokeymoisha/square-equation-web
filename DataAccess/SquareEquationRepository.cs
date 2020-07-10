using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class SquareEquationRepository
    {
        public IList<SquareEquation> GetAllSquareEquations()
        {
            using (var ctx = new SquareEquationContext())
            {
                return ctx.SquareEquations.ToList();
            }
        }

        public void AddSquareEquation(SquareEquation equation)
        {
            using (var ctx = new SquareEquationContext())
            {
                ctx.SquareEquations.Add(equation);

                ctx.SaveChanges();
            }
        }
    }
}
