namespace MyTunesShop.Interfaces
{
    using System;
    using System.Collections.Generic;

    using MyTunesShop.Models;

    public interface IPerformer
    {
        string Name { get; }

        PerformerType Type { get; }

        IList<ISong> Songs { get; }
    }
}
