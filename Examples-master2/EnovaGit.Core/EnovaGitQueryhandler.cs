using System.Collections.Generic;
using Autofac;
using EnovaGit.Core.Services;
using EnovaGit.Infrastructure.Models;
using MediatR;

namespace EnovaGit.Core
{
    class EnovaGitQueryHandler<TRequest, TResponse> : IRequestHandler<TRequest, IEnumerable<GitDataModel>> where TRequest : IRequest<IEnumerable<GitDataModel>>
    { 
        public IEnumerable<GitDataModel> Handle(TRequest message)
        {
            IEnovaGitService enovaGitService = CreateServiceObjectInstance();
            return enovaGitService.GetDataSource();
        }

        private IEnovaGitService CreateServiceObjectInstance()
        {
            AutofacConfiguration.AutofacConfiguration.RegisterAndResolve();  
            var container = AutofacConfiguration.AutofacConfiguration.RegisterAndResolve();
            return container.Resolve<EnovaGitService>();
        }
    }

    public class DataSourceRequest : IRequest<IEnumerable<GitDataModel>>
    { 
    }
     
}
