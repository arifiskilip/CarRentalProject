using Core.Entities;
using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IUserService
    {
        IResult Add(User user);
        IResult Delete(User user);
        IResult Update(User user);
        IDataResult<List<User>> GetAll();
        IDataResult<User> GetByUserId(int userId);
        List<OperationClaim> GetClaims(User user);
        User GetByMail(string email);
    }
}
