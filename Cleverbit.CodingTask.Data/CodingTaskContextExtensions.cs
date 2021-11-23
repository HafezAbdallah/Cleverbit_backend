using Cleverbit.CodingTask.Data.Models;
using Cleverbit.CodingTask.Utilities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cleverbit.CodingTask.Data
{
    public static class CodingTaskContextExtensions
    {
       
        public static async Task Initialize(this CodingTaskContext context, IHashService hashService)
        {
            await context.Database.EnsureCreatedAsync();
            bool anyDbChanges = false;

            #region Constants Users

             User USER_1 =new User
            {
                UserName = "User1",
                Password = await hashService.HashText("Password1")
            };
            User USER_2 = new User
            {
                UserName = "User2",
                Password = await hashService.HashText("Password2")
            };
            User USER_3 = new User
            {
                UserName = "User3",
                Password = await hashService.HashText("Password3")
            };
            User USER_4 = new User
            {
                UserName = "User4",
                Password = await hashService.HashText("Password4")
            };

            #endregion

            #region intilize users

            var currentUsers = await context.Users.ToListAsync();

            if (!currentUsers.Any(u => u.UserName == "User1"))
            {
                context.Users.Add(USER_1);

                anyDbChanges = true;
            }

            if (!currentUsers.Any(u => u.UserName == "User2"))
            {
                context.Users.Add(USER_2);

                anyDbChanges = true;
            }

            if (!currentUsers.Any(u => u.UserName == "User3"))
            {
                context.Users.Add(USER_3);

                anyDbChanges = true;
            }

            if (!currentUsers.Any(u => u.UserName == "User4"))
            {
                context.Users.Add(USER_4);

                anyDbChanges = true;
            }
            #endregion

            #region Intilize PreDefiend Matches

            var currentMatches = await context.Matches.ToListAsync();

            if (currentMatches.Count==0)
            {
                
                context.Matches.Add(new Match
                {
                    Players =new List<User> {USER_1,USER_2 },
                    Timestamp = System.DateTime.Now.AddMinutes(15)
                });

                context.Matches.Add(new Match
                {
                    Players = new List<User> { USER_2, USER_3 },
                    Timestamp = System.DateTime.Now.AddMinutes(15),
                    Winner=USER_3
                });

                anyDbChanges = true;
            }
            #endregion
            if (anyDbChanges)
            {
                await context.SaveChangesAsync(); 
            }
        }
    }
}
