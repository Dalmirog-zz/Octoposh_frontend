using Octokit;
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
            var connection = new Octokit.Connection(new ProductHeaderValue("DalmiroTesting"));
            var client = new GitHubClient(connection);
            var task = client.Repository.Get("Dalmirog", "Octoposh");

            Task.WaitAll(task);

            var repository = task.Result;

            Console.WriteLine(repository.SubscribersCount);

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
