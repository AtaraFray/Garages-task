using GaragesDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GaragesDAL
{
    public class GarageDAL : IGaragesDAL
    {
        private readonly GaragesDBContext garagesDb;

        public GarageDAL(GaragesDBContext garagesDb)
        {
            this.garagesDb = garagesDb;
        }

        public async Task<List<Garages>> GetAllGarages()
        {
            return await garagesDb.Garages.ToListAsync();
        }

        public async Task AddGarage(Garages garage)
        {
            await garagesDb.Garages.AddAsync(garage);
            await garagesDb.SaveChangesAsync();
        }
    }
}
