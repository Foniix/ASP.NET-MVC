using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Gym.Models.Database
{
    public class DatabaseInitializer : DropCreateDatabaseAlways<DatabaseContext> //DropCreateDatabaseAlways<DatabaseContext> //CreateDatabaseIfNotExists<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            context.Trainers.AddRange(new Trainer[] {
                new Trainer(){
                    Id = 1,
                    Image = "/Images/Trainer/t1.jpg",
                    FirstName ="Джон",
                    SecondName ="Уик",
                    Birthday="20/05/1990",
                    PhoneNumber = "+38 (065) 345-06-78",
                    Email = "trainer@gym.com",
                    Address = "LA 123s GYM#1",
                    Gender = "Male",
                    Status = "Главынй тренер",
                    Specialization = "Кроссфит",
                    WorkingTime = "16:00 - 22:00",
                },
                new Trainer(){
                    Id = 2,
                    Image = "/Images/Trainer/t2.jpg",
                    FirstName ="Конор",
                    SecondName ="макгрегор",
                    Birthday="10/07/1994",
                    PhoneNumber = "+38 (065) 560-06-32",
                    Email = "trainer2@gym.com",
                    Address = "LA 123s GYM#2",
                    Gender = "Male",
                    Status = "Тренер",
                    Specialization = "Кроссфит",
                    WorkingTime = "10:00 - 16:00",
                },
                new Trainer(){
                    Id = 3,
                    Image = "/Images/Trainer/t3.jpg",
                    FirstName ="Дуэйн",
                    SecondName ="Джонсон",
                    Birthday="17/02/1972",
                    PhoneNumber = "+38 (050) 345-21-79",
                    Email = "trainer3@gym.com",
                    Address = "LA 123s GYM#1",
                    Gender = "Male",
                    Status = "Главынй тренер",
                    Specialization = "Кроссфит",
                    WorkingTime = "00:00 - 16:00",
                },
                new Trainer(){
                    Id = 4,
                    Image = "/Images/Trainer/t4.jpg",
                    FirstName ="Просто",
                    SecondName ="Халк",
                    Birthday="10/12/1980",
                    PhoneNumber = "+38 (065) 456-35-65",
                    Email = "trainer4@gym.com",
                    Address = "LA 123s GYM#2",
                    Gender = "Male",
                    Status = "Старший тренер",
                    Specialization = "Кроссфит",
                    WorkingTime = "16:00 - 22:00",
                },
                new Trainer(){
                    Id = 5,
                    Image = "/Images/Trainer/t5.jpg",
                    FirstName ="Крис",
                    SecondName ="Хемсворт",
                    Birthday="11/07/1983",
                    PhoneNumber = "+38 (032) 145-06-38",
                    Email = "trainer5@gym.com",
                    Address = "LA 123s GYM#1",
                    Gender = "Male",
                    Status = "Тренер",
                    Specialization = "Кроссфит",
                    WorkingTime = "22:00 - 10:00",
                },
            });

            context.SaveChanges();
        }
    }
}