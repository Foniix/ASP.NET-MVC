using System.Data.Entity;

namespace Gym.Models.Database
{
    public class DatabaseInitializer : DropCreateDatabaseAlways<DatabaseContext> //DropCreateDatabaseAlways<DatabaseContext> //CreateDatabaseIfNotExists<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            var Lorem = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";
            context.Trainers.AddRange(new[] {
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

            context.Halls.AddRange(new[] {
                new Hall(){
                    Id = 1,
                    Image = "/Images/CrossFitHall.jpg",
                    Name = "Кроссфит",
                    Descr = Lorem,
                    CounterOfClient = 20,
                    Headin = "headingOne",
                    Collapse = "collapseOne",
                    Expanded = true,
                },
                new Hall(){
                    Id = 2,
                    Image = "/Images/Rastyjka.jpg",
                    Name = "Растяжка",
                    Descr = Lorem,
                    CounterOfClient = 20,
                    Headin = "headingTwo",
                    Collapse = "collapseTwo",
                    Expanded = false,
                },
                new Hall(){
                    Id = 3,
                    Image = "/Images/TrainingHall.jpg",
                    Name = "Зал",
                    Descr = Lorem,
                    CounterOfClient = 50,
                    Headin = "headingThree",
                    Collapse = "collapseThree",
                    Expanded = false,
                },
                new Hall(){
                    Id = 4,
                    Image = "/Images/WaterHall.jpg",
                    Name = "Бассейн",
                    Descr = Lorem,
                    CounterOfClient = 10,
                    Headin = "headingFour",
                    Collapse = "collapseFour",
                    Expanded = false,
                },
            });
            context.SaveChanges();
        }
    }
}