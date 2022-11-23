using System;
using System.Collections.Generic;
using System.Collections;

namespace Library
{
    public class Contract : IContract
    {
        private DateTime initDate;
        private DateTime finalDate;
        public string jobs;
        public bool IsValid;
        public bool Review = false;
        public Employee employee;
        public Employer employer;
        public bool employeeReviewed = false;
        public bool employerReviewed = false;

        public Contract(DateTime initDate, DateTime finalDate, string jobs, Employer employer, Employee employee)
        {
            this.initDate = initDate;
            this.finalDate = finalDate;
            this.jobs = jobs;

        }
        
       public DateTime getInitDate()
       {
        return this.initDate;
       }
       public DateTime getFinalDate()
       {
        return this.finalDate;
       }
       
       public void setInitDate(DateTime newInitDate)
       {
        this.initDate = newInitDate;
       } 
       public void setFinalDate(DateTime newFinalDate)
       {
        this.finalDate = newFinalDate;
       }
       
       public void setJobs (string newJob)
       {
        this.jobs = newJob;
       }

        // No se como mejorar lo del atributo si esta vigente. Pense en que si no tiene fecha de culminacion es que el contrato es valido y el trabajador sigue con contrato. 
        // Si la fecha de finalizacion es "-" es porque el trabajor sigue trabajando, por lo que  el contrato seria true, si es distinto a "-" es porque el contrato finalizo
        // No se si quieren dejarlo asi o quuieren modificar eso, porque no se me ocurre otra cosa. 
        public void isValid(string finalDate)
        {
            if (finalDate != "-")
            {
                IsValid = false;
            }
            else 
            {
                IsValid = true;
                var timeout = new TO();
                timeout.contract = this;
                var timer = new CountdownTimer();
                timer.Register(60000,timeout);
            }
        }
    }
}