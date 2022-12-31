using Business.Abstract;
using Business.Constants;
using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class FavoriteManager : IFavoriteService
    {
        IFavoriteDal _favoriteDal;
        public FavoriteManager(IFavoriteDal favoriteDal)
        {
            _favoriteDal = favoriteDal;
        }

        public IResult Add(Favorite favorite)
        {
            _favoriteDal.Add(favorite);
            return new SuccessResult(Messages.FavorityAdded);
        }

        public IResult Delete(Favorite favorite)
        {
            _favoriteDal.Delete(favorite);
            return new SuccessResult(Messages.FavorityDeleted);
        }

        public IDataResult<List<Favorite>> GetAll()
        {
            return new SuccessDataResult<List<Favorite>>(_favoriteDal.GetAll(),Messages.FavoriteGetAll);
        }

        public IDataResult<List<FavoriteProductsDto>> GetByUserId(int userId)
        {
            return new SuccessDataResult<List<FavoriteProductsDto>>(_favoriteDal.GetFavoriteProducts(userId), Messages.UsersFavorite);
        }
        public IResult Update(Favorite favorite)
        {
            _favoriteDal.Update(favorite);
            return new SuccessResult(Messages.FavoriteUpdated);
        }
    }
}
