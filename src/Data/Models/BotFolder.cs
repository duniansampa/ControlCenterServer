﻿using ControlCenterServer.Utils;

namespace ControlCenterServer.Data.Models;

public class BotFolder : EntityInfomation, ICustomClone<BotFolder>
{
    public Guid BotFolderId { get; set; }
    public string Name { get; set; }

    // Relations
    public virtual ICollection<Bot> Bots { get; set; }

    public BotFolder CreateShallowCopy()
    {
        return (BotFolder)MemberwiseClone();
    }
}