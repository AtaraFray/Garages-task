using GaragesDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace GaragesBLL
{
    public interface IGovApiService
    {
        Task<List<GarageDTO>> GetGovGaragesAsync();

    }
}
