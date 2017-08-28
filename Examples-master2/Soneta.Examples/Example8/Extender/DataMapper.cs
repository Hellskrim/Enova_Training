using System.Collections.Generic;
using System.Linq;
using Slapper;

namespace Soneta.Examples.Example8.Extender
{
    public class DataMapper
    {
        public CommitsViewModel ConvertcommitsListToCommitsViewModel(IList<Akcja> list)
        {
            List<Akcja> akcja = new List<Akcja>() {
                    new Akcja() {
                        Id = 1,
                        Nazwa = "test1",
                        //Data = Soneta.Types.Date.Now,
                        Commit = "2af3eeffadads",
                        Branch = "a"
                    },

                    new Akcja() {
                        Id = 2,
                        Nazwa = "test1",
                       // Data = Soneta.Types.Date.Now,
                        Commit = "1afeeffadads",
                        Branch = "a"
                    },

                    new Akcja() {
                        Id = 3,
                        Nazwa = "test1",
                       // Data = Soneta.Types.Date.Now,
                        Commit = "afeefdfadagds",
                        Branch = "b"
                    },
                    new Akcja() {
                        Id = 3,
                        Nazwa = "test1",
                      //  Data = Soneta.Types.Date.Now.AddDays(3),
                        Commit = "afeef4fadadaas",
                        Branch = "a"
                    },

                    new Akcja() {
                        Id = 4,
                        Nazwa = "test2",
                      // Data = Soneta.Types.Date.Now,
                        Commit = "afeeff2asfsdads",
                        Branch = "c"
                    },

                    new Akcja() {
                        Id = 5,
                        Nazwa = "test2",
                      //  Data = Soneta.Types.Date.Now,
                        Commit = "afeefdftadafdds",
                        Branch = "c"
                    },

                    new Akcja() {
                        Id = 1,
                        Nazwa = "test3",
                       // Data = Soneta.Types.Date.Now,
                        Commit = "afeeffffradads",
                        Branch = "c"
                    },

                    new Akcja() {
                        Id = 2,
                        Nazwa = "test3",
                      //  Data = Soneta.Types.Date.Today+1,
                        Commit = "aaafeeffawdads",
                        Branch = "d"
                    },

                    new Akcja() {
                        Id = 3,
                        Nazwa = "test1",
                       // Data = Soneta.Types.Date.Now.AddDays(1),
                        Commit = "afeeadfdfadadss",
                        Branch = "e"
                    },
                }; 
            CommitsViewModel view = new CommitsViewModel();
             
            //view.Commit = new List<Commits>();
             
            var users = akcja.GroupBy(g => g.Nazwa).Select(grp => grp.Key).ToList();
             
            foreach (var u in users)
            {
                view.Login = u;
                //Probowalam tu uzyc automappera ;) nie da sie go zainstaowac dla .net 4.0 ;) - stara wesja enovy najwidoczniej ;)
                view.Commit = akcja.Where(n => n.Nazwa == u).Select(s => new Commits { Data = s.Data, Commit = s.Commit, Branch = s.Branch}).ToList();
            } 

            return view;
        }
    }
}