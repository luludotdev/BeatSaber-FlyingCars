using System;
using IllusionPlugin;

namespace FlyingCarEnabler
{
    public class Plugin : IPlugin
    {
        public string Name => "Flying Car Enabler";
        public string Version => "0.1.0";

        public void OnApplicationStart()
        {
            Console.WriteLine("[Flying Car Enabler] Loaded.");
            FlyingCar.startflyingCars = true;
        }

        public void OnApplicationQuit()
        {
        }

        public void OnLevelWasLoaded(int level)
        {
        }

        public void OnLevelWasInitialized(int level)
        {
        }

        public void OnUpdate()
        {
        }

        public void OnFixedUpdate()
        {
        }
    }
}