
// See https://aka.ms/new-console-template for more information
Console.WriteLine(@"    ____                      _ __  _            __         ____                  ____          __ 
   / __ \____ __      _______(_) /_(_)   _____  / /_  __   / __ \__  ____________/ __/__  _____/ /_
  / /_/ / __ `/ | /| / / ___/ / __/ / | / / _ \/ / / / /  / /_/ / / / / ___/ ___/ /_/ _ \/ ___/ __/
 / ____/ /_/ /| |/ |/ (__  ) / /_/ /| |/ /  __/ / /_/ /  / ____/ /_/ / /  / /  / __/  __/ /__/ /_  
/_/    \__,_/ |__/|__/____/_/\__/_/ |___/\___/_/\__, /  /_/    \__,_/_/  /_/  /_/  \___/\___/\__/  
                                               /____/                                              ");

List<User> users = new List<User>
{
   new User()
   {
      Name = "Greg Korte",
      Id = 1,
      UserName = "IllumiGregi"
   },

   new User()
   {
      Name = "Sir Purs Alot",
      Id = 2,
      UserName = "PurrfectPants",
   },
   new User()
   {
      Name = "Mister Meows",
      Id = 3,
      UserName = "Meow",
   },
   new User()
   {
      Name = "Dog",
      Id = 4,
      UserName = "Spot",
   },
};


//First(OrDefault)
User mister = users.FirstOrDefault(u => u.Name.StartsWith("mister"));
Console.WriteLine(mister);
//Where
List<string> under3 = users
   .Where(u => u.Id < 3)
   .Select(u => u.Name.ToUpper() + u.Id.ToString())
   .ToList();
foreach (var user in under3)
{
   Console.WriteLine(user);
}
//Select
// List<string> screamedUsers = users;
// foreach (var name in screamedUsers)
// {
//    Console.WriteLine(name);
// }

List<CatMeme> catMemes = new List<CatMeme>
            {
                // Add five CatMemes to the list with Titles, prices, and CatMeme type IDs
               new CatMeme { 
               Title = "Cat Paws", 
               Image = "https://hips.hearstapps.com/hmg-prod/images/cute-cat-photos-1593441022.jpg?crop=0.670xw:1.00xh;0.167xw,0&resize=640:*", 
               Description = "Catch these paws outside.",
               PostDate = DateTime.Parse("2023-08-21")

            },
               new CatMeme { 
                  Title = "Trumpet", 
                  Image = "https://ih1.redbubble.net/image.421079385.0088/poster,504x498,f8f8f8-pad,600x600,f8f8f8.u3.jpg", 
                  Description = "Not to toot my own horn.",
                  PostDate = DateTime.Parse("2023-08-20")
            }
            };
// allow user to choose options until they exit
// 
//Display the menu options
string choice = null;
while (choice != "5")
{
   Console.WriteLine(@"Choose an option
   1.View all Cat Memes
   2.Post Cat Meme
   3.Update Cat Meme
   4.Delete Cat Meme
   5.Exit Menu ");

   //Handle the users choice
   choice = Console.ReadLine();


   switch (choice)
   {
      case "1":
         DisplayMemes();
         break;
      case "2":
         AddMeme();
         break;
      case "3":
         Console.WriteLine("Update Cat Meme");
         break;
      case "4":
         Console.WriteLine("Delete Meme");
         break;
      case "5":
         Console.WriteLine("Goodbye !");
         break;
   }

}

//display a list of all the cat memes
//method that will display list of cat memes
void DisplayMemes()
{
   //get the list, iterate through it
   //each iteration console writeline
   foreach (CatMeme meme in catMemes)
   {
      Console.WriteLine($"{meme.Title}: {meme.Image}");
   }
}

//add a new cat meme to the list

void AddMeme()
{
   //capture info going into the cat meme
   Console.WriteLine("Enter the title for your meme:");
   string memeTitle = Console.ReadLine();
   Console.WriteLine("Enter the image URL for your meme:");
   string memeURL = Console.ReadLine();
   Console.WriteLine("Enter the description for your meme:");
   string memeDescription = Console.ReadLine();
   //create a new cat meme object and put that info in it
   CatMeme newCatMeme = new CatMeme
   {
      Title = memeTitle,
      Image = memeURL,
      Description = memeDescription,
      UserId = 1,
      PostDate = DateTime.Now
   };
   //add the new cat meme to the database
   catMemes.Add(newCatMeme);
}






















// int parsedChoice;
// if (int.TryParse(choice, out parsedChoice))
// {
//    switch (parsedChoice)
//    {
//       case 1:
//          Console.WriteLine("View all cat memes");
//          break;
//    }
// }

// string maybeBool = "Definitely";

// bool parsedBool;
// if (bool.TryParse(maybeBool, out parsedBool))
// {
//    Console.WriteLine("success!");
// }
// else
// {
//    Console.WriteLine("failed!");

// }

//do different options based on the choice the user makes
