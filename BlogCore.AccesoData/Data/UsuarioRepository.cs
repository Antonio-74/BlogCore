using BlogCore.AccesoData.Data.Repository;
using BlogCore.AccesoDatos.Data;
using BlogCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlogCore.AccesoData.Data
{
    public class UsuarioRepository : Repository<ApplicationUser>, IUsuarioRepository
    {
        private readonly ApplicationDbContext _db;

        public UsuarioRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void BloquearUsuario(string idUsuario)
        {
            var usuarioDesdeDb = _db.ApplicationUser.FirstOrDefault(u => u.Id == idUsuario);
            usuarioDesdeDb.LockoutEnd = DateTime.Now.AddYears(100);
            _db.SaveChanges();
        }

        public void DesbloquearUsuario(string idUsuario)
        {
            var usuarioDesdeDb = _db.ApplicationUser.FirstOrDefault(u => u.Id == idUsuario);
            usuarioDesdeDb.LockoutEnd = DateTime.Now;
            _db.SaveChanges();
        }
    }
}
