﻿using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BlogApp.ViewComponents.Writer;

public class WriterAboutOnDashboard : ViewComponent
{
    WriterManager writermanager = new WriterManager(new EfWriterRepository());

    Context c = new Context();
    public IViewComponentResult Invoke()
    {
        var username = User.Identity.Name;
        ViewBag.veri = username;
        var usermail = c.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
        var writeID = c.Writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterID).FirstOrDefault();
        var values = writermanager.GetWriterById(writeID);
        return View(values);
    }
}
