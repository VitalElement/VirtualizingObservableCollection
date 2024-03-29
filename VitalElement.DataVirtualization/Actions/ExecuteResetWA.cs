﻿namespace VitalElement.DataVirtualization.Actions
{
    using System;
    using System.Collections.Specialized;

    public class ExecuteResetWA<T> : BaseActionVirtualization where T : class
    {
        readonly WeakReference _voc;

        public ExecuteResetWA(VirtualizingObservableCollection<T> voc)
            : base(VirtualActionThreadModelEnum.UseUIThread)
        {
            _voc = new WeakReference(voc);
        }

        public override void DoAction()
        {
            var voc = (VirtualizingObservableCollection<T>) _voc.Target;

            if (voc != null && _voc.IsAlive)
            {
                voc.RaiseCollectionChangedEvent(
                    new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
            }
        }
    }
}