using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using PersonalityTest.Models;
using PtEFLib;
using TestEF;

namespace PersonalityTest.Controllers
{
    public class ValuesController : ApiController
    {
        [HttpGet]
        public List<Survey> GetQuestionList()
        {
            using (PTDbContext db = new PTDbContext())
            {
                List<Survey> questions = db.Questions.OrderBy(x => x.QuestionNo)
                   .Select(x => new Survey()
                   {
                       QuestionId = x.QuestionId,
                       QuestionNo = x.QuestionNo,
                       QuestionText = x.QuestionText

                   }).ToList();

                foreach (var q in questions)
                {
                    q.QOptions = db.Options
                        .Where(x => x.QuestionId == q.QuestionId)
                        .OrderBy(x => x.Letter).ToList();
                }
                return questions;
            }

        }
        [HttpGet]
        public List<Kategori> x(){
            using (var dbtest = new TestEF.DenemeEntities())
            {
                var list = dbtest.Kategoris.Where(a => a.UstId == null).ToList();
                return list;

             }
        }

        [HttpGet]
        public List<UrunP> y()
        {
            using (var dbtest = new TestEF.DenemeEntities())
            {
                var kategori = dbtest.Kategoris.FirstOrDefault(a => a.KategoriId == 3);
                var UrunList = kategori.Uruns.ToList();

                var s = (from a in dbtest.Kategoris
                         join b in dbtest.Uruns
                         on a.KategoriId equals b.KategoriId
                         where a.KategoriId == 3
                         select new UrunP
                         {
                             UrunId = b.UrunId,
                             UrunAdi = b.UrunAdi,
                             KategoriId = b.KategoriId,
                             KategoriAdi = a.KategoriAdi
                         }).ToList();
                         
                return s;

            }
        }
    }
}
