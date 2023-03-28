using System;


namespace dz2._2._6
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("user1", "Amir", "Eranus", 30);
            user.LoginInfo();
            Console.ReadKey();
        }
        class User
        {
            public string Login { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
            public DateTime RegistrationDate { get; }

            public User(string login, string firstName, string lastName, int age)
            {
                Login = login;
                FirstName = firstName;
                LastName = lastName;
                Age = age;
                RegistrationDate = DateTime.Now;
            }

            public void LoginInfo()
            {
                Console.WriteLine( $"Login: {Login}\nFirst name: {FirstName}\nLast name: {LastName}\nAge: {Age}\nRegistration date: {RegistrationDate}");
            }
        }
    }
}
