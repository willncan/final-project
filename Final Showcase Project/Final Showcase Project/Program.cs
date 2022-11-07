using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

public class FinalShowcaseProject
{
    int P1Money = 1500;
    int P2Money = 1500;
    int P1Place = 0;
    int P2Place = 0;
    bool balticAvenueOwned = false;
    bool mediterraneanAvenueOwned = false;
    bool readingRailroadOwned = false;
    bool orientalAvenueOwned = false;
    bool vermontAvenueOwned = false;
    bool connecticutAvenueOwned = false;
    bool charlesPlaceOwned = false;
    bool electricCompanyOwned = false;
    bool statesAvenueOwned = false;
    bool virginiaAvenueOwned = false;
    bool pennsylvaniaRailroadOwned = false;
    bool jamesPlaceOwned = false;
    bool tennesseeAvenueOwned = false;
    bool newyorkAvenueOwned = false;
    bool kentuckyAvenueOwned = false;
    bool indianaAvenueOwned = false;
    bool illinoisAvenueOwned = false;
    bool B_and_ORailroadOwned = false;
    bool atlanticAvenueOwned = false;
    bool ventnorAvenueOwned = false;
    bool waterWorksOwned = false;
    bool marvinGardensOwned = false;
    bool pacificAvenueOwned = false;
    bool northCarolinaOwned = false;
    bool pennsylvaniaAvenueOwned = false;
    bool shortlineRailroadOwned = false;
    bool parkPlaceOwned = false;
    bool boardWalkOwned = false;
    //Project Requirements:
    //1. Must use at least three of the four variables(int, float, string, bool)✅
    //2. Must use user input to impact what happens in the program✅
    //3. Must use at least one if statement or a switch to determine what will happen in the program✅
    //4. Must use at least one while loop and at least one for loop✅
    //5. Must use at least one method(function)✅

