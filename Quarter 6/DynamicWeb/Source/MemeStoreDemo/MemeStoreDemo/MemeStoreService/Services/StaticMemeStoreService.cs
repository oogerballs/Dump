using MemeStoreService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemeStoreService.Services
{
    public class StaticMemeStoreService : IMemeStoreService
    {
        // What Service Methods Might we Need?
        public MemeModel GetMemeById(int id)
        {
            // TODO: In real service, fetch the meme from the DB using EF
            var model = GetAllMemes().Memes.FirstOrDefault(m => m.MemeId == id);
            return model;
        }

        public MemeListModel GetAllMemes()
        {
            var model = new MemeListModel();

            // Static Memes
            // TODO: Pull these from the Database somehow!
            model.Memes.Add(new MemeModel()
            {
                MemeId = 1,
                Name = "Ermagherd",
                IsDead = false,
                ImageUrl = "https://i.kym-cdn.com/entries/icons/original/000/009/479/Ermahgerd.jpg"
            });

            model.Memes.Add(new MemeModel()
            {
                MemeId = 2,
                Name = "Doge",
                IsDead = true,
                ImageUrl = "http://res.cloudinary.com/sagacity/image/upload/c_crop,h_800,w_616,x_0,y_0/c_scale,w_640/v1419879339/iVegJ35_xfjlfu.gif"
            });

            model.Memes.Add(new MemeModel()
            {
                MemeId = 3,
                Name = "Grumpy Cat",
                IsDead = false,
                ImageUrl = "https://www.lifewire.com/thmb/LxxpdFM9jKzGc0_KstO1a07CVLQ=/1024x0/filters:no_upscale():max_bytes(150000):strip_icc():format(webp)/tardarsauce-56a6a47d5f9b58b7d0e41bf6.jpg"
            });

            model.Memes.Add(new MemeModel()
            {
                MemeId = 4,
                Name = "Rick Roll",
                IsDead = false,
                ImageUrl = "https://www.lifewire.com/thmb/gMcrpOBLh__c21FxbbNrtMT0cf8=/1200x0/filters:no_upscale():max_bytes(150000):strip_icc():format(webp)/Rick-Roll-5705167e5f9b581408bf21d1.jpg"
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

        public void AddComment(CommentModel comment)
        {
            throw new NotImplementedException();
        }

        public string GetUserIdByUserName(string username)
        {
            throw new NotImplementedException();
        }

        public MemeModel GetFeaturedMeme()
        {
            throw new NotImplementedException();
        }

        public string GetUserNameByUserId(string userId)
        {
            throw new NotImplementedException();
        }

        // TODO: Add a new meme?
    }
}
