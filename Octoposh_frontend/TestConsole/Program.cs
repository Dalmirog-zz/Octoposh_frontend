using Octokit;
using Octoposh.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var credentials = new Octokit.Credentials("dalmirog", "somepassword");
            var APIconnection = new ApiConnection(new Octokit.Connection(new ProductHeaderValue("DalmiroTesting"))
            {
                Credentials = credentials
            });
            //var APIconnection = new ApiConnection(new Octokit.Connection(new ProductHeaderValue("DalmiroTesting")));
            var repositoryCommitClient = new RepositoryCommitsClient(APIconnection);
                    
            var task = repositoryCommitClient.GetAll("Dalmirog", "Octoposh");            

            Task.WaitAll(task);

            var Contributors = new List<GithubContributor>();

            foreach(var commit in task.Result)
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

            foreach(var c in Contributors)
            {
                Console.WriteLine("User [{0}] commited [{1}]",c.Username ,c.Commits);
            }    
            

        } 
        //static async void getcontributors()
        //{
        //    var connection = new Octokit.Connection(new ProductHeaderValue("DalmiroTesting"));
        //    var client = new GitHubClient(connection);
        //    var repository = client.Repository.Get("octokit", "octokit.net");
        //    Console.WriteLine(repository.FullName);
        //}
    }
}
