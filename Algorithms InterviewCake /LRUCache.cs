using System.Collections.Generic;

class LRUCache
{
    int cacheSize;
    Queue<int> lruCache = new Queue<int>();
    Dictionary<int, int> lruDictionary = new Dictionary<int, int>();

    public LRUCache(int size)
    {
        if (size < 1)
            new System.Exception();
        cacheSize = size;
    }

    public void set(int k, int v)
    {
        if (lruCache.Count < cacheSize)
        {
            if (lruDictionary.ContainsKey(k))
            {
                lruDictionary[k] = v;
                return;
            }
            else
            {
                lruDictionary[k] = v;
                lruCache.Enqueue(k);

                return;
            }
        }
        //max size reached
        int value = lruCache.Dequeue();
        set(k, v);
    }


    public int get(int key)
    {
        if (lruDictionary.ContainsKey(key))
        {
            int value = lruDictionary[key];
            return value;
        }
        throw new System.Exception();
    }

}

