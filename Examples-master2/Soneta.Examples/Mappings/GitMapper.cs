using Soneta.Examples.Example8.Extender;

namespace Soneta.Examples.Mappings
{
    public class GitMapper
    {
        public CommitsViewModel MappCommitsModelToCommitsViewModelForSelectedUser(string userLogin)
        {
            
            return  new CommitsViewModel();
        }
    }
}