using Core.DataAccess;
using Core.Entities;
using DataAccess.Abstract;
using DataAccess.Context;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete
{
    public class EfUserDal : EfEntityRepositoryBase<User, CarRentalContext>, IUserDal
    {
        public List<OperationClaim> GetClaims(User user)
        {
            using (var context = new CarRentalContext())
            {

                var result = from oc in context.OperationClaims 
                             join uoc in context.userOperationClaims on 
                             oc.Id equals uoc.OperationClaimId
                             where uoc.UserId == user.Id
                             select new OperationClaim { Id= oc.Id, Name = oc.Name, Status=oc.Status };
                return result.ToList();

            }
        }
    }
}
