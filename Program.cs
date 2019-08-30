using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat
{
    class Program
    {
        static void Main(string[] args)
        {

            LoggaIn();
            Console.Clear();
            Meny();






        }
  
        public static void Meny()
        {
            bool meny = true;
            int inputbank;
            int insättningsaldoBank = 0;
            int uttagsaldoBank = 0;
            int saldoBank = 0;
            while (meny)
            {
                
                Console.WriteLine("1.Saldo:");
                Console.WriteLine("2.Sätt in pengar:");
                Console.WriteLine("3.Ta ut pengar:");
                Console.WriteLine("4.Logga ut");

                
                while (true)
                {
                    Console.Write("Ange en siffra för det du vill göra: ");
                    bool ok = int.TryParse(Console.ReadLine(), out inputbank);
                      if (ok) break;
                      Console.WriteLine("Felaktig inmatning");

                }                
                    if (inputbank == 2)
                    {
                        while (true)
                        {
                            Console.Write("Skriv hur mycket du vill sätta in: ");
                            bool ok = int.TryParse(Console.ReadLine(), out inputbank);
                            if (ok) break;
                            Console.WriteLine("Felaktig inmatning");

                        }

                    insättningsaldoBank = inputbank;
                    saldoBank = saldoBank + insättningsaldoBank;
                    Console.WriteLine($"Ditt saldo är: {saldoBank}");
                    Console.ReadLine();
                        


                    }
                    else if (inputbank == 1)
                    {
                    Console.WriteLine($"Ditt saldo är: {saldoBank}");
                    Console.ReadLine();


                    }
                    else if (inputbank == 3)
                    {
                    while (true)
                    {
                        Console.Write("Skriv hur mycket du vill ta ut: ");
                        bool ok = int.TryParse(Console.ReadLine(), out inputbank);
                        if (ok) break;
                        Console.WriteLine("Felaktig inmatning");

                    }

                    uttagsaldoBank = inputbank;
                    if (uttagsaldoBank > saldoBank)
                    {
                        Console.WriteLine($"Ditt saldo är för litet för uttag av {uttagsaldoBank}, saldo: {saldoBank}");
                        Console.ReadLine();
                    }
                    else if (uttagsaldoBank <= saldoBank)
                    {
                        saldoBank = saldoBank - uttagsaldoBank;
                        Console.WriteLine($"Ditt saldo är: {saldoBank}");
                        Console.ReadLine();

                    }
                    


                }
                    else if (inputbank == 4)
                    {

                        meny = false;


                    }
                    else
                    {
                        Console.WriteLine("Fel siffra, försök igen!");
                        Console.ReadLine();
                    }
               


                
                Console.Clear();


            }

        }
        public static void LoggaIn()
        {
            
            bool görOm = true;
            while (görOm)
            {
                const long dittPersonnummer = 8809080032;
                const int dinPinkod = 1234;


                Console.WriteLine("Logga in till bank");
                Console.Write("Personnummer: ");
                
                

                if (long.TryParse(Console.ReadLine(), out long personnummer))
                {
                    if (personnummer == dittPersonnummer)
                    {
                        
                        bool pinkodTrue = true;
                        while (pinkodTrue)
                        {
                            Console.Write("Pinkod: ");
                            Console.ForegroundColor = ConsoleColor.Black;

                            if (int.TryParse(Console.ReadLine(), out int pinkod))
                            {
                                Console.ForegroundColor = ConsoleColor.White;
                                if (pinkod == dinPinkod)
                                {
                                    Console.WriteLine("Du är inloggad!");
                                    pinkodTrue = false;
                                    görOm = false;
                                    
                                    

                                }
                                else
                                {
                                    Console.WriteLine("Fel pinkod, försök igen");
                                    

                                }

                            }
                            else
                            {
                                Console.WriteLine("Fel pinkod, försök igen");
                                

                            }

                            

                        }
                        

                    }
                    else
                    {
                        Console.WriteLine("Fel personnummer, tryck enter och försök igen");
                        

                    }
                }
                else
                {
                    Console.WriteLine("Fel, Skriv personnummer med siffror , exemple 9007100032, tryck enter och försök igen");
                    
                }
                Console.ReadLine();
                
            }
            


        }

    }
}
