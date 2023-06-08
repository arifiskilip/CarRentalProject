using Business.Abstract;
using Business.Aspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;
        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }
        [SecuredOperation("admin")]
        [ValidationAspect(typeof(ColorValidator))]
        public IResult Add(Color color)
        {
            _colorDal.Add(color);
            return new SuccessResult();
        }

        public IResult Delete(Color color)
        {
            _colorDal.Delete(color);
            return new SuccessResult();
        }

        public IDataResult<List<Color>> GetAll()
        {
            var result = _colorDal.GetAll();
            return new SuccessDataResult<List<Color>>(result);
        }

        public IDataResult<Color> GetByColorId(int id)
        {
            var result = _colorDal.Get(x=> x.Id==id);
            if (result==null)
            {
                return new ErrorDataResult<Color>(result,"Renk mevcut değil.");
            }
            return new SuccessDataResult<Color>(result,"Renkler Listelendi.");
        }

        public IResult Update(Color color)
        {
            _colorDal.Update(color);
            return new SuccessResult();
        }
    }
}
