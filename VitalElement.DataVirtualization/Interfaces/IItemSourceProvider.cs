﻿namespace VitalElement.DataVirtualization.Interfaces
{
    public interface IItemSourceProvider<T> : IBaseSourceProvider<T>
    {
        bool Contains(T item);
        T GetAt(int index, object voc);
        int GetCount(bool asyncOk);

        int IndexOf(T item);
    }
}