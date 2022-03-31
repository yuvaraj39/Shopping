using System;

namespace Shopping_Cs{
class Program
{
    static void Main(string[] args)
    {
        var arrUsers = new Users[]
        {
            new Users("Uvaraja","Uvaraja@9080",1)
        };

        var Item = new Items[]
        {
            new Items("Led",15),
            new Items("Motor",10),
            new Items("WaterSensor",10),
            new Items("IR Sensor",10),
            new Items("Laser",5),
            new Items("Buck Converter",4)
        };

        Start:
        Console.WriteLine("Welcome To Electo");
        Console.WriteLine("1 SignIn");
        Console.WriteLine("2 SignUp");
        Console.WriteLine("3 Exit");

        var input = Console.ReadLine();

        bool successfull = false;
        while (!successfull)
        {
            if (input == "1")
            {
                Console.Write("Username:");
                var username = Console.ReadLine();
                Console.Write("Password:");
                var password = Console.ReadLine();

                foreach (Users user in arrUsers)
                {
                    if (username == user.username && password == user.password)
                    {
                        Console.WriteLine("Login Successfull");

                        for(int i=0;i<27;i++){Console.Write("-");}

                        Console.Write("Welcome {0}",user.username);

                        for(int i=0;i<27;i++){Console.Write("-");}

                        Console.WriteLine("");

                        Console.WriteLine(" :)  Product of the day  :) ");

                        foreach(Items Itm in Item){
                            Console.WriteLine($"Item Name: {Itm.Itm_Name} Qty:{Itm.qty}");

                        }
                        Console.ReadLine();
                        successfull = true;
                        break;
                    }
                }

                if (!successfull)
                {
                    Console.WriteLine("Your username or password is incorect, try again !!!");
                }

            }

            else if (input == "2")
            {

                Console.Write("New username:");
                var username = Console.ReadLine();

                Console.Write("New password:");
                var password = Console.ReadLine();

                Console.Write("Enter your id:");
                int id = int.Parse(Console.ReadLine());


                Array.Resize(ref arrUsers, arrUsers.Length + 1);
                arrUsers[arrUsers.Length - 1] = new Users(username, password, id);
                successfull = true;
                goto Start;

            }
            else if(input=="3")
            {
                Console.WriteLine("Thank You for Shopping");
                break;

            }
            else
            {
                Console.WriteLine("Try again !!!");
                break;


            }

        }

    }
}

public class Users
{
    public string username;
    public string password;
    private int id;

    public Users(string username, string password, int id)
    {
        this.username = username;
        this.password = password;
        this.id = id;
    }
}

public class Items{
    public string Itm_Name;

    public int qty;

    public Items(string Itm_Name,int qty)
    {
        this.Itm_Name=Itm_Name;
        this.qty=qty;

    }

}

}