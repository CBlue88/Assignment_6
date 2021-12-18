using System;
using System.Collections;

namespace Assignment_6
{
	class Program
	{
        

        static void Main(string[] args)
		{

			getPetInfo();
			void getPetInfo()
			{
				Console.WriteLine("How many pets do you have");
				int numOfpets = int.Parse(Console.ReadLine());

				if (numOfpets > 0)
				{
					// list of all the pets
					Pet[] allPets = new Pet[numOfpets];

					for (int i = 0; i < numOfpets; i++)
					{
						//create new instance of each pet
						Pet newPet = new Pet();

						//input prompts for property values	
						Console.WriteLine("What pet's name?");
						string petName = Console.ReadLine();
						newPet.petName = petName;
						Console.WriteLine("What is the age of your pet?");
						int petAge = int.Parse(Console.ReadLine());
						newPet.petAge = petAge;
						Console.WriteLine("What is the breed of your pet?");
						string petBreed = Console.ReadLine();
						newPet.petBreed = petBreed;

						//set pet to all pet array
						allPets[i] = newPet;

					}

					
					//for-loop
					for (int i = 0; i < numOfpets; i++)
					{
						// print all pets
						Console.WriteLine("Name: " + allPets[i].petName + " Age: " + allPets[i].petAge + " Breed: " + allPets[i].petBreed);
					}
					for (int i = 0; i < numOfpets; i++)
                    {
						//Can't get this damn thing to work
						Array.Sort(newPet, new PetComparer());

						Console.WriteLine("Your First dog is your youngest,  your last dog is your oldest!");
                    }
						
				}
			}
		}
    }
			   }			
