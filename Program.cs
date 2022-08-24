namespace RegistrationOnCourses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ввод данных пользователя
            string head = "Введите данные пользователя";
            Print printUserDatum = new Print(head);
            printUserDatum.PrintHead();
            Console.Write("Фамилия: ");
            string surname = Console.ReadLine();
            Console.Write("Имя: ");
            string name = Console.ReadLine();
            Console.Write("Отчество: ");
            string midname = Console.ReadLine();
            Console.Write("Уровень образования (высшее, среднее, начальное, общее): ");
            string eduLevel = Console.ReadLine();
            // Добавление
            using (registration_on_coursesContext db = new registration_on_coursesContext())
            {
                User newUser = new User { Surname = surname, Name = name, Midname = midname, EduLevel = eduLevel };
                
                // Добавление
                db.Users.Add(newUser);
                Console.WriteLine("Данные сохранены. Нажмите Enter для продолжения...");
                db.SaveChanges();
            }
            Console.Clear();

            //Просмотр доступных курсов
            head = "Список доступных курсов:";
            Print printCourseDatum = new Print(head);
            printCourseDatum.PrintHead();
            CoursesSet courses = new CoursesSet();
            courses.printCourses();

            //Запись на курс
            Console.Write("Укажите номер курса: ");
            int number = Convert.ToInt32(Console.ReadLine());
            using (registration_on_coursesContext db = new registration_on_coursesContext())
            {
                UsersOnCourse newP = new UsersOnCourse {  CourseId = number, UsersId = 5};

                // Добавление
                db.UsersOnCourses.Add(newP);
                Console.WriteLine("Запись на курс сохранена. Нажмите Enter для продолжения...");
                db.SaveChanges();
            }
        }
    }
}