using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Option02.Core
{
    public interface IApplicantAddressRepository
    {
        void Add(ApplicantAddress A);

        void Edit(ApplicantAddress A);

        void Remove(int Id);

        IEnumerable<ApplicantAddress> GetAddresses();

        ApplicantAddress FindById(int Id);
    }
}
