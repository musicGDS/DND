using System;
using System.Collections.Generic;

namespace DnD
{
    class Program
    {
        static void Main()
        {
            //List to store characterss
            List<Character> savedCharacters = new List<Character>();
            int choice = 0;

            //Main application loop
            do
            {
                Console.WriteLine("___________________________________________");
                Console.WriteLine("Please choose fro the following:\n" +
                "1 - Create random character " +
                "2 - Create character manually " +
                "3 - Show saved characters " +
                "4 - Quit");
                
                do
                {
                    choice = Convert.ToInt32(Console.ReadLine());
                } while (choice < 1 || choice > 3);

                //Choose a menu item
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("___________________________________________");
                        Console.WriteLine("Creating random character:");
                        Character randChar = RandomCharacter();
                        printCharacter(randChar);
                        savedCharacters.Add(randChar);
                        break;
                    case 2:
                        Console.WriteLine("___________________________________________");
                        Console.WriteLine("Create character manually:");
                        Character manChar = CreateCharacterManualy();
                        printCharacter(manChar);
                        savedCharacters.Add(manChar);
                        break;
                    case 3:
                        Console.WriteLine("___________________________________________");
                        int charCount = savedCharacters.Count;
                        Console.WriteLine("Showing saved characters:");
                        Console.WriteLine("Enter the number of a character " +
                            "to see its stats");
                    
                        for (int i = 0; i < charCount; i++)
                        {
                            Console.WriteLine("{0} - {1} ", i, savedCharacters[i].Name);
                        }

                        int cChoice = -1;
                        do
                        {
                            cChoice = Convert.ToInt32(Console.ReadLine());
                        } while (cChoice < 0 || cChoice >= charCount);
                        

                        printCharacter(savedCharacters[cChoice]);

                        break;
                    default:
                        Console.WriteLine("Please enter: 1, 2, 3 or 4");
                        break;
                }
            } while (choice != 4);
            Environment.Exit(0);
        }

        //Generates random character
        private static Character RandomCharacter()
        {
            //Generates random number from 1 to 6 to fill the stats
            int generateStat()
            {
                Random randStat = new Random();
                return randStat.Next(1, 7);
            }

            //List of random names
            string randomName ()
            {
                string[] randomNames = { "Daenerys Targaryen", "Jon Snow",
                "Arya Stark", "Jaime Lannister", "Sansa Stark",
                "Tirion Lannister", "Cersei Lannister", "Hodor",
                "Missandei", "Petyr Baelish"};

                Random r = new Random();
                int rInt = r.Next(0, 10);
                return randomNames[rInt];
            }

            //generate all stats and create the character object
            int randomStrenght = generateStat();
            int randomDexterity = generateStat();
            int randomConstitution = generateStat();
            int randomIntelligence = generateStat();
            int randomWisdom = generateStat();
            int randomCharisma = generateStat();

            return new Character(randomName(), 5, randomDexterity,
                randomConstitution, randomIntelligence, randomWisdom,
                randomCharisma);
        }

        //Create character manually by user input
        private static Character CreateCharacterManualy()
        {
            string mName;
            int mStrenght;
            int mDexterity;
            int mConstitution;
            int mIntelligence;
            int mWisdom;
            int mCharisma;

            bool wName = true;
            do
            {
                Console.WriteLine("Enter character name:");
                mName = Console.ReadLine();
                if (mName != "")
                {
                    wName = false;
                }
            } while (wName);

            bool wStrenght = true;
            do
            {
                Console.WriteLine("Enter Srenght (from 1 to 6)");
                string mStrenghtS = Console.ReadLine();
                if (int.TryParse(mStrenghtS, out mStrenght) && mStrenght > 0
                    && mStrenght < 7)
                {
                    wStrenght = false;
                }
                else
                {
                    Console.WriteLine("Please provide numeric value from 1 to 6");
                }

            }
            while (wStrenght);

            bool wDexterity = true;
            do
            {
                Console.WriteLine("Enter Dexterity (from 1 to 6)");
                string mDexterityS = Console.ReadLine();
                if (int.TryParse(mDexterityS, out mDexterity) && mDexterity > 0
                    && mDexterity < 7)
                {
                    wDexterity = false;
                }
                else
                {
                    Console.WriteLine("Please provide numeric value from 1 to 6");
                }
            } while (wDexterity);

            bool wConstitution = true;
            do
            {
                Console.WriteLine("Enter Constitution (from 1 to 6)");
                string mConstitutionS = Console.ReadLine();
                if (int.TryParse(mConstitutionS, out mConstitution) && mConstitution > 0
                    && mConstitution < 7)
                {
                    wConstitution = false;
                }
            } while (wConstitution);

            bool wIntelligence = true;
            do
            {
                Console.WriteLine("Enter Intelligence (from 1 to 6)");
                string mIntelligenceS = Console.ReadLine();
                if (int.TryParse(mIntelligenceS, out mIntelligence) && mIntelligence > 0
                    && mIntelligence < 7)
                {
                    wIntelligence = false;
                }
            } while (wIntelligence);

            bool wWisdom = true;
            do
            {
                Console.WriteLine("Enter Wisdom (from 1 to 6)");
                string mWisdomS = Console.ReadLine();
                if (int.TryParse(mWisdomS, out mWisdom) && mWisdom > 0
                    && mWisdom < 7)
                {
                    wWisdom = false;
                }
            } while (wWisdom);

            bool wCharisma = true;
            do
            {
                Console.WriteLine("Enter Charisma (from 1 to 6)");
                string mCharismaS = Console.ReadLine();
                if (int.TryParse(mCharismaS, out mCharisma) && mCharisma > 0
                    && mCharisma < 7)
                {
                    wCharisma = false;
                }
            } while (wCharisma);


            return new Character(mName, mStrenght, mDexterity,
            mConstitution, mIntelligence, mWisdom, mCharisma);

        }


        //Prints character stats on screen
        private static void printCharacter(Character character)
        {
            Console.WriteLine("___________________________________________");
            Console.Write("Name: {0}\n" +
                          "STR : {1}\n" +
                          "DEX : {2}\n" +
                          "CON : {3}\n" +
                          "INT : {4}\n" +
                          "WIS : {5}\n" +
                          "CHA : {6}\n" +
                          "HP  : {7}\n", character.Name, character.Strength,
                          character.Dexterity, character.Constitution,
                          character.Intelligence, character.Wisdom,
                          character.Charisma, character.Hitpoints);
        }
    }
}
