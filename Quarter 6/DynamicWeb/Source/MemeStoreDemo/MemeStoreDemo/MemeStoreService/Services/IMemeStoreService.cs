using MemeStoreService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemeStoreService.Services
{
    public interface IMemeStoreService
    {
        MemeModel GetMemeById(int id);
        MemeListModel GetAllMemes();
        ProfileModel GetProfileById(int id);
        void DeleteMemeById(int id);

        void CreateMeme(MemeModel model);
        void AddComment(CommentModel comment);
        string GetUserIdByUserName(string username);
        MemeModel GetFeaturedMeme();
        string GetUserNameByUserId(string userId);
    }
}
