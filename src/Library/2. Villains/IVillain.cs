using System;
using System.Collections.Generic;
using RolePlayEndGame;

namespace RolePlayEndGame
{
    public interface IVillain
    {
        bool isItemVillain(Item item);

        bool DoesItFly();
        bool isDead();
    }
}