# Week 3 Advanced Programming

Zoe Efstathiou

2423039

![gif](https://raw.githubusercontent.com/princessbleach/sad-no-ai-task/refs/heads/main/task3.gif)

### Dev Log

#### Process

I began by creating a flowchart to help visualise my choices. This was very rudimentary and simple but helped me to understand where each path would lead. I aimed to create a small story illustrating a classroom scenario with three choices. I could have extended it with ease, by repeating lines of code and creating more lists but I decided to stay simple due to the no AI nature of this task. 

I used lists and dictionaries. The lists were each created at the start of the code, these lists contained the dialogue for each event. To save time coding the "speaker name" and "dialogue line" each time, I created DialogueLine class.  I then created two dictionaries; one to store all the dialogue lists and one to store player choices. Dialogue lists could be easily accessed by a key within the dictionary and used when needed. This also meant I could reuse them if needed. 

I then set which list used using TheNewList and used a for loop to go through each line within the list and print them. I then used ReadLine() to take user input and used .ToLower to change their answer to lowercase. On reflection, I would've liked to implement something which would have rejected incorrect answers (words outside of yes and no) as currently, the program does not know what to do when the player answers incorrectly. I then used if and else if statements to check which answer the player had typed. This would change TheNewList to the next needed scene and also store the answer in the other dictionary. Then, I used another for loop to print every line in the new selected list. 

At the end of the code, I showed which choices they picked using a foreach which prints each dictionary item on a new line in the formatting I chose. 

#### Lists + Dictionaries 

I chose to use lists to store dialogue as lines must be ordered and lists preserve order. This makes it easy to run through lines sequentially. However, I chose to store events in dictionaries as I can randomly select events using a key. I don't need to remember the order within the container or number, I just have to use the key to access them. This is also more optimal than using no dictionary as I can easily reuse events without having to rewrite anything. Ultimately, the code would still work with just if statements, but using lists and dictionaries is far more efficient. My thought process was challenged and I will definitely try to use more efficient structure when moving forward now I understand these better. 

#### Sources

I mainly used the source supplied by Mo in class to help with syntax and structure. I found I could reuse and repeat multiple sections such as the dictionary and list creation.

I also used Microsoft Learn pages to help with syntax. (*See below*)




#### Images 

![flowchart](https://github.com/princessbleach/sad-no-ai-task/blob/main/flowchart.png?raw=true)










## References


Microsoft Learn

https://learn.microsoft.com/en-us/dotnet/api/system.string.tolower?view=net-10.0&utm_source=chatgpt.com

https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2.item?view=net-10.0&utm_source=chatgpt.com

https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/types/classes?utm_source=chatgpt.com

https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/collections?utm_source=chatgpt.com

https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2?view=net-10.0&utm_source=chatgpt.com

Other

https://stackoverflow.com/questions/78972811/using-foreach-loop-on-dictionary

https://www.reddit.com/r/csharp/comments/1c984zk/c_how_to_iterate_over_a_dictionary/