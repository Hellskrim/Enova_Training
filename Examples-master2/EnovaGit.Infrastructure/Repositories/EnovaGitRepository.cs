using System.Collections.Generic;
using System.Linq;
using EnovaGit.Infrastructure.Models; 

namespace EnovaGit.Infrastructure.Repositories
{ 
    public class EnovaGitRepository : IEnovaGitRepository
    {  
        public IQueryable<GitDataModel> GetCommitsFromGit()
        {
            return gitModel.AsQueryable(); //TODO
        }

        public IQueryable<GitDataModel> GetCommitsFromDevBranch()
        {
            return gitModel.AsQueryable(); //TODO
        }

        //TODO
        List<GitDataModel> gitModel = new List<GitDataModel>() {
                    new GitDataModel() {
                        Id = 1,
                        Nazwa = "test1",
                        Data = System.DateTime.Now,
                        Commit = "2af3eeffadads",
                        Branch = "a" 
                    },

                    new GitDataModel() {
                        Id = 2,
                        Nazwa = "test1",
                        Data = System.DateTime.Now,
                        Commit = "1afeeffadads",
                        Branch = "a"
                    },

                    new GitDataModel() {
                        Id = 3,
                        Nazwa = "test1",
                        Data = System.DateTime.Now,
                        Commit = "afeefdfadagds",
                        Branch = "b"
                    },
                    new GitDataModel() {
                        Id = 3,
                        Nazwa = "test1",
                        Data = System.DateTime.Now.AddDays(3),
                        Commit = "afeef4fadadaas",
                        Branch = "a"
                    },

                    new GitDataModel() {
                        Id = 4,
                        Nazwa = "test2",
                       Data = System.DateTime.Now,
                        Commit = "afeeff2asfsdads",
                        Branch = "c"
                    },

                    new GitDataModel() {
                        Id = 5,
                        Nazwa = "test2",
                        Data = System.DateTime.Now,
                        Commit = "afeefdftadafdds",
                        Branch = "c"
                    },

                    new GitDataModel() {
                        Id = 1,
                        Nazwa = "test3",
                        Data = System.DateTime.Now,
                        Commit = "afeeffffradads",
                        Branch = "c"
                    },

                    new GitDataModel() {
                        Id = 2,
                        Nazwa = "test3",
                        Data = System.DateTime.Now.AddDays(1),
                        Commit = "aaafeeffawdads",
                        Branch = "d"
                    },

                    new GitDataModel() {
                        Id = 3,
                        Nazwa = "test1",
                        Data = System.DateTime.Now.AddDays(1),
                        Commit = "afeeadfdfadadss",
                        Branch = "e"
                    },
                };
    }
}