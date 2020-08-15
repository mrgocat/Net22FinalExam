using System;
using System.Collections.Generic;
using System.Text;

namespace Net22FinalExam
{
    class EventAnswer
    {
        static void Main(string[] args)
        {
            EventReceiver receiver = new EventReceiver();
            receiver.Name = "Receiver1";

            EventCreater creater = new EventCreater();
            creater.MyEvent += receiver.HanderEvent;

            creater.CreateEvent();
        }
    }

    public class EventReceiver
    {
        public string Name { get; set; }

        public void HanderEvent(object sender, MyEventArgs e)
        {
            Console.WriteLine("{0} received Event {1}", Name, e.Info);
        }
    }

    public class EventCreater
    {
        public event MyEventHandeler MyEvent;

        public void CreateEvent()
        {
            Console.WriteLine("Fire!!!!");
            if (MyEvent != null)
            {
                MyEvent(this, new MyEventArgs("ticked!!"));
            }
        }
    }


    public delegate void MyEventHandeler(object source, MyEventArgs e);

    public class MyEventArgs : EventArgs
    {
        public string Info { get; set; }
        public MyEventArgs(string info)
        {
            this.Info = info;

        }
    }
}
