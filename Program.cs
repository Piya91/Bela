using System;

namespace Bela
{
    class Program
    {
        static void Main(string[] args)
        {
            int x,N=0,points=0;
            string B="";
            string cardValue, face, suit,line;
            line = Console.ReadLine().Trim();
            B = line.Substring(line.Length - 1);
            N = int.Parse( line.Substring(0, line.Length - 1).Trim());
            
            // Console.Write("("+B + ")  (" + line+")");

            for(x=1; x<=4*N;x++)
            {
                cardValue = Console.ReadLine().Trim();
                suit = cardValue.Substring(cardValue.Length - 1);
                face = cardValue.Substring(0, cardValue.Length - 1).Trim();
                switch(face)
                {                    
                    case "A":
                        points += 11;
                        break;
                    
                    case "K":
                        points += 4;
                        break;
                    
                    case "Q":
                        points += 3;
                        break;
                 
                    case "J":
                        if (suit.ToUpper().Equals(B.ToUpper()))
                            points += 20;
                        else
                            points += 2;
                        break;
                    
                    case "T":
                        points += 10;
                        break;
                    case "9":
                        if (suit.ToUpper().Equals(B.ToUpper()))
                            points += 14;
                        else
                            points += 0;
                    

                        break;
                    case "8":
                        points += 0;
                        break;
                    default:
                        points += 0;
                        break;
                }
            }
            Console.WriteLine(points);
        }
    }
}
