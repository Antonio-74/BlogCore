using BlogCore.AccesoData.Data.Repository;
using BlogCore.AccesoDatos.Data;
using BlogCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlogCore.AccesoData.Data
{
    public class ArticuloRepository : Repository<Articulo>, IArticuloRepository
    {
        private readonly ApplicationDbContext _db;

        public ArticuloRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        //public Articulo Get(object p)
        //{
        //    throw new NotImplementedException();
        //}

        public void Udate(Articulo articulo)
        {
            var objDesdeDb = _db.Articulo.FirstOrDefault(s => s.Id == articulo.Id);
            objDesdeDb.Nombre = articulo.Nombre;
            objDesdeDb.Descripcion = articulo.Descripcion;
            objDesdeDb.UrlImagen = articulo.UrlImagen;
            objDesdeDb.CategoriaId = articulo.CategoriaId;
        }
    }
}
