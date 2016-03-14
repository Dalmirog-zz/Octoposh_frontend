using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Octoposh.Client.Model
{
    public class GithubContributor
    {
        public string Username { get; set; }
        public string AvatarURL { get; set; }
        public string UserURL { get; set; }
        public int Commits { get; set; }
    }
}
