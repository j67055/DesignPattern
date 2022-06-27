namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            Video intro = new CinematicVideoProxy("인트로 시네마틱");
            Video ending = new CinematicVideoProxy("엔딩 시네마틱");

            intro.play();
            intro.play();
            ending.play();
            ending.play();
        }
    }
}
