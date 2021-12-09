using System;

namespace Lab8
{
    public interface IFuncs<T>
    {
        void Add(T item);
        void Remove(T item);
        void Show();
    }
}