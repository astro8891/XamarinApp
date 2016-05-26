using RayHotDogs.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayHotDogs.Core.Repository
{
    class HotDogRepository
    {
        private static List<HotDogGroup> hotDogGroups = new List<HotDogGroup>()
        {
             new HotDogGroup()
             {
                 HotDogGroupId = 1, Title = "Meat Lovers", ImagePath = "", HotDogs = new List<HotDog>()
                 {
                     new HotDog()
                     {
                         HotDogId = 1,
                         Name = "Regular Hot Dog",
                         ShortDescription = "The best there is on this planet",
                         Description = "Manchego smelly cheese danish fontina",
                         ImagePath = "hotdog1",
                         Available = true,
                         PrepTime = 10,
                         Price =8,
                         IsFavorite = true
                     },
                     new HotDog()
                     {

                     }
                 } 

        }
    }
}
