using System;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        // Creating my lists, these contain all the dialogue for each scene
        List<DialogueLine> IntroScene = new List<DialogueLine>();
        List<DialogueLine> YesOne = new List<DialogueLine>();
        List<DialogueLine> NoOne = new List<DialogueLine>();
        List<DialogueLine> Argue = new List<DialogueLine>();
        List<DialogueLine> Win = new List<DialogueLine>();
        List<DialogueLine> Lose = new List<DialogueLine>();
        
        

        // Creating my first dictionary

        Dictionary<string, List<DialogueLine>> DialoguesDictionary = new Dictionary<string, List<DialogueLine>>();
        DialoguesDictionary.Add("Intro", IntroScene);
        DialoguesDictionary.Add("YesOne", YesOne);
        DialoguesDictionary.Add("NoOne", NoOne);
        DialoguesDictionary.Add("Argue", Argue);
        DialoguesDictionary.Add("Win", Win);
        DialoguesDictionary.Add("Lose", Lose);
        

        // Second dictionary which will store player choices

        Dictionary<string, string> PlayerChoices = new Dictionary<string, string>();

        // Intro Scene
        
        DialogueLine introline0 = new DialogueLine();
        introline0.SpeakerName = "Mo";
        introline0.Speech = "I am setting you a new task.";
        IntroScene.Add(introline0); // adding the dialogue to the list

        
        DialogueLine introline1 = new DialogueLine();
        introline1.SpeakerName = "Mo";
        introline1.Speech = "I need you to complete it without ai.";
        IntroScene.Add(introline1); 

        DialogueLine introline2 = new DialogueLine();
        introline2.SpeakerName = "Narrator";
        introline2.Speech = "Do you use AI? (Answer 'yes' or 'no').";
        IntroScene.Add(introline2); 

        // Yes 1 
        
        DialogueLine yesoneline0 = new DialogueLine();
        yesoneline0.SpeakerName = "Narrator";
        yesoneline0.Speech = "You chose to use AI.";
        YesOne.Add(yesoneline0); 

        DialogueLine yesoneline1 = new DialogueLine();
        yesoneline1.SpeakerName = "Narrator";
        yesoneline1.Speech = "Do you only use it for research?.";
        YesOne.Add(yesoneline1); 



        // No 1

        DialogueLine nooneline0 = new DialogueLine();
        nooneline0.SpeakerName = "Narrator";
        nooneline0.Speech = "You chose to not use AI.";
        NoOne.Add(nooneline0); 

        DialogueLine nooneline1 = new DialogueLine();
        nooneline1.SpeakerName = "Narrator";
        nooneline1.Speech = "Do you make a list of your references?.";
        NoOne.Add(nooneline1); 

        // Yes AI For Everything

        

        // Argue
            
        DialogueLine argueline0 = new DialogueLine();
        argueline0.SpeakerName = "Narrator";
        argueline0.Speech = "Mo suspects you use AI.";
        Argue.Add(argueline0); 

        DialogueLine argueline1 = new DialogueLine();
        argueline1.SpeakerName = "Narrator";
        argueline1.Speech = "Do you fight with him?";
        Argue.Add(argueline1); 

        // Win
        
        DialogueLine winline0 = new DialogueLine();
        winline0.SpeakerName = "Narrator";
        winline0.Speech = "Your work is submitted with no suspicions!.";
        Win.Add(winline0); 

        DialogueLine winline1 = new DialogueLine();
        winline1.SpeakerName = "Narrator";
        winline1.Speech = "YOU WIN";
        Win.Add(winline1); 



        // Lose 

        DialogueLine loseline0 = new DialogueLine();
        loseline0.SpeakerName = "Narrator";
        loseline0.Speech = "You get kicked out of class by Mo.";
        Lose.Add(loseline0); 

        DialogueLine loseline1 = new DialogueLine();
        loseline1.SpeakerName = "Narrator";
        loseline1.Speech = "YOU LOSE";
        Lose.Add(loseline1); 


        List<DialogueLine> TheNewList;
        TheNewList = DialoguesDictionary["Intro"];

        // Print the dialogue retrieved from the dictionary with the lists

        for (int i = 0; i < TheNewList.Count; i++)
        {
            TheNewList[i].PrintSpeech();
        }

        //  Get player input

        string answer = Console.ReadLine();
        answer = answer.ToLower();
        
        
        if (answer == "yes")
        {
            TheNewList = DialoguesDictionary["YesOne"];
            
            PlayerChoices.Add("Decision1", answer); // recording their answer
            
             for (int i = 0; i < TheNewList.Count; i++)
             {
                 TheNewList[i].PrintSpeech();
             }
        }
        else if (answer == "no")
        {
            TheNewList = DialoguesDictionary["NoOne"];

            PlayerChoices.Add("Decision1", answer);
            
             for (int i = 0; i < TheNewList.Count; i++)
             {
                 TheNewList[i].PrintSpeech();
             }
        }

        // Q2

        string answer2 = Console.ReadLine();
        answer2 = answer2.ToLower();
        PlayerChoices.Add("Decision2", answer2);

        if (answer2 == "yes")
        {
            TheNewList = DialoguesDictionary["Win"];
        }
        else if (answer2 == "no")
        {
            TheNewList = DialoguesDictionary["Argue"];
        }

        for (int i = 0; i < TheNewList.Count; i++) 
        {
            TheNewList[i].PrintSpeech();
        }

        //  Q3
        
        if (answer2 == "no")
        {
            string answer3 = Console.ReadLine();
            answer3 = answer3.ToLower();
            
            PlayerChoices.Add("Decision3", answer3);
        if (answer3 == "yes")
        {
            TheNewList = DialoguesDictionary["Lose"];
        }
        else if (answer3 == "no")
        {
            TheNewList = DialoguesDictionary["Win"];
        }
            for (int i = 0; i < TheNewList.Count; i++)
            {
                TheNewList[i].PrintSpeech();
            }
}



        // SHow their choices
        
        Console.WriteLine("Your choices were:");
        foreach (KeyValuePair<string, string> choice in PlayerChoices)
        {
            Console.WriteLine(choice.Key + ": " + choice.Value);
        }
    }
}


// Creating Class for Dialogue

 public class DialogueLine
{
    public string SpeakerName;
    public string Speech;
    public void PrintSpeech()
    {
        Console.WriteLine(SpeakerName + ": " + Speech);
    }
}