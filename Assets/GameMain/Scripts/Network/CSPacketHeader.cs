﻿namespace GameMain
{
    public sealed class CSPacketHeader : PacketHeaderBase
    {
        public override PacketType PacketType
        {
            get
            {
                return PacketType.ClientToServer;
            }
        }
    }
}
