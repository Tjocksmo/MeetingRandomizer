using System;

namespace Meeting
{
    class Program
    {
        static void Main(string[] args)
        {
            IMeeting meeting = new Meeting();

            Console.WriteLine(meeting);
        }
    }
}
