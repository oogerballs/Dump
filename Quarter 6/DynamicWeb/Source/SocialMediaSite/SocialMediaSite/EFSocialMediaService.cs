using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SocialMediaSite.Models;

namespace SocialMediaSite
{
    public class EFSocialMediaService : ISocialMediaService
    {
        public void CreateImage(Models.Image model)
        {
            using (var context = new SocialMediaEntities1())
            {
                var newImage = new Image()
                {
                    ImageName = model.ImageName,
                    publisher = model.Publisher,
                    caption = model.Caption,
                    ImgSrc = model.ImgSrc,
                    ImageId = model.ImageId,
                    ProfileId = model.ProfileId
                };

                context.Images.Add(newImage);
                context.SaveChanges();
            }
        }

        public void CreateProfile(ProfileModel model, RegisterViewModel singIn)
        {
            AspNetUser theUser = null;
            using (var context = new SocialMediaEntities1())
            {
                theUser = context.AspNetUsers.FirstOrDefault(m => m.Email == singIn.Email);

                var nProfile = new Profile()
                {
                    ProfileName = model.ProfileName,
                    NickName = model.NickName,
                    ProfileImageUrl = model.ProfileImageUrl,
                    UserId = theUser.Id                    
                };
                context.Profiles.Add(nProfile);
                context.SaveChanges();
            }
        }

        public void DeleteImageById(int id)
        {
            using (var context  = new SocialMediaEntities1())
            {
                var ImageToDelete = context.Images.FirstOrDefault(i => i.ImageId == id);

                if(ImageToDelete != null)
                {
                    //Get 'em outta here!
                    context.SaveChanges();
                    //Now Delete that handsome image
                    context.Images.Remove(ImageToDelete);

                    //Make sure to save bud
                    context.SaveChanges();
                }

            }
        }

        public GalleryList GetGalleryList(int PId)
        {
            var res = new GalleryList();
            List <Image> ImageEntites = null;

            using (var context = new SocialMediaEntities1())
            {
                ImageEntites = context.Images.Where(m => m.ProfileId == PId).ToList();
            }

            if (ImageEntites != null)
            {
                foreach(var image in ImageEntites)
                {
                    res.Images.Add(new Models.Image()
                    {
                        ImageId = image.ImageId,
                        ImageName = image.ImageName,
                        ImgSrc = image.ImgSrc,
                        Caption = image.caption,
                        Publisher = image.publisher
                    });
                }
            }

            return res;
        }

        public Models.Image GetImageById(int id)
        {
            Image TheImage = null;
            using (var context = new SocialMediaEntities1())
            {
                TheImage = context.Images.FirstOrDefault(m => m.ImageId == id);
            }

            if (TheImage == null) return null;

            var res = new Models.Image()
            {
                ImageId = TheImage.ImageId,
                ImgSrc = TheImage.ImgSrc,
                ImageName = TheImage.ImageName,
                Publisher = TheImage.publisher,
                Caption = TheImage.caption
            };

            return res;
        }

        public NewsFeed GetNewsFeed(int id)
        {
            NewsFeed News = null;
            using(var context = new SocialMediaEntities1())
            {
                News = context.NewsFeeds.FirstOrDefault(n => n.NewsId == id);
            }

            if (News == null) return null;

            var res = new NewsFeed()
            {
                NewsHeader = News.NewsHeader,
                NewsImageUrl = News.NewsImageUrl,
                NewsBody = News.NewsBody
            };
            return res;
        }

        public ProfileModel GetProfile(String username)
        {
            var res = new ProfileModel();
            Profile theProfile = null;
            List<Favorite> favs = null;
            using (var context = new SocialMediaEntities1())
            {
                theProfile = context.Profiles.FirstOrDefault(p => p.NickName == username);
                favs = context.Favorites.Select(f => f).ToList();
            }
            if(theProfile != null)
            {
                res = new ProfileModel()
                {
                    Id = theProfile.ProfileId,
                    ProfileName = theProfile.ProfileName,
                    NickName = theProfile.NickName,
                    ProfileImageUrl = theProfile.ProfileImageUrl,
                    Favorite = favs
                };

            }
            return res;

        }

        public void UpdateImage(Models.Image model)
        {
            using (var context = new SocialMediaEntities1())
            {
                //Fetch existing entity
                var theImageToUpdate = context.Images.FirstOrDefault(m => m.ImageId == model.ImageId);

                //update entity based on model
                theImageToUpdate.ImageName = model.ImageName;
                theImageToUpdate.publisher = model.Publisher;
                theImageToUpdate.ImgSrc = model.ImgSrc;
                theImageToUpdate.caption = model.Caption;

                //Save changes
                context.SaveChanges();
            }
        }
    }
}