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
        }
    }
}
