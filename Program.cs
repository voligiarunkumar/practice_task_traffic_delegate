using System;

namespace cn_traffic_delegate
{
    internal class Program
    {
        public delegate void TrafficDel();
        class TrafficSignall
        {

            public static void signals() { Console.WriteLine("This are the signals"); }
            public static void Red() { Console.WriteLine("Red light signals "); }

            public static void Green() { Console.WriteLine("Green light signals "); }

            public static void yellow() { Console.WriteLine("Yellow light signals "); }

            TrafficDel[] obj = new TrafficDel[4];
            public void IdentifySignal()
            {
                obj[0] = new TrafficDel(signals);
                obj[2] = new TrafficDel(yellow);

                obj[1] = new TrafficDel(Green);
                obj[3] = new TrafficDel(Red);
            }
            public void show()
            {
                obj[0]();
                Console.WriteLine("-----------------------------------");
                obj[1]();
                obj[2]();
                obj[3]();

            }
            static void Main(string[] args)
            {
                TrafficSignall trafficSignall = new TrafficSignall();
                trafficSignall.IdentifySignal();
                trafficSignall.show();
            }


        }
    }
}
