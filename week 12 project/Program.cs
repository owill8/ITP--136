namespace week_12_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parts part1 = new Parts(1232, 20.20, "Cold air intake", "cold air");

            int objectNum;

            Console.WriteLine("Enter in how many objects you wish to enter: ");
            objectNum = Convert.ToInt32(Console.ReadLine());

            Parts[] partArray = new Parts[objectNum];

            for (int i = 0; i < partArray.Length; i++)
            {
                populateObjects(ref partArray[i]);
            }

            static void populateObjects(ref Parts part)
            {
               
               int PartNum;
                string PartName, PartDescription;
                double Cost;

                Console.WriteLine("Enter in your part number: ");
                PartNum = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter in your Cost: ");
                Cost = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter in your part name: ");
                PartName = Console.ReadLine();
                
                Console.WriteLine("Enter in your part description: ");
                PartDescription = Console.ReadLine();

                Console.WriteLine();

                part = new Parts(PartNum, Cost, PartName, PartDescription);

                


            }
            
            for (int y = 0; y < partArray.Length; y++)
            {
                Console.WriteLine(partArray[y].PartNum + " " + partArray[y].Cost + " " + partArray[y].PartName + " " + partArray[y].ParDescription);

                Console.WriteLine();
            }


            Console.WriteLine("Enter in the number below on which part you want to view");

            Console.WriteLine();

            



            for (int z = 0; z < partArray.Length; z++)
            {

                Console.WriteLine(z + 1 + " " + partArray[z].PartNum + " " + partArray[z].Cost + " " + partArray[z].PartName + " " + partArray[z].ParDescription);

                Console.WriteLine();
            }
            Console.WriteLine("Enter number here: ");



            int selectedPart = Convert.ToInt32(Console.ReadLine());

            ViewPart(ref partArray[selectedPart - 1]);

            static void ViewPart(ref Parts parts)
            {
                Console.WriteLine("What part do you want to view data on? \n 1.Part number \n 2.Cost \n 3.Part Name \n 4.Part Description");
                int userInput = Convert.ToInt32(Console.ReadLine());

                if (userInput == 1)
                {
                    Console.WriteLine("Data: " + " " + parts.PartNum);

                }
                else if (userInput == 2)
                {
                    Console.WriteLine("Data: " + " " + parts.Cost);
                }
                else if (userInput == 3)
                {
                    Console.WriteLine("Data: " + " " + parts.PartName);
                }
                else if (userInput == 4)
                {
                    Console.WriteLine("Data: " + " " + parts.ParDescription);
                }
                else
                {
                    Console.WriteLine("Enter in a number 1-4 please");
                }



            }
            Console.WriteLine();

            for (int y = 0; y < partArray.Length; y++)
            {
                Console.WriteLine(partArray[y].PartNum + " " + partArray[y].Cost + " " + partArray[y].PartName + " " + partArray[y].ParDescription);
            }

            Console.ReadKey();

        }
    }
}
