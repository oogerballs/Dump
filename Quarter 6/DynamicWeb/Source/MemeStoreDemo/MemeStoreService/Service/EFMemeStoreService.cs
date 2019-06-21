using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MemeStoreService.Models;


namespace MemeStoreService.Service
{
    public class EFMemeStoreService : IMemeStoreServicecs
    {
        public void DeleteMemeById(int id)
        {

            using (var context = new MemeStoreEntities())
            {


                var theMemeToDelete = context.Memes.FirstOrDefault(m => m.MemeId == id);

                if (theMemeToDelete != null)
                {
                    //fetch associated comments, so we can delete them!
                    var comments = theMemeToDelete.Comments.ToList();

                    foreach (var comment in comments)
                    {
                        context.Comments.Remove(comment);
                    }
                    //Actually delete all comments
                    context.SaveChanges();
                    //Delete the meme itself
                    context.Memes.Remove(theMemeToDelete);

                    context.SaveChanges();
                }
            }
        }

        public void UpdateMeme(MemeModel model)
        {
            using (var context = new MemeStoreEntities())
            {
                //Fetch existing entity
                var theMemeToUpdate = context.Memes.FirstOrDefault(m => m.MemeId == model.MemeId);
                
                //update entity based on model
                theMemeToUpdate.Name = model.Name;
                theMemeToUpdate.IsDead = model.IsDead;
                theMemeToUpdate.ImageUrl = model.ImageUrl;

                //Save changes
                context.SaveChanges();
            }
        }
       
        public MemeListModel GetAllMemes()
        {
            var res = new MemeListModel();

            List<Meme> memeEntites = null;

            // Use EF to get MemeModels from the Database
            // Unit of Work
            using (var context = new MemeStoreEntities())
            {
                // Fetch the meme Entities!
                memeEntites = context.Memes.Select(m => m).ToList();
            }

            if (memeEntites != null)
            {
                foreach (var meme in memeEntites)
                {
                    res.Memes.Add(new MemeModel()
                    {
                        MemeId = meme.MemeId,
                        Name = meme.Name,
                        ImageUrl = meme.ImageUrl,
                        IsDead = meme.IsDead
                    });
                }
            }

            return res;
        }

        public MemeModel GetMemeById(int id)
        {
            Meme theMeme = null;
            using (var context = new MemeStoreEntities())
            {
                var theMemeToDelete = context.Memes.FirstOrDefault(m => m.MemeId == id);
            }

            if (theMeme == null) return null;

            var res = new MemeModel()
            {
                MemeId = theMeme.MemeId,
                ImageUrl = theMeme.ImageUrl,
                Name = theMeme.Name,
                IsDead = theMeme.IsDead
            };

            return res;

        }

        public ProfileModel GetProfileById(int id)
        {
            throw new NotImplementedException();
        }

        public void CreateMeme(MemeModel model)
        {
            using(var context = new MemeStoreEntities())
            {
                var newMeme = new Meme()
                {
                    Name = model.Name,
                    IsDead = model.IsDead,
                    ImageUrl = model.ImageUrl
                };

                context.Memes.Add(newMeme);
                context.SaveChanges();
            }
        }

        public string GetUserIdByUserName(string username)
        {
            var userId = "";

            //How???
            using(var context = new MemeStoreEntities())
            {
                var theUser = context.aso.FirstOrDefault(u => u.UserName == username);
            }
        }
    }
}
