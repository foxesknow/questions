namespace _460_LFUCache
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cache = new LFUCache(2);
            
            cache.Put(1, 1);
            cache.Put(2, 2);
            var g1 = cache.Get(1);
            cache.Put(3, 3);
            var g2 = cache.Get(2);
            var g3 = cache.Get(3);
            cache.Put(4, 4);
            var g4 = cache.Get(1);
            var g5 = cache.Get(3);
            var g6 = cache.Get(4);

            Console.WriteLine("Hello, World!");
        }
    }
}