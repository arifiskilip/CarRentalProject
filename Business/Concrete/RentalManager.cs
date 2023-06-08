using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;
        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }
        public IResult Add(Rental rental)
        {
            var result = _rentalDal.Get(c => c.CarId == rental.CarId);
            if (result == null || result.IsDelivered != false)
            {
                _rentalDal.Add(rental);
                return new SuccessResult(Messages.RentalAdded);
            }
            return new ErrorResult(Messages.RentalInvalid);
        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.RentalDeleted);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            var result = _rentalDal.GetAll();
            return new SuccessDataResult<List<Rental>>(result,Messages.RentalListed);
        }

        public IDataResult<Rental> GetById(int id)
        {
            var result = _rentalDal.Get(x => x.Id == id);
            if (result == null)
            {
                return new ErrorDataResult<Rental>(result,Messages.RentalNotFound);
            }
            return new SuccessDataResult<Rental>(result,Messages.RentalDeleted);
        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.RentalUpdated);
        }
    }
}
