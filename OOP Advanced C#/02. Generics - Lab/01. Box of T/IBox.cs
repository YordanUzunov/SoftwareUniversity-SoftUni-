namespace _01._Box_of_T
{
    public interface IBox<T>
    {
        int Count { get; }

        T this[int index] { get; }

        void Add(T element);

        T Remove();
    }
}
