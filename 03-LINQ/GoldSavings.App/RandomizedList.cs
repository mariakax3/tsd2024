using System;
using System.Collections.Generic;

public class RandomizedList<T>
{
    private List<T> internalList;
    private Random random;

    public RandomizedList()
    {
        internalList = new List<T>();
        random = new Random();
    }

    public void Add(T element)
    {
        if (random.Next(2) == 0)
            internalList.Insert(0, element);
        else
            internalList.Add(element);
    }

    public T Get(int index)
    {
        if (internalList.Count == 0)
            throw new InvalidOperationException("List is empty");

        int randomIndex = random.Next(internalList.Count);
        int actualIndex = Math.Min(randomIndex + index, internalList.Count - 1);

        return internalList[actualIndex];
    }

    public bool IsEmpty => internalList.Count == 0;
}
