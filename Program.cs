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
   }
};


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
