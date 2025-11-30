using GaragesDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaragesDTO
{
    public class Auto : AutoMapper.Profile
    {
        public Auto()
        {
            CreateMap<GarageDTO, Garages>();
            CreateMap<Garages, GarageDTO>();
        }
    }
}
