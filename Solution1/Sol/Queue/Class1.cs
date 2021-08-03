using System;

public class Queue<T>
{
	private int index;
	private readonly int capacitate;
	private T[] q;

	public Queue(int capacitate)
	{
		this.capacitate = capacitate;
		this.q = new T[capacitate];
		this.index = 0;
	}
	public void enqueue(T item)
	{

		if (index == capacitate)
		{
			throw new InvalidOperationException("Queue is full");
		}
	q[index++] = item;
	}
	
	public T dequeue()
	{
		if (index == 0)
		{
			throw new InvalidOperationException("Queue is empty");
		}
			
		T item;
		item = q[0];
		for (int i = 0; i <index-1; i++)
			q[i] = q[i+1];
		index--;
		return item;
	}
    public override string ToString()
    {

		string a = "";

		for (int i = 0; i < index; i++)
		{ a = a + $"elementul {i} is {q[i]}\n"; }
		return a;
    }

}
