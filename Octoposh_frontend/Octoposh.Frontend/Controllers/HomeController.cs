using Octoposh.Client;
using Octokit;
using Octoposh.Client.Model;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Octoposh.Frontend.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ActionResult> Index()
        {
            //Getting Powershell Gallery data to populate the "Releases" table
            var gallery = new Gallery();

            //Getting Github project contributors data to popular the "Contributors" table
            var contributors = new OctoposhContributors();

            var g = gallery.GetEntries();
            var task = contributors.GetAll();

            await Task.WhenAll(task);

            var c = contributors.serializeContributors(task.Result);

            var model = new model()
            {
                Contributors = c,
                GalleryEntries = g

            };

            return View(model);
        }
    }

    public class model
    {
        public List<GithubContributor> Contributors { get; set; }
        public List<GalleryEntry> GalleryEntries { get; set; }
    }
}