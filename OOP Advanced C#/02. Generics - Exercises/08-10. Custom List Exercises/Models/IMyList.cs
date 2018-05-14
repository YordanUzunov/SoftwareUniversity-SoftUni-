namespace _08_10._Custom_List_Exercises.Models
{
    using System.Collections.Generic;

    public interface IMyList<T> : IEnumerable<T>
    {
        void Add(T element);

        T Remove(int index);

        bool Contains(T element);

        void Swap(int index1, int index2);

        int CountGreaterThan(T element);

        T Max();

        T Min();

        void Sort();
    }
}
