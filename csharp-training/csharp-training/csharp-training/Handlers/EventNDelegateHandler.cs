using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using csharp_training.Features;

namespace csharp_training.Handlers
{
    internal class EventNDelegateHandler
    {
        public void executeHandler()
        {
            Publisher publisher = new Publisher();
            Subscriber subscriber = new Subscriber();

            publisher.handler += subscriber.SendNotification;
            publisher.Publish();
        }
    }
}
