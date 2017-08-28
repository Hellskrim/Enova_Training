using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnovaGit.Infrastructure.Models;

namespace EnovaGit.Infrastructure.Repositories
{
    public interface IEnovaGitRepository
    {
        /// <summary>
        /// Pobierze commity z wszystkich branchy zdalnych
        /// </summary>
        /// <returns></returns>
        IQueryable<GitDataModel> GetCommitsFromGit();

        /// <summary>
        /// Pobierze nam commity z brancha lokalnego, jeśli takowe istnieją. Wiadomym jest, że branch developerski nie jest branchem zdalnym
        /// </summary>
        /// <returns></returns>
        IQueryable<GitDataModel> GetCommitsFromDevBranch();
    }
}
