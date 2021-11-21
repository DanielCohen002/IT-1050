using System;
using System.Collections.Generic;
using System.Text;

namespace Main
{
	class Pet
	{
		#region Variables
		public string name;
		public int age;
		public string breed;

		public static int numberOfPets;
		public static int sumOfAllPetAges;
		public static double averageAge;
		public static Pet[] petsList = new Pet[1];
		#endregion

		public static void createPetList()
		{
			Console.WriteLine("How many pets do you have?");
			Pet.numberOfPets = int.Parse(Console.ReadLine());
			if (Pet.numberOfPets > 0)
			{
				Array.Resize<Pet>(ref petsList, numberOfPets);
				//Had to look this one up. How else do you resize an array?
			}
		}

		public static void createPet()
		{
			for (int i = 0; i < Pet.numberOfPets; i++)
			{
				petsList[i] = new Pet();
				Pet.petsList[i].name = Console.ReadLine();
				Pet.petsList[i].age = int.Parse(Console.ReadLine());
				Pet.petsList[i].breed = Console.ReadLine();
				if (i != (Pet.numberOfPets-1))
                {
                    Console.WriteLine("What is the name, age, and breed of a different one of your pets?");
                }
			}
		}

		public static void calculateSumOfAllPetAges()
		{
			for (int i = 0; i < Pet.numberOfPets; i++)
			{
				Pet.sumOfAllPetAges = Pet.sumOfAllPetAges + Pet.petsList[i].age;
			}
		}

		public static void calculateAveragePetAge()
		{
			Pet.averageAge = (double)Pet.sumOfAllPetAges / (double)Pet.numberOfPets;
		}
		public static void printPetInfo()
		{
			Console.WriteLine("List of your pets:");
			for (int i = 0; i < Pet.numberOfPets; i++)
			{
				Console.WriteLine((i + 1) + ") " + Pet.petsList[i].name + ", a " + Pet.petsList[i].breed + ", is " + Pet.petsList[i].age + " years old.");
			}
			if (Pet.numberOfPets == 1)
			{
				Console.WriteLine("You have " + Pet.numberOfPets + " pet!");
			}
			else
			{
				Console.WriteLine("You have " + Pet.numberOfPets + " pets!");
			}
			
		}
	}
}
