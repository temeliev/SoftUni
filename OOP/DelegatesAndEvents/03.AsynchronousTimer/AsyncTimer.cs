namespace _03.AsynchronousTimer
{
    using System;
    using System.Timers;

    public class AsyncTimer
    {
        private Action action;

        private int ticks;

        private Timer InternalTimer { get; set; }

        public AsyncTimer(Action action, int ticks, double timeInterval)
        {
            this.action = action;
            this.ticks = ticks;
            this.InternalTimer = new Timer(timeInterval);
            this.IsCounting = true;
        }

        public bool IsCounting { get; private set; }

        public void Start()
        {
            this.InternalTimer.Elapsed += this.InternalTimerElapsed;
            this.InternalTimer.AutoReset = true;
            this.InternalTimer.Enabled = true;
            this.InternalTimer.Start();
        }

        void InternalTimerElapsed(object sender, ElapsedEventArgs e)
        {
            this.action();

            this.ticks--;

            if (this.ticks == 0)
            {
                this.IsCounting = false;
                this.InternalTimer.Stop();
               // this.InternalTimer.Elapsed -= this.InternalTimerElapsed;
            }
        }
    }
}
