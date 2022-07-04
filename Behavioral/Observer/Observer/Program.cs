namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            FireDetector detector = new FireDetector();
            Alam alam = new Alam(detector);
            Sprinkler sprinkler = new Sprinkler(detector);

            detector.add(sprinkler);
            detector.add(alam);

            detector.detecte(true);
            detector.detecte(false);

            detector.remove(alam);
            detector.remove(sprinkler);
        }
    }
}
