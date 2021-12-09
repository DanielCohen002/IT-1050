using System;

namespace IT1050_DC_Assignment_8
{
	class Program
	{
		static void Main(string[] args)
		{
			#region Determine number of pets
			Pet.createPetList();
			#endregion

			#region Create Pet
			if (Pet.numberOfPets < 0)
			{
				Console.WriteLine("Uhh... That's impossible...");
			}
			else if (Pet.numberOfPets == 0)
			{
				Console.WriteLine("Aww... You don't have any pets?");
			}
			#endregion

			else
			{
				Pet.createPet();

				#region Calculate Oldest
				Pet oldestPet = Pet.petsList[0];
				for (int i = 0; i < Pet.numberOfPets; i++)
				{
					if (Pet.petsList[i].age > oldestPet.age)
					{
						oldestPet = Pet.petsList[i];
					}
				}
				#endregion

				#region Determine Youngest
				Pet youngestPet = Pet.petsList[0];
				for (int i = 0; i < Pet.numberOfPets; i++)
				{
					if (Pet.petsList[i].age < youngestPet.age)
					{
						youngestPet = Pet.petsList[i];
					}
				}
				Pet.calculateAveragePetAge();
				#endregion

				#region //Print info
				Pet.calculateSumOfAllPetAges();
				Pet.calculateAveragePetAge();
				Pet.printPetInfo();
				Console.WriteLine("Your oldest pet is " + oldestPet.name + ".");
				Console.WriteLine("Your youngest pet is " + youngestPet.name + ".");
				Console.WriteLine("The average age of all your pets is " + Pet.averageAge + " years old.");
				#endregion
			}
		}
	}
}
