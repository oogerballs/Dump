using MemeStoreService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemeStoreService.Service
{
    public interface IMemeStoreServicecs
    {
        MemeModel GetMemeById(int id);
        MemeListModel GetAllMemes();
        ProfileModel GetProfileById(int id);
        void DeleteMemeById(int id);
        void CreateMeme(MemeModel model);
        string GetUserIdByUserName(String username);
    }
}
