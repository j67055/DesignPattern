namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            ApplicationController appController = new ApplicationController(Updated.Instance);
            appController.releaseNewUpdate();
            appController.update();
            appController.releaseNewUpdate();
            appController.update();
            appController.update();
        }
    }
}
