using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AotWebsite.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string ProjectTitle { get; set; }
        public int YearReleased { get; set; }
        public string DescriptionHtml { get; set; }
        public Developer[] Developers { get; set; }
        public bool Released { get; set; }

        //note that this value is readonly (can not be set because it has no setter) can only be gotten
        public string DisplayText
        {
            get
            {
                return ProjectTitle + " :" + YearReleased;
            }
        }

            //file names for images should follow a convention that allows them to be dynamically called based on the information in the model.
            //e.g. for the ComicBook example the patter follows <series-title-issuenumber.jpg>
            //By saving image files (or other source files) as such it makes it very easy to call them with a dynamic variable
            //e.g. Each model can have a string named <imageName> that concatonates the information and then can be used to
            //call the desired image

            //obviously this method will not work until I have each project set up with a corresponding jpg.
            public string CoverImageFileName
        {
            get
            {
                return ProjectTitle.Replace(" ", "-").ToLower() + "-" + YearReleased + ".jpg";
            }
        }
    }
}