using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IArticleService
    {
        IDataResult<Article> GetById(int articleId);

        IDataResult<List<Article>> GetList();

        IResult Add(Article article);

        IResult Delete(Article article);

        IResult Update(Article article);
    }
}
