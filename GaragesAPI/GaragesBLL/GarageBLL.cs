using AutoMapper;
using GaragesDAL;
using GaragesDAL.Models;
using GaragesDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaragesBLL
{
    public class GarageBLL : IGarageBLL
    {
        IGaragesDAL garageDAL;
        IMapper mapper;

        public GarageBLL(IGaragesDAL _garageDAL)
        {
            this.garageDAL = _garageDAL;
            var config = new MapperConfiguration(cnf => cnf.AddProfile<Auto>());
            mapper = config.CreateMapper();
        }

        public async Task AddGarage(GarageDTO garage)
        {
            await garageDAL.AddGarage(mapper.Map<GarageDTO, Garages>(garage));
        }

        public async Task<List<GarageDTO>> GetAllGarages()
        {
            return await mapper.Map<Task<List<Garages>>, Task<List<GarageDTO>>>(garageDAL.GetAllGarages());
        }
    }
}
