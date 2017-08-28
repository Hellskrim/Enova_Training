using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace EnovaGit.Infrastructure.Models
{
    public class GitDataModel
    {
        public int Id { get; set; }
        public string Nazwa { get; set; }
        public DateTime Data { get; set; }
        public string Commit { get; set; }
        public string Branch { get; set; }
        public string Description { get; set; }
    }
}
