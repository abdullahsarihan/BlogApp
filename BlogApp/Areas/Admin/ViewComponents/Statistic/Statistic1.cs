using System.Xml.Linq;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BlogApp.Areas.Admin.ViewComponents.Statistic;

public class Statistic1 : ViewComponent
{
    BlogManager bm = new BlogManager(new EfBlogRepository());
    Context c = new Context();
    public IViewComponentResult Invoke()
    {
        ViewBag.v1 = bm.GetList().Count();
        ViewBag.v2 = c.Contacts.Count();
        ViewBag.v3 = c.Comments.Count();

        string api = "a033d18aafb5c07892d60c8a85183471";
        string connection = "https://api.openweathermap.org/data/2.5/weather?q=ankara&mode=xml&appid=" + api + "&units=metric&lang=tr";
        XDocument document = XDocument.Load(connection);
        ViewBag.v4 = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;
        return View();
    }
}
