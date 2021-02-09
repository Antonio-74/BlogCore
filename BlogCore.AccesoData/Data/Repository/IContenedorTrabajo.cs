using System;
using System.Collections.Generic;
using System.Text;

namespace BlogCore.AccesoData.Data.Repository
{
    public interface IContenedorTrabajo : IDisposable
    {
        ICategoriaRepository Categoria { get; }

        IArticuloRepository Articulo { get; }

        ISliderRepository Slider { get; }

        IUsuarioRepository Usuario { get; }

        void Save();
    }
}
