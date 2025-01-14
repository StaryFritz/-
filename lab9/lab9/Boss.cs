﻿using System;
using System.Collections.Generic;
using System.Text;

namespace lab9
{
    class Boss
    {
        public delegate void Upgrade(string message);
        public delegate bool TurnOn(bool flag);

        public event Upgrade OnUpgrade;

        public string version = "Windows 10";
        public bool isTurned = false;
        
        public void doUpgrade(string newVersion)
        {
            version = newVersion;
            OnUpgrade(newVersion);
        }
        public static void DisplayMessage(string version)
        {
            Console.WriteLine(version);
        }
        public void doTurnOn()
        {
            TurnOn OnTurnOn = (flag) => !flag;
            if (OnTurnOn(isTurned))
                Console.WriteLine("ВКЛ");
            else
                Console.WriteLine("ВЫКЛ");
        }
    }
}
