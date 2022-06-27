namespace Proxy
{
    class CinematicVideoProxy : Video
    {
        private string name;
        private CinematicVideo real;

        public CinematicVideoProxy(string name)
            => this.name = name;

        public void play()
        {
            if(real == null)
                real = new CinematicVideo(name);

            real.play();
        }
    }
}
