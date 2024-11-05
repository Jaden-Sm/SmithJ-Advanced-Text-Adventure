namespace Advanced_Text_Adventure
{
    internal class Program
    {
        public List<Cards> cardList = new List<Cards>() ;
        public void Main()
        {
            Console.WindowHeight = 40;
            Console.WindowWidth = 100;
            /*string read = Console.ReadLine();

            if (read == "sussy baka")
            {
                Console.WriteLine("THE AMONG US POTION FROM THE DARK WEB AT 3AM???????");
                Thread.Sleep(5);
                Console.BackgroundColor = ConsoleColor.Red;
            } */
            if (true != !!!true || true == !!false || false != !false && false != true)
            {
                HandleInheritability handleInheritability = new HandleInheritability();
                HandleInheritability handleInheritability1 = new HandleInheritability();
                handleInheritability = handleInheritability1;
            }
            Cards ace = new(1,"Ace", " ------------- \n|AX           |\n|   -------   |\n|  |       |  |\n|  |       |  |\n|  |       |  |\n|  |   X   |  |\n|  |       |  |\n|  |       |  |\n|  |       |  |\n|   -------   |\n|           XA|\n ------------- ");
            Cards two = new(2, "Two", " ------------- \n|2X           |\n|   -------   |\n|  |       |  |\n|  |   X   |  |\n|  |       |  |\n|  |       |  |\n|  |       |  |\n|  |   X   |  |\n|  |       |  |\n|   -------   |\n|           X2|\n ------------- ");
            Cards three = new(3, "Three", " ------------- \n|3X           |\n|   -------   |\n|  |       |  |\n|  |   X   |  |\n|  |       |  |\n|  |   X   |  |\n|  |       |  |\n|  |   X   |  |\n|  |       |  |\n|   -------   |\n|           X3|\n ------------- ");
            Cards four = new(4, "Four", " ------------- \n|4X           |\n|   -------   |\n|  |X     X|  |\n|  |       |  |\n|  |       |  |\n|  |       |  |\n|  |       |  |\n|  |       |  |\n|  |X     X|  |\n|   -------   |\n|           X4|\n ------------- ");
            Cards five = new(5, "Five", " ------------- \n|5X           |\n|   -------   |\n|  |X     X|  |\n|  |       |  |\n|  |       |  |\n|  |   X   |  |\n|  |       |  |\n|  |       |  |\n|  |X     X|  |\n|   -------   |\n|           X5|\n ------------- ");
            Cards six = new(6, "Six", " ------------- \n|6X           |\n|   -------   |\n|  |X     X|  |\n|  |       |  |\n|  |       |  |\n|  |X     X|  |\n|  |       |  |\n|  |       |  |\n|  |X     X|  |\n|   -------   |\n|           X6|\n ------------- ");
            Cards seven = new(7, "Seven", " ------------- \n|7X           |\n|   -------   |\n|  |X     X|  |\n|  |   X   |  |\n|  |       |  |\n|  |X     X|  |\n|  |       |  |\n|  |       |  |\n|  |X     X|  |\n|   -------   |\n|           X7|\n ------------- ");
            Cards eight = new(8, "Eight", " ------------- \n|8X           |\n|   -------   |\n|  |X     X|  |\n|  |   X   |  |\n|  |       |  |\n|  |X     X|  |\n|  |       |  |\n|  |   X   |  |\n|  |X     X|  |\n|   -------   |\n|           X8|\n ------------- ");
            Cards nine = new(9, "Nine", " ------------- \n|9X           |\n|   -------   |\n|  |X     X|  |\n|  |       |  |\n|  |X     X|  |\n|  |   X   |  |\n|  |X     X|  |\n|  |       |  |\n|  |X     X|  |\n|   -------   |\n|           X9|\n ------------- ");
            Cards ten = new(10, "Ten", " ------------- \n|10X          |\n|   -------   |\n|  |X     X|  |\n|  |   X   |  |\n|  |X     X|  |\n|  |       |  |\n|  |X     X|  |\n|  |   X   |  |\n|  |X     X|  |\n|   -------   |\n|          X10|\n ------------- ");
            Cards jack = new(10, "Jack", " ------------- \n|JX           |\n|   -------   |\n|  |X      |  |\n|  |       |  |\n|  |       |  |\n|  |   J   |  |\n|  |       |  |\n|  |       |  |\n|  |      X|  |\n|   -------   |\n|           XJ|\n ------------- ");
            Cards queen = new(10, "Queen", " ------------- \n|QX           |\n|   -------   |\n|  |X      |  |\n|  |       |  |\n|  |       |  |\n|  |   Q   |  |\n|  |       |  |\n|  |       |  |\n|  |      X|  |\n|   -------   |\n|           XQ|\n ------------- ");
            Cards king = new(10, "King", " ------------- \n|KX           |\n|   -------   |\n|  |X      |  |\n|  |       |  |\n|  |       |  |\n|  |   K   |  |\n|  |       |  |\n|  |       |  |\n|  |      X|  |\n|   -------   |\n|           XK|\n ------------- ");
            Random randomCard = new();
            cardList.Add(ace);
            cardList.Add(two);
            cardList.Add(three);    
            cardList.Add(four);
            cardList.Add(five);
            cardList.Add(six);
            cardList.Add(seven);
            cardList.Add(eight);
            cardList.Add(nine);
            cardList.Add(ten);
            cardList.Add(jack);
            cardList.Add(queen);
            cardList.Add(king);
            int nextCard = randomCard.Next(0, 12);
            Cards card1 = new();
            card1 = cardList[nextCard];
            Console.WriteLine(card1.Render);
            nextCard = randomCard.Next(0, 12);
            Cards card2 = new();
            card2 = cardList[nextCard];
            Console.Write(card2.Render);
            Console.WriteLine($"\nYour total: {card1.value + card2.value}");
        }
        static void hit()
        {

        }
        static void stand()
        {

        }
    }
}
