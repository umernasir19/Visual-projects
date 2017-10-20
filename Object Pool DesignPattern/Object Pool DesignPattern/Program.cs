using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;


namespace ObjectPoolExample
{
    // Generic Object Pool Class
    public class ObjectPool<T>
    {
        // ConcurrentBag used to store and retrieve objects from Pool.
        private ConcurrentBag<T> _objects;
        private Func<T> _objectGenerator;

        // Object pool contructor used to get a delegate for implementing instance initialization
        // or retrieval process
        public ObjectPool(Func<T> objectGenerator)
        {
            if (objectGenerator == null) throw new ArgumentNullException("objectGenerator");
            _objects = new ConcurrentBag<T>();
            _objectGenerator = objectGenerator;
        }

        // GetObject retrieves the object from the object pool (if already exists) or else
        // creates an instance of object and returns (if not exists)
        public T GetObject()
        {
            T item;
            if (_objects.TryTake(out item)) return item;
            return _objectGenerator();
        }

        // PutObject stores back the object back to pool.
        public void PutObject(T item)
        {
            _objects.Add(item);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            /* Long running and single thread operation which creates an instance of 
             * object for every iteration.
             * See results in below depicted image.
            for (int i = 0; i <= 10000; i++)
            {
                MyClass mc = new MyClass();
                Console.WriteLine(mc.GetValue(i));
            }
            */

            // Object pool implementation
            ObjectPool<MyClass> pool = new ObjectPool<MyClass>(() => new MyClass());

            /* Use thread safe - multi threaded Parallel.For to speed up the process
             * Pool.GetObject() first creates an instance of MyClass and then get its
             * value, finally Pool.PutObject() places back the instance to the pool.
            */
            Parallel.For(0, 10000, (i, loopState) =>
            {
                MyClass mc = pool.GetObject();

                Console.CursorLeft = 0;
                Console.WriteLine(mc.GetValue(i));

                pool.PutObject(mc);
            });

            Console.WriteLine("Press the Enter key to exit.");
            Console.ReadLine();
        }

    }

    // Sample class which creates an array of integers and then stores Random integers
    // into it. GetValue() takes a long as a param and then return the specific value 
    // stored in that position of array.
    class MyClass
    {
        public int[] Nums { get; set; }
        public long GetValue(long i)
        {
            return Nums[i];
        }
        public MyClass()
        {
            Nums = new int[100000];
            Random rand = new Random();
            for (int i = 0; i < Nums.Length; i++)
                Nums[i] = rand.Next();
        }
    }
}