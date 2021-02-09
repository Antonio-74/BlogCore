using BlogCore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogCore.AccesoData.Data.Repository
{
    public interface IUsuarioRepository : IRepository<ApplicationUser>
    {
        void BloquearUsuario(string idUsuario);
        void DesbloquearUsuario(string idUsuario);
    }
}
