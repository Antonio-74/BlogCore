using BlogCore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogCore.AccesoData.Data.Repository
{
    public interface IArticuloRepository : IRepository<Articulo>
    {
        void Udate(Articulo articulo);
        //Articulo Get(object p);
    }
}
