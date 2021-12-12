using System;
using System.Collections.Generic;
using System.Text;

namespace IT1050_DC_Assignment_9
{
	class Pet
	{
		#region Variables
		public string name { get; set; }
		public int age { get; set; }
		public string breed { get; set; }

		public static int NUMBER_OF;
		public static double AVERAGE_AGE;
		public static Pet[] list;
		public static Pet oldest = new Pet("a", 0, "a");
		public static Pet youngest = new Pet("a", 0, "a");


		public Pet(string name, int age, string breed)
        {
			this.name = name;
			this.age = age;
			this.breed = breed;
        }
		//New constuctor format
		#endregion
        public static void createList()
		{
			Console.WriteLine("How many pets do you have?");
			Pet.NUMBER_OF = int.Parse(Console.ReadLine());
			if (Pet.NUMBER_OF < 0)
			{
				Console.WriteLine("Uhh... That's impossible...");
				Environment.Exit(0);
			}
			else if (Pet.NUMBER_OF == 0)
			{
				Console.WriteLine("Aww... You don't have any pets?");
				Environment.Exit(0);
			}
			else
			{
				list = new Pet[NUMBER_OF];
			}
		}
		public static void fillList()
		{
			for (int i = 0; i < Pet.NUMBER_OF; i++)
			{
				if (Pet.NUMBER_OF == 1)
                {
					Console.WriteLine("What is the name, age, and breed of your pet?");
				}
                else
                {
					if (i == 0)
					{
						Console.WriteLine("What is the name, age, and breed of one of your pets?");
					}
					if ((i > 0) && (i < Pet.NUMBER_OF))
					{
						Console.WriteLine("What is the name, age, and breed of a different one of your pets?");
					}
				}
				list[i] = new Pet(Console.ReadLine() , int.Parse(Console.ReadLine()), Console.ReadLine());
				//New constuctor format use
			}
		}
		public static void determineOldest()
		{
			for (int i = 0; i < Pet.NUMBER_OF; i++)
			{
				if (Pet.list[i].age > Pet.oldest.age)
				{
					Pet.oldest = Pet.list[i];
				}
			}
		}
		public static void determineYoungest()
		{
			for (int i = 0; i < Pet.NUMBER_OF; i++)
			{
				if (Pet.list[i].age < Pet.youngest.age)
				{
					youngest = Pet.list[i];
				}
			}
		}
		public static void calculateAverageAge()
		{
			int sumOfAllAges = 0;
			for (int i = 0; i < Pet.NUMBER_OF; i++)
			{
				
				sumOfAllAges = sumOfAllAges + Pet.list[i].age;
			}
			Pet.AVERAGE_AGE = (double)sumOfAllAges / (double)Pet.NUMBER_OF;
		}
		public static void printInfo()
		{
			if (Pet.NUMBER_OF == 1)
			{
				Console.WriteLine("You have " + Pet.NUMBER_OF + " pet!");
			}
			else
			{
				Console.WriteLine("You have " + Pet.NUMBER_OF + " pets!");
			}
			Console.WriteLine("List of your pets:");
			for (int i = 0; i < Pet.NUMBER_OF; i++)
			{
				if (Pet.list[i].age == 1)
				{
					Console.WriteLine((i + 1) + ") " + Pet.list[i].name + ", a " + Pet.list[i].breed + ", is " + Pet.list[i].age + " year old.");
				}
                else
                {
					Console.WriteLine((i + 1) + ") " + Pet.list[i].name + ", a " + Pet.list[i].breed + ", is " + Pet.list[i].age + " years old.");
				}
			}
			Console.WriteLine("Your oldest pet is " + Pet.oldest.name + ".");
			Console.WriteLine("Your youngest pet is " + Pet.youngest.name + ".");
			Console.WriteLine("The average age of all your pets is " + Pet.AVERAGE_AGE + " years old.");
		}
	}
}
