using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Core.DTOs
{
    public class PrisonerDTO
    {
        public int Id { get; set; }
        public string FamilyName { get; set; }
        public int YearsInPrison { get; set; }
        public int Meals { get; set; }
        public int Level1_10 { get; set; }
    }
}
