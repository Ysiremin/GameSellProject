using GameSellProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellProject.Abstract
{
    interface IGamerCheckService
    {
        bool CheckIfRealPerson(Gamer gamer);
    }
}
