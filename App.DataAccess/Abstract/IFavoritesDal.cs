using App.Core.DataAccess;
using App.Core.DataAccess.EntityFramework;
using App.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DataAccess.Abstract
{
    public interface IFavoritesDal:IEntityRepository<Favorite>
    {
    }
}
