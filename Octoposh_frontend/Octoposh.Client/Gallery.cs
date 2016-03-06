using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Octoposh.Client.Model
{
    public class Gallery
    {
        public Gallery()
        {

        }
        public List<GalleryEntry> GetEntries()
        {
            List<GalleryEntry> Entries = new List<GalleryEntry>();

            //Entries.Add(new GalleryEntry {
            //    Version = new Version("0.3.5"),
            //    Downloads = 187,
            //    DatePushed = DateTime.Parse("12/29/2015")                
            //});

            //Entries.Add(new GalleryEntry
            //{
            //    Version = new Version("0.2.72"),
            //    Downloads = 139,
            //    DatePushed = DateTime.Parse("8/23/2015")
            //});

            //Entries.Add(new GalleryEntry
            //{
            //    Version = new Version("0.2.71"),
            //    Downloads = 10,
            //    DatePushed = DateTime.Parse("8/10/2015")
            //});

            //Entries.Add(new GalleryEntry
            //{
            //    Version = new Version("0.2.69"),
            //    Downloads = 6,
            //    DatePushed = DateTime.Parse("8/2/2015")
            //});

            //Entries.Add(new GalleryEntry
            //{
            //    Version = new Version("0.2.66"),
            //    Downloads = 11,
            //    DatePushed = DateTime.Parse("6/7/2015")
            //});

            return Entries;
        }
    }
}
