using Assignment_11___C____advanced___shahd_mostafa.classes;

namespace Assignment_11___C____advanced___shahd_mostafa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region V1
            //Action action = () => Console.WriteLine("Hello");
            //action.Invoke();

            //Ball ball = new Ball(121,new Location ());

            //Player player11 = new Player("Mohamed", "FC");
            //Player player12 = new Player("Sayed","FC");
            //Player player21 = new Player("Karim", "FC2");
            //Player player22 = new Player("Sherif", "FC2");

            //Refree refree = new Refree("Mahmoud");
            //ball.LocationChange += player11.Run;
            //ball.LocationChange += player12.Run;
            //ball.LocationChange += player21.Run;
            //ball.LocationChange += player22.Run;
            //ball.LocationChange += refree.Look;
            //ball.LocationChange += (newloc) => Console.WriteLine("Extra Time");
            //ball.Location = new Location(10,15);
            #endregion

            #region V2
            Ball ball = new Ball(121, new Location()) { Name="kora"};

            Player player11 = new Player("Mohamed", "FC");
            Player player12 = new Player("Sayed", "FC");
            Player player21 = new Player("Karim", "FC2");
            Player player22 = new Player("Sherif", "FC2");

            Refree refree = new Refree("Mahmoud");
            ball.LocationChange += player11.Run;
            ball.LocationChange += player12.Run;
            ball.LocationChange += player21.Run;
            ball.LocationChange += player22.Run;
            ball.LocationChange += refree.Look;
            ball.LocationChange += (sender, loc) => Console.WriteLine("Extra Time");
            ball.Location = new Location(10, 15);
            #endregion

            #region V3
            // var,dynamic,object
            var str = "Hello world";
            foreach (var arg in str)
            {
                Console.WriteLine(arg);
            }
            //str = 10; // not allowed for reassignment in diffferent datatype

            //Dictionary<string,int> keyValuePairs = new Dictionary<string,int>();
            //foreach(var arg in keyValuePairs)
            //{
            //    Console.WriteLine(arg.Key);
            //}

            dynamic str1 = "shahd"; // detect datatype in runtime
            Console.WriteLine(str1);
            str1 = 10;
            Console.WriteLine(str1);
            str1 = new Player("Mohamed","FC");
            Console.WriteLine(str1.ToString());
            str += 10; // throw expection
            #endregion

            #region V4
            Player player = new Player() { Name = "Ahmed", Team = "FC" };
            var employee = new {Id=12,Name="sayed" ,Age=25,Salary=4500};
            var employee1 = new { Id = 9, Name = "Mohamed", Age = 26, Salary = 7000 };
            var newemp = employee with { Id = 1 };
            Console.WriteLine(employee.GetType().Name);
            Console.WriteLine(employee1.GetType().Name);
            #endregion
        }
    }
}
