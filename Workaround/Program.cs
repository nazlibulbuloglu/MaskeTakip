using Business.Concrete;
using Workaround;



Person person1 = new Person();
person1.FirstName = "Nazlı";
person1.LastName = "Yıldız";
person1.DateOfBirthYear = 1993;
person1.NationalIdentity = 132412423134;

Person person2 = new Person();
person2.FirstName = "Tolga";
person2.LastName = "Bülbüloğlu";
person2.DateOfBirthYear = 1989;
person2.NationalIdentity = 1324124423434;



PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person2);