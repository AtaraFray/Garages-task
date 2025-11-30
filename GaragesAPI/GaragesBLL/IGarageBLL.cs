using GaragesDAL.Models;
using GaragesDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaragesBLL
{
    public interface IGarageBLL
    {
        Task<List<GarageDTO>> GetAllGarages();

        Task AddGarage(GarageDTO garage);
    }
}
