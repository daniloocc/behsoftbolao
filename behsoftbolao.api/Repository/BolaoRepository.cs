using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BehSoft.DataAccess.Repository.IRepository;
using behsoftbolao.api.Data;
using Core.Models;


namespace BehSoft.DataAccess.Repository;

public class BolaoRepository : Repository<Bolao>, IBolaoRepository
{
    private BolaoDbContext _db;
    public BolaoRepository(BolaoDbContext db):base(db)
    {
        _db = db;
    }

    public void Update(Bolao product)
    {
        var objFromDb = _db.Boloes.FirstOrDefault(p => p.Id == product.Id);
        if (objFromDb != null)
        {/*
            objFromDb.Title = product.Title;
            objFromDb.ISBN = product.ISBN;
            objFromDb.Price = product.Price;
            objFromDb.Price50 = product.Price50;
            objFromDb.ListPrice = product.ListPrice;
            objFromDb.Price100 = product.Price100;
            objFromDb.Description = product.Description;
            objFromDb.CategoryId = product.CategoryId;
            objFromDb.Author = product.Author;
            if(product.ImageUrl != null)
            {
                objFromDb.ImageUrl = product.ImageUrl;
            }
            //_db.Products.Update(objFromDb);//*/
        }
    }
}
