using System.Collections.Generic;
using System.Linq;

namespace Slamby.SDK.Net.Helpers
{
    public sealed class RawMessagePublisher
    {
        private static readonly RawMessagePublisher instance = new RawMessagePublisher();

        private LinkedList<IRawMessageSubscriber> Subscribers { get; set; } = new LinkedList<IRawMessageSubscriber>();

        // For events to be treated as 'fields', they need to be of type 'delegate'.
        // First, define the delegate type for the event 
        public delegate void RawDataHandler(object sender, RawMessageEventArgs e);

        // public event declaration, a 'delegate' type for the event must be declared first
        // initialize to empty delegate to avoid Gotcha 4 - race condition      
        public event RawDataHandler RawDataPublish = delegate { };


        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit
        static RawMessagePublisher()
        {
        }

        private RawMessagePublisher()
        {
        }

        public static RawMessagePublisher Instance
        {
            get
            {
                return instance;
            }
        }

        public void AddSubscriber(IRawMessageSubscriber subscriber)
        {
            this.Subscribers.AddFirst(subscriber);
            this.RawDataPublish += subscriber.OnRawDataPublish;
        }

        public void RemoveSubscriber(IRawMessageSubscriber subscriber)
        {
            this.RawDataPublish -= subscriber.OnRawDataPublish;
            this.Subscribers.Remove(subscriber);
        }

        public void Publish(string message)
        {
            if (RawDataPublish == null)
            {
                return;
            }

            var args = new RawMessageEventArgs(message);

            foreach (var handler in RawDataPublish.GetInvocationList().Cast<RawDataHandler>())
            {
                handler.BeginInvoke(this, args, null, null);
            }
        }
    }
}
