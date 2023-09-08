using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete;
public class NewsLetterManager : INewsLetterService
{
    INewsLetterDal _newsletterDal;

    public NewsLetterManager(INewsLetterDal newsletterDal)
    {
        _newsletterDal = newsletterDal;
    }

    public void AddNewsLetter(NewsLetter newsletter)
    {
        _newsletterDal.Insert(newsletter);
    }
}
