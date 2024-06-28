/*Question 1: Create a custom Stack class MyStack<T> that can be used with any data type which has following methods
1. int Count()
2. T Pop()
3. Void Push() */

using System;
using System.Collections.Generic;
public class MyStack<T>
{
    private List<T> _stack;
    public MyStack()
    {
        _stack = new List<T>();
    }
    public int Count()
    {
        return _stack.Count;
    }
    public T Pop()
    {
        if (_stack.Count == 0)
        {
            throw new InvalidOperationException("Stack is empty.");
        }
        T item = _stack[_stack.Count - 1];
        _stack.RemoveAt(_stack.Count - 1);
        return item;
    }
    public void Push(T item)
    {
        _stack.Add(item);
    }
}

/*Question 2: 2. Create a Generic List data structure MyList<T> that can store any data type.
Implement the following methods.
1. void Add (T element)
2. T Remove (int index)
3. bool Contains (T element)
4. void Clear ()
5. void InsertAt (T element, int index)
6. void DeleteAt (int index)
7. T Find (int index) */

using System;
using System.Collections.Generic;
public class MyList<T>
{
    private List<T> _items;
    public MyList()
    {
        _items = new List<T>();
    }
    public void Add(T element)
    {
        _items.Add(element);
    }
    public T Remove(int index)
    {
        if (index < 0 || index >= _items.Count)
        {
            throw new ArgumentOutOfRangeException("Index is out of range.");
        }
        T element = _items[index];
        _items.RemoveAt(index);
        return element;
    }
    public bool Contains(T element)
    {
        return _items.Contains(element);
    }
    public void Clear()
    {
        _items.Clear();
    }
    public void InsertAt(T element, int index)
    {
        if (index < 0 || index > _items.Count)
        {
            throw new ArgumentOutOfRangeException("Index is out of range.");
        }
        _items.Insert(index, element);
    }
    public void DeleteAt(int index)
    {
        if (index < 0 || index >= _items.Count)
        {
            throw new ArgumentOutOfRangeException("Index is out of range.");
        }
        _items.RemoveAt(index);
    }
    public T Find(int index)
    {
        if (index < 0 || index >= _items.Count)
        {
            throw new ArgumentOutOfRangeException("Index is out of range.");
        }
        return _items[index];
    }
}

/*Question 3: Implement a GenericRepository<T> class that implements IRepository<T> interface
that will have common /CRUD/ operations so that it can work with any data source
such as SQL Server, Oracle, In-Memory Data etc. Make sure you have a type constraint
on T were it should be of reference type and can be of type Entity which has one
property called Id. IRepository<T> should have following methods
1. void Add(T item)
2. void Remove(T item)
3. Void Save()
4. IEnumerable<T> GetAll()
5. T GetById(int id)*/
using System;
using System.Collections.Generic;

public abstract class Entity
{
    public int Id { get; set; }
}
public interface IRepository<T> where T : Entity
{
    void Add(T item);
    void Remove(T item);
    void Save();
    IEnumerable<T> GetAll();
    T GetById(int id);
}
public class GenericRepository<T> : IRepository<T> where T : Entity
{
    private readonly List<T> _dataSource;
    public GenericRepository()
    {
        _dataSource = new List<T>();
    }
    public void Add(T item)
    {
        _dataSource.Add(item);
    }
    public void Remove(T item)
    {
        _dataSource.Remove(item);
    }
    public void Save()
    {
    }
    public IEnumerable<T> GetAll()
    {
        return _dataSource;
    }
    public T GetById(int id)
    {
        foreach (T item in _dataSource)
        {
            if (item.Id == id)
            {
                return item;
            }
        }
        return null;
    }
}
