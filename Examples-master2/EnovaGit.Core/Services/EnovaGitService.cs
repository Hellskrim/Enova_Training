using System.Collections.Generic; 
using EnovaGit.Infrastructure.Models;
using EnovaGit.Infrastructure.Repositories;
using System.Linq;
using EnovaGit.Core.Utils;

namespace EnovaGit.Core.Services
{
    public class EnovaGitService : IEnovaGitService
    { 
        private readonly IEnovaGitRepository _enovaGitRepository;
        private readonly INumericHelper _numericHelper;

        public EnovaGitService(IEnovaGitRepository enovaGitRepository, INumericHelper numericHelper)
        { 
            _enovaGitRepository = enovaGitRepository;
            _numericHelper = numericHelper;
        }

        public IEnumerable<GitDataModel> GetDataSource()
        {
           return _enovaGitRepository.GetCommitsFromGit();
        }

        public decimal GetCommitsAverageForUser(string userLogin)
        {
            var commits = _enovaGitRepository.GetCommitsFromGit();

            var daysCountForUser = commits.Where(y => y.Nazwa == userLogin).GroupBy(r => r.Data).Count();
            var commitsCountForUser = commits.Count(y => y.Nazwa == userLogin);
             
            return _numericHelper.ConverIntToDecimal(commitsCountForUser) / _numericHelper.ConverIntToDecimal(daysCountForUser);
        }
         
    }
}
