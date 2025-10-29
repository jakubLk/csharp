﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cvicenia_Battlesimulator
{
    internal class Monster
    {
        public string RaceType { get; set; } //Monster race type (e.g.,Goblin,Orc,Troll)
        public int HP { get; set; } //Health Points
        public int DMG { get; set; } //Damage

        public Monster(string raceType, int hP, int dMG)
        {
            RaceType = raceType;
            HP = hP;
            DMG = dMG;
        }

        public void MonsterAttack(Hero hero)
        {
            hero.HP = hero.HP - DMG;
        }




    }
}
