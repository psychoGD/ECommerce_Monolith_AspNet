using App.Business.Abstract;
using App.DataAccess.Abstract;
using App.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Business.Concrete
{
    public class FavoriteService : IFavoriteService
    {
        private IFavoritesDal _favoritesDal;

        public FavoriteService(IFavoritesDal favoritesDal)
        {
            this._favoritesDal = favoritesDal;
        }

        public void Add(Favorite favorite)
        {
            _favoritesDal.Add(favorite);
        }

        public void Delete(int Id)
        {
            _favoritesDal.Delete(_favoritesDal.Get(f => f.FavoritesId == Id));
        }

        public List<Favorite> GetAll()
        {
            return _favoritesDal.GetList();
        }
    }
}
