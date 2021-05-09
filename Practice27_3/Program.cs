using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice27_3
{
    delegate void Notify(string message);
    class Notifier
    {
        public Notify EventOccured;
    }

    class EventListener
    {
        private string name;
        public EventListener(string name)
        {
            this.name = name; 
        }
        public void SomethingHapped(string message)
        {
            Console.WriteLine($"{name}.SomethingHappend : {message}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Notifier notifier = new Notifier();
            EventListener listener1 = new EventListener("Listner1");
            EventListener listener2 = new EventListener("Listner2");
            EventListener listener3 = new EventListener("Listner3");

            notifier.EventOccured += listener1.SomethingHapped;
            notifier.EventOccured += listener2.SomethingHapped;
            notifier.EventOccured += listener3.SomethingHapped;

            notifier.EventOccured("You've Got Mail");

            Console.WriteLine();

            notifier.EventOccured -= listener1.SomethingHapped;
            notifier.EventOccured("Download Complete");

            Console.WriteLine();

            notifier.EventOccured = new Notify(listener2.SomethingHapped) + new Notify(listener3.SomethingHapped);
            notifier.EventOccured("Nuclear launch detected");

            Console.WriteLine();

            Notify notify1 = new Notify(listener1.SomethingHapped);
            Notify notify2 = new Notify(listener2.SomethingHapped);

            notifier.EventOccured = (Notify)Delegate.Combine(notify1, notify2);
            notifier.EventOccured("Fire");

            Console.WriteLine();

            notifier.EventOccured = (Notify)Delegate.Remove(notifier.EventOccured, notify2);
            notifier.EventOccured("RPG");

        }
    }
}
