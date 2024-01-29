using System.Collections.Generic;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*var person = new person();
            var p = person.parse("john");
            var person = person.parse("john");
            person.introduce("mosh");

            var customer = new Customer(1, "John");
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);

            var order = new Order();
            customer.Orders.Add(order);


            static void UsePoints()
            {
                try
                {
                    var point = new Point(10, 20);
                    point.Move(null);
                    Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);

                    point.Move(100, 200);
                    Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);

                }
                catch (Exception)
                {

                    Console.WriteLine("An unexpectd error occured.");
                }
            }

            static void UseParams()
            {
                var calculator = new Calculator();
                Console.WriteLine(calculator.Add(1, 2));
                Console.WriteLine(calculator.Add(1, 2, 3));
                Console.WriteLine(calculator.Add(1, 2, 3, 4));
                Console.WriteLine(calculator.Add(new int[] { 1, 2, 3, 4, 5 }));

            }

            try
            {
                var num = int.Parse("abc");
            }
            catch (Exception)
            {

                Console.WriteLine("Conversion failed.");
            }


            int number;
            var result = int.TryParse("abc", out number);
            if(result)
                Console.WriteLine(number);
            else
                Console.WriteLine("Conversion failed.");

            var customer = new Customer(1);
            customer.Orders.Add(new Order());
            customer.Orders.Add(new Order());

            customer.Promote();

            Console.WriteLine(customer.Orders.Count);
           

            var person = new Person();
            person.SetBirthdate(new DateTime(1982, 1, 1));
            Console.WriteLine(person.GetBirthdate());
            

            var person = new Person(new DateTime(2001, 9, 26));
            Console.WriteLine(person.Age);
            

            var cookie = new HttpCookie();
            cookie["name"] = "Mosh";
            Console.WriteLine(cookie["name"]);
            

            try
            {
                var stopwatch = new Stopwatch();

                while (true)
                {
                    Console.WriteLine("Please select one option to perform action with stopwatch: \n 1.Start \n 2.Stop \n 3.Exit");
                    var res = Console.ReadLine();
                    if (res.ToLower() == "exit") break;
                    Console.WriteLine(stopwatch.Run(res));
                }
                


            }
            catch (Exception)
            {

                Console.WriteLine("The operation is Invalid..!"); ;
            }
            

            var newPost = new Post();
            while (true)
            {
                Console.WriteLine("Please select a option number to upvote " +
                    "and downvote or exit to view vote count" +
                    ":\n1.Upvote\n2.Downvote\n3.Exit");
                var vote=Console.ReadLine();
                if (int.Parse(vote)==3) break;
                newPost.voteCount(int.Parse(vote));
            }
            Console.WriteLine("Post Details are:\n"+"Title: "+newPost.Title+"\nDescription: "+newPost.Desc+"\nDateTime: "+newPost.DateTimeCreate+'\n');
            Console.WriteLine("Total Votes are: "+(newPost.Upvote-newPost.Downvote));
            

            var text = new Text();
            text.Width = 100;
            text.Copy();
            */

            var dbMigrator = new DbMigrator(new Logger());

            var logger = new Logger();
            var installer = new Installer(logger);

            dbMigrator.Migrate();
            installer.Install();

        }
    }
}
