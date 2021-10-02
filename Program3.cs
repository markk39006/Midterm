using System;
using System.Collections.Generic;
enum Menu
{
    Login =1,
    Register,
}

namespace ConsoleApp13
{
    class Program
    {
        static PersonList personList;
        static void Main(string[] args)
        {
            PreparePersonList();
            PrintMainMenuScreen();
        }

        static void PreparePersonList()
        {
            Program.personList = new PersonList();
        }

        static void PrintMainMenuScreen()
        {
            Console.WriteLine("Welcome to Digital Library.");
            Console.WriteLine("----------------------------");
            Console.WriteLine("1 Login");
            Console.WriteLine("2.Register.");
            InputSelectMenu();

        }
        
        static void SelectMenu(Menu menu)
        {
            if(menu == Menu.Login)
            {
                PrintLoginScreen();
            }
            else if(menu == Menu.Register)
            {
                PrintHeaderRegisterPerson();
                Console.WriteLine("Select Type :");
                int n = int.Parse(Console.ReadLine());
                if (n == 1)
                {
                    Student student = TypeStudentperson();
                    Program.personList.AddNewPerson(student);
                }
                else if (n == 2)
                {
                    InputEmployeeID();
                    Employee employee = TypeEmployeeperson();
                    Program.personList.AddNewPerson(employee);
                } 
            }
        }

        static void PrintLoginScreen()
        {
            Console.WriteLine("Loging Screen");
            Console.WriteLine("--------------");
            InputLogint();
        }

        static void InputLogint()
        {
            Console.WriteLine("Input Name : ");
            string nameinput = Console.ReadLine();
            Console.WriteLine("Input Password : ");
            string Passwordinput = Console.ReadLine();
        }

        static void InputSelectMenu()
        {
            Console.WriteLine("Select Menu ");
            Menu menu = (Menu)int.Parse(Console.ReadLine());
            SelectMenu(menu);
        }

        static void PrintHeaderRegisterPerson()
        {
            Console.WriteLine("Register new Person");
            Console.WriteLine("-------------------");
            InputNewPerson();
        }

        static void InputNewPerson()
        {
            Person person = CreateNewPerson();
        }

        static Person CreateNewPerson()
        {
            return new Person(InputName(), InputPassword());
        }

        static string InputName()
        {
            Console.Write("Name : ");
            return Console.ReadLine();
        }

        static string InputPassword()
        {
            Console.Write("Password : ");
            return Console.ReadLine();
        }

        static Student TypeStudentperson()
        {
            Console.Clear();
            return new Student(InputName(),InputPassword(),InputStudentID());
        }

        static Employee TypeEmployeeperson()
        {
            Console.Clear();
            return new Employee(InputName(), InputPassword(), InputEmployeeID()) ;
        }

        static string InputStudentID()
        {
            Console.Write("Student ID : ");
            return Console.ReadLine();
        }

        static string InputEmployeeID()
        {
            Console.Write("Employee ID");
            return Console.ReadLine();
        }
        

    }

    class Person
    {
        public string Name;
        public string Password;
        public string Type;

        public Person(string name, string password)
        {
            this.Name = name;
            this.Password = password;
        }
    }

    class Student : Person
    {
        public string StudentID;
        public Student(string name,string password,string studentID):base(name, password)
        {
            this.StudentID = studentID;
        }
    }

    class Employee : Person
    {
        public string EmployeeID;
        public Employee(string name, string password, string employeeID) : base(name, password)
        {
            this.EmployeeID= employeeID;
        }
    }

    class PersonList
    {
        public List<Person> personList;

        public PersonList()
        {
            this.personList = new List<Person>();
        }

        public void AddNewPerson(Person person)
        {
            this.personList.Add(person);
        }
    }
}
