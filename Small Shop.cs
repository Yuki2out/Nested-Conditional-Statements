string product = Console.ReadLine();
string city = Console.ReadLine();
double amount = double.Parse(Console.ReadLine());

double coffee = 0.00;
double water = 0.00;
double juice = 0.00;
double sweets = 0.00;
double peanuts = 0.00;




switch (city)
{
    case "Sofia":
        if (product == "coffee")
        {
            Console.WriteLine(0.55 * amount);
        }else if (product == "water")
        {
            Console.WriteLine(0.80 * amount);
        }
        else if (product == "juice")
        {
            Console.WriteLine(1.20 * amount);
        }
        else if (product == "sweets")
        {
            Console.WriteLine(1.45 * amount);
        }
        else if (product == "peanuts")
        {
            Console.WriteLine(1.60 * amount);
        }

       
        break;

    case "Plovdiv":
        if (product == "coffee")
        {
            Console.WriteLine(0.40 * amount);
        }
        else if (product == "water")
        {
            Console.WriteLine(0.70 * amount);
        }
        else if (product == "juice")
        {
            Console.WriteLine(1.15 * amount);
        }
        else if (product == "sweets")
        {
            Console.WriteLine(1.30 * amount);
        }
        else if (product == "peanuts")
        {
            Console.WriteLine(1.50 * amount);
        }
        break;
    case "Varna":

        if (product == "coffee")
        {
            Console.WriteLine(0.45 * amount);
        }
        else if (product == "water")
        {
            Console.WriteLine(0.70 * amount);
        }
        else if (product == "juice")
        {
            Console.WriteLine(1.10 * amount);
        }
        else if (product == "sweets")
        {
            Console.WriteLine(1.35 * amount);
        }
        else if (product == "peanuts")
        {
            Console.WriteLine(1.55 * amount);
        }
        break;
    

}