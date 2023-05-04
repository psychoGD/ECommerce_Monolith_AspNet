using App.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Business.Abstract
{
    public interface IFavoriteService
    {
        public List<Favorite> GetAll();
        public void Add(Favorite favorite);
        public void Delete(int Id);
    }
}
