using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Soneta.Examples.Example8.Extender
{
    public  class CommitsViewModel
    { 
        public string Login { get; set; }
        public decimal CommitsAverage { get; set; }
        public IList<Commits> Commit { get; set; } 
    }

    public class Commits
    {
        public Types.Date Data { get; set; }
        public string Commit { get; set; }
        public string Branch { get; set; }
        
    }
}
