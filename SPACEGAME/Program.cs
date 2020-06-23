using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPACEGAME
{
    class Program
    {
        static void Main(string[] args)
        
            {
                startGame();


            }
        public static double currentAge;

        public static void GameTitle()

        {
            Console.WriteLine("Welcome to my Space trade game");

            Console.WriteLine("you live on Planet earth and own a spaceship and 1000 credits");
            Console.WriteLine(" press 'Enter' to Begin.");

            Console.ReadLine();
            Console.Clear();
            EarthMenu();
        }


        public static void EarthMenu()  // First Method, give menu on earth

        {
            string Choice;

            Console.WriteLine("you have 1000 credit, spaceship and fuel to travel, What would you like to do?");
            Console.WriteLine("1. buy goods");
            Console.WriteLine("2. travel to Mars");
            Console.WriteLine("3. travel to proxima");
            Console.WriteLine("4. sell goods");

            Console.Write("choice:   ");
            Choice = Console.ReadLine().ToLower();
            Console.Clear();

            switch (Choice)
            {
                case "1":
                case "buygoods":
                    {
                        Console.WriteLine(" you purchase cases of 2 cases of water, clothes, 2 computers, furs and  2 bottles of Henessy");
                        AssetonEarth(); // give total value of items purchased

                        break;
                    }

                case "2":
                case "MarsTravel": // character load his spaceship and travel the planet Mars

                    {
                        Console.WriteLine("after loading your spaceship, you travelled and arrived on  Mars safely from earth");
                        TimeTravelEarthtoMars();

                        Console.ReadLine();

                        break;
                    }

                case "3":
                case "proximatravel": // Character load his spaceship and travel to Proxima 1.
                    {
                        Console.WriteLine(" you just arrived on Proxima 1 what would like to do?");
                        Console.WriteLine("press enter to continue");
                        Console.ReadLine();
                        TimeTravelEarttoProxima();
                        break;
                    }

                case "4":
                case "sellGoods": // character sells good on earth

                    {
                        Console.WriteLine(" you just arrived to  Mars what would like to do?");
                        Console.WriteLine("press enter to continue");
                        Console.ReadLine();
                        break;
                    }

                default:
                    {
                        Console.WriteLine(" I don't know what to do");
                        Console.WriteLine("press enter to try again ");
                        Console.ReadLine();
                        EarthMenu();
                        break;

                    }


            }
        }


        public static void MarsMenu()  // Second Method, give menu on Mars

        {
            string Choice;

            Console.WriteLine("You are on Planet Mars, What would you like to do?");
            Console.WriteLine("1. trade goods");
            Console.WriteLine("2. travel to proxima");
            Console.WriteLine("3. sell goods and return to earth");

            Console.Write("choice:   ");
            Choice = Console.ReadLine().ToLower();
            Console.Clear();

            switch (Choice)
            {
                case "1":
                case "tradegoods":
                    {
                        Console.WriteLine(" select items on Mars  you would like to trade");
                        AssetonMars(); // give total value of items purchased

                        break;
                    }

                case "2":
                case "travelproxima": // character travel to proxima from Mars

                    {
                        Console.WriteLine("after trading items on Mars you load your ship and travel to Proxima century for more trade before returning on earth");
                        TimeTravelMarstoProxima();
                        Console.ReadLine();
                        break;
                    }

                case "3":
                case "return": // Character return on earth after selling or trading items.
                    {
                        Console.WriteLine(" you just arrived on Proxima 1 what would like to do?");
                        Console.WriteLine("press enter to continue");
                        Console.ReadLine();
                        break;
                    }

                default:
                    {
                        Console.WriteLine(" I don't know what to do");
                        Console.WriteLine("press enter to try again ");
                        Console.ReadLine();
                        MarsMenu();
                        break;

                    }


            }
        }

        public static void proximamenu()  // Third Method, give menu on Proxima

        {
            string Choice;

            Console.WriteLine("You are on Proxima Century, What would you like to do?");
            Console.WriteLine("1. buy goods");
            Console.WriteLine("2. trade goods");
            Console.WriteLine("3. travel back to earth");
            Console.WriteLine("4. travel to Mars");

            Console.Write("choice:   ");
            Choice = Console.ReadLine().ToLower();
            Console.Clear();

            switch (Choice)
            {
                case "1":
                case "buygoods":
                    {
                        Console.WriteLine(" you purchase more goods on Proxima century");
                        // give total value of items purchased

                        break;
                    }

                case "2":
                case "Tradegoods": // character load his spaceship and travel to planet Mars

                    {
                        Console.WriteLine("You are on proxima century and decide to trade the remaining items you brought from earth");
                        AssetonProxima();
                        Console.ReadLine();
                        break;
                    }

                case "3":
                case "travelearth": // Character return to earth after selling or trading goods
                    {
                        Console.WriteLine(" You traded all item you brought from earth, You load your with new items and get ready to return to earth");
                        TimeTravelEarttoProxima();
                        Console.ReadLine();
                        break;
                    }

                case "4":
                case "TravelMars": // character return to Mars 

                    {
                        Console.WriteLine(" you just arrived to  Mars what would like to do?");
                        Console.WriteLine("press enter to continue");
                        Console.ReadLine();
                        break;
                    }

                default:
                    {
                        Console.WriteLine(" I don't know what to do");
                        Console.WriteLine("press enter to try again ");
                        Console.ReadLine();
                        proximamenu();
                        break;

                    }


            }
        }

        public static void ReturnEarthMenu()  // WHAT USER CAN DO WITH ITEMS WHEN HE RETURNS ON THE PLANET  EARTH. 

        {
            string Choice;

            Console.WriteLine("You are back on planet earth, What would you like to do?");
            Console.WriteLine("1. sell all items you brought from space and calculate profit");
            Console.WriteLine("2.   second trip to Mars");
            Console.WriteLine("3.  second trip to proxima");
            Console.WriteLine("4. build your mansion after selling items");
            Console.WriteLine("5. buy more items");

            Console.Write("choice:   ");
            Choice = Console.ReadLine().ToLower();
            Console.Clear();

            switch (Choice)
            {
                case "1":
                case "sell": // character sell all good on earth.
                    {
                        Console.WriteLine(" you decide to sell what you brought back on earth");
                        ProfitofTrips();

                        break;
                    }

                case "2":
                case "travelMars2": // character visit Mars for the second time for more trade

                    {
                        Console.WriteLine("You purchase more goods and travel to Mars again");

                        Console.ReadLine();
                        break;
                    }

                case "3":
                case "travelProxima2": // Character visit Proxima for the second time for more trade
                    {
                        Console.WriteLine(" You purchase more good and travel to Proxima again");

                        Console.ReadLine();
                        break;
                    }

                case "4":
                case "Retire": // Character builds his Mansion and retire
                    {
                        Console.WriteLine(" You sell everything, calculate your profit, build your Mansion and retire");
                        ProfitofTrips();
                        Console.WriteLine("ENJOY A PEACEFULL AND WEALTHY  RETIREMENT IN YOUR MANSION  ALONG COTE D'AZUR ");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    }

                case "5":
                case "Buy more": // Character buy more goods on earth for trade
                    {
                        Console.WriteLine(" You buy more good on earth.");
                        Console.WriteLine("press enter to continue");
                        Console.ReadLine();
                        break;
                    }


                default:
                    {
                        Console.WriteLine(" I don't know what to do");
                        Console.WriteLine("press enter to try again ");
                        Console.ReadLine();

                        break;

                    }


            }
        }

        public static void AssetonEarth()

        {
            int water = 20; int clothes = 30; int computers = 200; int furs = 70; int Henessy = 80; int Asset = 1000;
            int sum = water + clothes + computers + furs + Henessy;
            int remainder = 1000 - sum;
            Console.WriteLine(($"the total value of good purchased is {sum} credit"));
            Console.WriteLine(($"you have a remaining balance of  {remainder} credit"));
            Console.WriteLine(($" your total asset is {Asset} credit"));
            EarthMenu();
            Console.ReadLine();
        }

        public static void AssetonMars() // trade on mars

        {
            int Uranium = 700; int Iridium = 290; int Rhodium = 6200; int Palladium = 170; int Platinum = 280;
            int sum = Uranium + Iridium + Rhodium + Palladium + Platinum;
            int AssetsMars = sum - 400 + 1000;
            Console.WriteLine($" you traded items brought from earth and receive Uranium, Iridium, Rhodium, Palladium and Platinum");
            Console.WriteLine(($"the total value of your assest on Mars  is {AssetsMars} credit"));
            ContinuGameOnMars();
            Console.ReadLine();
        }

        public static void startGame() // game start if user between 18-60

        {

            Console.WriteLine("Enter your age");
            Console.Write("Age: ");
            int age = int.Parse(Console.ReadLine());
            currentAge = age;
            if (age > 17 && age < 60)
            {
                Console.WriteLine("you can play the game");
                age++;
                GameTitle();

                //int.TryParse(Console.ReadLine(), out age);
            }



            else
            {
                Console.WriteLine("You must be at least 18 or less than 60 to play this game. ");
                Console.WriteLine("Enter your age again");

                startGame();
            }

        }

        public static void ContinuGameOnEarth() // this method continu oor ends game on Mars
        {
            Console.WriteLine($"age: {currentAge}");



            if (currentAge > 17 && currentAge < 60)
            {
                Console.WriteLine("continue with the game");
                currentAge++;
                checkassetMars();

                //int.TryParse(Console.ReadLine(), out age);
            }
            else
            {
                Console.WriteLine("END OF THE GAME");
                EndGame();

            }

        }

        public static void ContinuGameOnMars() // this method continue oor ends game on Mars
        {
            Console.WriteLine($"age: {currentAge}");



            if (currentAge > 17 && currentAge < 60)
            {
                Console.WriteLine("continue with the game");
                currentAge++;
                checkassetMars();

                //int.TryParse(Console.ReadLine(), out age);
            }
            else
            {
                Console.WriteLine("END OF THE GAME");
                EndGame();

            }

        }

        public static void continugameonProxima()  // this method continu or ends game on Proxima
        {

            Console.WriteLine($"age: {currentAge}");



            if (currentAge > 17 && currentAge < 60)
            {
                Console.WriteLine("continue with the game");
                currentAge++;
                checkassestProxima();

                //int.TryParse(Console.ReadLine(), out age);
            }
            else
            {
                Console.WriteLine("END OF THE GAME");
                EndGame();

            }

        }

        public static void TimeTravelEarttoProxima() // time of travel from planet earth to planet Proxima Century

        {
            Console.WriteLine($"age: {currentAge}");

            double Velocity = 109570;
            double Distance = 225000000;
            double Timeinsecond = Distance / Velocity / 60;
            double timeInYears = Timeinsecond / 365;
            currentAge += timeInYears;
            Console.WriteLine($"age: {currentAge}");

            Console.WriteLine(($"it took you {Timeinsecond} days to travel from proxima to Earth"));
            ReturnEarthMenu();
            Console.ReadLine();
        }

        public static void TimeTravelEarthtoMars() // time of travel from planet earth to planet Mars

        {
            Console.WriteLine($"age: {currentAge}");
            double Velocity = 109575000;
            double Distance = 225000000;

            double Timeinsecond = Distance / Velocity / 60;
            double timeInYears = Timeinsecond / 365;
            currentAge += timeInYears;
            Console.WriteLine($"age: {currentAge}");

            Console.WriteLine(($"it took you {Timeinsecond} days to travel to Mars century from Earth"));
            MarsMenu();
            Console.ReadLine();
        }
        public static void TimeTravelMarstoProxima()

        {
            Console.WriteLine($"age: {currentAge}");

            double Velocity = 1095750;
            double Distance = 22500000000;
            double Timeinsecond = Distance / Velocity / 60;
            double timeInYears = Timeinsecond / 365;
            currentAge += timeInYears;
            Console.WriteLine($"age: {currentAge}");

            Console.WriteLine(($"it took you {Timeinsecond} days to travel to proxima century from Mars"));
            proximamenu();
            Console.ReadLine();

        }

        public static void AssetonProxima()
        {
            int topaz = 1900; int emerald = 5354; int RedDiamond = 9200; int rubby = 4170; int granite = 5280;
            int Uranium = 700; int Iridium = 290; int Rhodium = 6200; int Palladium = 170; int Platinum = 280;
            int sum = topaz + emerald + RedDiamond + rubby + granite + Uranium + Iridium + Rhodium + Palladium + Platinum;
            int AssetsonProxima = sum;
            Console.WriteLine($" you traded the remaining items you brought from earth and receive ruby, topaz, emerald, reddiamond and granite ");
            Console.WriteLine(($"the total value of your assest on Proxima- is {AssetsonProxima} credit"));
            continugameonProxima();

            Console.ReadLine();

        }

        public static void checkassestProxima()
        {
            int AssetonProxima;
            Console.WriteLine("Enter Total value of your asset");
            Console.Write("asset: ");
            int.TryParse(Console.ReadLine(), out AssetonProxima);

            if (AssetonProxima > 0)
            {
                Console.WriteLine("continu with the game");
                AssetonProxima++;
                proximamenu();

                //int.TryParse(Console.ReadLine(), out age);
            }
            else
            {
                Console.WriteLine("YOU LOST ");
                EndGame();
                Console.ReadLine();
                Console.Clear();
            }

        }

        public static void checkassetMars()
        {
            int AssetonMars;
            Console.WriteLine("Enter Total value of your asset");
            Console.Write("asset: ");
            int.TryParse(Console.ReadLine(), out AssetonMars);

            if (AssetonMars > 0)
            {
                Console.WriteLine("continu with the game");
                AssetonMars++;
                MarsMenu();

                //int.TryParse(Console.ReadLine(), out age);
            }
            else
            {
                Console.WriteLine("YOU LOST ");
                EndGame();
                Console.ReadLine();
                Console.Clear();


            }

        }

        public static void checkassetEarth()
        {
            int AssetonEarth;
            Console.WriteLine("Enter Total value of your asset");
            Console.Write("asset: ");
            int.TryParse(Console.ReadLine(), out AssetonEarth);

            if (AssetonEarth > 0)
            {
                Console.WriteLine("continue with the game");
                AssetonEarth++;
                EarthMenu();

                //int.TryParse(Console.ReadLine(), out age);
            }
            else
            {
                Console.WriteLine("YOU LOST ");
                EndGame();
                Console.ReadLine();
                Console.Clear();


            }

        }

        public static void ProfitofTrips()
        {
            int topaz = 1900; int emerald = 5354; int RedDiamond = 9200; int rubby = 4170; int granite = 5280;
            int Uranium = 700; int Iridium = 290; int Rhodium = 6200; int Palladium = 170; int Platinum = 280;
            int sum = topaz + emerald + RedDiamond + rubby + granite + Uranium + Iridium + Rhodium + Palladium + Platinum;
            int AssetsonProxima = sum;
            int Profit = sum - 1000;
            Console.WriteLine($" on earth you sell everyting and have a total value of {sum} ");
            Console.WriteLine(($" you made a profit of {Profit} credit"));

            if (Profit > 0)
            {
                Console.WriteLine(" CONGRATULATIONS YOU WON");
                Console.WriteLine("ENJOY A PEACEFULL AND WEALTHY  RETIREMENT IN YOUR MANSION  ALONG COTE D'AZUR ");
                EndGame();
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("SORRY YOU LOST");
                EndGame();
                Console.ReadLine();
                Console.Clear();
            }

        }

        public static void EndGame()
        {
            Console.WriteLine(" Thank you for playing my SpaceGame");
            Console.ReadLine();
            Console.Clear();
            startGame();
        }
    }
    }