    public static void Main(string[] args)
    {
        FinalShowcaseProject fp = new FinalShowcaseProject();

        fp.PlayerSelect();
        fp.PLayerMoves();
    }
    public void PlayerSelect()
    {
        bool select = true;
        while (select == true)
        {
            Console.WriteLine("This is a 2 Player game.");
            string P1Token = "";
            string P2Token = "";
            bool P1Select = true;
            bool P2Select = true;

            while (P1Select == true)
            {
                Console.WriteLine("What token does P1 want to be? Dog, Car, Hat, or Ship? (Use the same capital letters that I used.)");
                string P1Character = Console.ReadLine();
                if (P1Character == "Dog" || P1Character == "dog")
                {
                    P1Select = false;
                    Console.WriteLine();
                    Console.WriteLine("Player 1 is Dog.");
                    Console.WriteLine();
                    P1Token = "dog";
                    break;
                }
                else if (P1Character == "Car" || P1Character == "car")
                {
                    P1Select = false;
                    Console.WriteLine();
                    Console.WriteLine("Player 1 is Car.");
                    Console.WriteLine();
                    P1Token = "car";
                    break;
                }
                else if (P1Character == "Hat" || P1Character == "hat")
                {
                    P1Select = false;
                    Console.WriteLine();
                    Console.WriteLine("Player 1 is Hat.");
                    Console.WriteLine();
                    P1Token = "hat";
                    break;
                }
                else if (P1Character == "Ship" || P1Character == "ship")
                {
                    P1Select = false;
                    Console.WriteLine();
                    Console.WriteLine("Player 1 is Ship.");
                    Console.WriteLine();
                    P1Token = "ship";
                    break;
                }
                else
                {
                    Console.WriteLine("Not a character. Try again.");
                    P1Select = true;
                }
                P1Select = true;
            }
            while (P2Select == true) //Make it so P2 can't be same character as P1.
            {
                Console.WriteLine("What token does P2 want to be?");
                string P2Character = Console.ReadLine();
                if (P2Character == "Dog" || P2Character == "dog")
                {
                    P2Character = "dog";
                    if (P2Character == P1Token)
                    {
                        Console.WriteLine("Can't be same Character as Player 1. Pick again.");
                        P2Select = true;
                    }
                    else
                    {
                        P2Select = false;
                        Console.WriteLine();
                        Console.WriteLine("Player 2 is Dog.");
                        Console.WriteLine();
                        break;
                    }
                }
                else if (P2Character == "Car" || P2Character == "car")
                {
                    P2Character = "car";
                    if (P2Character == P1Token)
                    {
                        Console.WriteLine("Can't be same Character as Player 1. Pick again.");
                        P2Select = true;
                    }
                    else
                    {
                        P2Select = false;
                        Console.WriteLine();
                        Console.WriteLine("Player 2 is Car.");
                        Console.WriteLine();
                        break;
                    }
                }
                else if (P2Character == "Hat" || P2Character == "hat")
                {
                    P2Character = "hat";
                    if (P2Character == P1Token)
                    {
                        Console.WriteLine("Can't be same Character as Player 1. Pick again.");
                        P2Select = true;
                    }
                    else
                    {
                        P2Select = false;
                        Console.WriteLine();
                        Console.WriteLine("Player 2 is Hat.");
                        Console.WriteLine();
                        break;
                    }
                }
                else if (P2Character == "Ship" || P2Character == "ship")
                {
                    P2Character = "ship";
                    if (P2Character == P1Token)
                    {
                        Console.WriteLine("Can't be same Character as Player 1. Pick again.");
                        P2Select = true;
                    }
                    else
                    {
                        P2Select = false;
                        Console.WriteLine();
                        Console.WriteLine("Player 2 is Ship.");
                        Console.WriteLine();
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Not a character. Try again.");
                    P2Select = true;
                }
                P2Select = true;
            }
            break;
            select = true;
        }
        select = false;
    }
    public void PLayerMoves()
    {
        bool P1Turn = true;
        bool P2Turn = true;
        bool playingGame = true;
        while (playingGame == true)
        {
            P1Turn = true;
            while (P1Turn == true)//Add if in jail,
            {
                Console.WriteLine();
                Console.WriteLine("Player 1 has $" + P1Money + ". Type in 'Roll' to roll the Dice.");
                Console.WriteLine();
                string roll = Console.ReadLine();
                if (roll == "Roll" || roll == "roll")
                {
                    Random random = new Random();
                    int P1Roll = random.Next(2, 13);
                    P1Place = P1Roll + P1Place;
                    Console.WriteLine("You moved " + P1Roll + " spaces.");
                    if (P1Place > 20)
                    {
                        P1Place = P1Place - 20;
                        int P1Position = 0;
                        P1Position = P1Position + P1Place;
                        playingGame = true;
                    }//change numbers when you add more places.
                    if (P1Place == 0)
                        {
                            int P1Position = 0;
                            P1Position = P1Roll + P1Position;
                            Console.WriteLine("You are on Go. Collect $200 as you pass!");
                            P1Money = P1Money + 200;
                            Console.WriteLine("You have $" + P1Money + ".");
                            break;
                        }
                    if (P1Place == 1)
                        {
                            int P1Position = 0;
                            P1Position = P1Roll + P1Position;
                            Console.WriteLine("You are on Mediterranean Avenue.");
                            if (mediterraneanAvenueOwned == false)
                            {
                                Console.WriteLine("This property is unowned. Would you like to buy it for $60?");
                                string P1BuyMediterranean = Console.ReadLine();
                                if (P1BuyMediterranean == "yes" || P1BuyMediterranean == "Yes")
                                {
                                    mediterraneanAvenueOwned = true;
                                    P1Money = P1Money - 60;
                                    Console.WriteLine("You now own Mediterranean Avenue. Players have to pay $90 when they land on this. You have $" + P1Money + ".");
                                }
                                else if (P1BuyMediterranean == "no" || P1BuyMediterranean == "No")
                                {
                                    mediterraneanAvenueOwned = false;
                                }
                                else
                                {
                                    Console.WriteLine("You needed to say 'Yes' or 'No'. You are unfit to buy this property.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("This property is owned! You need to pay Player 2 $90!");
                                P1Money = P1Money - 90;
                                P2Money = P2Money + 90;
                                Console.WriteLine("You have $" + P1Money + ". Player 2 has $" + P2Money + ".");
                            }
                            break;
                        }
                    else if (P1Place == 2)
                    {
                        int P1Position = 0;
                        P1Position = P1Roll + P1Position;
                        Console.WriteLine("You are on Community Chest.");
                        Console.WriteLine("Picking Card...");
                        Thread.Sleep(1500);
                        int communityChestCard = random.Next(1, 15);
                        if (communityChestCard == 1)
                            {
                                Console.WriteLine("Advance to Go (Collect $200)");
                                P1Position = 0;
                                P1Money = P1Money + 200;
                                Console.WriteLine("You have $" + P1Money + ".");
                            }
                        else if (communityChestCard == 2)
                            {
                                Console.WriteLine("Bank error in your favor. Collect $200.");
                                P1Money = P1Money + 200;
                                Console.WriteLine("You have $" + P1Money + ".");
                            }
                        else if (communityChestCard == 3)
                            {
                                Console.WriteLine("Doctor's Fee. Pay $50.");
                                P1Money = P1Money - 50;
                                Console.WriteLine("You have $" + P1Money + ".");
                            }
                        else if (communityChestCard == 4)
                            {
                                Console.WriteLine("From sale of stock you get $50.");
                                P1Money = P1Money + 50;
                                Console.WriteLine("You have $" + P1Money + ".");
                            }
                        else if (communityChestCard == 5)
                        {
                            Console.WriteLine("Go to Jail. Go directly to jail, do not pass Go, do not collect $200. On your next turn, $50 will be taken from you and you will be out of jail.");
                            P1Position = 10;
                            P1Money = P1Money - 50;
                        }
                        else if (communityChestCard == 6)
                            {
                                Console.WriteLine("Holiday fund matures. Receive $100.");
                                P1Money = P1Money + 100;
                                Console.WriteLine("You have $" + P1Money + ".");
                            }
                        else if (communityChestCard == 7)
                            {
                                Console.WriteLine("Income tax refund. Collect $20.");
                                P1Money = P1Money + 20;
                                Console.WriteLine("You have $" + P1Money + ".");
                            }
                        else if (communityChestCard == 8)
                            {
                                Console.WriteLine("It is your birthday. Collect $10 from every player.");
                                P1Money = P1Money + 10;
                                P2Money = P2Money - 10;
                                Console.WriteLine("You have $" + P1Money + ". Player 2 has $" + P2Money + ".");
                            }
                        else if (communityChestCard == 9)
                            {
                                Console.WriteLine("Life insurance matures. Collect $100.");
                                P1Money = P1Money + 100;
                                Console.WriteLine("You have $" + P1Money + ".");
                            }
                        else if (communityChestCard == 10)
                            {
                                Console.WriteLine("Pay hospital fees of $100.");
                                P1Money = P1Money - 100;
                                Console.WriteLine("You have $" + P1Money + ".");
                            }
                        else if (communityChestCard == 11)
                            {
                                Console.WriteLine("Pay school fees of $50.");
                                P1Money = P1Money - 50;
                                Console.WriteLine("You have $" + P1Money + ".");
                            }
                        else if (communityChestCard == 12)
                            {
                                Console.WriteLine("Receive $25 consultancy fee.");
                                P1Money = P1Money + 25;
                                Console.WriteLine("You have $" + P1Money + ".");
                            }
                        else if (communityChestCard == 13)
                        {
                            Console.WriteLine("You have won second prize in a beauty contest. Collect $10.");
                            P1Money = P1Money + 10;
                            Console.WriteLine("You have $" + P1Money + ".");
                        }
                        else
                            {
                                Console.WriteLine("You inherit $100.");
                                P1Money = P1Money + 100;
                                Console.WriteLine("You have $" + P1Money + ".");
                            }
                        break;
                    }
                    else if (P1Place == 3)
                        {
                            int P1Position = 0;
                            P1Position = P1Roll + P1Position;
                            Console.WriteLine("You are on Baltic Avenue.");
                            if (balticAvenueOwned == false)
                            {
                                Console.WriteLine("This property is unowned. Would you like to buy it for $60?");
                                string P1BuyBaltic = Console.ReadLine();
                                if (P1BuyBaltic == "yes" || P1BuyBaltic == "Yes")
                                {
                                    balticAvenueOwned = true;
                                    P1Money = P1Money - 60;
                                    Console.WriteLine("You now own Baltic Avenue. Players have to pay $180 when they land on this. You have $" + P1Money + ".");
                                }
                                else if (P1BuyBaltic == "no" || P1BuyBaltic == "No")
                                {
                                    balticAvenueOwned = false;
                                }
                                else
                                {
                                    Console.WriteLine("You needed to say 'Yes' or 'No'. You are unfit to buy this property.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("This property is owned! You need to pay Player 2 $180!");
                                P1Money = P1Money - 180;
                                P2Money = P2Money + 180;
                                Console.WriteLine("You have $" + P1Money + ". Player 2 has $" + P2Money + ".");
                            }
                            break;
                        }
                    else if (P1Place == 4)
                        {
                            bool payIt = true;
                            while (payIt == true)
                            {
                                int P1Position = 0;
                                P1Position = P1Roll + P1Position;
                                int taxedMoney = P1Money / 10;
                                Console.WriteLine("You are on Income Tax. Would you like to pay $200, or would you like to pay 10% of your money. ($" + taxedMoney + ")");
                                string P1TaxAnswer = Console.ReadLine();
                                if (P1TaxAnswer == "$200")
                                {
                                    P1Money = P1Money - 200;
                                    Console.WriteLine("You have $" + P1Money + ".");
                                    break;
                                }
                                else if (P1TaxAnswer == "10%")
                                {
                                    P1Money = P1Money - taxedMoney;
                                    Console.WriteLine("You have $" + P1Money + ".");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("You need to say either '$200' or '10%'.");
                                    payIt = true;
                                }
                                payIt = true;
                            }
                            break;
                        }
                    else if (P1Place == 5)
                        {
                            int P1Position = 0;
                            P1Position = P1Roll + P1Position;
                            Console.WriteLine("You are on Reading Railroad.");
                            if (readingRailroadOwned == false)
                            {
                                Console.WriteLine("This property is unowned. Would you like to buy it for $200?");
                                string P1BuyReading = Console.ReadLine();
                                if (P1BuyReading == "yes" || P1BuyReading == "Yes")
                                {
                                    readingRailroadOwned = true;
                                    P1Money = P1Money - 200;
                                    Console.WriteLine("You now own Reading Railroad. Players have to pay $100 when they land on this. You have $" + P1Money + ".");
                                }
                                else if (P1BuyReading == "no" || P1BuyReading == "No")
                                {
                                    readingRailroadOwned = false;
                                }
                                else
                                {
                                    Console.WriteLine("You needed to say 'Yes' or 'No'. You are unfit to buy this property.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("This property is owned! You need to pay Player 2 $100!");
                                P1Money = P1Money - 100;
                                P2Money = P2Money + 100;
                                Console.WriteLine("You have $" + P1Money + ". Player 2 has $" + P2Money + ".");
                            }
                            break;
                        }
                    else if (P1Place == 6)
                    {
                        int P1Position = 0;
                        P1Position = P1Roll + P1Position;
                        Console.WriteLine("You are on Oriental Avenue.");
                        if (orientalAvenueOwned == false)
                        {
                            Console.WriteLine("This property is unowned. Would you like to buy it for $100?");
                            string P1BuyOriental = Console.ReadLine();
                            if (P1BuyOriental == "yes" || P1BuyOriental == "Yes")
                            {
                                orientalAvenueOwned = true;
                                P1Money = P1Money - 100;
                                Console.WriteLine("You now own Oriental Avenue. Players have to pay $270 when they land on this. You have $" + P1Money + ".");
                            }
                            else if (P1BuyOriental == "no" || P1BuyOriental == "No")
                            {
                                orientalAvenueOwned = false;
                            }
                            else
                            {
                                Console.WriteLine("You needed to say 'Yes' or 'No'. You are unfit to buy this property.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("This property is owned! You need to pay Player 2 $270!");
                            P1Money = P1Money - 270;
                            P2Money = P2Money + 270;
                            Console.WriteLine("You have $" + P1Money + ". Player 2 has $" + P2Money + ".");
                        }
                        break;
                    }
                    else if (P1Place == 7)
                    {
                        int P1Position = 0;
                        P1Position = P1Roll + P1Position;
                        Console.WriteLine("You are on Chance.");
                        Console.WriteLine("Picking Card...");
                        Thread.Sleep(1500);
                        int chanceCard = random.Next(1, 15);
                        if (chanceCard == 1)
                            {
                                Console.WriteLine("Advance to Boardwalk.");
                                P1Position = 39;
                            }
                        else if (chanceCard == 2)
                            {
                                Console.WriteLine("Advance to Go (Collect $200)");
                                P1Position = 0;
                                P1Money = P1Money + 200;
                                Console.WriteLine("You have $" + P1Money + ".");
                            }
                        else if (chanceCard == 3)
                        {
                            Console.WriteLine("Advance to Illinois Avenue. If you pass Go, collect $200.");
                            if (P1Position > 24)
                            {
                                Console.WriteLine("You passed Go! Collect $200.");
                                P1Money = P1Money + 200;
                                Console.WriteLine("You have $" + P1Money + ".");
                                P1Position = 24;
                            }
                            else
                            {
                                P1Position = 24;
                            }
                        }
                        else if (chanceCard == 4)
                        {
                            Console.WriteLine("Advance to St. Charles Place. If you pass Go, collect $200.");
                            if (P1Position > 11)
                            {
                                Console.WriteLine("You passed Go! Collect $200.");
                                P1Money = P1Money + 200;
                                Console.WriteLine("You have $" + P1Money + ".");
                                P1Position = 11;
                            }
                            else
                            {
                                P1Position = 11;
                            }
                        }
                        else if (chanceCard == 5)
                        {
                            Console.WriteLine("Advance to the nearest Railroad.");
                            if (P1Position > 35 && P1Position < 5)
                            {
                                P1Position = 5;
                                Console.WriteLine("You are on Reading Railroad.");
                            }
                            else if (P1Position > 5 && P1Position < 15)
                            {
                                P1Position = 15;
                                Console.WriteLine("You are on Pennsylvania Railroad.");
                            }
                            else if (P1Position > 15 && P1Position < 25)
                            {
                                P1Position = 25;
                                Console.WriteLine("You are on B&O Railroad.");
                            }
                            else if (P1Position > 25 && P1Position < 35)
                            {
                                P1Position = 35;
                                Console.WriteLine("You are on Short Line.");
                            }
                            else
                            {
                                P1Position = P1Position;
                            }

                        }
                        else if (chanceCard == 6)
                        {
                            Console.WriteLine("Advance to nearest Utility.");
                            if (P1Position < 12 && P1Position > 28)
                            {
                                P1Position = 12;
                                Console.WriteLine("You are on Electric Company.");
                            }
                            else if (P1Position < 28 && P1Position > 12)
                            {
                                P1Position = 28;
                                Console.WriteLine("You are on Waterworks.");
                            }
                            else
                            {
                                P1Position = P1Position;
                            }
                            P1Position = 10;
                        }
                        else if (chanceCard == 7)
                        {
                            Console.WriteLine("Bank pays you dividend of $50.");
                            P1Money = P1Money + 50;
                            Console.WriteLine("You have $" + P1Money + ".");
                        }
                        else if (chanceCard == 8)
                        {
                            Console.WriteLine("Go Back 3 Spaces.");
                            if (P1Position == 7)
                            {
                                P1Position = 4;
                                Console.WriteLine("You are on Income Tax.");
                            }
                            else if (P1Position == 22)
                            {
                                P1Position = 19;
                                Console.WriteLine("You are on New York Avenue.");
                            }
                            else if (P1Position == 36)
                            {
                                P1Position = 33;
                                Console.WriteLine("You are on Community Chest.");
                            }
                            else
                            {
                                P1Position = P1Position - 3;
                            }
                        }
                        else if (chanceCard == 9)
                        {
                            Console.WriteLine("Go to Jail. Go directly to jail, do not pass Go, do not collect $200. On your next turn, $50 will be taken from you and you will be out of jail.");
                            P1Position = 10;
                            P1Money = P1Money - 50;
                        }
                        else if (chanceCard == 10)
                        {
                            Console.WriteLine("Pay poor tax of $15.");
                            P1Money = P1Money - 15;
                            Console.WriteLine("You have $" + P1Money + ".");
                        }
                        else if (chanceCard == 11)
                        {
                            Console.WriteLine("Take a ride to Reading. If you pass Go, collect $200.");
                            P1Position = 5;
                            if (P1Position < 40 && P1Position > 5)
                            {
                                Console.WriteLine("You passed Go! Collect $200.");
                                P1Money = P1Money + 200;
                                Console.WriteLine("You have $" + P1Money + ".");
                            }
                            else
                            {
                                P1Position = P1Position;
                            }
                        }
                        else if (chanceCard == 12)
                        {
                            Console.WriteLine("You have been elected Chairman of the Board. Pay each player $50.");
                            P1Money = P1Money - 50;
                            P2Money = P2Money + 50;
                            Console.WriteLine("You have $" + P1Money + ". Player 2 has $" + P2Money + ".");
                        }
                        else if (chanceCard == 13)
                        {
                            Console.WriteLine("Your building and loan matures. Collect $150.");
                            P1Money = P1Money + 150;
                            Console.WriteLine("You have $" + P1Money + ".");
                        }
                        else
                        {
                            Console.WriteLine("You have won a crossword competition. Collect $100.");
                            P1Money = P1Money + 100;
                            Console.WriteLine("You have $" + P1Money + ".");
                        }
                        break;
                    }
                    else if (P1Place == 8)
                        {
                            int P1Position = 0;
                            P1Position = P1Roll + P1Position;
                            Console.WriteLine("You are on Vermont Avenue.");
                            if (vermontAvenueOwned == false)
                            {
                                Console.WriteLine("This property is unowned. Would you like to buy it for $100?");
                                string P1BuyVermont = Console.ReadLine();
                                if (P1BuyVermont == "yes" || P1BuyVermont == "Yes")
                                {
                                    vermontAvenueOwned = true;
                                    P1Money = P1Money - 100;
                                    Console.WriteLine("You now own Vermont Avenue. Players have to pay $270 when they land on this. You have $" + P1Money + ".");
                                }
                                else if (P1BuyVermont == "no" || P1BuyVermont == "No")
                                {
                                    vermontAvenueOwned = false;
                                }
                                else
                                {
                                    Console.WriteLine("You needed to say 'Yes' or 'No'. You are unfit to buy this property.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("This property is owned! You need to pay Player 2 $270!");
                                P1Money = P1Money - 270;
                                P2Money = P2Money + 270;
                                Console.WriteLine("You have $" + P1Money + ". Player 2 has $" + P2Money + ".");
                            }
                            break;
                        }
                    else if (P1Place == 9)
                    {
                        int P1Position = 0;
                        P1Position = P1Roll + P1Position;
                        Console.WriteLine("You are on Connecticut Avenue.");
                        if (connecticutAvenueOwned == false)
                        {
                            Console.WriteLine("This property is unowned. Would you like to buy it for $120?");
                            string P1BuyConnecticut = Console.ReadLine();
                            if (P1BuyConnecticut == "yes" || P1BuyConnecticut == "Yes")
                            {
                                connecticutAvenueOwned = true;
                                P1Money = P1Money - 120;
                                Console.WriteLine("You now own Connecticut Avenue. Players have to pay $300 when they land on this. You have $" + P1Money + ".");
                            }
                            else if (P1BuyConnecticut == "no" || P1BuyConnecticut == "No")
                            {
                                connecticutAvenueOwned = false;
                            }
                            else
                            {
                                Console.WriteLine("You needed to say 'Yes' or 'No'. You are unfit to buy this property.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("This property is owned! You need to pay Player 2 $300!");
                            P1Money = P1Money - 300;
                            P2Money = P2Money + 300;
                            Console.WriteLine("You have $" + P1Money + ". Player 2 has $" + P2Money + ".");
                        }
                        break;
                    }
                    else if (P1Place == 10)
                        {
                            int P1Position = 0;
                            P1Position = P1Roll + P1Position;
                            Console.WriteLine("You are visiting jail.");
                            break;
                        }
                    else if (P1Place == 11)
                    {
                        int P1Position = 0;
                        P1Position = P1Roll + P1Position;
                        Console.WriteLine("You are on St. Charles Place.");
                        if (charlesPlaceOwned == false)
                        {
                            Console.WriteLine("This property is unowned. Would you like to buy it for $140?");
                            string P1BuyCharles = Console.ReadLine();
                            if (P1BuyCharles == "yes" || P1BuyCharles == "Yes")
                            {
                                charlesPlaceOwned = true;
                                P1Money = P1Money - 140;
                                Console.WriteLine("You now own St. Charles Place. Players have to pay $450 when they land on this. You have $" + P1Money + ".");
                            }
                            else if (P1BuyCharles == "no" || P1BuyCharles == "No")
                            {
                                charlesPlaceOwned = false;
                            }
                            else
                            {
                                Console.WriteLine("You needed to say 'Yes' or 'No'. You are unfit to buy this property.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("This property is owned! You need to pay Player 2 $450!");
                            P1Money = P1Money - 450;
                            P2Money = P2Money + 450;
                            Console.WriteLine("You have $" + P1Money + ". Player 2 has $" + P2Money + ".");
                        }
                        break;
                    }
                    else if (P1Place == 12)
                    {
                        int P1Position = 0;
                        P1Position = P1Roll + P1Position;
                        Console.WriteLine("You are on Electric Company.");
                        if (electricCompanyOwned == false)
                        {
                            Console.WriteLine("This property is unowned. Would you like to buy it for $150?");
                            string P1BuyElectric = Console.ReadLine();
                            if (P1BuyElectric == "yes" || P1BuyElectric == "Yes")
                            {
                                electricCompanyOwned = true;
                                P1Money = P1Money - 150;

                                Console.WriteLine("You now own Electric Company. Players have to pay 4x whatever they rolled when they land on this. You have $" + P1Money + ".");
                            }
                            else if (P1BuyElectric == "no" || P1BuyElectric == "No")
                            {
                                electricCompanyOwned = false;
                            }
                            else
                            {
                                Console.WriteLine("You needed to say 'Yes' or 'No'. You are unfit to buy this property.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("This property is owned! You need to pay Player 2 4x what you rolled!");
                            int electricTax = 4 * P1Roll;
                            P1Money = P1Money - electricTax;
                            P2Money = P2Money + electricTax;
                            Console.WriteLine("You have $" + P1Money + ". Player 2 has $" + P2Money + ".");
                        }
                        break;
                    }
                    else if (P1Place == 13)
                    {
                        int P1Position = 0;
                        P1Position = P1Roll + P1Position;
                        Console.WriteLine("You are on States Avenue.");
                        if (statesAvenueOwned == false)
                        {
                            Console.WriteLine("This property is unowned. Would you like to buy it for $140?");
                            string P1BuyStates = Console.ReadLine();
                            if (P1BuyStates == "yes" || P1BuyStates == "Yes")
                            {
                                statesAvenueOwned = true;
                                P1Money = P1Money - 140;
                                Console.WriteLine("You now own States Avenue. Players have to pay $450 when they land on this. You have $" + P1Money + ".");
                            }
                            else if (P1BuyStates == "no" || P1BuyStates == "No")
                            {
                                statesAvenueOwned = false;
                            }
                            else
                            {
                                Console.WriteLine("You needed to say 'Yes' or 'No'. You are unfit to buy this property.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("This property is owned! You need to pay Player 2 $450!");
                            P1Money = P1Money - 450;
                            P2Money = P2Money + 450;
                            Console.WriteLine("You have $" + P1Money + ". Player 2 has $" + P2Money + ".");
                        }
                        break;
                    }
                    else if (P1Place == 14)
                    {
                        int P1Position = 0;
                        P1Position = P1Roll + P1Position;
                        Console.WriteLine("You are on Virginia Avenue.");
                        if (virginiaAvenueOwned == false)
                        {
                            Console.WriteLine("This property is unowned. Would you like to buy it for $160?");
                            string P1BuyVirginia = Console.ReadLine();
                            if (P1BuyVirginia == "yes" || P1BuyVirginia == "Yes")
                            {
                                virginiaAvenueOwned = true;
                                P1Money = P1Money - 160;
                                Console.WriteLine("You now own Virginia Avenue. Players have to pay $500 when they land on this. You have $" + P1Money + ".");
                            }
                            else if (P1BuyVirginia == "no" || P1BuyVirginia == "No")
                            {
                                virginiaAvenueOwned = false;
                            }
                            else
                            {
                                Console.WriteLine("You needed to say 'Yes' or 'No'. You are unfit to buy this property.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("This property is owned! You need to pay Player 2 $500!");
                            P1Money = P1Money - 500;
                            P2Money = P2Money + 500;
                            Console.WriteLine("You have $" + P1Money + ". Player 2 has $" + P2Money + ".");
                        }
                        break;
                    }
                    else if (P1Place == 15)
                    {
                        int P1Position = 0;
                        P1Position = P1Roll + P1Position;
                        Console.WriteLine("You are on Pennsylvania Railroad.");
                        if (pennsylvaniaRailroadOwned == false)
                        {
                            Console.WriteLine("This property is unowned. Would you like to buy it for $200?");
                            string P1BuyPennRailroad = Console.ReadLine();
                            if (P1BuyPennRailroad == "yes" || P1BuyPennRailroad == "Yes")
                            {
                                pennsylvaniaRailroadOwned = true;
                                P1Money = P1Money - 200;
                                Console.WriteLine("You now own Pennsylvania Railroad. Players have to pay $100 when they land on this. You have $" + P1Money + ".");
                            }
                            else if (P1BuyPennRailroad == "no" || P1BuyPennRailroad == "No")
                            {
                                pennsylvaniaRailroadOwned = false;
                            }
                            else
                            {
                                Console.WriteLine("You needed to say 'Yes' or 'No'. You are unfit to buy this property.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("This property is owned! You need to pay Player 2 $100!");
                            P1Money = P1Money - 100;
                            P2Money = P2Money + 100;
                            Console.WriteLine("You have $" + P1Money + ". Player 2 has $" + P2Money + ".");
                        }
                        break;
                    }
                    else if (P1Place == 16)
                    {
                        int P1Position = 0;
                        P1Position = P1Roll + P1Position;
                        Console.WriteLine("You are on St. James Place.");
                        if (jamesPlaceOwned == false)
                        {
                            Console.WriteLine("This property is unowned. Would you like to buy it for $180?");
                            string P1BuyJames = Console.ReadLine();
                            if (P1BuyJames == "yes" || P1BuyJames == "Yes")
                            {
                                jamesPlaceOwned = true;
                                P1Money = P1Money - 180;
                                Console.WriteLine("You now own St. James Place. Players have to pay $550 when they land on this. You have $" + P1Money + ".");
                            }
                            else if (P1BuyJames == "no" || P1BuyJames == "No")
                            {
                                jamesPlaceOwned = false;
                            }
                            else
                            {
                                Console.WriteLine("You needed to say 'Yes' or 'No'. You are unfit to buy this property.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("This property is owned! You need to pay Player 2 $550!");
                            P1Money = P1Money - 550;
                            P2Money = P2Money + 550;
                            Console.WriteLine("You have $" + P1Money + ". Player 2 has $" + P2Money + ".");
                        }
                        break;
                    }
                    else if (P1Place == 17)
                        {
                            int P1Position = 0;
                            P1Position = P1Roll + P1Position;
                            Console.WriteLine("You are on Community Chest.");
                            Console.WriteLine("Rolling Dice...");
                            Thread.Sleep(1500);
                            int communityChestCard = random.Next(1, 17);
                            if (communityChestCard == 1)
                            {
                                Console.WriteLine("Advance to Go (Collect $200)");
                                P1Position = 0;
                                P1Money = P1Money + 200;
                                Console.WriteLine("You have $" + P1Money + ".");
                            }
                            else if (communityChestCard == 2)
                            {
                                Console.WriteLine("Bank error in your favor. Collect $200.");
                                P1Money = P1Money + 200;
                                Console.WriteLine("You have $" + P1Money + ".");
                            }
                            else if (communityChestCard == 3)
                            {
                                Console.WriteLine("Doctor's Fee. Pay $50.");
                                P1Money = P1Money - 50;
                                Console.WriteLine("You have $" + P1Money + ".");
                            }
                            else if (communityChestCard == 4)
                            {
                                Console.WriteLine("From sale of stock you get $50.");
                                P1Money = P1Money + 50;
                                Console.WriteLine("You have $" + P1Money + ".");
                            }
                            else if (communityChestCard == 5)
                            {
                                Console.WriteLine("Get Out of Jail Free. (You can only have 1 'Get Out of Jail Free' card at a time, so if you have one you won't get another.)");
                                int P1getOutOfJailCards = 1;
                            }
                            else if (communityChestCard == 6)
                            {
                                Console.WriteLine("Go to Jail. Go directly to jail, do not pass Go, do not collect $200.");
                            }
                            else if (communityChestCard == 7)
                            {
                                Console.WriteLine("Holiday fund matures. Receive $100.");
                                P1Money = P1Money + 100;
                                Console.WriteLine("You have $" + P1Money + ".");
                            }
                            else if (communityChestCard == 8)
                            {
                                Console.WriteLine("Income tax refund. Collect $20.");
                                P1Money = P1Money + 100;
                                Console.WriteLine("You have $" + P1Money + ".");
                            }
                            else if (communityChestCard == 9)
                            {
                                Console.WriteLine("It is your birthday. Collect $10 from every player.");
                                P1Money = P1Money + 10;
                                P2Money = P2Money - 10;
                                Console.WriteLine("You have $" + P1Money + ". Player 2 has $" + P2Money + ".");
                            }
                            else if (communityChestCard == 10)
                            {
                                Console.WriteLine("Life insurance matures. Collect $100.");
                                P1Money = P1Money + 100;
                                Console.WriteLine("You have $" + P1Money + ".");
                            }
                            else if (communityChestCard == 11)
                            {
                                Console.WriteLine("Pay hospital fees of $100.");
                                P1Money = P1Money - 100;
                                Console.WriteLine("You have $" + P1Money + ".");
                            }
                            else if (communityChestCard == 12)
                            {
                                Console.WriteLine("Pay school fees of $50.");
                                P1Money = P1Money - 50;
                                Console.WriteLine("You have $" + P1Money + ".");
                            }
                            else if (communityChestCard == 13)
                            {
                                Console.WriteLine("Receive $25 consultancy fee.");
                                P1Money = P1Money + 25;
                                Console.WriteLine("You have $" + P1Money + ".");
                            }
                            else if (communityChestCard == 14)
                            {
                                Console.WriteLine("You are assessed for street repair. $40 per house. $115 per hotel.");
                                int P1HouseTax = 40;
                                int P1HotelTax = 115;
                                P1Money = P1Money - P1HouseTax - P1HotelTax;
                                Console.WriteLine("You have $" + P1Money + ".");
                            }
                            else if (communityChestCard == 15)
                            {
                                Console.WriteLine("You have won second prize in a beauty contest. Collect $10.");
                                P1Money = P1Money + 10;
                                Console.WriteLine("You have $" + P1Money + ".");
                            }
                            else
                            {
                                Console.WriteLine("You inherit $100.");
                                P1Money = P1Money + 100;
                                Console.WriteLine("You have $" + P1Money + ".");
                            }
                            break;
                        }
                    else if (P1Place == 18)
                    {
                        int P1Position = 0;
                        P1Position = P1Roll + P1Position;
                        Console.WriteLine("You are on Tennessee Avenue.");
                        if (tennesseeAvenueOwned == false)
                        {
                            Console.WriteLine("This property is unowned. Would you like to buy it for $180?");
                            string P1BuyTennessee = Console.ReadLine();
                            if (P1BuyTennessee == "yes" || P1BuyTennessee == "Yes")
                            {
                                tennesseeAvenueOwned = true;
                                P1Money = P1Money - 180;
                                Console.WriteLine("You now own Tennessee Avenue. Players have to pay $550 when they land on this. You have $" + P1Money + ".");
                            }
                            else if (P1BuyTennessee == "no" || P1BuyTennessee == "No")
                            {
                                tennesseeAvenueOwned = false;
                            }
                            else
                            {
                                Console.WriteLine("You needed to say 'Yes' or 'No'. You are unfit to buy this property.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("This property is owned! You need to pay Player 2 $550!");
                            P1Money = P1Money - 550;
                            P2Money = P2Money + 550;
                            Console.WriteLine("You have $" + P1Money + ". Player 2 has $" + P2Money + ".");
                        }
                        break;
                    }
                    else if (P1Place == 19)
                    {
                        int P1Position = 0;
                        P1Position = P1Roll + P1Position;
                        Console.WriteLine("You are on New York Avenue.");
                        if (newyorkAvenueOwned == false)
                        {
                            Console.WriteLine("This property is unowned. Would you like to buy it for $200?");
                            string P1BuyNewYork = Console.ReadLine();
                            if (P1BuyNewYork == "yes" || P1BuyNewYork == "Yes")
                            {
                                newyorkAvenueOwned = true;
                                P1Money = P1Money - 200;
                                Console.WriteLine("You now own New York Avenue. Players have to pay $600 when they land on this. You have $" + P1Money + ".");
                            }
                            else if (P1BuyNewYork == "no" || P1BuyNewYork == "No")
                            {
                                newyorkAvenueOwned = false;
                            }
                            else
                            {
                                Console.WriteLine("You needed to say 'Yes' or 'No'. You are unfit to buy this property.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("This property is owned! You need to pay Player 2 $600!");
                            P1Money = P1Money - 600;
                            P2Money = P2Money + 600;
                            Console.WriteLine("You have $" + P1Money + ". Player 2 has $" + P2Money + ".");
                        }
                        break;
                    }
                    else if (P1Place == 20)
                    {
                        int P1Position = 0;
                        P1Position = P1Roll + P1Position;
                        Console.WriteLine("You are on Free Parking. Nothing happens here.");
                        break;
                    }
                    else if (P1Place == 21)
                    {
                        int P1Position = 0;
                        P1Position = P1Roll + P1Position;
                        Console.WriteLine("You are on Kentucky Avenue.");
                        if (kentuckyAvenueOwned == false)
                        {
                            Console.WriteLine("This property is unowned. Would you like to buy it for $220?");
                            string P1BuyKentucky = Console.ReadLine();
                            if (P1BuyKentucky == "yes" || P1BuyKentucky == "Yes")
                            {
                                kentuckyAvenueOwned = true;
                                P1Money = P1Money - 220;
                                Console.WriteLine("You now own Kentucky Avenue. Players have to pay $700 when they land on this. You have $" + P1Money + ".");
                            }
                            else if (P1BuyKentucky == "no" || P1BuyKentucky == "No")
                            {
                                kentuckyAvenueOwned = false;
                            }
                            else
                            {
                                Console.WriteLine("You needed to say 'Yes' or 'No'. You are unfit to buy this property.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("This property is owned! You need to pay Player 2 $700!");
                            P1Money = P1Money - 700;
                            P2Money = P2Money + 700;
                            Console.WriteLine("You have $" + P1Money + ". Player 2 has $" + P2Money + ".");
                        }
                        break;
                    }
                    else if (P1Place == 22)
                    {
                        int P1Position = 0;
                        P1Position = P1Roll + P1Position;
                        Console.WriteLine("You are on Chance.");
                        Console.WriteLine("Picking Card...");
                        Thread.Sleep(1500);
                        int chanceCard = random.Next(1, 15);
                        if (chanceCard == 1)
                        {
                            Console.WriteLine("Advance to Boardwalk.");
                            P1Position = 39;
                        }
                        else if (chanceCard == 2)
                        {
                            Console.WriteLine("Advance to Go (Collect $200)");
                            P1Position = 0;
                            P1Money = P1Money + 200;
                            Console.WriteLine("You have $" + P1Money + ".");
                        }
                        else if (chanceCard == 3)
                        {
                            Console.WriteLine("Advance to Illinois Avenue. If you pass Go, collect $200.");
                            if (P1Position > 24)
                            {
                                Console.WriteLine("You passed Go! Collect $200.");
                                P1Money = P1Money + 200;
                                Console.WriteLine("You have $" + P1Money + ".");
                                P1Position = 24;
                            }
                            else
                            {
                                P1Position = 24;
                            }
                        }
                        else if (chanceCard == 4)
                        {
                            Console.WriteLine("Advance to St. Charles Place. If you pass Go, collect $200.");
                            if (P1Position > 11)
                            {
                                Console.WriteLine("You passed Go! Collect $200.");
                                P1Money = P1Money + 200;
                                Console.WriteLine("You have $" + P1Money + ".");
                                P1Position = 11;
                            }
                            else
                            {
                                P1Position = 11;
                            }
                        }
                        else if (chanceCard == 5)
                        {
                            Console.WriteLine("Advance to the nearest Railroad.");
                            if (P1Position > 35 && P1Position < 5)
                            {
                                P1Position = 5;
                                Console.WriteLine("You are on Reading Railroad.");
                            }
                            else if (P1Position > 5 && P1Position < 15)
                            {
                                P1Position = 15;
                                Console.WriteLine("You are on Pennsylvania Railroad.");
                            }
                            else if (P1Position > 15 && P1Position < 25)
                            {
                                P1Position = 25;
                                Console.WriteLine("You are on B&O Railroad.");
                            }
                            else if (P1Position > 25 && P1Position < 35)
                            {
                                P1Position = 35;
                                Console.WriteLine("You are on Short Line.");
                            }
                            else
                            {
                                P1Position = P1Position;
                            }

                        }
                        else if (chanceCard == 6)
                        {
                            Console.WriteLine("Advance to nearest Utility.");
                            if (P1Position < 12 && P1Position > 28)
                            {
                                P1Position = 12;
                                Console.WriteLine("You are on Electric Company.");
                            }
                            else if (P1Position < 28 && P1Position > 12)
                            {
                                P1Position = 28;
                                Console.WriteLine("You are on Waterworks.");
                            }
                            else
                            {
                                P1Position = P1Position;
                            }
                            P1Position = 10;
                        }
                        else if (chanceCard == 7)
                        {
                            Console.WriteLine("Bank pays you dividend of $50.");
                            P1Money = P1Money + 50;
                            Console.WriteLine("You have $" + P1Money + ".");
                        }
                        else if (chanceCard == 8)
                        {
                            Console.WriteLine("Go Back 3 Spaces.");
                            if (P1Position == 7)
                            {
                                P1Position = 4;
                                Console.WriteLine("You are on Income Tax.");
                            }
                            else if (P1Position == 22)
                            {
                                P1Position = 19;
                                Console.WriteLine("You are on New York Avenue.");
                            }
                            else if (P1Position == 36)
                            {
                                P1Position = 33;
                                Console.WriteLine("You are on Community Chest.");
                            }
                            else
                            {
                                P1Position = P1Position - 3;
                            }
                        }
                        else if (chanceCard == 9)
                        {
                            Console.WriteLine("Go to Jail. Go directly to jail, do not pass Go, do not collect $200. On your next turn, $50 will be taken from you and you will be out of jail.");
                            P1Position = 10;
                            P1Money = P1Money - 50;
                        }
                        else if (chanceCard == 10)
                        {
                            Console.WriteLine("Pay poor tax of $15.");
                            P1Money = P1Money - 15;
                            Console.WriteLine("You have $" + P1Money + ".");
                        }
                        else if (chanceCard == 11)
                        {
                            Console.WriteLine("Take a ride to Reading. If you pass Go, collect $200.");
                            P1Position = 5;
                            if (P1Position < 40 && P1Position > 5)
                            {
                                Console.WriteLine("You passed Go! Collect $200.");
                                P1Money = P1Money + 200;
                                Console.WriteLine("You have $" + P1Money + ".");
                            }
                            else
                            {
                                P1Position = P1Position;
                            }
                        }
                        else if (chanceCard == 12)
                        {
                            Console.WriteLine("You have been elected Chairman of the Board. Pay each player $50.");
                            P1Money = P1Money - 50;
                            P2Money = P2Money + 50;
                            Console.WriteLine("You have $" + P1Money + ". Player 2 has $" + P2Money + ".");
                        }
                        else if (chanceCard == 13)
                        {
                            Console.WriteLine("Your building and loan matures. Collect $150.");
                            P1Money = P1Money + 150;
                            Console.WriteLine("You have $" + P1Money + ".");
                        }
                        else
                        {
                            Console.WriteLine("You have won a crossword competition. Collect $100.");
                            P1Money = P1Money + 100;
                            Console.WriteLine("You have $" + P1Money + ".");
                        }
                        break;
                    }
                    else if (P1Place == 23)
                    {
                        int P1Position = 0;
                        P1Position = P1Roll + P1Position;
                        Console.WriteLine("You are on Indiana Avenue.");
                        if (indianaAvenueOwned == false)
                        {
                            Console.WriteLine("This property is unowned. Would you like to buy it for $220?");
                            string P1BuyIndiana = Console.ReadLine();
                            if (P1BuyIndiana == "yes" || P1BuyIndiana == "Yes")
                            {
                                indianaAvenueOwned = true;
                                P1Money = P1Money - 220;
                                Console.WriteLine("You now own Indiana Avenue. Players have to pay $700 when they land on this. You have $" + P1Money + ".");
                            }
                            else if (P1BuyIndiana == "no" || P1BuyIndiana == "No")
                            {
                                indianaAvenueOwned = false;
                            }
                            else
                            {
                                Console.WriteLine("You needed to say 'Yes' or 'No'. You are unfit to buy this property.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("This property is owned! You need to pay Player 2 $700!");
                            P1Money = P1Money - 700;
                            P2Money = P2Money + 700;
                            Console.WriteLine("You have $" + P1Money + ". Player 2 has $" + P2Money + ".");
                        }
                        break;
                    }
                    else if (P1Place == 24)
                    {
                        int P1Position = 0;
                        P1Position = P1Roll + P1Position;
                        Console.WriteLine("You are on Illinois Avenue.");
                        if (illinoisAvenueOwned == false)
                        {
                            Console.WriteLine("This property is unowned. Would you like to buy it for $240?");
                            string P1BuyIllinois = Console.ReadLine();
                            if (P1BuyIllinois == "yes" || P1BuyIllinois == "Yes")
                            {
                                illinoisAvenueOwned = true;
                                P1Money = P1Money - 240;
                                Console.WriteLine("You now own Illinois Avenue. Players have to pay $750 when they land on this. You have $" + P1Money + ".");
                            }
                            else if (P1BuyIllinois == "no" || P1BuyIllinois == "No")
                            {
                                illinoisAvenueOwned = false;
                            }
                            else
                            {
                                Console.WriteLine("You needed to say 'Yes' or 'No'. You are unfit to buy this property.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("This property is owned! You need to pay Player 2 $750!");
                            P1Money = P1Money - 750;
                            P2Money = P2Money + 750;
                            Console.WriteLine("You have $" + P1Money + ". Player 2 has $" + P2Money + ".");
                        }
                        break;
                    }
                    else if (P1Place == 25)
                    {
                        int P1Position = 0;
                        P1Position = P1Roll + P1Position;
                        Console.WriteLine("You are on B&O Railroad.");
                        if (B_and_ORailroadOwned == false)
                        {
                            Console.WriteLine("This property is unowned. Would you like to buy it for $200?");
                            string P1BuyB_and_O = Console.ReadLine();
                            if (P1BuyB_and_O == "yes" || P1BuyB_and_O == "Yes")
                            {
                                B_and_ORailroadOwned = true;
                                P1Money = P1Money - 200;
                                Console.WriteLine("You now own B&O Railroad. Players have to pay $100 when they land on this. You have $" + P1Money + ".");
                            }
                            else if (P1BuyB_and_O == "no" || P1BuyB_and_O == "No")
                            {
                                B_and_ORailroadOwned = false;
                            }
                            else
                            {
                                Console.WriteLine("You needed to say 'Yes' or 'No'. You are unfit to buy this property.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("This property is owned! You need to pay Player 2 $100!");
                            P1Money = P1Money - 100;
                            P2Money = P2Money + 100;
                            Console.WriteLine("You have $" + P1Money + ". Player 2 has $" + P2Money + ".");
                        }
                        break;
                    }
                    else if (P1Place == 26)
                    {
                        int P1Position = 0;
                        P1Position = P1Roll + P1Position;
                        Console.WriteLine("You are on Atlantic Avenue.");
                        if (atlanticAvenueOwned == false)
                        {
                            Console.WriteLine("This property is unowned. Would you like to buy it for $260?");
                            string P1BuyAtlantic = Console.ReadLine();
                            if (P1BuyAtlantic == "yes" || P1BuyAtlantic == "Yes")
                            {
                                atlanticAvenueOwned = true;
                                P1Money = P1Money - 260;
                                Console.WriteLine("You now own Atlantic Avenue. Players have to pay $800 when they land on this. You have $" + P1Money + ".");
                            }
                            else if (P1BuyAtlantic == "no" || P1BuyAtlantic == "No")
                            {
                                atlanticAvenueOwned = false;
                            }
                            else
                            {
                                Console.WriteLine("You needed to say 'Yes' or 'No'. You are unfit to buy this property.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("This property is owned! You need to pay Player 2 $800!");
                            P1Money = P1Money - 800;
                            P2Money = P2Money + 800;
                            Console.WriteLine("You have $" + P1Money + ". Player 2 has $" + P2Money + ".");
                        }
                        break;
                    }
                    else if (P1Place == 27)
                    {
                        int P1Position = 0;
                        P1Position = P1Roll + P1Position;
                        Console.WriteLine("You are on Ventnor Avenue.");
                        if (ventnorAvenueOwned == false)
                        {
                            Console.WriteLine("This property is unowned. Would you like to buy it for $260?");
                            string P1BuyVentnor = Console.ReadLine();
                            if (P1BuyVentnor == "yes" || P1BuyVentnor == "Yes")
                            {
                                ventnorAvenueOwned = true;
                                P1Money = P1Money - 260;
                                Console.WriteLine("You now own Ventnor Avenue. Players have to pay $800 when they land on this. You have $" + P1Money + ".");
                            }
                            else if (P1BuyVentnor == "no" || P1BuyVentnor == "No")
                            {
                                ventnorAvenueOwned = false;
                            }
                            else
                            {
                                Console.WriteLine("You needed to say 'Yes' or 'No'. You are unfit to buy this property.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("This property is owned! You need to pay Player 2 $800!");
                            P1Money = P1Money - 800;
                            P2Money = P2Money + 800;
                            Console.WriteLine("You have $" + P1Money + ". Player 2 has $" + P2Money + ".");
                        }
                        break;
                    }
                    else if (P1Place == 28)
                    {
                        int P1Position = 0;
                        P1Position = P1Roll + P1Position;
                        Console.WriteLine("You are on Waterworks.");
                        if (waterWorksOwned == false)
                        {
                            Console.WriteLine("This property is unowned. Would you like to buy it for $150?");
                            string P1BuyWaterWorks = Console.ReadLine();
                            if (P1BuyWaterWorks == "yes" || P1BuyWaterWorks == "Yes")
                            {
                                waterWorksOwned = true;
                                P1Money = P1Money - 150;

                                Console.WriteLine("You now own Waterworks. Players have to pay 4x whatever they rolled when they land on this. You have $" + P1Money + ".");
                            }
                            else if (P1BuyWaterWorks == "no" || P1BuyWaterWorks == "No")
                            {
                                waterWorksOwned = false;
                            }
                            else
                            {
                                Console.WriteLine("You needed to say 'Yes' or 'No'. You are unfit to buy this property.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("This property is owned! You need to pay Player 2 4x what you rolled!");
                            int waterTax = 4 * P1Roll;
                            P1Money = P1Money - waterTax;
                            P2Money = P2Money + waterTax;
                            Console.WriteLine("You have $" + P1Money + ". Player 2 has $" + P2Money + ".");
                        }
                        break;
                    }
                    else if (P1Place == 29)
                    {
                        int P1Position = 0;
                        P1Position = P1Roll + P1Position;
                        Console.WriteLine("You are on Marvin Gardens.");
                        if (marvinGardensOwned == false)
                        {
                            Console.WriteLine("This property is unowned. Would you like to buy it for $280?");
                            string P1BuyMarvin = Console.ReadLine();
                            if (P1BuyMarvin == "yes" || P1BuyMarvin == "Yes")
                            {
                                marvinGardensOwned = true;
                                P1Money = P1Money - 280;
                                Console.WriteLine("You now own Marvin Gardens. Players have to pay $850 when they land on this. You have $" + P1Money + ".");
                            }
                            else if (P1BuyMarvin == "no" || P1BuyMarvin == "No")
                            {
                                marvinGardensOwned = false;
                            }
                            else
                            {
                                Console.WriteLine("You needed to say 'Yes' or 'No'. You are unfit to buy this property.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("This property is owned! You need to pay Player 2 $850!");
                            P1Money = P1Money - 850;
                            P2Money = P2Money + 850;
                            Console.WriteLine("You have $" + P1Money + ". Player 2 has $" + P2Money + ".");
                        }
                        break;
                    }
                    else if (P1Place == 30)
                    {
                        int P1Position = 0;
                        P1Position = P1Roll + P1Position;
                        Console.WriteLine("You landed on Go to Jail! Do not pass Go, do not collect Go money, just go to jail.");
                        P1Position = 10;
                        Console.WriteLine("$50 will be taken from you and you will be released on your next turn.");
                        P1Money = P1Money - 50;
                    }
                    else if (P1Place == 31)
                    {
                        int P1Position = 0;
                        P1Position = P1Roll + P1Position;
                        Console.WriteLine("You are on Pacific Avenue.");
                        if (pacificAvenueOwned == false)
                        {
                            Console.WriteLine("This property is unowned. Would you like to buy it for $300?");
                            string P1BuyPacific = Console.ReadLine();
                            if (P1BuyPacific == "yes" || P1BuyPacific == "Yes")
                            {
                                pacificAvenueOwned = true;
                                P1Money = P1Money - 300;
                                Console.WriteLine("You now own Pacific Avenue. Players have to pay $900 when they land on this. You have $" + P1Money + ".");
                            }
                            else if (P1BuyPacific == "no" || P1BuyPacific == "No")
                            {
                                pacificAvenueOwned = false;
                            }
                            else
                            {
                                Console.WriteLine("You needed to say 'Yes' or 'No'. You are unfit to buy this property.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("This property is owned! You need to pay Player 2 $900!");
                            P1Money = P1Money - 900;
                            P2Money = P2Money + 900;
                            Console.WriteLine("You have $" + P1Money + ". Player 2 has $" + P2Money + ".");
                        }
                        break;
                    }
                    else if (P1Place == 32)
                    {
                        int P1Position = 0;
                        P1Position = P1Roll + P1Position;
                        Console.WriteLine("You are on North Carolina Avenue.");
                        if (northCarolinaOwned == false)
                        {
                            Console.WriteLine("This property is unowned. Would you like to buy it for $300?");
                            string P1BuyCarolina = Console.ReadLine();
                            if (P1BuyCarolina == "yes" || P1BuyCarolina == "Yes")
                            {
                                northCarolinaOwned = true;
                                P1Money = P1Money - 300;
                                Console.WriteLine("You now own North Carolina Avenue. Players have to pay $900 when they land on this. You have $" + P1Money + ".");
                            }
                            else if (P1BuyCarolina == "no" || P1BuyCarolina == "No")
                            {
                                northCarolinaOwned = false;
                            }
                            else
                            {
                                Console.WriteLine("You needed to say 'Yes' or 'No'. You are unfit to buy this property.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("This property is owned! You need to pay Player 2 $900!");
                            P1Money = P1Money - 900;
                            P2Money = P2Money + 900;
                            Console.WriteLine("You have $" + P1Money + ". Player 2 has $" + P2Money + ".");
                        }
                        break;
                    }
                    else if (P1Place == 33)
                    {
                        int P1Position = 0;
                        P1Position = P1Roll + P1Position;
                        Console.WriteLine("You are on Community Chest.");
                        Console.WriteLine("Picking Card...");
                        Thread.Sleep(1500);
                        int communityChestCard = random.Next(1, 15);
                        if (communityChestCard == 1)
                        {
                            Console.WriteLine("Advance to Go (Collect $200)");
                            P1Position = 0;
                            P1Money = P1Money + 200;
                            Console.WriteLine("You have $" + P1Money + ".");
                        }
                        else if (communityChestCard == 2)
                        {
                            Console.WriteLine("Bank error in your favor. Collect $200.");
                            P1Money = P1Money + 200;
                            Console.WriteLine("You have $" + P1Money + ".");
                        }
                        else if (communityChestCard == 3)
                        {
                            Console.WriteLine("Doctor's Fee. Pay $50.");
                            P1Money = P1Money - 50;
                            Console.WriteLine("You have $" + P1Money + ".");
                        }
                        else if (communityChestCard == 4)
                        {
                            Console.WriteLine("From sale of stock you get $50.");
                            P1Money = P1Money + 50;
                            Console.WriteLine("You have $" + P1Money + ".");
                        }
                        else if (communityChestCard == 5)
                        {
                            Console.WriteLine("Go to Jail. Go directly to jail, do not pass Go, do not collect $200. On your next turn, $50 will be taken from you and you will be out of jail.");
                            P1Position = 10;
                            P1Money = P1Money - 50;
                        }
                        else if (communityChestCard == 6)
                        {
                            Console.WriteLine("Holiday fund matures. Receive $100.");
                            P1Money = P1Money + 100;
                            Console.WriteLine("You have $" + P1Money + ".");
                        }
                        else if (communityChestCard == 7)
                        {
                            Console.WriteLine("Income tax refund. Collect $20.");
                            P1Money = P1Money + 20;
                            Console.WriteLine("You have $" + P1Money + ".");
                        }
                        else if (communityChestCard == 8)
                        {
                            Console.WriteLine("It is your birthday. Collect $10 from every player.");
                            P1Money = P1Money + 10;
                            P2Money = P2Money - 10;
                            Console.WriteLine("You have $" + P1Money + ". Player 2 has $" + P2Money + ".");
                        }
                        else if (communityChestCard == 9)
                        {
                            Console.WriteLine("Life insurance matures. Collect $100.");
                            P1Money = P1Money + 100;
                            Console.WriteLine("You have $" + P1Money + ".");
                        }
                        else if (communityChestCard == 10)
                        {
                            Console.WriteLine("Pay hospital fees of $100.");
                            P1Money = P1Money - 100;
                            Console.WriteLine("You have $" + P1Money + ".");
                        }
                        else if (communityChestCard == 11)
                        {
                            Console.WriteLine("Pay school fees of $50.");
                            P1Money = P1Money - 50;
                            Console.WriteLine("You have $" + P1Money + ".");
                        }
                        else if (communityChestCard == 12)
                        {
                            Console.WriteLine("Receive $25 consultancy fee.");
                            P1Money = P1Money + 25;
                            Console.WriteLine("You have $" + P1Money + ".");
                        }
                        else if (communityChestCard == 13)
                        {
                            Console.WriteLine("You have won second prize in a beauty contest. Collect $10.");
                            P1Money = P1Money + 10;
                            Console.WriteLine("You have $" + P1Money + ".");
                        }
                        else
                        {
                            Console.WriteLine("You inherit $100.");
                            P1Money = P1Money + 100;
                            Console.WriteLine("You have $" + P1Money + ".");
                        }
                        break;
                    }
                    else if (P1Place == 34)
                    {
                        int P1Position = 0;
                        P1Position = P1Roll + P1Position;
                        Console.WriteLine("You are on Pennsylvania Avenue.");
                        if (pennsylvaniaAvenueOwned == false)
                        {
                            Console.WriteLine("This property is unowned. Would you like to buy it for $320?");
                            string P1BuyPennAvenue = Console.ReadLine();
                            if (P1BuyPennAvenue == "yes" || P1BuyPennAvenue == "Yes")
                            {
                                pennsylvaniaAvenueOwned = true;
                                P1Money = P1Money - 320;
                                Console.WriteLine("You now own Pennsylvania Avenue. Players have to pay $950 when they land on this. You have $" + P1Money + ".");
                            }
                            else if (P1BuyPennAvenue == "no" || P1BuyPennAvenue == "No")
                            {
                                pennsylvaniaAvenueOwned = false;
                            }
                            else
                            {
                                Console.WriteLine("You needed to say 'Yes' or 'No'. You are unfit to buy this property.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("This property is owned! You need to pay Player 2 $950!");
                            P1Money = P1Money - 950;
                            P2Money = P2Money + 950;
                            Console.WriteLine("You have $" + P1Money + ". Player 2 has $" + P2Money + ".");
                        }
                        break;
                    }
                    else if (P1Place == 35)
                    {
                        int P1Position = 0;
                        P1Position = P1Roll + P1Position;
                        Console.WriteLine("You are on ShortLine Railroad.");
                        if (shortlineRailroadOwned == false)
                        {
                            Console.WriteLine("This property is unowned. Would you like to buy it for $200?");
                            string P1BuyShortLine = Console.ReadLine();
                            if (P1BuyShortLine == "yes" || P1BuyShortLine == "Yes")
                            {
                                shortlineRailroadOwned = true;
                                P1Money = P1Money - 200;
                                Console.WriteLine("You now own ShortLine Railroad. Players have to pay $100 when they land on this. You have $" + P1Money + ".");
                            }
                            else if (P1BuyShortLine == "no" || P1BuyShortLine == "No")
                            {
                                shortlineRailroadOwned = false;
                            }
                            else
                            {
                                Console.WriteLine("You needed to say 'Yes' or 'No'. You are unfit to buy this property.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("This property is owned! You need to pay Player 2 $100!");
                            P1Money = P1Money - 100;
                            P2Money = P2Money + 100;
                            Console.WriteLine("You have $" + P1Money + ". Player 2 has $" + P2Money + ".");
                        }
                        break;
                    }
                    else if (P1Place == 36)
                    {
                        int P1Position = 0;
                        P1Position = P1Roll + P1Position;
                        Console.WriteLine("You are on Chance.");
                        Console.WriteLine("Picking Card...");
                        Thread.Sleep(1500);
                        int chanceCard = random.Next(1, 15);
                        if (chanceCard == 1)
                        {
                            Console.WriteLine("Advance to Boardwalk.");
                            P1Position = 39;
                        }
                        else if (chanceCard == 2)
                        {
                            Console.WriteLine("Advance to Go (Collect $200)");
                            P1Position = 0;
                            P1Money = P1Money + 200;
                            Console.WriteLine("You have $" + P1Money + ".");
                        }
                        else if (chanceCard == 3)
                        {
                            Console.WriteLine("Advance to Illinois Avenue. If you pass Go, collect $200.");
                            if (P1Position > 24)
                            {
                                Console.WriteLine("You passed Go! Collect $200.");
                                P1Money = P1Money + 200;
                                Console.WriteLine("You have $" + P1Money + ".");
                                P1Position = 24;
                            }
                            else
                            {
                                P1Position = 24;
                            }
                        }
                        else if (chanceCard == 4)
                        {
                            Console.WriteLine("Advance to St. Charles Place. If you pass Go, collect $200.");
                            if (P1Position > 11)
                            {
                                Console.WriteLine("You passed Go! Collect $200.");
                                P1Money = P1Money + 200;
                                Console.WriteLine("You have $" + P1Money + ".");
                                P1Position = 11;
                            }
                            else
                            {
                                P1Position = 11;
                            }
                        }
                        else if (chanceCard == 5)
                        {
                            Console.WriteLine("Advance to the nearest Railroad.");
                            if (P1Position > 35 && P1Position < 5)
                            {
                                P1Position = 5;
                                Console.WriteLine("You are on Reading Railroad.");
                            }
                            else if (P1Position > 5 && P1Position < 15)
                            {
                                P1Position = 15;
                                Console.WriteLine("You are on Pennsylvania Railroad.");
                            }
                            else if (P1Position > 15 && P1Position < 25)
                            {
                                P1Position = 25;
                                Console.WriteLine("You are on B&O Railroad.");
                            }
                            else if (P1Position > 25 && P1Position < 35)
                            {
                                P1Position = 35;
                                Console.WriteLine("You are on Short Line.");
                            }
                            else
                            {
                                P1Position = P1Position;
                            }

                        }
                        else if (chanceCard == 6)
                        {
                            Console.WriteLine("Advance to nearest Utility.");
                            if (P1Position < 12 && P1Position > 28)
                            {
                                P1Position = 12;
                                Console.WriteLine("You are on Electric Company.");
                            }
                            else if (P1Position < 28 && P1Position > 12)
                            {
                                P1Position = 28;
                                Console.WriteLine("You are on Waterworks.");
                            }
                            else
                            {
                                P1Position = P1Position;
                            }
                            P1Position = 10;
                        }
                        else if (chanceCard == 7)
                        {
                            Console.WriteLine("Bank pays you dividend of $50.");
                            P1Money = P1Money + 50;
                            Console.WriteLine("You have $" + P1Money + ".");
                        }
                        else if (chanceCard == 8)
                        {
                            Console.WriteLine("Go Back 3 Spaces.");
                            if (P1Position == 7)
                            {
                                P1Position = 4;
                                Console.WriteLine("You are on Income Tax.");
                            }
                            else if (P1Position == 22)
                            {
                                P1Position = 19;
                                Console.WriteLine("You are on New York Avenue.");
                            }
                            else if (P1Position == 36)
                            {
                                P1Position = 33;
                                Console.WriteLine("You are on Community Chest.");
                            }
                            else
                            {
                                P1Position = P1Position - 3;
                            }
                        }
                        else if (chanceCard == 9)
                        {
                            Console.WriteLine("Go to Jail. Go directly to jail, do not pass Go, do not collect $200. On your next turn, $50 will be taken from you and you will be out of jail.");
                            P1Position = 10;
                            P1Money = P1Money - 50;
                        }
                        else if (chanceCard == 10)
                        {
                            Console.WriteLine("Pay poor tax of $15.");
                            P1Money = P1Money - 15;
                            Console.WriteLine("You have $" + P1Money + ".");
                        }
                        else if (chanceCard == 11)
                        {
                            Console.WriteLine("Take a ride to Reading. If you pass Go, collect $200.");
                            P1Position = 5;
                            if (P1Position < 40 && P1Position > 5)
                            {
                                Console.WriteLine("You passed Go! Collect $200.");
                                P1Money = P1Money + 200;
                                Console.WriteLine("You have $" + P1Money + ".");
                            }
                            else
                            {
                                P1Position = P1Position;
                            }
                        }
                        else if (chanceCard == 12)
                        {
                            Console.WriteLine("You have been elected Chairman of the Board. Pay each player $50.");
                            P1Money = P1Money - 50;
                            P2Money = P2Money + 50;
                            Console.WriteLine("You have $" + P1Money + ". Player 2 has $" + P2Money + ".");
                        }
                        else if (chanceCard == 13)
                        {
                            Console.WriteLine("Your building and loan matures. Collect $150.");
                            P1Money = P1Money + 150;
                            Console.WriteLine("You have $" + P1Money + ".");
                        }
                        else
                        {
                            Console.WriteLine("You have won a crossword competition. Collect $100.");
                            P1Money = P1Money + 100;
                            Console.WriteLine("You have $" + P1Money + ".");
                        }
                        break;
                    }
                    else if (P1Place == 37)
                    {
                        int P1Position = 0;
                        P1Position = P1Roll + P1Position;
                        Console.WriteLine("You are on Park Place.");
                        if (parkPlaceOwned == false)
                        {
                            Console.WriteLine("This property is unowned. Would you like to buy it for $350?");
                            string P1BuyParkPlace = Console.ReadLine();
                            if (P1BuyParkPlace == "yes" || P1BuyParkPlace == "Yes")
                            {
                                parkPlaceOwned = true;
                                P1Money = P1Money - 350;
                                Console.WriteLine("You now own Park Place. Players have to pay $1000 when they land on this. You have $" + P1Money + ".");
                            }
                            else if (P1BuyParkPlace == "no" || P1BuyParkPlace == "No")
                            {
                                parkPlaceOwned = false;
                            }
                            else
                            {
                                Console.WriteLine("You needed to say 'Yes' or 'No'. You are unfit to buy this property.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("This property is owned! You need to pay Player 2 $1000!");
                            P1Money = P1Money - 1000;
                            P2Money = P2Money + 1000;
                            Console.WriteLine("You have $" + P1Money + ". Player 2 has $" + P2Money + ".");
                        }
                        break;
                    }
                    else if (P1Place == 38)
                    {
                        int P1Position = 0;
                        P1Position = P1Roll + P1Position;
                        Console.WriteLine("You are on Luxury Tax. Pay $75.");
                        P1Money = P1Money - 75;
                        Console.WriteLine("You have $" + P1Money + ".");
                    }
                    else if (P1Place == 39)
                    {
                        int P1Position = 0;
                        P1Position = P1Roll + P1Position;
                        Console.WriteLine("You are on Board Walk.");
                        if (boardWalkOwned == false)
                        {
                            Console.WriteLine("This property is unowned. Would you like to buy it for $350?");
                            string P1BuyBoardWalk = Console.ReadLine();
                            if (P1BuyBoardWalk == "yes" || P1BuyBoardWalk == "Yes")
                            {
                                boardWalkOwned = true;
                                P1Money = P1Money - 350;
                                Console.WriteLine("You now own Board Walk. Players have to pay $1000 when they land on this. You have $" + P1Money + ".");
                            }
                            else if (P1BuyBoardWalk == "no" || P1BuyBoardWalk == "No")
                            {
                                boardWalkOwned = false;
                            }
                            else
                            {
                                Console.WriteLine("You needed to say 'Yes' or 'No'. You are unfit to buy this property.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("This property is owned! You need to pay Player 2 $1000!");
                            P1Money = P1Money - 1000;
                            P2Money = P2Money + 1000;
                            Console.WriteLine("You have $" + P1Money + ". Player 2 has $" + P2Money + ".");
                        }
                        break;
                    }
                    else
                        {
                            P1Turn = true;
                        }
                }
                else
                    {
                        Console.WriteLine("You typed it in wrong.");
                        P1Turn = true;
                    }
                if (P1Money == 0)
                    {
                        playingGame = false;
                        Console.WriteLine("Player 2 Wins!");
                        break;
                    }
                playingGame = true;
            }
            P2Turn = true;
            while (P2Turn == true)
            {
                Console.WriteLine();
                Console.WriteLine("Player 2 has $" + P2Money + ". Type in 'Roll' to roll the Dice.");
                Console.WriteLine();
                string roll = Console.ReadLine();
                if (roll == "Roll" || roll == "roll")
                {
                    Random random = new Random();
                    int P2Roll = random.Next(2, 13);
                    P2Place = P2Roll + P2Place;
                    Console.WriteLine("You moved " + P2Roll + " spaces.");
                    if (P2Place > 20)
                    {
                        P2Place = P2Place - 20;
                        int P2Position = 0;
                        P2Position = P2Position + P2Place;
                        playingGame = true;
                    }//change numbers when adding more places.
                    if (P2Place == 0)
                        {
                            int P2Position = 0;
                            P2Position = P2Roll + P2Position;
                            Console.WriteLine("You are on Go. Collect $200 as you pass!");
                            P2Money = P2Money + 200;
                            Console.WriteLine("You have $" + P2Money + ".");
                            break;
                        }
                    if (P2Place == 1)
                        {
                            int P2Position = 0;
                            P2Position = P2Roll + P2Position;
                            Console.WriteLine("You are on Meditteranean Avenue.");
                            if (mediterraneanAvenueOwned == false)
                            {
                                Console.WriteLine("This property is unowned. Would you like to buy it for $60?");
                                string P2BuyMediterranean = Console.ReadLine();
                                if (P2BuyMediterranean == "yes" || P2BuyMediterranean == "Yes")
                                {
                                    mediterraneanAvenueOwned = true;
                                    P2Money = P2Money - 60;
                                    Console.WriteLine("You now own Mediterranean Avenue. Players have to pay $90 when they land on this. You have $" + P2Money + ".");
                                }
                                else if (P2BuyMediterranean == "no" || P2BuyMediterranean == "No")
                                {
                                    mediterraneanAvenueOwned = false;
                                }
                                else
                                {
                                    Console.WriteLine("You needed to say 'Yes' or 'No'. You are unfit to buy this property.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("This property is owned! You need to pay Player 1 $90!");
                                P1Money = P1Money + 90;
                                P2Money = P2Money - 90;
                                Console.WriteLine("You have $" + P2Money + ". Player 1 has $" + P1Money + ".");
                            }
                            break;
                        }
                    else if (P2Place == 2)
                        {
                            int P2Position = 0;
                            P2Position = P2Roll + P2Position;
                            Console.WriteLine("You are on Community Chest.");
                            Console.WriteLine("Rolling Dice...");
                            Thread.Sleep(1500);
                            int communityChestCard = random.Next(1, 17);
                            if (communityChestCard == 1)
                            {
                                Console.WriteLine("Advance to Go (Collect $200)");
                                P2Position = 0;
                                P2Money = P2Money + 200;
                                Console.WriteLine("You have $" + P2Money + ".");
                            }
                            else if (communityChestCard == 2)
                            {
                                Console.WriteLine("Bank error in your favor. Collect $200.");
                                P2Money = P2Money + 200;
                                Console.WriteLine("You have $" + P2Money + ".");
                            }
                            else if (communityChestCard == 3)
                            {
                                Console.WriteLine("Doctor's Fee. Pay $50.");
                                P2Money = P2Money - 50;
                                Console.WriteLine("You have $" + P2Money + ".");
                            }
                            else if (communityChestCard == 4)
                            {
                                Console.WriteLine("From sale of stock you get $50.");
                                P2Money = P2Money + 50;
                                Console.WriteLine("You have $" + P2Money + ".");
                            }
                            else if (communityChestCard == 5)
                            {
                                Console.WriteLine("Get Out of Jail Free. (You can only have 1 'Get Out of Jail Free' card at a time, so if you have one you won't get another.)");
                                int getOutOfJailCards = 1;
                            }
                            else if (communityChestCard == 6)
                            {
                                Console.WriteLine("Go to Jail. Go directly to jail, do not pass Go, do not collect $200.");
                            }
                            else if (communityChestCard == 7)
                            {
                                Console.WriteLine("Holiday fund matures. Receive $100.");
                                P2Money = P2Money + 100;
                                Console.WriteLine("You have $" + P2Money + ".");
                            }
                            else if (communityChestCard == 8)
                            {
                                Console.WriteLine("Income tax refund. Collect $20.");
                                P2Money = P2Money + 20;
                                Console.WriteLine("You have $" + P2Money + ".");
                            }
                            else if (communityChestCard == 9)
                            {
                                Console.WriteLine("It is your birthday. Collect $10 from every player.");
                                P2Money = P2Money + 10;
                                P1Money = P1Money - 10;
                                Console.WriteLine("You have $" + P2Money + ". Player 1 has $" + P1Money + ".");
                            }
                            else if (communityChestCard == 10)
                            {
                                Console.WriteLine("Life insurance matures. Collect $100.");
                                P2Money = P2Money + 100;
                                Console.WriteLine("You have $" + P2Money + ".");
                            }
                            else if (communityChestCard == 11)
                            {
                                Console.WriteLine("Pay hospital fees of $100.");
                                P2Money = P2Money - 100;
                                Console.WriteLine("You have $" + P2Money + ".");
                            }
                            else if (communityChestCard == 12)
                            {
                                Console.WriteLine("Pay school fees of $50.");
                                P2Money = P2Money - 50;
                                Console.WriteLine("You have $" + P2Money + ".");
                            }
                            else if (communityChestCard == 13)
                            {
                                Console.WriteLine("Receive $25 consultancy fee.");
                                P2Money = P2Money + 25;
                                Console.WriteLine("You have $" + P2Money + ".");
                            }
                            else if (communityChestCard == 14)
                            {
                                Console.WriteLine("You are assessed for street repair. $40 per house. $115 per hotel.");
                                int P2HouseTax = 40;
                                int P2HotelTax = 115;
                                P2Money = P2Money - P2HouseTax - P2HotelTax;
                                Console.WriteLine("You have $" + P2Money + ".");
                            }
                            else if (communityChestCard == 15)
                            {
                                Console.WriteLine("You have won second prize in a beauty contest. Collect $10.");
                                P2Money = P2Money + 10;
                                Console.WriteLine("You have $" + P2Money + ".");
                            }
                            else
                            {
                                Console.WriteLine("You inherit $100.");
                                P2Money = P2Money + 100;
                                Console.WriteLine("You have $" + P2Money + ".");
                            }
                            break;
                        }
                    else if (P2Place == 3)
                        {
                            int P2Position = 0;
                            P2Position = P2Roll + P2Position;
                            Console.WriteLine("You are on Baltic Avenue.");
                            if (balticAvenueOwned == false)
                            {
                                Console.WriteLine("This property is unowned. Would you like to buy it for $60?");
                                string P2BuyBaltic = Console.ReadLine();
                                if (P2BuyBaltic == "yes" || P2BuyBaltic == "Yes")
                                {
                                    balticAvenueOwned = true;
                                    P2Money = P2Money - 60;
                                    Console.WriteLine("You now own Baltic Avenue. Players have to pay $180 when they land on this. You have $" + P2Money + ".");
                                }
                                else if (P2BuyBaltic == "no" || P2BuyBaltic == "No")
                                {
                                    balticAvenueOwned = false;
                                }
                                else
                                {
                                    Console.WriteLine("You needed to say 'Yes' or 'No'. You are unfit to buy this property.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("This property is owned! You need to pay Player 1 $180!");
                                P2Money = P2Money - 180;
                                P1Money = P1Money + 180;
                                Console.WriteLine("You have $" + P2Money + ". Player 1 has $" + P1Money + ".");
                            }
                            break;
                        }
                    else if (P2Place == 4)
                        {
                            bool payIt = true;
                            while (payIt == true)
                            {
                                int P2Position = 0;
                                P2Position = P2Roll + P2Position;
                                int taxedMoney = P2Money / 10;
                                Console.WriteLine("You are on Income Tax. Would you like to pay $200, or would you like to pay 10% of your money. ($" + taxedMoney + ")");
                                string P2TaxAnswer = Console.ReadLine();
                                if (P2TaxAnswer == "$200")
                                {
                                    P2Money = P2Money - 200;
                                    Console.WriteLine("You have $" + P2Money + ".");
                                    break;
                                }
                                else if (P2TaxAnswer == "10%")
                                {
                                    P2Money = P2Money - taxedMoney;
                                    Console.WriteLine("You have $" + P2Money + ".");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("You need to say either '$200' or '10%'.");
                                    payIt = true;
                                }
                                payIt = true;
                            }
                            break;
                        }
                    else if (P2Place == 5)
                        {
                            int P2Position = 0;
                            P2Position = P2Roll + P2Position;
                            Console.WriteLine("You are on Reading Railroad.");
                            if (readingRailroadOwned == false)
                            {
                                Console.WriteLine("This property is unowned. Would you like to buy it for $200?");
                                string P2BuyReading = Console.ReadLine();
                                if (P2BuyReading == "yes" || P2BuyReading == "Yes")
                                {
                                    readingRailroadOwned = true;
                                    P2Money = P2Money - 200;
                                    Console.WriteLine("You now own Reading Railroad. Players have to pay $100 when they land on this. You have $" + P2Money + ".");
                                }
                                else if (P2BuyReading == "no" || P2BuyReading == "No")
                                {
                                    readingRailroadOwned = false;
                                }
                                else
                                {
                                    Console.WriteLine("You needed to say 'Yes' or 'No'. You are unfit to buy this property.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("This property is owned! You need to pay Player 1 $100!");
                                P1Money = P1Money + 100;
                                P2Money = P2Money - 100;
                                Console.WriteLine("You have $" + P2Money + ". Player 1 has $" + P1Money + ".");
                            }
                            break;
                        }
                    else if (P2Place == 6)
                        {
                            int P2Position = 0;
                            P2Position = P2Roll + P2Position;
                            Console.WriteLine("You are on Oriental Avenue.");
                            if (orientalAvenueOwned == false)
                            {
                                Console.WriteLine("This property is unowned. Would you like to buy it for $100?");
                                string P2BuyOriental = Console.ReadLine();
                                if (P2BuyOriental == "yes" || P2BuyOriental == "Yes")
                                {
                                    orientalAvenueOwned = true;
                                    P2Money = P2Money - 100;
                                    Console.WriteLine("You now own Oriental Avenue. Players have to pay $270 when they land on this. You have $" + P2Money + ".");
                                }
                                else if (P2BuyOriental == "no" || P2BuyOriental == "No")
                                {
                                    orientalAvenueOwned = false;
                                }
                                else
                                {
                                    Console.WriteLine("You needed to say 'Yes' or 'No'. You are unfit to buy this property.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("This property is owned! You need to pay Player 1 $270!");
                                P1Money = P1Money + 270;
                                P2Money = P2Money - 270;
                                Console.WriteLine("You have $" + P2Money + ". Player 1 has $" + P1Money + ".");
                            }
                            break;
                        }
                    else if (P2Place == 7)
                    {
                        int P2Position = 0;
                        P2Position = P2Roll + P2Position;
                        Console.WriteLine("You are on Chance.");
                        Console.WriteLine("Picking Card...");
                        Thread.Sleep(1500);
                        int chanceCard = random.Next(1, 16);
                        if (chanceCard == 1)
                        {
                            Console.WriteLine("Advance to Boardwalk.");
                            P2Position = 39;
                        }
                        else if (chanceCard == 2)
                        {
                            Console.WriteLine("Advance to Go (Collect $200)");
                            P2Position = 0;
                            P2Money = P2Money + 200;
                            Console.WriteLine("You have $" + P2Money + ".");
                        }
                        else if (chanceCard == 3)
                        {
                            Console.WriteLine("Advance to Illinois Avenue. If you pass Go, collect $200.");
                            if (P2Position > 24)
                            {
                                Console.WriteLine("You passed Go! Collect $200.");
                                P2Money = P2Money + 200;
                                Console.WriteLine("You have $" + P2Money + ".");
                                P2Position = 24;
                            }
                            else
                            {
                                P2Position = 24;
                            }
                        }
                        else if (chanceCard == 4)
                        {
                            Console.WriteLine("Advance to St. Charles Place. If you pass Go, collect $200.");
                            if (P2Position > 11)
                            {
                                Console.WriteLine("You passed Go! Collect $200.");
                                P2Money = P2Money + 200;
                                Console.WriteLine("You have $" + P2Money + ".");
                                P2Position = 11;
                            }
                            else
                            {
                                P2Position = 11;
                            }
                        }
                        else if (chanceCard == 5)
                        {
                            Console.WriteLine("Advance to the nearest Railroad.");
                            if (P2Position > 35 && P2Position < 5)
                            {
                                P2Position = 5;
                                Console.WriteLine("You are on Reading Railroad.");
                            }
                            else if (P2Position > 5 && P2Position < 15)
                            {
                                P2Position = 15;
                                Console.WriteLine("You are on Pennsylvania Railroad.");
                            }
                            else if (P2Position > 15 && P2Position < 25)
                            {
                                P2Position = 25;
                                Console.WriteLine("You are on B&O Railroad.");
                            }
                            else if (P2Position > 25 && P2Position < 35)
                            {
                                P2Position = 35;
                                Console.WriteLine("You are on Short Line.");
                            }
                            else
                            {
                                P2Position = P2Position;
                            }
                        }
                        else if (chanceCard == 6)
                        {
                            Console.WriteLine("Advance to nearest Utility.");
                            if (P2Position < 12 && P2Position > 28)
                            {
                                P2Position = 12;
                                Console.WriteLine("You are on Electric Company.");
                            }
                            else if (P2Position < 28 && P2Position > 12)
                            {
                                P2Position = 28;
                                Console.WriteLine("You are on Waterworks.");
                            }
                            else
                            {
                                P2Position = P2Position;
                            }
                            P2Position = 10;
                        }
                        else if (chanceCard == 7)
                        {
                            Console.WriteLine("Bank pays you dividend of $50.");
                            P2Money = P2Money + 50;
                            Console.WriteLine("You have $" + P2Money + ".");
                        }
                        else if (chanceCard == 8)
                        {
                            Console.WriteLine("Go Back 3 Spaces.");
                            if (P2Position == 7)
                            {
                                P2Position = 4;
                                Console.WriteLine("You are on Income Tax.");
                            }
                            else if (P2Position == 22)
                            {
                                P2Position = 19;
                                Console.WriteLine("You are on New York Avenue.");
                            }
                            else if (P2Position == 36)
                            {
                                P2Position = 33;
                                Console.WriteLine("You are on Community Chest.");
                            }
                            else
                            {
                                P2Position = P2Position - 3;
                            }
                        }
                        else if (chanceCard == 9)
                        {
                            Console.WriteLine("Go to Jail. Go directly to jail, do not pass Go, do not collect $200. On your next turn, $50 will be taken from you and you will be out of jail.");
                            P2Position = 10;
                            P2Money = P2Money - 50;
                        }
                        else if (chanceCard == 10)
                        {
                            Console.WriteLine("Pay poor tax of $15.");
                            P2Money = P2Money - 15;
                            Console.WriteLine("You have $" + P2Money + ".");
                        }
                        else if (chanceCard == 11)
                        {
                            Console.WriteLine("Take a ride to Reading. If you pass Go, collect $200.");
                            P2Position = 5;
                            if (P2Position < 40 && P2Position > 5)
                            {
                                Console.WriteLine("You passed Go! Collect $200.");
                                P2Money = P2Money + 200;
                                Console.WriteLine("You have $" + P2Money + ".");
                            }
                            else
                            {
                                P2Position = P2Position;
                            }
                        }
                        else if (chanceCard == 12)
                        {
                            Console.WriteLine("You have been elected Chairman of the Board. Pay each player $50.");
                            P1Money = P1Money + 50;
                            P2Money = P2Money - 50;
                            Console.WriteLine("You have $" + P2Money + ". Player 1 has $" + P1Money + ".");
                        }
                        else if (chanceCard == 13)
                        {
                            Console.WriteLine("Your building and loan matures. Collect $150.");
                            P2Money = P2Money + 150;
                            Console.WriteLine("You have $" + P2Money + ".");
                        }
                        else
                        {
                            Console.WriteLine("You have won a crossword competition. Collect $100.");
                            P2Money = P2Money + 100;
                            Console.WriteLine("You have $" + P2Money + ".");
                        }
                        break;
                    }
                    else if (P2Place == 8)
                    {
                        int P2Position = 0;
                        P2Position = P2Roll + P2Position;
                        Console.WriteLine("You are on Vermont Avenue.");
                        if (vermontAvenueOwned == false)
                        {
                            Console.WriteLine("This property is unowned. Would you like to buy it for $100?");
                            string P2BuyVermont = Console.ReadLine();
                            if (P2BuyVermont == "yes" || P2BuyVermont == "Yes")
                            {
                                vermontAvenueOwned = true;
                                P2Money = P2Money - 100;
                                Console.WriteLine("You now own Vermont Avenue. Players have to pay $270 when they land on this. You have $" + P2Money + ".");
                            }
                            else if (P2BuyVermont == "no" || P2BuyVermont == "No")
                            {
                                vermontAvenueOwned = false;
                            }
                            else
                            {
                                Console.WriteLine("You needed to say 'Yes' or 'No'. You are unfit to buy this property.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("This property is owned! You need to pay Player 1 $270!");
                            P1Money = P1Money + 270;
                            P2Money = P2Money - 270;
                            Console.WriteLine("You have $" + P2Money + ". Player 1 has $" + P1Money + ".");
                        }
                        break;
                    }
                    else if (P2Place == 9)
                    {
                        int P2Position = 0;
                        P2Position = P2Roll + P2Position;
                        Console.WriteLine("You are on Connecticut Avenue.");
                        if (connecticutAvenueOwned == false)
                        {
                            Console.WriteLine("This property is unowned. Would you like to buy it for $120?");
                            string P2BuyConnecticut = Console.ReadLine();
                            if (P2BuyConnecticut == "yes" || P2BuyConnecticut == "Yes")
                            {
                                connecticutAvenueOwned = true;
                                P2Money = P2Money - 120;
                                Console.WriteLine("You now own Connecticut Avenue. Players have to pay $300 when they land on this. You have $" + P2Money + ".");
                            }
                            else if (P2BuyConnecticut == "no" || P2BuyConnecticut == "No")
                            {
                                connecticutAvenueOwned = false;
                            }
                            else
                            {
                                Console.WriteLine("You needed to say 'Yes' or 'No'. You are unfit to buy this property.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("This property is owned! You need to pay Player 1 $300!");
                            P1Money = P1Money + 300;
                            P2Money = P2Money - 300;
                            Console.WriteLine("You have $" + P2Money + ". Player 1 has $" + P1Money + ".");
                        }
                        break;
                    }
                    else if (P2Place == 10)
                    {
                        int P2Position = 0;
                        P2Position = P2Roll + P2Position;
                        Console.WriteLine("You are visiting jail.");
                        break;
                    }
                    else if (P2Place == 11)
                    {
                        int P2Position = 0;
                        P2Position = P2Roll + P2Position;
                        Console.WriteLine("You are on St. Charles Place.");
                        if (charlesPlaceOwned == false)
                        {
                            Console.WriteLine("This property is unowned. Would you like to buy it for $140?");
                            string P2BuyCharles = Console.ReadLine();
                            if (P2BuyCharles == "yes" || P2BuyCharles == "Yes")
                            {
                                charlesPlaceOwned = true;
                                P2Money = P2Money - 140;
                                Console.WriteLine("You now own St. Charles Place. Players have to pay $450 when they land on this. You have $" + P2Money + ".");
                            }
                            else if (P2BuyCharles == "no" || P2BuyCharles == "No")
                            {
                                charlesPlaceOwned = false;
                            }
                            else
                            {
                                Console.WriteLine("You needed to say 'Yes' or 'No'. You are unfit to buy this property.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("This property is owned! You need to pay Player 1 $450!");
                            P1Money = P1Money + 450;
                            P2Money = P2Money - 450;
                            Console.WriteLine("You have $" + P2Money + ". Player 1 has $" + P1Money + ".");
                        }
                        break;
                    }
                    else if (P2Place == 12)
                    {
                        int P2Position = 0;
                        P2Position = P2Roll + P2Position;
                        Console.WriteLine("You are on Electric Company.");
                        if (electricCompanyOwned == false)
                        {
                            Console.WriteLine("This property is unowned. Would you like to buy it for $150?");
                            string P2BuyElectric = Console.ReadLine();
                            if (P2BuyElectric == "yes" || P2BuyElectric == "Yes")
                            {
                                electricCompanyOwned = true;
                                P2Money = P2Money - 150;
                                Console.WriteLine("You now own Electric Company. Players have to pay 4x whatever they rolled when they land on this. You have $" + P2Money + ".");
                            }
                            else if (P2BuyElectric == "no" || P2BuyElectric == "No")
                            {
                                electricCompanyOwned = false;
                            }
                            else
                            {
                                Console.WriteLine("You needed to say 'Yes' or 'No'. You are unfit to buy this property.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("This property is owned! You need to pay Player 1 4x what you rolled!");
                            int electricTax = 4 * P2Roll;
                            P1Money = P1Money + electricTax;
                            P2Money = P2Money - electricTax;
                            Console.WriteLine("You have $" + P2Money + ". Player 1 has $" + P1Money + ".");
                        }
                        break;
                    }
                    else if (P2Place == 13)
                    {
                        int P2Position = 0;
                        P2Position = P2Roll + P2Position;
                        Console.WriteLine("You are on States Avenue.");
                        if (statesAvenueOwned == false)
                        {
                            Console.WriteLine("This property is unowned. Would you like to buy it for $140?");
                            string P2BuyStates = Console.ReadLine();
                            if (P2BuyStates == "yes" || P2BuyStates == "Yes")
                            {
                                statesAvenueOwned = true;
                                P2Money = P2Money - 140;
                                Console.WriteLine("You now own States Avenue. Players have to pay $450 when they land on this. You have $" + P2Money + ".");
                            }
                            else if (P2BuyStates == "no" || P2BuyStates == "No")
                            {
                                statesAvenueOwned = false;
                            }
                            else
                            {
                                Console.WriteLine("You needed to say 'Yes' or 'No'. You are unfit to buy this property.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("This property is owned! You need to pay Player 1 $450!");
                            P1Money = P1Money + 450;
                            P2Money = P2Money - 450;
                            Console.WriteLine("You have $" + P2Money + ". Player 1 has $" + P1Money + ".");
                        }
                        break;
                    }
                    else if (P2Place == 14)
                    {
                        int P2Position = 0;
                        P2Position = P2Roll + P2Position;
                        Console.WriteLine("You are on Virginia Avenue.");
                        if (virginiaAvenueOwned == false)
                        {
                            Console.WriteLine("This property is unowned. Would you like to buy it for $160?");
                            string P2BuyVirginia = Console.ReadLine();
                            if (P2BuyVirginia == "yes" || P2BuyVirginia == "Yes")
                            {
                                virginiaAvenueOwned = true;
                                P2Money = P2Money - 160;
                                Console.WriteLine("You now own Virginia Avenue. Players have to pay $500 when they land on this. You have $" + P2Money + ".");
                            }
                            else if (P2BuyVirginia == "no" || P2BuyVirginia == "No")
                            {
                                virginiaAvenueOwned = false;
                            }
                            else
                            {
                                Console.WriteLine("You needed to say 'Yes' or 'No'. You are unfit to buy this property.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("This property is owned! You need to pay Player 1 $500!");
                            P1Money = P1Money + 500;
                            P2Money = P2Money - 500;
                            Console.WriteLine("You have $" + P2Money + ". Player 1 has $" + P1Money + ".");
                        }
                        break;
                    }
                    else if (P2Place == 15)
                    {
                        int P2Position = 0;
                        P2Position = P2Roll + P2Position;
                        Console.WriteLine("You are on Pennsylvania Railroad.");
                        if (pennsylvaniaRailroadOwned == false)
                        {
                            Console.WriteLine("This property is unowned. Would you like to buy it for $200?");
                            string P2BuyPennRailroad = Console.ReadLine();
                            if (P2BuyPennRailroad == "yes" || P2BuyPennRailroad == "Yes")
                            {
                                pennsylvaniaRailroadOwned = true;
                                P2Money = P2Money - 200;
                                Console.WriteLine("You now own Pennsylvania Railroad. Players have to pay $100 when they land on this. You have $" + P2Money + ".");
                            }
                            else if (P2BuyPennRailroad == "no" || P2BuyPennRailroad == "No")
                            {
                                pennsylvaniaRailroadOwned = false;
                            }
                            else
                            {
                                Console.WriteLine("You needed to say 'Yes' or 'No'. You are unfit to buy this property.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("This property is owned! You need to pay Player 1 $100!");
                            P1Money = P1Money + 100;
                            P2Money = P2Money - 100;
                            Console.WriteLine("You have $" + P2Money + ". Player 1 has $" + P1Money + ".");
                        }
                        break;
                    }
                    else if (P2Place == 16)
                    {
                        int P2Position = 0;
                        P2Position = P2Roll + P2Position;
                        Console.WriteLine("You are on St. James Place.");
                        if (jamesPlaceOwned == false)
                        {
                            Console.WriteLine("This property is unowned. Would you like to buy it for $180?");
                            string P2BuyJames = Console.ReadLine();
                            if (P2BuyJames == "yes" || P2BuyJames == "Yes")
                            {
                                jamesPlaceOwned = true;
                                P2Money = P2Money - 180;
                                Console.WriteLine("You now own St. James Place. Players have to pay $550 when they land on this. You have $" + P2Money + ".");
                            }
                            else if (P2BuyJames == "no" || P2BuyJames == "No")
                            {
                                jamesPlaceOwned = false;
                            }
                            else
                            {
                                Console.WriteLine("You needed to say 'Yes' or 'No'. You are unfit to buy this property.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("This property is owned! You need to pay Player 1 $550!");
                            P1Money = P1Money + 550;
                            P2Money = P2Money - 550;
                            Console.WriteLine("You have $" + P2Money + ". Player 1 has $" + P1Money + ".");
                        }
                        break;
                    }
                    else if (P2Place == 17)
                        {
                            int P2Position = 0;
                            P2Position = P2Roll + P2Position;
                            Console.WriteLine("You are on Community Chest.");
                            Console.WriteLine("Rolling Dice...");
                            Thread.Sleep(1500);
                            int communityChestCard = random.Next(1, 17);
                            if (communityChestCard == 1)
                                {
                                    Console.WriteLine("Advance to Go (Collect $200)");
                                    P2Position = 0;
                                    P2Money = P2Money + 200;
                                    Console.WriteLine("You have $" + P2Money + ".");
                                }
                            else if (communityChestCard == 2)
                                {
                                    Console.WriteLine("Bank error in your favor. Collect $200.");
                                    P2Money = P2Money + 200;
                                    Console.WriteLine("You have $" + P2Money + ".");
                                }
                            else if (communityChestCard == 3)
                                {
                                    Console.WriteLine("Doctor's Fee. Pay $50.");
                                    P2Money = P2Money - 50;
                                    Console.WriteLine("You have $" + P2Money + ".");
                                }
                            else if (communityChestCard == 4)
                                {
                                    Console.WriteLine("From sale of stock you get $50.");
                                    P2Money = P2Money + 50;
                                    Console.WriteLine("You have $" + P2Money + ".");
                                }
                            else if (communityChestCard == 5)
                                {
                                    Console.WriteLine("Get Out of Jail Free. (You can only have 1 'Get Out of Jail Free' card at a time, so if you have one you won't get another.)");
                                    int getOutOfJailCards = 1;
                                }
                            else if (communityChestCard == 6)
                                {
                                    Console.WriteLine("Go to Jail. Go directly to jail, do not pass Go, do not collect $200.");
                                }
                            else if (communityChestCard == 7)
                                {
                                    Console.WriteLine("Holiday fund matures. Receive $100.");
                                    P2Money = P2Money + 100;
                                    Console.WriteLine("You have $" + P2Money + ".");
                                }
                            else if (communityChestCard == 8)
                                {
                                    Console.WriteLine("Income tax refund. Collect $20.");
                                    P2Money = P2Money + 20;
                                    Console.WriteLine("You have $" + P2Money + ".");
                                }
                            else if (communityChestCard == 9)
                                {
                                    Console.WriteLine("It is your birthday. Collect $10 from every player.");
                                    P2Money = P2Money + 10;
                                    P1Money = P1Money - 10;
                                    Console.WriteLine("You have $" + P2Money + ". Player 1 has $" + P1Money + ".");
                                }
                            else if (communityChestCard == 10)
                                {
                                    Console.WriteLine("Life insurance matures. Collect $100.");
                                    P2Money = P2Money + 100;
                                    Console.WriteLine("You have $" + P2Money + ".");
                                }
                            else if (communityChestCard == 11)
                                {
                                    Console.WriteLine("Pay hospital fees of $100.");
                                    P2Money = P2Money - 100;
                                    Console.WriteLine("You have $" + P2Money + ".");
                                }
                            else if (communityChestCard == 12)
                                {
                                    Console.WriteLine("Pay school fees of $50.");
                                    P2Money = P2Money - 50;
                                    Console.WriteLine("You have $" + P2Money + ".");
                                }
                            else if (communityChestCard == 13)
                                {
                                    Console.WriteLine("Receive $25 consultancy fee.");
                                    P2Money = P2Money + 25;
                                    Console.WriteLine("You have $" + P2Money + ".");
                                }
                            else if (communityChestCard == 14)
                                {
                                    Console.WriteLine("You are assessed for street repair. $40 per house. $115 per hotel.");
                                    int P2HouseTax = 40;
                                    int P2HotelTax = 115;
                                    P2Money = P2Money - P2HouseTax - P2HotelTax;
                                    Console.WriteLine("You have $" + P2Money + ".");
                                }
                            else if (communityChestCard == 15)
                                {
                                    Console.WriteLine("You have won second prize in a beauty contest. Collect $10.");
                                    P2Money = P2Money + 10;
                                    Console.WriteLine("You have $" + P2Money + ".");
                                }
                            else
                                {
                                    Console.WriteLine("You inherit $100.");
                                    P2Money = P2Money + 100;
                                    Console.WriteLine("You have $" + P2Money + ".");
                                }
                            break;
                        }
                    else if (P2Place == 18)
                    {
                        int P2Position = 0;
                        P2Position = P2Roll + P2Position;
                        Console.WriteLine("You are on Tennessee Avenue.");
                        if (tennesseeAvenueOwned == false)
                        {
                            Console.WriteLine("This property is unowned. Would you like to buy it for $180?");
                            string P2BuyTennessee = Console.ReadLine();
                            if (P2BuyTennessee == "yes" || P2BuyTennessee == "Yes")
                            {
                                tennesseeAvenueOwned = true;
                                P2Money = P2Money - 180;
                                Console.WriteLine("You now own Tennessee Avenue. Players have to pay $550 when they land on this. You have $" + P2Money + ".");
                            }
                            else if (P2BuyTennessee == "no" || P2BuyTennessee == "No")
                            {
                                tennesseeAvenueOwned = false;
                            }
                            else
                            {
                                Console.WriteLine("You needed to say 'Yes' or 'No'. You are unfit to buy this property.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("This property is owned! You need to pay Player 1 $550!");
                            P1Money = P1Money + 550;
                            P2Money = P2Money - 550;
                            Console.WriteLine("You have $" + P2Money + ". Player 1 has $" + P1Money + ".");
                        }
                        break;
                    }
                    else if (P2Place == 19)
                    {
                        int P2Position = 0;
                        P2Position = P2Roll + P2Position;
                        Console.WriteLine("You are on New York Avenue.");
                        if (newyorkAvenueOwned == false)
                        {
                            Console.WriteLine("This property is unowned. Would you like to buy it for $200?");
                            string P2BuyNewYork = Console.ReadLine();
                            if (P2BuyNewYork == "yes" || P2BuyNewYork == "Yes")
                            {
                                newyorkAvenueOwned = true;
                                P2Money = P2Money - 200;
                                Console.WriteLine("You now own New York Avenue. Players have to pay $600 when they land on this. You have $" + P2Money + ".");
                            }
                            else if (P2BuyNewYork == "no" || P2BuyNewYork == "No")
                            {
                                newyorkAvenueOwned = false;
                            }
                            else
                            {
                                Console.WriteLine("You needed to say 'Yes' or 'No'. You are unfit to buy this property.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("This property is owned! You need to pay Player 1 $600!");
                            P1Money = P1Money + 600;
                            P2Money = P2Money - 600;
                            Console.WriteLine("You have $" + P2Money + ". Player 1 has $" + P1Money + ".");
                        }
                        break;
                    }
                    else if (P2Place == 20)
                    {
                        int P2Position = 0;
                        P2Position = P2Roll + P2Position;
                        Console.WriteLine("You are on Free Parking. Nothing happens here.");
                        break;
                    }
                    else if (P2Place == 21)
                    {
                        int P2Position = 0;
                        P2Position = P2Roll + P2Position;
                        Console.WriteLine("You are on Kentucky Avenue.");
                        if (kentuckyAvenueOwned == false)
                        {
                            Console.WriteLine("This property is unowned. Would you like to buy it for $220?");
                            string P2BuyKentucky = Console.ReadLine();
                            if (P2BuyKentucky == "yes" || P2BuyKentucky == "Yes")
                            {
                                kentuckyAvenueOwned = true;
                                P2Money = P2Money - 220;
                                Console.WriteLine("You now own Kentucky Avenue. Players have to pay $700 when they land on this. You have $" + P2Money + ".");
                            }
                            else if (P2BuyKentucky == "no" || P2BuyKentucky == "No")
                            {
                                kentuckyAvenueOwned = false;
                            }
                            else
                            {
                                Console.WriteLine("You needed to say 'Yes' or 'No'. You are unfit to buy this property.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("This property is owned! You need to pay Player 1 $700!");
                            P1Money = P1Money + 700;
                            P2Money = P2Money - 700;
                            Console.WriteLine("You have $" + P2Money + ". Player 1 has $" + P1Money + ".");
                        }
                        break;
                    }
                    else if (P2Place == 22)
                    {
                        int P2Position = 0;
                        P2Position = P2Roll + P2Position;
                        Console.WriteLine("You are on Chance.");
                        Console.WriteLine("Picking Card...");
                        Thread.Sleep(1500);
                        int chanceCard = random.Next(1, 16);
                        if (chanceCard == 1)
                        {
                            Console.WriteLine("Advance to Boardwalk.");
                            P2Position = 39;
                        }
                        else if (chanceCard == 2)
                        {
                            Console.WriteLine("Advance to Go (Collect $200)");
                            P2Position = 0;
                            P2Money = P2Money + 200;
                            Console.WriteLine("You have $" + P2Money + ".");
                        }
                        else if (chanceCard == 3)
                        {
                            Console.WriteLine("Advance to Illinois Avenue. If you pass Go, collect $200.");
                            if (P2Position > 24)
                            {
                                Console.WriteLine("You passed Go! Collect $200.");
                                P2Money = P2Money + 200;
                                Console.WriteLine("You have $" + P2Money + ".");
                                P2Position = 24;
                            }
                            else
                            {
                                P2Position = 24;
                            }
                        }
                        else if (chanceCard == 4)
                        {
                            Console.WriteLine("Advance to St. Charles Place. If you pass Go, collect $200.");
                            if (P2Position > 11)
                            {
                                Console.WriteLine("You passed Go! Collect $200.");
                                P2Money = P2Money + 200;
                                Console.WriteLine("You have $" + P2Money + ".");
                                P2Position = 11;
                            }
                            else
                            {
                                P2Position = 11;
                            }
                        }
                        else if (chanceCard == 5)
                        {
                            Console.WriteLine("Advance to the nearest Railroad.");
                            if (P2Position > 35 && P2Position < 5)
                            {
                                P2Position = 5;
                                Console.WriteLine("You are on Reading Railroad.");
                            }
                            else if (P2Position > 5 && P2Position < 15)
                            {
                                P2Position = 15;
                                Console.WriteLine("You are on Pennsylvania Railroad.");
                            }
                            else if (P2Position > 15 && P2Position < 25)
                            {
                                P2Position = 25;
                                Console.WriteLine("You are on B&O Railroad.");
                            }
                            else if (P2Position > 25 && P2Position < 35)
                            {
                                P2Position = 35;
                                Console.WriteLine("You are on Short Line.");
                            }
                            else
                            {
                                P2Position = P2Position;
                            }
                        }
                        else if (chanceCard == 6)
                        {
                            Console.WriteLine("Advance to nearest Utility.");
                            if (P2Position < 12 && P2Position > 28)
                            {
                                P2Position = 12;
                                Console.WriteLine("You are on Electric Company.");
                            }
                            else if (P2Position < 28 && P2Position > 12)
                            {
                                P2Position = 28;
                                Console.WriteLine("You are on Waterworks.");
                            }
                            else
                            {
                                P2Position = P2Position;
                            }
                            P2Position = 10;
                        }
                        else if (chanceCard == 7)
                        {
                            Console.WriteLine("Bank pays you dividend of $50.");
                            P2Money = P2Money + 50;
                            Console.WriteLine("You have $" + P2Money + ".");
                        }
                        else if (chanceCard == 8)
                        {
                            Console.WriteLine("Go Back 3 Spaces.");
                            if (P2Position == 7)
                            {
                                P2Position = 4;
                                Console.WriteLine("You are on Income Tax.");
                            }
                            else if (P2Position == 22)
                            {
                                P2Position = 19;
                                Console.WriteLine("You are on New York Avenue.");
                            }
                            else if (P2Position == 36)
                            {
                                P2Position = 33;
                                Console.WriteLine("You are on Community Chest.");
                            }
                            else
                            {
                                P2Position = P2Position - 3;
                            }
                        }
                        else if (chanceCard == 9)
                        {
                            Console.WriteLine("Go to Jail. Go directly to jail, do not pass Go, do not collect $200. On your next turn, $50 will be taken from you and you will be out of jail.");
                            P2Position = 10;
                            P2Money = P2Money - 50;
                        }
                        else if (chanceCard == 10)
                        {
                            Console.WriteLine("Pay poor tax of $15.");
                            P2Money = P2Money - 15;
                            Console.WriteLine("You have $" + P2Money + ".");
                        }
                        else if (chanceCard == 11)
                        {
                            Console.WriteLine("Take a ride to Reading. If you pass Go, collect $200.");
                            P2Position = 5;
                            if (P2Position < 40 && P2Position > 5)
                            {
                                Console.WriteLine("You passed Go! Collect $200.");
                                P2Money = P2Money + 200;
                                Console.WriteLine("You have $" + P2Money + ".");
                            }
                            else
                            {
                                P2Position = P2Position;
                            }
                        }
                        else if (chanceCard == 12)
                        {
                            Console.WriteLine("You have been elected Chairman of the Board. Pay each player $50.");
                            P1Money = P1Money + 50;
                            P2Money = P2Money - 50;
                            Console.WriteLine("You have $" + P2Money + ". Player 1 has $" + P1Money + ".");
                        }
                        else if (chanceCard == 13)
                        {
                            Console.WriteLine("Your building and loan matures. Collect $150.");
                            P2Money = P2Money + 150;
                            Console.WriteLine("You have $" + P2Money + ".");
                        }
                        else
                        {
                            Console.WriteLine("You have won a crossword competition. Collect $100.");
                            P2Money = P2Money + 100;
                            Console.WriteLine("You have $" + P2Money + ".");
                        }
                        break;
                    }
                    else if (P2Place == 23)
                    {
                        int P2Position = 0;
                        P2Position = P2Roll + P2Position;
                        Console.WriteLine("You are on Indiana Avenue.");
                        if (indianaAvenueOwned == false)
                        {
                            Console.WriteLine("This property is unowned. Would you like to buy it for $220?");
                            string P2BuyIndiana = Console.ReadLine();
                            if (P2BuyIndiana == "yes" || P2BuyIndiana == "Yes")
                            {
                                indianaAvenueOwned = true;
                                P2Money = P2Money - 220;
                                Console.WriteLine("You now own Indiana Avenue. Players have to pay $700 when they land on this. You have $" + P2Money + ".");
                            }
                            else if (P2BuyIndiana == "no" || P2BuyIndiana == "No")
                            {
                                indianaAvenueOwned = false;
                            }
                            else
                            {
                                Console.WriteLine("You needed to say 'Yes' or 'No'. You are unfit to buy this property.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("This property is owned! You need to pay Player 1 $700!");
                            P1Money = P1Money + 700;
                            P2Money = P2Money - 700;
                            Console.WriteLine("You have $" + P2Money + ". Player 1 has $" + P1Money + ".");
                        }
                        break;
                    }
                    else if (P2Place == 24)
                    {
                        int P2Position = 0;
                        P2Position = P2Roll + P2Position;
                        Console.WriteLine("You are on Illinois Avenue.");
                        if (illinoisAvenueOwned == false)
                        {
                            Console.WriteLine("This property is unowned. Would you like to buy it for $240?");
                            string P2BuyIllinois = Console.ReadLine();
                            if (P2BuyIllinois == "yes" || P2BuyIllinois == "Yes")
                            {
                                illinoisAvenueOwned = true;
                                P2Money = P2Money - 240;
                                Console.WriteLine("You now own Illinois Avenue. Players have to pay $750 when they land on this. You have $" + P2Money + ".");
                            }
                            else if (P2BuyIllinois == "no" || P2BuyIllinois == "No")
                            {
                                illinoisAvenueOwned = false;
                            }
                            else
                            {
                                Console.WriteLine("You needed to say 'Yes' or 'No'. You are unfit to buy this property.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("This property is owned! You need to pay Player 1 $750!");
                            P1Money = P1Money + 750;
                            P2Money = P2Money - 750;
                            Console.WriteLine("You have $" + P2Money + ". Player 1 has $" + P1Money + ".");
                        }
                        break;
                    }
                    else if (P2Place == 25)
                    {
                        int P2Position = 0;
                        P2Position = P2Roll + P2Position;
                        Console.WriteLine("You are on B&O Railroad.");
                        if (B_and_ORailroadOwned == false)
                        {
                            Console.WriteLine("This property is unowned. Would you like to buy it for $200?");
                            string P2BuyB_and_O = Console.ReadLine();
                            if (P2BuyB_and_O == "yes" || P2BuyB_and_O == "Yes")
                            {
                                B_and_ORailroadOwned = true;
                                P2Money = P2Money - 200;
                                Console.WriteLine("You now own B&O Railroad. Players have to pay $100 when they land on this. You have $" + P2Money + ".");
                            }
                            else if (P2BuyB_and_O == "no" || P2BuyB_and_O == "No")
                            {
                                B_and_ORailroadOwned = false;
                            }
                            else
                            {
                                Console.WriteLine("You needed to say 'Yes' or 'No'. You are unfit to buy this property.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("This property is owned! You need to pay Player 1 $100!");
                            P1Money = P1Money + 100;
                            P2Money = P2Money - 100;
                            Console.WriteLine("You have $" + P2Money + ". Player 1 has $" + P1Money + ".");
                        }
                        break;
                    }
                    else if (P2Place == 26)
                    {
                        int P2Position = 0;
                        P2Position = P2Roll + P2Position;
                        Console.WriteLine("You are on Atlantic Avenue.");
                        if (atlanticAvenueOwned == false)
                        {
                            Console.WriteLine("This property is unowned. Would you like to buy it for $260?");
                            string P2BuyAtlantic = Console.ReadLine();
                            if (P2BuyAtlantic == "yes" || P2BuyAtlantic == "Yes")
                            {
                                atlanticAvenueOwned = true;
                                P2Money = P2Money - 260;
                                Console.WriteLine("You now own Atlantic Avenue. Players have to pay $800 when they land on this. You have $" + P2Money + ".");
                            }
                            else if (P2BuyAtlantic == "no" || P2BuyAtlantic == "No")
                            {
                                atlanticAvenueOwned = false;
                            }
                            else
                            {
                                Console.WriteLine("You needed to say 'Yes' or 'No'. You are unfit to buy this property.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("This property is owned! You need to pay Player 1 $800!");
                            P1Money = P1Money + 800;
                            P2Money = P2Money - 800;
                            Console.WriteLine("You have $" + P2Money + ". Player 1 has $" + P1Money + ".");
                        }
                        break;
                    }
                    else if (P2Place == 27)
                    {
                        int P2Position = 0;
                        P2Position = P2Roll + P2Position;
                        Console.WriteLine("You are on Ventnor Avenue.");
                        if (ventnorAvenueOwned == false)
                        {
                            Console.WriteLine("This property is unowned. Would you like to buy it for $260?");
                            string P2BuyVentnor = Console.ReadLine();
                            if (P2BuyVentnor == "yes" || P2BuyVentnor == "Yes")
                            {
                                ventnorAvenueOwned = true;
                                P2Money = P2Money - 260;
                                Console.WriteLine("You now own Ventnor Avenue. Players have to pay $800 when they land on this. You have $" + P2Money + ".");
                            }
                            else if (P2BuyVentnor == "no" || P2BuyVentnor == "No")
                            {
                                ventnorAvenueOwned = false;
                            }
                            else
                            {
                                Console.WriteLine("You needed to say 'Yes' or 'No'. You are unfit to buy this property.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("This property is owned! You need to pay Player 1 $800!");
                            P1Money = P1Money + 800;
                            P2Money = P2Money - 800;
                            Console.WriteLine("You have $" + P2Money + ". Player 1 has $" + P1Money + ".");
                        }
                        break;
                    }
                    else if (P2Place == 28)
                    {
                        int P2Position = 0;
                        P2Position = P2Roll + P2Position;
                        Console.WriteLine("You are on Waterworks.");
                        if (waterWorksOwned == false)
                        {
                            Console.WriteLine("This property is unowned. Would you like to buy it for $150?");
                            string P2BuyWaterWorks = Console.ReadLine();
                            if (P2BuyWaterWorks == "yes" || P2BuyWaterWorks == "Yes")
                            {
                                waterWorksOwned = true;
                                P2Money = P2Money - 150;
                                Console.WriteLine("You now own Waterworks. Players have to pay 4x whatever they rolled when they land on this. You have $" + P2Money + ".");
                            }
                            else if (P2BuyWaterWorks == "no" || P2BuyWaterWorks == "No")
                            {
                                waterWorksOwned = false;
                            }
                            else
                            {
                                Console.WriteLine("You needed to say 'Yes' or 'No'. You are unfit to buy this property.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("This property is owned! You need to pay Player 1 4x what you rolled!");
                            int waterTax = 4 * P2Roll;
                            P1Money = P1Money + waterTax;
                            P2Money = P2Money - waterTax;
                            Console.WriteLine("You have $" + P2Money + ". Player 1 has $" + P1Money + ".");
                        }
                        break;
                    }
                    else if (P2Place == 29)
                    {
                        int P2Position = 0;
                        P2Position = P2Roll + P2Position;
                        Console.WriteLine("You are on Marvin Gardens.");
                        if (marvinGardensOwned == false)
                        {
                            Console.WriteLine("This property is unowned. Would you like to buy it for $280?");
                            string P2BuyVentnor = Console.ReadLine();
                            if (P2BuyVentnor == "yes" || P2BuyVentnor == "Yes")
                            {
                                marvinGardensOwned = true;
                                P2Money = P2Money - 280;
                                Console.WriteLine("You now own Marvin Gardens. Players have to pay $850 when they land on this. You have $" + P2Money + ".");
                            }
                            else if (P2BuyVentnor == "no" || P2BuyVentnor == "No")
                            {
                                marvinGardensOwned = false;
                            }
                            else
                            {
                                Console.WriteLine("You needed to say 'Yes' or 'No'. You are unfit to buy this property.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("This property is owned! You need to pay Player 1 $850!");
                            P1Money = P1Money + 850;
                            P2Money = P2Money - 850;
                            Console.WriteLine("You have $" + P2Money + ". Player 1 has $" + P1Money + ".");
                        }
                        break;
                    }
                    else if (P2Place == 30)
                    {
                        int P2Position = 0;
                        P2Position = P2Roll + P2Position;
                        Console.WriteLine("You landed on Go to Jail! Do not pass Go, do not collect Go money, just go to jail.");
                        P2Position = 10;
                        Console.WriteLine("$50 will be taken from you and you will be released on your next turn.");
                        P2Money = P2Money - 50;
                    }
                    else if (P2Place == 31)
                    {
                        int P2Position = 0;
                        P2Position = P2Roll + P2Position;
                        Console.WriteLine("You are on Pacific Avenue.");
                        if (pacificAvenueOwned == false)
                        {
                            Console.WriteLine("This property is unowned. Would you like to buy it for $300?");
                            string P2BuyVentnor = Console.ReadLine();
                            if (P2BuyVentnor == "yes" || P2BuyVentnor == "Yes")
                            {
                                pacificAvenueOwned = true;
                                P2Money = P2Money - 300;
                                Console.WriteLine("You now own Pacific Avenue. Players have to pay $900 when they land on this. You have $" + P2Money + ".");
                            }
                            else if (P2BuyVentnor == "no" || P2BuyVentnor == "No")
                            {
                                pacificAvenueOwned = false;
                            }
                            else
                            {
                                Console.WriteLine("You needed to say 'Yes' or 'No'. You are unfit to buy this property.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("This property is owned! You need to pay Player 1 $900!");
                            P1Money = P1Money + 900;
                            P2Money = P2Money - 900;
                            Console.WriteLine("You have $" + P2Money + ". Player 1 has $" + P1Money + ".");
                        }
                        break;
                    }
                    else if (P2Place == 32)
                    {
                        int P2Position = 0;
                        P2Position = P2Roll + P2Position;
                        Console.WriteLine("You are on North Carolina Avenue.");
                        if (northCarolinaOwned == false)
                        {
                            Console.WriteLine("This property is unowned. Would you like to buy it for $300?");
                            string P2BuyCarolina = Console.ReadLine();
                            if (P2BuyCarolina == "yes" || P2BuyCarolina == "Yes")
                            {
                                northCarolinaOwned = true;
                                P2Money = P2Money - 300;
                                Console.WriteLine("You now own North Carolina Avenue. Players have to pay $900 when they land on this. You have $" + P2Money + ".");
                            }
                            else if (P2BuyCarolina == "no" || P2BuyCarolina == "No")
                            {
                                northCarolinaOwned = false;
                            }
                            else
                            {
                                Console.WriteLine("You needed to say 'Yes' or 'No'. You are unfit to buy this property.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("This property is owned! You need to pay Player 1 $900!");
                            P1Money = P1Money + 900;
                            P2Money = P2Money - 900;
                            Console.WriteLine("You have $" + P2Money + ". Player 1 has $" + P1Money + ".");
                        }
                        break;
                    }
                    else if (P2Place == 33)
                    {
                        int P2Position = 0;
                        P2Position = P2Roll + P2Position;
                        Console.WriteLine("You are on Community Chest.");
                        Console.WriteLine("Rolling Dice...");
                        Thread.Sleep(1500);
                        int communityChestCard = random.Next(1, 17);
                        if (communityChestCard == 1)
                        {
                            Console.WriteLine("Advance to Go (Collect $200)");
                            P2Position = 0;
                            P2Money = P2Money + 200;
                            Console.WriteLine("You have $" + P2Money + ".");
                        }
                        else if (communityChestCard == 2)
                        {
                            Console.WriteLine("Bank error in your favor. Collect $200.");
                            P2Money = P2Money + 200;
                            Console.WriteLine("You have $" + P2Money + ".");
                        }
                        else if (communityChestCard == 3)
                        {
                            Console.WriteLine("Doctor's Fee. Pay $50.");
                            P2Money = P2Money - 50;
                            Console.WriteLine("You have $" + P2Money + ".");
                        }
                        else if (communityChestCard == 4)
                        {
                            Console.WriteLine("From sale of stock you get $50.");
                            P2Money = P2Money + 50;
                            Console.WriteLine("You have $" + P2Money + ".");
                        }
                        else if (communityChestCard == 5)
                        {
                            Console.WriteLine("Get Out of Jail Free. (You can only have 1 'Get Out of Jail Free' card at a time, so if you have one you won't get another.)");
                            int getOutOfJailCards = 1;
                        }
                        else if (communityChestCard == 6)
                        {
                            Console.WriteLine("Go to Jail. Go directly to jail, do not pass Go, do not collect $200.");
                        }
                        else if (communityChestCard == 7)
                        {
                            Console.WriteLine("Holiday fund matures. Receive $100.");
                            P2Money = P2Money + 100;
                            Console.WriteLine("You have $" + P2Money + ".");
                        }
                        else if (communityChestCard == 8)
                        {
                            Console.WriteLine("Income tax refund. Collect $20.");
                            P2Money = P2Money + 20;
                            Console.WriteLine("You have $" + P2Money + ".");
                        }
                        else if (communityChestCard == 9)
                        {
                            Console.WriteLine("It is your birthday. Collect $10 from every player.");
                            P2Money = P2Money + 10;
                            P1Money = P1Money - 10;
                            Console.WriteLine("You have $" + P2Money + ". Player 1 has $" + P1Money + ".");
                        }
                        else if (communityChestCard == 10)
                        {
                            Console.WriteLine("Life insurance matures. Collect $100.");
                            P2Money = P2Money + 100;
                            Console.WriteLine("You have $" + P2Money + ".");
                        }
                        else if (communityChestCard == 11)
                        {
                            Console.WriteLine("Pay hospital fees of $100.");
                            P2Money = P2Money - 100;
                            Console.WriteLine("You have $" + P2Money + ".");
                        }
                        else if (communityChestCard == 12)
                        {
                            Console.WriteLine("Pay school fees of $50.");
                            P2Money = P2Money - 50;
                            Console.WriteLine("You have $" + P2Money + ".");
                        }
                        else if (communityChestCard == 13)
                        {
                            Console.WriteLine("Receive $25 consultancy fee.");
                            P2Money = P2Money + 25;
                            Console.WriteLine("You have $" + P2Money + ".");
                        }
                        else if (communityChestCard == 14)
                        {
                            Console.WriteLine("You are assessed for street repair. $40 per house. $115 per hotel.");
                            int P2HouseTax = 40;
                            int P2HotelTax = 115;
                            P2Money = P2Money - P2HouseTax - P2HotelTax;
                            Console.WriteLine("You have $" + P2Money + ".");
                        }
                        else if (communityChestCard == 15)
                        {
                            Console.WriteLine("You have won second prize in a beauty contest. Collect $10.");
                            P2Money = P2Money + 10;
                            Console.WriteLine("You have $" + P2Money + ".");
                        }
                        else
                        {
                            Console.WriteLine("You inherit $100.");
                            P2Money = P2Money + 100;
                            Console.WriteLine("You have $" + P2Money + ".");
                        }
                        break;
                    }
                    else if (P2Place == 34)
                    {
                        int P2Position = 0;
                        P2Position = P2Roll + P2Position;
                        Console.WriteLine("You are on Pennsylvania Avenue.");
                        if (pennsylvaniaAvenueOwned == false)
                        {
                            Console.WriteLine("This property is unowned. Would you like to buy it for $320?");
                            string P2BuyPennAvenue = Console.ReadLine();
                            if (P2BuyPennAvenue == "yes" || P2BuyPennAvenue == "Yes")
                            {
                                pennsylvaniaAvenueOwned = true;
                                P2Money = P2Money - 320;
                                Console.WriteLine("You now own Pennsylvania Avenue. Players have to pay $950 when they land on this. You have $" + P2Money + ".");
                            }
                            else if (P2BuyPennAvenue == "no" || P2BuyPennAvenue == "No")
                            {
                                pennsylvaniaAvenueOwned = false;
                            }
                            else
                            {
                                Console.WriteLine("You needed to say 'Yes' or 'No'. You are unfit to buy this property.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("This property is owned! You need to pay Player 1 $950!");
                            P1Money = P1Money + 950;
                            P2Money = P2Money - 950;
                            Console.WriteLine("You have $" + P2Money + ". Player 1 has $" + P1Money + ".");
                        }
                        break;
                    }
                    else if (P2Place == 35)
                    {
                        int P2Position = 0;
                        P2Position = P2Roll + P2Position;
                        Console.WriteLine("You are on ShortLine Railroad.");
                        if (shortlineRailroadOwned == false)
                        {
                            Console.WriteLine("This property is unowned. Would you like to buy it for $200?");
                            string P2BuyShortLine = Console.ReadLine();
                            if (P2BuyShortLine == "yes" || P2BuyShortLine == "Yes")
                            {
                                shortlineRailroadOwned = true;
                                P2Money = P2Money - 200;
                                Console.WriteLine("You now own ShortLine Railroad. Players have to pay $100 when they land on this. You have $" + P2Money + ".");
                            }
                            else if (P2BuyShortLine == "no" || P2BuyShortLine == "No")
                            {
                                shortlineRailroadOwned = false;
                            }
                            else
                            {
                                Console.WriteLine("You needed to say 'Yes' or 'No'. You are unfit to buy this property.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("This property is owned! You need to pay Player 1 $100!");
                            P1Money = P1Money + 100;
                            P2Money = P2Money - 100;
                            Console.WriteLine("You have $" + P2Money + ". Player 1 has $" + P1Money + ".");
                        }
                        break;
                    }
                    else if (P2Place == 36)
                    {
                        int P2Position = 0;
                        P2Position = P2Roll + P2Position;
                        Console.WriteLine("You are on Chance.");
                        Console.WriteLine("Picking Card...");
                        Thread.Sleep(1500);
                        int chanceCard = random.Next(1, 16);
                        if (chanceCard == 1)
                        {
                            Console.WriteLine("Advance to Boardwalk.");
                            P2Position = 39;
                        }
                        else if (chanceCard == 2)
                        {
                            Console.WriteLine("Advance to Go (Collect $200)");
                            P2Position = 0;
                            P2Money = P2Money + 200;
                            Console.WriteLine("You have $" + P2Money + ".");
                        }
                        else if (chanceCard == 3)
                        {
                            Console.WriteLine("Advance to Illinois Avenue. If you pass Go, collect $200.");
                            if (P2Position > 24)
                            {
                                Console.WriteLine("You passed Go! Collect $200.");
                                P2Money = P2Money + 200;
                                Console.WriteLine("You have $" + P2Money + ".");
                                P2Position = 24;
                            }
                            else
                            {
                                P2Position = 24;
                            }
                        }
                        else if (chanceCard == 4)
                        {
                            Console.WriteLine("Advance to St. Charles Place. If you pass Go, collect $200.");
                            if (P2Position > 11)
                            {
                                Console.WriteLine("You passed Go! Collect $200.");
                                P2Money = P2Money + 200;
                                Console.WriteLine("You have $" + P2Money + ".");
                                P2Position = 11;
                            }
                            else
                            {
                                P2Position = 11;
                            }
                        }
                        else if (chanceCard == 5)
                        {
                            Console.WriteLine("Advance to the nearest Railroad.");
                            if (P2Position > 35 && P2Position < 5)
                            {
                                P2Position = 5;
                                Console.WriteLine("You are on Reading Railroad.");
                            }
                            else if (P2Position > 5 && P2Position < 15)
                            {
                                P2Position = 15;
                                Console.WriteLine("You are on Pennsylvania Railroad.");
                            }
                            else if (P2Position > 15 && P2Position < 25)
                            {
                                P2Position = 25;
                                Console.WriteLine("You are on B&O Railroad.");
                            }
                            else if (P2Position > 25 && P2Position < 35)
                            {
                                P2Position = 35;
                                Console.WriteLine("You are on Short Line.");
                            }
                            else
                            {
                                P2Position = P2Position;
                            }
                        }
                        else if (chanceCard == 6)
                        {
                            Console.WriteLine("Advance to nearest Utility.");
                            if (P2Position < 12 && P2Position > 28)
                            {
                                P2Position = 12;
                                Console.WriteLine("You are on Electric Company.");
                            }
                            else if (P2Position < 28 && P2Position > 12)
                            {
                                P2Position = 28;
                                Console.WriteLine("You are on Waterworks.");
                            }
                            else
                            {
                                P2Position = P2Position;
                            }
                            P2Position = 10;
                        }
                        else if (chanceCard == 7)
                        {
                            Console.WriteLine("Bank pays you dividend of $50.");
                            P2Money = P2Money + 50;
                            Console.WriteLine("You have $" + P2Money + ".");
                        }
                        else if (chanceCard == 8)
                        {
                            Console.WriteLine("Go Back 3 Spaces.");
                            if (P2Position == 7)
                            {
                                P2Position = 4;
                                Console.WriteLine("You are on Income Tax.");
                            }
                            else if (P2Position == 22)
                            {
                                P2Position = 19;
                                Console.WriteLine("You are on New York Avenue.");
                            }
                            else if (P2Position == 36)
                            {
                                P2Position = 33;
                                Console.WriteLine("You are on Community Chest.");
                            }
                            else
                            {
                                P2Position = P2Position - 3;
                            }
                        }
                        else if (chanceCard == 9)
                        {
                            Console.WriteLine("Go to Jail. Go directly to jail, do not pass Go, do not collect $200. On your next turn, $50 will be taken from you and you will be out of jail.");
                            P2Position = 10;
                            P2Money = P2Money - 50;
                        }
                        else if (chanceCard == 10)
                        {
                            Console.WriteLine("Pay poor tax of $15.");
                            P2Money = P2Money - 15;
                            Console.WriteLine("You have $" + P2Money + ".");
                        }
                        else if (chanceCard == 11)
                        {
                            Console.WriteLine("Take a ride to Reading. If you pass Go, collect $200.");
                            P2Position = 5;
                            if (P2Position < 40 && P2Position > 5)
                            {
                                Console.WriteLine("You passed Go! Collect $200.");
                                P2Money = P2Money + 200;
                                Console.WriteLine("You have $" + P2Money + ".");
                            }
                            else
                            {
                                P2Position = P2Position;
                            }
                        }
                        else if (chanceCard == 12)
                        {
                            Console.WriteLine("You have been elected Chairman of the Board. Pay each player $50.");
                            P1Money = P1Money + 50;
                            P2Money = P2Money - 50;
                            Console.WriteLine("You have $" + P2Money + ". Player 1 has $" + P1Money + ".");
                        }
                        else if (chanceCard == 13)
                        {
                            Console.WriteLine("Your building and loan matures. Collect $150.");
                            P2Money = P2Money + 150;
                            Console.WriteLine("You have $" + P2Money + ".");
                        }
                        else
                        {
                            Console.WriteLine("You have won a crossword competition. Collect $100.");
                            P2Money = P2Money + 100;
                            Console.WriteLine("You have $" + P2Money + ".");
                        }
                        break;
                    }
                    else if (P2Place == 37)
                    {
                        int P2Position = 0;
                        P2Position = P2Roll + P2Position;
                        Console.WriteLine("You are on Park Place.");
                        if (parkPlaceOwned == false)
                        {
                            Console.WriteLine("This property is unowned. Would you like to buy it for $350?");
                            string P2BuyParkPlace = Console.ReadLine();
                            if (P2BuyParkPlace == "yes" || P2BuyParkPlace == "Yes")
                            {
                                parkPlaceOwned = true;
                                P2Money = P2Money - 350;
                                Console.WriteLine("You now own Park Place. Players have to pay $1000 when they land on this. You have $" + P2Money + ".");
                            }
                            else if (P2BuyParkPlace == "no" || P2BuyParkPlace == "No")
                            {
                                parkPlaceOwned = false;
                            }
                            else
                            {
                                Console.WriteLine("You needed to say 'Yes' or 'No'. You are unfit to buy this property.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("This property is owned! You need to pay Player 1 $1000!");
                            P1Money = P1Money + 1000;
                            P2Money = P2Money - 1000;
                            Console.WriteLine("You have $" + P2Money + ". Player 1 has $" + P1Money + ".");
                        }
                        break;
                    }
                    else if (P2Place == 38)
                    {
                        int P2Position = 0;
                        P2Position = P2Roll + P2Position;
                        Console.WriteLine("You are on Luxury Tax. Pay $75.");
                        P2Money = P2Money - 75;
                        Console.WriteLine("You have $" + P2Money + ".");
                    }
                    else if (P2Place == 39)
                    {
                        int P2Position = 0;
                        P2Position = P2Roll + P2Position;
                        Console.WriteLine("You are on Board Walk.");
                        if (boardWalkOwned == false)
                        {
                            Console.WriteLine("This property is unowned. Would you like to buy it for $350?");
                            string P2BuyBoardWalk = Console.ReadLine();
                            if (P2BuyBoardWalk == "yes" || P2BuyBoardWalk == "Yes")
                            {
                                boardWalkOwned = true;
                                P2Money = P2Money - 350;
                                Console.WriteLine("You now own Board Walk. Players have to pay $1000 when they land on this. You have $" + P2Money + ".");
                            }
                            else if (P2BuyBoardWalk == "no" || P2BuyBoardWalk == "No")
                            {
                                boardWalkOwned = false;
                            }
                            else
                            {
                                Console.WriteLine("You needed to say 'Yes' or 'No'. You are unfit to buy this property.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("This property is owned! You need to pay Player 1 $1000!");
                            P1Money = P1Money + 1000;
                            P2Money = P2Money - 1000;
                            Console.WriteLine("You have $" + P2Money + ". Player 1 has $" + P1Money + ".");
                        }
                        break;
                    }
                    else
                    {
                        P2Turn = true;
                    }
                }
                else
                    {
                        Console.WriteLine("You typed it in wrong.");
                        P2Turn = true;
                    }
                if (P2Money == 0)
                    {
                        playingGame = false;
                        Console.WriteLine("Player 1 Wins!");
                        break;
                    }
                playingGame = true;
            }
            playingGame = true;
        }
        playingGame = true;
    }
}