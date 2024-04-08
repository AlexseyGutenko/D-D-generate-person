using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace D_D
{
    internal class character
    {
        int LVL=0;
        int XP=0;
        int skill_bonus=0;

        public static int LVL_UP(ref int XP,ref int LVL,int xp,ref int skill_bonus)
        {
            XP = XP + xp;
            if (0<=XP&&XP<=299)
            {
                LVL = 1;
                skill_bonus = 2;
                return LVL;
            }
            if (300 <= XP && XP <= 899)
            {
                LVL = 2;
                skill_bonus = 2;
                return LVL;
            }
            if (900 <= XP && XP <= 2699)
            {
                LVL = 3;
                skill_bonus = 2;
                return LVL;
            }
            if (2700 <= XP && XP <= 6499)
            {
                LVL = 4;
                skill_bonus = 2;
                return LVL;
            }
            if (6500 <= XP && XP <= 13999)
            {
                LVL = 5;
                skill_bonus = 3;
                return LVL;
            }
            if (14000 <= XP && XP <= 22999)
            {
                LVL = 6;
                skill_bonus = 3;
                return LVL;
            }
            if (23000 <= XP && XP <= 33999)
            {
                LVL = 7;
                skill_bonus = 3;
                return LVL;
            }
            if (34000 <= XP && XP <= 47999)
            {
                LVL = 8;
                skill_bonus = 3;
                return LVL;
            }
            if (48000 <= XP && XP <= 63999)
            {
                LVL = 9;
                skill_bonus = 4;
                return LVL;
            }
            if (64000 <= XP && XP <= 84999)
            {
                LVL = 10;
                skill_bonus = 4;
                return LVL;
            }
            if (85000 <= XP && XP <= 99999)
            {
                LVL = 11;
                skill_bonus = 4;
                return LVL;
            }
            if (100000 <= XP && XP <= 119999)
            {
                LVL = 12;
                skill_bonus = 4;
                return LVL;
            }
            if (120000 <= XP && XP <= 139999)
            {
                LVL = 13;
                skill_bonus = 5;
                return LVL;
            }
            if (140000 <= XP && XP <= 164999)
            {
                LVL = 14;
                skill_bonus = 5;
                return LVL;
            }
            if (165000 <= XP && XP <= 194999)
            {
                LVL = 15;
                return LVL;
            }
            if (195000 <= XP && XP <= 224999)
            {
                LVL = 16;
                skill_bonus = 5;
                return LVL;
            }
            if (225000 <= XP && XP <= 264999)
            {
                LVL = 17;
                skill_bonus = 6;
                return LVL;
            }
            if (265000 <= XP && XP <= 304999)
            {
                LVL = 18;
                skill_bonus = 6;
                return LVL;
            }
            if (305000 <= XP && XP <= 354999)
            {
                LVL = 19;
                skill_bonus = 6;
                return LVL;
            }
            if (355000 <= XP)
            {
                LVL = 20;
                skill_bonus = 6;
                return LVL;
            }
            else
            {
                return LVL;
            }
        }
        public static int characterization_modifier(int characterization)
        {
            return (characterization - 10) / 2;
        }
    }
}
