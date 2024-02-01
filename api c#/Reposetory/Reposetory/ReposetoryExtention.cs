using Reposetory.Entity;
using Reposetory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reposetory.Reposetory
{
    public static class ReposetoryExtention
    {

        public static IserviceColection AddReposetory(this IserviceColection service)
        {
            service.addScoped(typeof(IReposetory<Property>), typeof(PropertyReposetory));
            service.addScoped(typeof(IReposetory<>), typeof(PropertyReposetory));
            service.addScoped(typeof(IReposetory<Property>), typeof(PropertyReposetory));
        }
    }
}
