
public class PromptGenerator
{
    string prompt1 = "What was something nice about today?";
    string prompt2 = "Did you meet anyone new today?";
    string prompt3 = "Did you try a new food today?";
    string prompt4 = "Did anything enteresting happen today?";
    string prompt5 = "What did you eat for dinner today?";
    
    list<int> prompts = {1,2,3,4,5};
    
    int randPrompts = Random(prompts);
    
    if (randPrompts == 1){
        console.WriteLine(prompt1);
    }
    else if (randPrompts == 2){
        Console.Write(prompt2);
    }
    else if (randPrompts == 3){
        Console.Write(prompt3);
    }
    else if (randPrompts == 4){
        Console.Write(prompt4);
    }
    else if (randPrompts == 5){
        Console.Write(prompt5);
    }

    
}   