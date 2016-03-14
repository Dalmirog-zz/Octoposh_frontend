using Octokit;
using Octoposh.Client.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Octoposh.Client
{
    public class OctoposhContributors
    {
        public OctoposhContributors()
        {
            string GithubLogin = ConfigurationManager.AppSettings["GithubLogin"];
            string GithubPassword = ConfigurationManager.AppSettings["GithubPassword"];

            credentials = new Octokit.Credentials(GithubLogin,GithubPassword);

            apiConnection = new ApiConnection(new Connection(new ProductHeaderValue("Octoposh"))
            {
                Credentials = credentials
            });
            
        }

        public async Task<IReadOnlyList<GitHubCommit>> GetAll()
        {
            string GithubLogin = ConfigurationManager.AppSettings["GithubLogin"];
            string GithubPassword = ConfigurationManager.AppSettings["GithubPassword"];



            var repositoryCommitClient = new RepositoryCommitsClient(apiConnection);

            var task = await repositoryCommitClient.GetAll("Dalmirog", "Octoposh");

            return task;
        }

        public List<GithubContributor> serializeContributors(IReadOnlyList<GitHubCommit> result)
        {
            var Contributors = new List<GithubContributor>();

            foreach (var commit in result)
            {
                if (Contributors.Exists(x => x.Username == commit.Committer.Login))
                {
                    Contributors.Find(x => x.Username == commit.Committer.Login).Commits++;
                }
                else
                {
                    GithubContributor contributor = new GithubContributor()
                    {
                        Username = commit.Committer.Login,
                        AvatarURL = commit.Committer.AvatarUrl,
                        Commits = 0,
                        UserURL = commit.Committer.HtmlUrl
                    };

                    Contributors.Add(contributor);
                }
            }

            return Contributors;
        }

        private Credentials credentials;
        private ApiConnection apiConnection;
    }
}
