﻿﻿using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Terraria;
using Hooks;
using TShockAPI;
using TShockAPI.DB;
using System.ComponentModel;

namespace DisableBloodmoon
{
    [APIVersion(1, 12)]
    public class DisableBloodmoon : TerrariaPlugin
    {
        public override Version Version
        {
            get { return new Version("1.0"); }
        }
        public override string Name
        {
            get { return "Disable Bloodmoon"; }
        }
        public override string Author
        {
            get { return "Ijwu"; }
        }
        public override string Description
        {
            get { return "Disable Bloodmoon. Durr."; }
        }

        public DisableBloodmoon(Main game)
            : base(game)
        {
        	
        }
        public override void Initialize()
        {
            GameHooks.Update += OnUpdate;
        }
        
         protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                GameHooks.Update -= OnUpdate;
            }
            base.Dispose(disposing);
        }

        private void OnUpdate()
        {
            Terraria.Main.bloodMoon = false;
        }
    }
}