using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VuThuan_2080600058.Models;

namespace VuThuan_2080600058.Views.ViewModels
{
    public class CourseViewModels
    {
        public string Place { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public DateTime GetDateTime()
        {
            return DateTime.Parse(string.Format("{0} {1}", Date, Time));
        }
    }
}