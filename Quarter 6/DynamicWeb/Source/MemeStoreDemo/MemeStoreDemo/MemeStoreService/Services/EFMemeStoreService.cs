using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MemeStoreService.Models;

namespace MemeStoreService.Services
{
    public class EFMemeStoreService : IMemeStoreService
    {
        public void DeleteMemeById(int id)
        {
            // UoW
            using(var context = new MemeStoreEntities())
            {
                // Delete from meme where memeid = id
                // Fetch the entity to delete, and remove it from the DBSet
                var theMemeToDelete = context.Memes.FirstOrDefault(m => m.MemeId == id);


                if (theMemeToDelete != null)
                {
                    // Fetch Associated Comments, so we can delete them!
                    var comments = theMemeToDelete.Comments.ToList();

                    foreach(var comment in comments)
                    {
                        context.Comments.Remove(comment);
                    }

                    // Actually Delete All Comments
                    context.SaveChanges();

                    // Delete the meme itself
                    context.Memes.Remove(theMemeToDelete);
                    // REMEMBER this!
                    context.SaveChanges();
                }
            }
        }

        public void UpdateMeme(MemeModel model)
        {
            using(var context = new MemeStoreEntities())
            {
                // Fetch existing entity
                var theMemeToUpdate = context.Memes.FirstOrDefault(m => m.MemeId == model.MemeId);

                // Update entity based on model
                theMemeToUpdate.Name = model.Name;
                theMemeToUpdate.IsDead = model.IsDead;
                theMemeToUpdate.ImageUrl = model.ImageUrl;

                // Save Changes
                context.SaveChanges();
            }
        }

        public MemeListModel GetAllMemes()
        {
            var result = new MemeListModel();

            List<Meme> memeEntities = null;

            // Use EF to get MemeModels from the Database
            // Unit of Work
            using (var context = new MemeStoreEntities())
            {
                // Fetch the Meme Entities!
                memeEntities = context.Memes
                    .Include("Comments") // This loads the comments with the meme
                    .Select(m => m).ToList();
            }

            if(memeEntities != null)
            {
                // Convert Meme Entities to Meme Models
                foreach(var meme in memeEntities)
                {
                    result.Memes.Add(GetMemeModelFromEntity(meme));
                }
            }

            return result;
        }

        public MemeModel GetMemeById(int id)
        {
            Meme theMeme = null;
            using (var context = new MemeStoreEntities())
            {
                theMeme = context.Memes
                    .Include("Comments") // This loads the comments with the meme
                    .FirstOrDefault(m => m.MemeId == id);
            }

            if (theMeme == null) return null;


            return GetMemeModelFromEntity(theMeme);
        }

        public ProfileModel GetProfileById(int id)
        {
            throw new NotImplementedException();
        }

        public void CreateMeme(MemeModel model)
        {
            // USE EF to create a new Meme based on our Meme Model
            using (var context = new MemeStoreEntities())
            {
                // Create an entity for our new record
                var newMeme = new Meme()
                {
                    Name = model.Name,
                    IsDead = model.IsDead,
                    ImageUrl = model.ImageUrl
                };

                context.Memes.Add(newMeme);
                context.SaveChanges();

                // Update the memeid on the model
                model.MemeId = newMeme.MemeId;
            }
        }

        public void AddComment(CommentModel comment)
        {
            // UoW
            using(var context = new MemeStoreEntities()){
                // Fetch the Meme that the comment belongs to
                var theMeme = context.Memes.FirstOrDefault(m => m.MemeId == comment.MemeId);

                // Build the new Comment Entity
                var newComment = new Comment()
                {
                    Text = comment.Text,
                    UserId = comment.UserId
                };

                theMeme.Comments.Add(newComment);
                context.SaveChanges();
            }
            
        }

        // Helper Methods
        public MemeModel GetMemeModelFromEntity(Meme meme)
        {
            // Map from Meme Entity to View Model
            var result = new MemeModel()
            {
                MemeId = meme.MemeId,
                ImageUrl = meme.ImageUrl,
                Name = meme.Name,
                IsDead = meme.IsDead
            };

            if (meme.Comments != null)
            {
                foreach (var comment in meme.Comments)
                {
                    result.Comments.Add(new CommentModel()
                    {
                        MemeId = result.MemeId,
                        Text = comment.Text,
                        UserId = comment.UserId,
                        UserName = GetUserNameByUserId(comment.UserId) // This line fetches the username for the comment's userId
                    });
                }
            }

            return result;
        }

        public string GetUserNameByUserId(string userId)
        {
            var userName = "";

            using (var context = new MemeStoreEntities())
            {
                var theUser = context.AspNetUsers.FirstOrDefault(u => u.Id == userId);

                if (theUser != null)
                {
                    userName = theUser.UserName;
                }
            }

            return userName;
        }

        public string GetUserIdByUserName(string username)
        {
            var userId = "";

            using(var context = new MemeStoreEntities())
            {
                var theUser = context.AspNetUsers.FirstOrDefault(u => u.UserName == username);

                if(theUser != null)
                {
                    userId = theUser.Id;
                }
            }

            return userId;
        }

        public MemeModel GetFeaturedMeme()
        {
            using(var context = new MemeStoreEntities())
            {
                var featuerdMemes = context.Memes.Where(m => m.IsFeatured == true).ToList();
                if (featuerdMemes.Count == 0) return null;
                return GetMemeModelFromEntity(featuerdMemes[0]);
            }
        }
    }
}
