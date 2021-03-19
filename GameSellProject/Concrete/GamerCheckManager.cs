using GameSellProject.Abstract;
using GameSellProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellProject.Concrete
{
    class GamerCheckManager : IGamerCheckService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            return true;
        }
    }
}
