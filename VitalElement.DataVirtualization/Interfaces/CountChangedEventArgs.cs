﻿namespace VitalElement.VirtualizingCollection.Interfaces
{
    using System;

    public class CountChangedEventArgs : EventArgs
    {
        public int Count { get; set; }
        public bool NeedsReset { get; set; }
    }
}