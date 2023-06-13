using Business.Abstract;
using Business.Constants;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;
using System.Linq;

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
            IResult rule = BusinessRules.Run(CheckRentalIsDelivered(rental));
            if (rule != null)
            {
                return rule;
            }
            _rentalDal.Add(rental);
            return new SuccessResult(Messages.RentalAdded);
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



        //Rules 

        IResult CheckRentalIsDelivered(Rental rental)
        {
            var checkRental = _rentalDal.GetAll(x=> x.CarId==rental.CarId);
            bool isDelivered = false;
            if (!checkRental.Any())
            {
                return new SuccessResult();
            }
            else if (checkRental.Any())
            {
                foreach (var item in checkRental)
                {
                    if (item.IsDelivered)
                    {
                        isDelivered = item.IsDelivered;
                    }
                    else
                    {
                        isDelivered = item.IsDelivered;
                    }
                }
            }
            if (isDelivered)
            {
                return new SuccessResult();
            }
            return new ErrorResult();
        }
    }
}
