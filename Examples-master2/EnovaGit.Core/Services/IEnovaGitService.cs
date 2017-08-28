using System.Collections.Generic; 
using EnovaGit.Infrastructure.Models; 

namespace EnovaGit.Core.Services
{
    public interface IEnovaGitService
    {
        IEnumerable<GitDataModel> GetDataSource();
    }
}
