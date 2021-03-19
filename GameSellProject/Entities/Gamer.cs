using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellProject.Entities
{
    class Gamer
    {
        public int Id { get; set; }
        public string IdentityNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
