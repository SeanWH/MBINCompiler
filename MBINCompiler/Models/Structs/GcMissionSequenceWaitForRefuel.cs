﻿namespace MBINCompiler.Models.Structs
{
    public class GcMissionSequenceWaitForRefuel : NMSTemplate       // size: 0x108
    {
        [NMS(Size = 0x80)]
        /* 0x000 */ public string Message;
        /* 0x080 */ public GcStatsTypes TargetStat;
        /* 0x084 */ public int Amount;
        [NMS(Size = 0x80)]
        /* 0x088 */ public string DebugText;
    }
}
