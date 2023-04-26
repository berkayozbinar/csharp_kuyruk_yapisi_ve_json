using System;

namespace veriproje
{
    class Queue
    {
        public readonly Poetrist[] arr;

        private int rear = -1;
        public Queue(int capacity) => arr = new Poetrist[capacity];
        public void Enqueue(Poetrist data)
        {
            arr[++rear] = data;
        }
    }
}
