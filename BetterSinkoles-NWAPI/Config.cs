﻿using System.ComponentModel;

namespace BetterSinkoles_NWAPI
{
    public class Config
    {
        [Description("Distance from the center of a sinkhole where you get teleported")]
        public float TeleportDistance { get; set; } = 0.5f;

        [Description("Broadcasted message duration. Default: 0")]
        public ushort TeleportMessageDuration { get; set; } = 0;

        [Description("Message broadcasted to the player upon falling into a sinkhole. Default: nothing")]
        public string TeleportMessage { get; set; } = "";
    }
}
