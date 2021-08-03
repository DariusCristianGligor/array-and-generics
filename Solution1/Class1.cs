using System;

public class Queue<T>
{
	private int  index;
	private readonly int capacitate;
	private T[]q;

	public Queue(int capacitate)
	{
		this.capacitate = capacitate;
		this.q = new T[capacitate];
		this.index = 0;
	}
	public void enqueue(T item)
	{

		if (index == capacitate)
			throw new InvalidOperationException("Queue is full");
	}
	Queue[index++]=item;
	public T dequeue()
	{ 
	if(index==0) throw new InvalidOperationException("Queue is empty");
		T item = new T<>;
		for (int i = 1; i < index; i++)
			q[i] = q[i++];
		index--;
		return item;
	}
}
