using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class ArticleManager : IArticleService
    {
        private IArticleDal _articleDal;

        public ArticleManager(IArticleDal articleDal)
        {
            _articleDal = articleDal;
        }

        public IResult Add(Article article)
        {
            //business code            
            _articleDal.Add(article);
            return new SuccessResult("Ürün başarıyla kaydedildi");

        }

        public IResult Delete(Article article)
        {
            _articleDal.Delete(article);
            return new SuccessResult("Ürün başarıyla silindi");
        }

        public IDataResult<Article> GetById(int articleId)
        {
            return new SuccessDataResult<Article>(_articleDal.Get(p => p.ArticleID == articleId));

        }

        public IDataResult<List<Article>> GetList()
        {
            return new SuccessDataResult<List<Article>>(_articleDal.GetList().ToList());

        }

        public IResult Update(Article article)
        {
            //business code            
            _articleDal.Update(article);
            return new SuccessResult("Ürün başarıyla güncellendi");
        }
    }
}
