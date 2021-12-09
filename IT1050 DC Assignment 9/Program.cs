using System;

namespace IT1050_DC_Assignment_9
{
	class Program
	{
		static void Main(string[] args)
		{
			Pet.createList();
			if (Pet.NUMBER_OF > 0)
			{
				Pet.fillList();
				Pet.determineOldest();
				Pet.determineYoungest();
				Pet.calculateAverageAge();
				Pet.printInfo();
			}
		}
	}
}
