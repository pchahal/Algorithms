using System;

namespace Algorithms
{

    //implement circular queue
    class Queue
    {
        const int MAX_SIZE = 4;
        public string[] queue = new string[MAX_SIZE];

        public int Head
        {
            get;
            set;
        }

        public int Tail
        {
            get;
            set;
        }

        public  Queue()
        {
            Head = -1;
            Tail = 0;
        }

        public void EnQueue(string data)
        {
            if (Head == -1)
            {
                Head = 0;
                Tail = 0;
            } else
            {
                Tail++;

                if (Tail > MAX_SIZE - 1)
                    Tail = 0;
            }
            queue [Tail] = data;



        }

        public string Dequeue()
        {
            string data = queue [Head];
            queue [Head] = string.Empty;
            Head++;

            if (Head > MAX_SIZE - 1)
                Head = 0;
            

            return data;
        }

        public override string ToString()
        {
            string output = "Head=" + Head + " Tail=" + Tail + "\n";

            foreach (var item in queue)
            {
                if (item != "")
                    output += item + ",";
            }
            return output;

        }
    }

}

