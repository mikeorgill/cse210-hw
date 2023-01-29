
public class PromptGenerator
{
    
    public string _randomPrompt(){
    
        string prompt1 = "What was something nice about today?";
        string prompt2 = "Did you meet anyone new today?";
        string prompt3 = "Did you try a new food today?";
        string prompt4 = "Did anything enteresting happen today?";
        string prompt5 = "What did you eat for dinner today?";

        Random r = new Random();
        int randPrompts = r.Next(1,5);
    
        string promptEntry = "";

        if (randPrompts == 1){
            promptEntry = prompt1;
        }
        else if (randPrompts == 2){
            promptEntry = prompt2;
        }
        else if (randPrompts == 3){
            promptEntry = prompt3;
        }
        else if (randPrompts == 4){
            promptEntry = prompt4;
        }
        else{
            promptEntry = prompt5;
        }

        return promptEntry;
    }
}; 