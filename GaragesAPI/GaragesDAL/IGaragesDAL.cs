using GaragesDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaragesDAL
{
    public interface IGaragesDAL
    {
        Task<List<Garages>> GetAllGarages();

        Task AddGarage(Garages garage);

        // הוספת פונקציה האם מוסך קיים 
        Task<bool> IsGarageExist(int garageId);

    }
}
