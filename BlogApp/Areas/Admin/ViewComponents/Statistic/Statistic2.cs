using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace BlogApp.Areas.Admin.ViewComponents.Statistic;

public class Statistic2 : ViewComponent
{
    Context c = new Context();
    public IViewComponentResult Invoke()
    {
        ViewBag.v1 = c.Blogs.OrderByDescending(x => x.BlogID).Select(x => x.BlogTitle).Take(1).FirstOrDefault();

        var blogid = c.Blogs.OrderByDescending(x => x.BlogID).Select(x => x.WriterID).Take(1).FirstOrDefault();
        ViewBag.writer = c.Writers.Where(x => x.WriterID == blogid).Select(x => x.WriterName).FirstOrDefault();

        ViewBag.v2 = c.Contacts.Count();
        ViewBag.v3 = c.Comments.Count();
        return View();
    }
}
