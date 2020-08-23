﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Media;
using WPF_gaming_3.CharCreation;
using WPF_gaming_3.backend;
using WPF_gaming_3;
using System.Threading.Tasks;

namespace WPF_gaming_3.backend
{
    public class business
    {
        public playerClass pClass;
        public player playerObject;
        public List<dungoen> dungoens;
        public void createClass(string className, int stregthP, int agilityP, int luckP, string playerName)
        {
            playerClass p1Class = new playerClass(className);
            if (p1Class.ClassName == "warrior")
            {
                p1Class.Def = 11;
                p1Class.MaxHP = 153;
                p1Class.MaxStamina = 41;
            }
            else
            {
                p1Class.Def = 6;
                p1Class.MaxHP = 79;
                p1Class.MaxStamina = 54;
            }
            pClass = p1Class;
            playerObject = new player(playerName, pClass, 1, 0, 100, stregthP, agilityP, luckP);
        
        }


        public void selcectSound()
        {
            MediaPlayer selcect = new MediaPlayer();
            Uri selectPath = new Uri(@"C:/Users/chris/source/repos/WPF_gaming_3/WPF_gaming_3/WPF_gaming_3/sounds/select.wav");
            selcect.Open(selectPath);
            selcect.Play();
        }

        public void createDungoen(int dungoenIndex)
        {
          dungoens  = new List<dungoen>()
            {
            new dungoen("Chambers of the Unknown Forest",
                2,
                120,
                0,
                "C:/Users/chris/source/repos/WPF_gaming_3/WPF_gaming_3/WPF_gaming_3/images/area1/areaLoading.png",
                "C:/Users/chris/source/repos/WPF_gaming_3/WPF_gaming_3/WPF_gaming_3/images/area1/areabg.png",
                new List<enemy>
                {
                    new enemy(60, "Wild Goblin", "C:/Users/chris/source/repos/WPF_gaming_3/WPF_gaming_3/WPF_gaming_3/images/Enemy/download.png", false, 13),
                    new enemy(80, "Rouge Pumpkin Famer", "C:/Users/chris/source/repos/WPF_gaming_3/WPF_gaming_3/WPF_gaming_3/images/Enemy/goblin.gif", true, 3)
                }
                )
                ,
              new dungoen("Vault of the Nameless Widow",
                2,
                250,
                0,
                "C:/Users/chris/source/repos/WPF_gaming_3/WPF_gaming_3/WPF_gaming_3/images/area2/areaLoading.png",
                "C:/Users/chris/source/repos/WPF_gaming_3/WPF_gaming_3/WPF_gaming_3/images/area2/areaBg.png",
                new List<enemy>
                {
                    new enemy(80, "Gaara of the Sand", "C:/Users/chris/source/repos/WPF_gaming_3/WPF_gaming_3/WPF_gaming_3/images/Enemy/sand2.gif", false, 17),
                    new enemy(120, "Primitive Sand Howler", "C:/Users/chris/source/repos/WPF_gaming_3/WPF_gaming_3/WPF_gaming_3/images/Enemy/sand.gif", true, 20),

                }
                ),
                
            new dungoen("Tunnels of the Mystic Horsemen",
                2,
                600,
                0,
                "C:/Users/chris/source/repos/WPF_gaming_3/WPF_gaming_3/WPF_gaming_3/images/area3/areaLoading.png",
                "C:/Users/chris/source/repos/WPF_gaming_3/WPF_gaming_3/WPF_gaming_3/images/area3/areaBg.png",
                new List<enemy>
                {
                    
                     new enemy(80, "Lava guy", "C:/Users/chris/source/repos/WPF_gaming_3/WPF_gaming_3/WPF_gaming_3/images/Enemy/lavaEnemy1.gif", false, 20),
                     new enemy(120, "Super lava guy", "C:/Users/chris/source/repos/WPF_gaming_3/WPF_gaming_3/WPF_gaming_3/images/Enemy/lavaBoss.gif", true, 27)
                
                    }
                )
            };
        }

       

        

    }
}
