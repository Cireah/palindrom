/*
* Input layer: ta in användarens input och spara den i en array för en plats per bokstav. 
* 
* Verification layer: omvandla alla bokstäver till lowercase
*
* Data layer: kolla varje bokstav mot den sista bokstaven i ordet och sedan gå till nästa och kolla näst sista. 
* om ordet är anna så kollar position 0 och position 3 och sedan ta position++; och anna.length--;
* lägg detta i en for loop som loopar n antal gånger baserat på hur många bokstäver ordet innehåller
* 
* Output layer: skriv ut om användarens ord är en palindrom eller inte. 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrom 
{
    class Program 
    {
        static void Main(string[] args) 
        {
            Userinput();
        }
        static void Userinput()
        {
            string userinput;

            Console.WriteLine("skriv ett ord det kanske är en palindrom vem vet :oooo");
            userinput = Console.ReadLine();
            userinput = userinput.ToLower(); //gör userinput till lowercase för uppercase of lowercase bokstäver är  två olika tecken

            Palindromcheck(userinput);
        }

        static void Palindromcheck(string userinput)
        {
            int startnum = 0;
            int uinputlength;
            bool palindromstatus = false;

            string[] userinputs = userinput.Split(' ');
            uinputlength = userinputs.Length;

            for (int i = 0; i < uinputlength; i++)
            {
                userinput = userinputs[0].ToString();
                char[] palindrome = userinput.ToCharArray(); //gör userinput till en array
                int pLength = palindrome.Length; //bestämmer längden på arrayen

                for (int j = 0; j < pLength; j++) //loopar n antal gånger utifrån hur många tecken som finns i arrayen
                {
                    if (palindrome[startnum] == palindrome[pLength - 1]) //kollar om första tecknet i userinput är samma som det sista och sedan kollar samma sak om nästa och näst sista
                    {
                        pLength--;
                        startnum++;
                        palindromstatus = true;
                    }
                    else
                    {
                        palindromstatus = false;
                        i = pLength;
                    }
                } //slutar loopa när den jämfört de ett eller två mittersta tecknen

                if (palindromstatus == false)
                {
                    Console.WriteLine(userinput + " är inte en palindrom jag gråtar nu");
                }
                else if (palindromstatus == true)
                {
                    Console.WriteLine(userinput + " has been successfully palindromed");
                }
                else
                {
                    Console.WriteLine("idek how you got here tbh");
                } //ger svar till användaren om ordet är en palindrom eller inte 
            }

            Continue();
        }

        static void Continue() //kollar om användaren vill fortsätta eller inte
        {
            Console.WriteLine("continue? y/n");
            string userinput = Console.ReadLine();

            if(userinput == "y")
            {
                Userinput();
            }
            else
            {
                Console.WriteLine("bye"); 
                Console.ReadKey();
            }
        }
    }
}