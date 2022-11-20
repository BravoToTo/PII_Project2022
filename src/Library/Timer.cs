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

        public void Register(int timeOut, TimerClient client)
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

    public class TO : TimerClient
    {
        public Contract contract;
        public void TimeOut()
        {
            if (contract.employeeReviewed == false)
            {
                new EmployeeQualification(contract.employee, 3, "Autogenerated review, time to review ran out", contract);
            }
            if (contract.employerReviewed == false)
            {
                //No tengo idea que es el error de contract.employer
                new EmployerQualification(contract.employer, 3, "Autogenerated review, time to review ran out", contract);
            }
        }
    }
}