using System;
class Words{
    
    /*List word - place each word in the list so that it can removed when needed.
    random RandomWord - randomly remove a few words from the word list and replace it with "_ _ _" 
        when the enter button is pressed.*/

    public static string randomVerse = Reference._reference();
    
    
    public static string _getReplaceWords(){
    Random randReplace = new Random(); 
    int randVerse = randReplace.Next(2, randomVerse.Length);  
    string replaceWords = " ";

    
    
    return replaceWords;
    }
}
