using MemeStoreService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemeStoreService.Service
{
    public class StaticMemeStoreService : IMemeStoreServicecs
    {
       // What service methods might we need? 
       public MemeModel GetMemeById(int id)
        {
            var model = GetAllMemes().Memes.FirstOrDefault(m => m.MemeId == id);
            return model;
        }

        public MemeListModel GetAllMemes()
        {
            var model = new MemeListModel();
            //Statitc memes
            //TODO: Pull these from the Database somehow!
            model.Memes.Add(new MemeModel()
            {
                Name = "Ermagherd",
                ImageUrl = "http://res.cloudinary.com/sagacity/image/upload/c_crop,h_800,w_616,x_0,y_0/c_scale,w_640/v1419879339/iVegJ35_xfjlfu.gif",
                IsDead = true,
                MemeId = 1

            });

            model.Memes.Add(new MemeModel()
            {
                Name = "Doge",
                ImageUrl = "http://res.cloudinary.com/sagacity/image/upload/c_crop,h_800,w_616,x_0,y_0/c_scale,w_640/v1419879339/iVegJ35_xfjlfu.gif",
                IsDead = false,
                MemeId = 2
            });
            return model;
        }

        public ProfileModel GetProfileById(int id)
        {
            return new ProfileModel();
        }

        public void DeleteMemeById(int id)
        {
            throw new NotImplementedException();
        }

        public void CreateMeme(MemeModel model)
        {
            throw new NotImplementedException();
        }

        // TODO: Add a new meme?
    }
}
