using AutoMapper;
using BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SquareEquation_ASP.Models
{
    public class SquareEquationPresentationManager
    {
        private SquareEquationManager _manager;
        private Mapper _mapper;
        
        public SquareEquationPresentationManager()
        {
            _manager = new SquareEquationManager();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<SquareEquationViewModel, SquareEquationBusiness>();
                cfg.CreateMap<SquareEquationBusiness, SquareEquationViewModel>();
            });

            _mapper = new Mapper(config);
        }

        public IList<SquareEquationViewModel> GetAllSquareEquations()
        {
            return _mapper.Map<IList<SquareEquationViewModel>>(_manager.GetAllSquareEquations());
        }

        public void AddSquareEquation(SquareEquationViewModel equation)
        {
            _manager.AddSquareEquation(_mapper.Map<SquareEquationBusiness>(equation));
        }
    }
}