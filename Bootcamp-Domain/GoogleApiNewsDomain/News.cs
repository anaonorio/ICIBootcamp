using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp_Domain.GoogleApiNewsDomain
{
    public class News
    {
        public string status { get; set; }
        public int totalResults { get; set; }
        public IEnumerable<Articles> articles { get; set; }
    }
}
