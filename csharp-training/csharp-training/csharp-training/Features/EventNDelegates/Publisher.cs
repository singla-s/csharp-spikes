using System;

namespace csharp_training.Features
{
    internal class Publisher
    {
        public delegate void PublishHandler(object src, EventArgs args);

        public event PublishHandler handler;

        public void Publish()
        {
            Console.WriteLine("Publish Started...");
            Thread.Sleep(2000);
            OnPublish();
        }

        protected virtual void OnPublish()
        {
            handler(this, EventArgs.Empty);
        }
    }
}
