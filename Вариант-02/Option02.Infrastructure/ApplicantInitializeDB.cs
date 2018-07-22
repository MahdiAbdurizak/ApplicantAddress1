using Option02.Core;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Option02.Infrastructure
{
    public class ApplicantInitializeDB : DropCreateDatabaseIfModelChanges<ApplicantContext>
    {
        protected override void Seed(ApplicantContext context)
        {
            context.Addresses.Add(new ApplicantAddress
            {
                Id = 1,
                Address1 = "ул. Красная",
                Address2 = "д.45",
                Address3 = "K1",
                Address4 = "кв. 111",
                город = "Пермь",
                Край_Область = "Пермский край"

            });
            context.Addresses.Add(new ApplicantAddress
            {
                Address1 = "ул. Синяя",
                Address2 = "д.42",
                Address3 = "K5",
                Address4 = "кв. 12",
                

            });
            context.SaveChanges();

            base.Seed(context);
        }
    }
}
