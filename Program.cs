using System;
using System.Collections.Generic;

namespace Session05_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // While 

            //Ex #01
            //int i = 0;

            //while (i <= 4)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //Ex #02

            //Console.WriteLine("Are you ok?");
            //Console.WriteLine("Answer with Yes or No");
            //string answer = Console.ReadLine();

            //bool chk = false;

            //switch (answer)
            //{
            //    case "Yes":
            //        chk = true;
            //        break;

            //    case "No":
            //        chk = false;
            //        break;
            //}
            //int num = 5;


            //switch (num)
            //{
            //    case 0:
            //        break;
            //}


            //while(chk == false)
            //{
            //    Console.WriteLine("Be ok");
            //    Console.WriteLine("------------------------------");
            //    Console.WriteLine("Are you ok?");
            //    Console.WriteLine("Answer with Yes or No");
            //    answer = Console.ReadLine();

            //    switch (answer)
            //    {
            //        case "Yes":
            //            chk = true;
            //            break;

            //        case "No":
            //            chk = false;
            //            break;
            //    }
            //}



            // Do While
            //do
            //{
            //    Console.WriteLine("Be ok");
            //    Console.WriteLine("------------------------------");
            //    Console.WriteLine("Are you ok?");
            //    Console.WriteLine("Answer with Yes or No");
            //    answer = Console.ReadLine();

            //    switch (answer)
            //    {
            //        case "Yes":
            //            chk = true;
            //            break;

            //        case "No":
            //            chk = false;
            //            break;
            //    }
            //} while(chk == false);



            // For loop

            //for (int i =0; i <= 10; i++)
            //{

            //    if (i == 5)
            //    {
            //        continue;
            //    }

            //    if (i == 8)
            //    {
            //        break;
            //    }

            //    Console.WriteLine(i);
            //}



            // For each

            //Declare Material list
            List<string> materialList = new List<string>();

            //Ask user to add materials 
            Console.WriteLine("Add materials until you say Done");
            string answer = Console.ReadLine();
            materialList.Add(answer);

            while (answer != "Done")
            {
                Console.WriteLine("Add material");
                answer = Console.ReadLine();

                if (answer != "Done")
                {
                    materialList.Add(answer);
                }
                //if (answer == "Done")
                //{
                //    materialList.Remove(answer);
                //}

            }

            //Thread.Sleep(1000);





            foreach (string material in materialList)
            {
                switch (material)
                {
                    case "Concrete":
                        {
                            Console.WriteLine("1 m3 Concrete = 1000");
                        }
                        break;

                    case "Timber":
                        {
                            Console.WriteLine("1 m2 Timber = 500");
                        }
                        break;

                    case "Steel":
                        {
                            Console.WriteLine("1 ton Steel = 20000");
                        }
                        break;

                    default:
                        Console.WriteLine("We dont have this material is the store");
                        break;
                }
            }

            Console.WriteLine("To buy of Materials: \n" +
            $"Press 1 for {materialList[0]} \n" +
            $"Press 2 for {materialList[1]} \n" +
            $"Press 3 for {materialList[2]}");

            //int numAnswer = Convert.ToInt32( Console.ReadLine());
            int numAnswer = int.Parse(Console.ReadLine());

            int i = 0;
            switch (numAnswer)
            {
                case 1:
                    Console.WriteLine($"YOU'VE PURCHASED {materialList[0]}");
                    break;

                case 2:
                    Console.WriteLine($"YOU'VE PURCHASED {materialList[1]}");
                    break;

                case 3:
                    Console.WriteLine($"YOU'VE PURCHASED {materialList[2]}");

                    break;

                default:
                    Console.WriteLine("We only have Concrete, Timber, and Steel");
                    break;
            }

            Console.ReadLine();


            //vvvaveavddddddddddlmllmlwclcmlamlsamclsmacllcscsal

            /* 
             efqefqWFFQ

            AEVEAVEAV
            EAVEV
            WCAEEAVEAVEVEV
            E
            VAE
            VEA
            VAE
            VAEV
            EAV
            EAVAEVEAEAVEAVEA
             
             EAVAEVAEVAEV
             EAVEAVEAVEAV

            AEVEAVEAVEAVEAVEAVEAVEA

            EAVEAVEVEVEAVAEV

            AEVEVEAVAE

            AEVEAVEA
             */


        }
    }
}
