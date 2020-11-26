﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JRMarketing.Gui.Models
{
    public class Usuarios
    {
        public string NombreUsuario { get; set; }
        public string Contrasenia { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public string Colonia { get; set; }
        public string Estado { get; set; }
        public string Ciudad { get; set; }
        public string CoidgoPostal { get; set; }
        public string Correo { get; set; }
        public DateTime FechaNacimiento { get; set; }
    }
}