using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace GaragesDAL.Models
{
    public partial class Garages
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
