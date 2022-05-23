﻿namespace lab4
{
    using System.Collections.Generic;

    public enum OfType
    {
        Open,
        Closed
    }

    public interface IAviary
    {
        List<IAnimal> Animals { get; }
    }
}