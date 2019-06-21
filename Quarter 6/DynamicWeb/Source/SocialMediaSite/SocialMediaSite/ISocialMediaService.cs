using SocialMediaSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SocialMediaSite
{
    public interface ISocialMediaService
    {
        Models.Image GetImageById(int id);
        GalleryList GetGalleryList(int PId);
        ProfileModel GetProfile(String username);
        NewsFeed GetNewsFeed(int id);
        void DeleteImageById(int id);
        void CreateImage(Models.Image model);
        void UpdateImage(Models.Image model);
        void CreateProfile(ProfileModel model, RegisterViewModel singIn);

    }
}