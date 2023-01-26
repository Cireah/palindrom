/*
* Input layer: ta in användarens input och spara den i en array för en plats per bokstav. 
* 
* Verification layer: tror inte jag behöver göra något här om jag inte vidareutvecklar det mer
* just nu tar den med alla tecken i unicode men om jag blir klar i tid så kan den bli restricted till bara bokstäver
*
* Data layer: kolla varje bokstav mot den sista bokstaven i ordet och sedan gå till nästa och kolla näst sista. 
* om ordet är anna så kollar position 0 och position 3 och sedan ta position++; och anna.length--;
* lägg detta i en for loop som loopar n antal gånger baserat på hur många bokstäver ordet innehåller
* 
* (jag ska omvandla den här texten till något normala människor också kan förstå och inte bara jag)
* 
* Output layer: skriv ut om användarens ord är en palindrom eller inte. 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrom {
    class Program {
        static void Main(string[] args) {
            string userinput;
            Console.WriteLine("skriv ett ord det kanske är en palindrom vem vet :oooo");
            userinput = Console.ReadLine();
            char[] Palindrome = userinput.ToCharArray();
            int PalindromLength = Palindrome.Length;
            Console.ReadKey();
        }
    }
}
