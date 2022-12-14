using System;
using System.Threading;

namespace Library
{
    public interface TimerClient
    {
        void TimeOut();
    }

    public class CountdownTimer
    {
        private TimerClient client;

        private Timer timer;

        public void Register(long timeOut, TimerClient client)
        {
            this.client = client;
            this.timer = new Timer(this.OnTimedEvent, null, timeOut, Timeout.Infinite);
        }

        private void OnTimedEvent(object state)
        {
            this.client.TimeOut();
            this.timer.Change(Timeout.Infinite, Timeout.Infinite);
        }
    }

    public class TimeOutReview : TimerClient
    {
        public Contract contract;
        public void TimeOut()
        {
            if (contract.employeeReviewed == false)
            {
               QualificationManager.Instance.Review(contract.employer, 3, "Autogenerated review, time to review ran out", contract);
            }
            if (contract.employerReviewed == false)
            {
                QualificationManager.Instance.Review(contract.employee, 3, "Autogenerated review, time to review ran out", contract);
            }
        }
    }
    public class TimeOutContract : TimerClient
    {
        public Contract contract;
        public void TimeOut()
        {
            contract.ended();
        }
    }
}