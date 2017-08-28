using System.Collections.Generic;
using System.Linq;
using Soneta.Business.UI;   

namespace Soneta.Examples.Example8.Extender {

    public class Notowania { 
        List<Akcja> akcja = new List<Akcja>() {
                    new Akcja() {
                        Id = 1,
                        Nazwa = "test1",
                        Data = Soneta.Types.Date.Now,
                        Commit = "2af3eeffadads",
                        Branch = "a" 
                    },

                    new Akcja() {
                        Id = 2,
                        Nazwa = "test1",
                        Data = Soneta.Types.Date.Now,
                        Commit = "1afeeffadads",
                        Branch = "a"
                    },

                    new Akcja() {
                        Id = 3,
                        Nazwa = "test1",
                        Data = Soneta.Types.Date.Now,
                        Commit = "afeefdfadagds",
                        Branch = "b"
                    },
                    new Akcja() {
                        Id = 3,
                        Nazwa = "test1",
                        Data = Soneta.Types.Date.Now.AddDays(3),
                        Commit = "afeef4fadadaas",
                        Branch = "a"
                    },

                    new Akcja() {
                        Id = 4,
                        Nazwa = "test2",
                       Data = Soneta.Types.Date.Now,
                        Commit = "afeeff2asfsdads",
                        Branch = "c"
                    },

                    new Akcja() {
                        Id = 5,
                        Nazwa = "test2",
                        Data = Soneta.Types.Date.Now,
                        Commit = "afeefdftadafdds",
                        Branch = "c"
                    },

                    new Akcja() {
                        Id = 1,
                        Nazwa = "test3",
                        Data = Soneta.Types.Date.Now,
                        Commit = "afeeffffradads",
                        Branch = "c"
                    },

                    new Akcja() {
                        Id = 2,
                        Nazwa = "test3",
                        Data = Soneta.Types.Date.Today+1,
                        Commit = "aaafeeffawdads",
                        Branch = "d"
                    },

                    new Akcja() {
                        Id = 3,
                        Nazwa = "test1",
                        Data = Soneta.Types.Date.Now.AddDays(1),
                        Commit = "afeeadfdfadadss",
                        Branch = "e"
                    },
                };
       

        public IEnumerable<Akcja> AktualneNotowania { 
            get {
               // akcja.GroupBy(u => u.Nazwa).Select(grp => grp.ToList()).ToList();
                return akcja;
            }
        }
          
        public decimal GetCommitsAverageForUser(string userLogin = "test1")
        {
            var daysCountForUser = akcja.Where(y => y.Nazwa == userLogin).GroupBy(r => r.Data).Count();
            var commitsCountForUser = akcja.Count(y => y.Nazwa == userLogin);

            decimal correctNumber = (decimal)daysCountForUser / 100;
            decimal correctNumber1 = (decimal)commitsCountForUser / 100;

            return correctNumber1 / correctNumber;
        }
         
       
        public decimal CommitsAverageForDay { get; set; }
        public string Date { get; set; }
        public string Login { get; set; }
        public GridElement Grid = new GridElement();

        public class GridData
        {
            public string Commit { get; set; }
            public string Branch { get; set; }
        }

        public CommitsViewModel ConvertcommitsListToCommitsViewModel(IList<Akcja> list)
        {
            CommitsViewModel view = new CommitsViewModel();
            view.Commit = new List<Commits>();

           
            akcja.GroupBy(g => g.Nazwa).Select(grp => grp.ToList());

            ////////////

            foreach (var n in akcja.Select(x=>x.Nazwa))
            {
                view.Login = n;
            }
            
            ////////////
            
            return view; 
        }

        public UIElement GetSource()
        {
             
            var labelName = new LabelElement();

            var labelAverage = new LabelElement();

            var stack = new StackContainer();
            var group = new GroupContainer { CaptionHtml = "Tytuł grupy", LabelHeight = "10" };
            var row = new RowContainer();
            var rowCmd = new RowContainer();

            //create grid 
            IList<GridData> gridData = new List<GridData>(); 
            Grid.EditValue = "{gridData}";

            //create header
            Login = "test1";
            CommitsAverageForDay = GetCommitsAverageForUser(Login);
            //



            var field1 = new FieldElement { CaptionHtml = "Pole 1", EditValue = "{Field1}", OuterWidth = "30" };
             var command = new CommandElement { CaptionHtml = "Pokaż wartości", MethodName = "ShowFieldValue", Width = "20" };

            row.Elements.Add(field1); 
            rowCmd.Elements.Add(command);

            group.Elements.Add(row);
            group.Elements.Add(rowCmd);
            stack.Elements.Add(group);

            return stack;

        }

        public MessageBoxInformation ShowFieldValue()
        {
            return new MessageBoxInformation("Aktualne wartości")
            {
               // Text = String.Format("Pole1 = {0}, Pole2 = {1}, Pole3 = {2}", Field1, Field2, Field3)
            };
        }

    }

}
