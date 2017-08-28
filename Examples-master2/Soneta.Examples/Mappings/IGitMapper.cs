using Soneta.Examples.Example8.Extender;

namespace Soneta.Examples.Mappings
{
    interface IGitMapper
    {
        CommitsViewModel MappCommitsModelToCommitsViewModelForSelectedUser(string userLogin);
    }
}
                                                                                     