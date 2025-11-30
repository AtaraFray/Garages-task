using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaragesDTO
{
    public class GarageDTO
    {
        public int Id { get; set; }
        public int? GarageId { get; set; }
        public int? GarageNumber { get; set; }
        public string GarageName { get; set; }
        public int? GarageCodeType { get; set; }
        public string GarageType { get; set; }
        public string GarageAddress { get; set; }
        public string GarageCity { get; set; }
        public string GaragePhone { get; set; }
        public int? GaragePostalCode { get; set; }
        public int? GarageProfession { get; set; }
        public string Profession { get; set; }
        public string ProfessionManager { get; set; }
        public long? RegisterCompany { get; set; }
        public string Testime { get; set; }
    }
}
