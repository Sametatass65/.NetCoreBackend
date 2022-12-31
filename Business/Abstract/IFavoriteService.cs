using Core.Utilities.Result.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IFavoriteService
    {
        IDataResult<List<FavoriteProductsDto>> GetByUserId(int userId);
        IDataResult<List<Favorite>> GetAll();
        IResult Add(Favorite favorite);
        IResult Update(Favorite favorite);
        IResult Delete(Favorite favorite);
    }
}
