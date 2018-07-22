using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Option02.Core;

namespace Option02.Infrastructure
{
  public class ApplicantAddressRepository: IApplicantAddressRepository
    {
        ApplicantContext context = new ApplicantContext();
        public void Add(ApplicantAddress A)
        {
            context.Addresses.Add(A);
            context.SaveChanges();
        }
        public void Edit(ApplicantAddress A)
        {
            context.Entry(A).State = System.Data.Entity.EntityState.Modified;
        }

        public ApplicantAddress FindById(int Id)
        {
            var result = (from r in context.Addresses where r.Id == Id select r).FirstOrDefault();
            return result;
        }

        public IEnumerable<ApplicantAddress> GetAddresses()
        {
            return context.Addresses;
        }

        public void Remove(int Id)
        {
            ApplicantAddress A = context.Addresses.Find(Id);
            context.Addresses.Remove(A);
            context.SaveChanges();
        }


    }
}
