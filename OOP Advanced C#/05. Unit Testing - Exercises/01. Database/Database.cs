using System;
using System.Collections.Generic;
using System.Linq;

public class Database
{
    private const int defaultCapacity = 16;

    private int[] values;
    private int currentIndex;

    private Database()
    {
        this.values = new int[defaultCapacity];
        this.currentIndex = 0;
    }

    public Database(params int[] values)
        : this()
    {
        this.InitializeValues(values);
    }

    private void InitializeValues(int[] inputValues)
    {
        try
        {
            //inputValues = inputValues.Concat(inputValues).ToArray();
            Array.Copy(inputValues.Concat(inputValues).ToArray(), this.values, inputValues.Length);
            this.currentIndex = inputValues.Length;
        }
        catch (ArgumentException e)
        {
            throw new InvalidOperationException("Array is full!", e);
        }
    }

    public void Add(int element)
    {
        if (this.currentIndex >= defaultCapacity)
        {
            throw new InvalidOperationException("Array is full!");
        }

        this.values[this.currentIndex] = element;
        currentIndex++;
    }

    public void Remove()
    {
        if (this.currentIndex == 0)
        {
            throw new InvalidOperationException("Array is empty!");
        }

        currentIndex--;
        this.values[this.currentIndex] = default(int);
    }

    public int[] Fetch()
    {
        if (this.currentIndex < 0)
        {
            throw new InvalidOperationException("Index cannot be negative!");
        }

        int[] newArray = new int[this.currentIndex];
        Array.Copy(this.values, newArray, this.currentIndex);

        return newArray;
    }


}

