using Clean.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Clean.Core
{
    public static class Mapping
    {
        public static RoomDTO MapToRoomDTO(RoomDTO room)
        {
            return new RoomDTO
            {
                Tiny_Neglected = room.Tiny_Neglected,
                Well_groomed = room.Well_groomed
            };
        }

        public static PrisonerDTO MapToPrisonerDTO(PrisonerDTO prisoner)
        {
            return new PrisonerDTO
            {
                FamilyName = prisoner.FamilyName,
                Meals = prisoner.Meals,
                YearsInPrison = prisoner.YearsInPrison,
                Level1_10 = prisoner.Level1_10
            };
        }

        public static Prison_GuardDTO MapToPrison_GuardDTO(Prison_GuardDTO prison_Guard)
        {
            return new Prison_GuardDTO
            {
                Name = prison_Guard.Name,
                Professional_Level = prison_Guard.Professional_Level,
                PrisonToFloor = prison_Guard.PrisonToFloor
            };
        }
    }
}
