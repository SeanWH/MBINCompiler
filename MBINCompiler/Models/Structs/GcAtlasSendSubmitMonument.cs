﻿namespace MBINCompiler.Models.Structs
{
    [NMS(Size = 0x150)]
    public class GcAtlasSendSubmitMonument : NMSTemplate
    {
        ///* 0x000 */ public sub_1404777E0 ClientUserData;
        ///* 0x010 */ public sub_140482DC0 Monument;
        /* 0x120 */ public int MonumentRole;
        public string[] MonumentRolesValues()
        {
            return new[] { "Creator", "CoCreator"};
        }
        [NMS(Size = 0x20)]
        /* 0x124 */ public string OtherUser;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x144 */ public byte[] EndPadding;
    }
}
