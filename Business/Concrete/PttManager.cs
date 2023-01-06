﻿using Business.Abstract;
using Workaround;

namespace Business.Concrete
{
    public class PttManager:ISupplierService
    {
        private IApplicantService _applicantService;
        public PttManager(IApplicantService applicantService)
        {
            _applicantService= applicantService; 
        }
        public void GiveMask(Person person)
        {
            
            if (_applicantService.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + " için maske verilmiştir.");
            }
            else
            { 
                Console.WriteLine(person.FirstName + " için maske VERİLEMEDİ.");
            }
                
            
        }
    }
}
