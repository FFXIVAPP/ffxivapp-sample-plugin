using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ffxivmc.Plugin.Utilities
{
    static class MCTask
    {
        public static Task RunOnThread(Action A)
        {
            Task Ta = new Task(A);
            Ta.Start();
            return Ta;
        }

        /*
        public static void RunOnUI(Action A)
        {
            Application.Current.Dispatcher.Invoke(A);
        }

        public static Task IntervalThread(Action A, int delay)
        {
            Task Interval = new Task(() =>
            {
                while (true)
                {
                    Thread.Sleep(delay);
                    A.Invoke();
                }
            });
            Interval.Start();
            return Interval;
        }

        public static Task DelayThread(Action A, int delay)
        {
            Task Interval = new Task(() =>
            {
                Thread.Sleep(delay);
                A.Invoke();
            });
            Interval.Start();
            return Interval;
        }*/

        public static long UnixTimeNow()
        {
            var timeSpan = (DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0));
            return (long)timeSpan.TotalSeconds;
        }
    }
}
