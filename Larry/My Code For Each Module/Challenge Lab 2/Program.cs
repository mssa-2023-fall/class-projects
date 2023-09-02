using System;
using System.Buffers;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using Restaurant;
/*
See how this will work out:

Create prompts to ask customers if they want a choice of a salad, sandwhich, burger or burrito

Create prompts to ask what sides they would like: fries, drink, chips or veggies
*/

namespace Restaurant 
{ 
    class Program 
    { 
        static void Main(string[] args)
        {
            string main;
            string side;
            string drink;
            string response;
            string cName;
            string option;
            
        
            Console.WriteLine("Good day, welcome to some restaurant! How are you doing today?");
            response = Console.ReadLine();
            Console.WriteLine("and what is your name?");
            cName = Console.ReadLine();
            Console.WriteLine($"Hey {cName}! I'm glad to hear that you are doing {response}! Would you like a combo or separate entrees today for your meal?");
            option = Console.ReadLine();
            //Combos
            //WHILE loop with nested IF statemenets in order to break out or continue loops.
            if (option == "combo")
            {
            while (option == "combo")
            {
                Console.WriteLine("""
                    Easy day! Our combo options are:
                    Number 1 is burger, fries, and your choice of drink.
                    Number 2 is burrito, chips and your choice of drink.
                    Number 3 is a chicken caesar salad, with more veggies and your choice of drink.
                    
                    Please choose any of the above.
                    """);
                var rCombo = int.Parse(Console.ReadLine());
                if (rCombo == 1)
                {
                    Combos choice1 = new Combos();
                    choice1.combo1();
                    Console.WriteLine("Here is your combo..");
                    break;
                }
                else if (rCombo == 2)
                {
                    Combos choice2 = new Combos();
                    choice2.combo2();
                    Console.WriteLine("Here is your combo..");
                    break;
                }
                else if (rCombo == 3)
                {
                    Combos choice3 = new Combos();
                    choice3.combo3();
                    Console.WriteLine("Here is your combo..");
                    break;
                }
            }
            }
            else
            {
                goto DESERTS;
            }
            //Entrees
            //WHILE loop with nested IF statemenets in order to break out or continue loops.
            if (option == "entrees")
            {
            while (option == "entrees")
                {
                    //Choosing main dish
                    Console.WriteLine("""
                    So you prefer entrees that's great to hear! What would you like to get started with today? 
                    You have a choice of salad, sandwich, burger or burrito.
                    """);

                    main = Console.ReadLine();
                    if (main == "salad" || main == "sandwich" || main == "burger" || main == "burrito")
                    {
                        Console.WriteLine($"""
                    A {main}, that's great! 
                    Please choose a side of fries, chips or veggies: 
                    """);
                    }
                    //ELSEIF the response is not an option
                    else if (main == "" || main != "salad" || main != "sandwich" || main != "burger" || main != "burrito")
                    {
                        Console.WriteLine("Try again: ");
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Sir this is Arby's. Goodbye.");
                        break;
                    }
                    
                    //Choosing a side if everything has gone smooth so far
                    side = Console.ReadLine();
                    if (side == "fries" || side == "chips" || side == "veggies")
                    {
                        Console.WriteLine($"""
                    A side of {side}, that's cool.. 
                    What about a drink? coke, water or juice?
                    """);
                    }
                    //ELSEIF the response is not an option
                    else if (side == "" || side != "fries" || side != "chips" || side != "veggies")
                    {
                        Console.WriteLine("Not an option..");
                        Console.WriteLine("Please just choose a side: ");
                        side = Console.ReadLine();
                            if (side == "fries" || side == "chips" || side == "veggies")
                            {
                                Console.WriteLine($"Okay, so {side}.. and your choice of coke, water or juice: ");
                                drink = Console.ReadLine();
                                    if (drink == "coke" || drink == "water" || drink == "juice")
                                    {
                                        Console.WriteLine($"Great! a {main}, {side}, and {drink} coming right up!");
                                    }
                                    else
                                    {
                                        Console.WriteLine("I quit");
                                        break;
                                    }
                            }
                    }
                    else
                    {
                        Console.WriteLine("Sir this is Arby's. Goodbye.");
                        break;
                    }

                    //Choosing a drink if everything has gone smooth so far
                    drink = Console.ReadLine();
                    if (drink == "coke" || drink == "water" || drink == "juice")
                    {
                        Console.WriteLine($"""
                    Great! a {main}, {side}, and {drink} coming right up! .................
                    Thank you for your patience and enjoy your meal! Peace
                    """);
                    }
                    //ELSEIF the response is not an option
                    else if (drink == "" || drink != "coke" || drink != "water" || drink != "juice")
                    {
                        Console.WriteLine("A what..?");
                        drink = Console.ReadLine();
                            if (drink == "coke" || drink == "water" || drink == "juice")
                                {
                                    Console.WriteLine($"Great! a {main}, {side}, and {drink} coming right up!");
                                }
                            else
                                {
                                continue;
                                }
                    }
                    else
                    {
                        Console.WriteLine("Sir this is Arby's. Goodbye.");
                        break;
                    }
                continue;
                }
            }
            else
            {
                goto DESERTS;
            }
            //Read final results 
            Console.ReadLine();
            
            //Post meal
            DESERTS:
            //SETTING VARIABLES 
            string jResponse;
            string pResponse;
            // Restaurant Positions
            // Restaurant Position's WAGES
            Negotiating money = new Negotiating();
            //Looking for a job?
            Console.WriteLine("If you aren't looking for food, are you looking for a job?");
            jResponse = Console.ReadLine();
            
            //Begin interview
            while (jResponse != "" || jResponse != null)
            {
            if (jResponse == "yes" || jResponse == "Yes")
            {
                Console.WriteLine($"""
                What position are you looking for? We have:

                {money.cEmployee}
                {money.wEmployee} 
                {money.rEmployee}

                Available.. which would you like? 

                """);
                pResponse = Console.ReadLine();
                if (pResponse == "Chef" || pResponse == "chef")
                { 
                    Console.WriteLine($"Please wait one moment while I look for information on the {money.cEmployee} position: ");
                    System.Threading.Thread.Sleep(3000);
                    money.ChefWage();
                    break;
                }
                else if (pResponse == "Waiter" || pResponse == "waiter")
                {
                    Console.WriteLine($"Please wait one moment while I look for information on the {money.wEmployee} position: ");
                    System.Threading.Thread.Sleep(3000);
                    money.WaiterWage();    
                    break;
                }
                else if (pResponse == "Register" || pResponse == "register")
                {
                Console.WriteLine($"Please wait one moment while I look for information on the {money.rEmployee} position: ");
                    System.Threading.Thread.Sleep(3000);
                    money.RegisterWage();
                    break;
                }
                else if (pResponse == "" || pResponse == null)
                {
                    continue;
                }
                else 
                {
                    Console.WriteLine("Sorry, that's all we got boss");
                    break;
                }
                
            }
            }
            
        }    
    } 
} 
