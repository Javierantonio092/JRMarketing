﻿using System;
using System.Collections.Generic;
using System.Text;

namespace JRMarketing.Domain.DTOs
{
    public class UsuarioRequestDto
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
        public string Tipo { get; set; }
        public string Telefono { get; set; }
    }

    public class UsuarioRequestDto2
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
        public string Tipo { get; set; }
    }
}
