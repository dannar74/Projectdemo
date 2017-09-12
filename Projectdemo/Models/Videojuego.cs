using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projectdemo.Models
{
    public class Videojuego
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public string ImagenUrl { get; set; }
    }
}