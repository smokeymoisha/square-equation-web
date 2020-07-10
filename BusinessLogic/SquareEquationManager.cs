using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace BusinessLogic
{
    public class SquareEquationManager
    {
        private SquareEquationRepository _repository;
        private Mapper _mapper;

        public SquareEquationManager()
        {
            _repository = new SquareEquationRepository();

            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<SquareEquation, SquareEquationBusiness>();
                cfg.CreateMap<SquareEquationBusiness, SquareEquation>();
            });

            _mapper = new Mapper(config);
        }

        public IList<SquareEquationBusiness> GetAllSquareEquations()
        {
            return _mapper.Map<IList<SquareEquationBusiness>>(_repository.GetAllSquareEquations());
        }

        public void AddSquareEquation(SquareEquationBusiness equation)
        {
            _repository.AddSquareEquation(_mapper.Map<SquareEquation>(equation));
        }
    }
}
