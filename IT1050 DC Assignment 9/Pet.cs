using System;
using System.Collections.Generic;
using System.Text;

namespace IT1050_DC_Assignment_9
{
	class Pet
	{
		#region Variables
		private string name;
		private int age;
		private string breed;

		public static int NUMBER_OF;
		public static double AVERAGE_AGE;
		public static Pet[] petsList = new Pet[1];

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
		#region Get/Sets
		#region Gets
		public string getName()
		{
			return this.name;
		}
		public int getAge()
		{
			return this.age;
		}
		public string getBreed()
		{
			return this.breed;
		}
        #endregion
        #region Sets
        public void setName(string newName)
		{
			this.name = newName;
		}
		public void setAge(int newAge)
		{
			this.age = newAge;
		}
		public void setBreed(string newBreed)
		{
			this.breed = newBreed;
		}
        #endregion
        #endregion
        public static void createList()
		{
			Console.WriteLine("How many pets do you have?");
			Pet.NUMBER_OF = int.Parse(Console.ReadLine());
			if (Pet.NUMBER_OF < 0)
			{
				Console.WriteLine("Uhh... That's impossible...");
			}
			else if (Pet.NUMBER_OF == 0)
			{
				Console.WriteLine("Aww... You don't have any pets?");
			}
			else
			{
				Array.Resize<Pet>(ref petsList, Pet.NUMBER_OF);
				//Had to look this one up. How else do you resize an array?
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
				petsList[i] = new Pet(Console.ReadLine() , int.Parse(Console.ReadLine()), Console.ReadLine());
				//New constuctor format use
			}
		}
		public static void determineOldest()
		{
			for (int i = 0; i < Pet.NUMBER_OF; i++)
			{
				if (Pet.petsList[i].age > Pet.oldest.age)
				{
					Pet.oldest = Pet.petsList[i];
				}
			}
		}
		public static void determineYoungest()
		{
			for (int i = 0; i < Pet.NUMBER_OF; i++)
			{
				if (Pet.petsList[i].age < Pet.youngest.age)
				{
					youngest = Pet.petsList[i];
				}
			}
		}
		public static void calculateAverageAge()
		{
			int sumOfAllAges = 0;
			for (int i = 0; i < Pet.NUMBER_OF; i++)
			{
				
				sumOfAllAges = sumOfAllAges + Pet.petsList[i].age;
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
				if (Pet.petsList[i].age == 1)
				{
					Console.WriteLine((i + 1) + ") " + Pet.petsList[i].name + ", a " + Pet.petsList[i].breed + ", is " + Pet.petsList[i].age + " year old.");
				}
                else
                {
					Console.WriteLine((i + 1) + ") " + Pet.petsList[i].name + ", a " + Pet.petsList[i].breed + ", is " + Pet.petsList[i].age + " years old.");
				}
			}
			Console.WriteLine("Your oldest pet is " + Pet.oldest.name + ".");
			Console.WriteLine("Your youngest pet is " + Pet.youngest.name + ".");
			Console.WriteLine("The average age of all your pets is " + Pet.AVERAGE_AGE + " years old.");
		}
	}
}
