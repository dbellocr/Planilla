﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Entidades
{
    /// <summary>
    /// Dar persistencia a las variables 
    /// </summary>
    public class Colaborador
    {
        /// <summary>
        /// Declarar las variables
        /// </summary>
        public string ID { get; set; }
        public string Nombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Curriculum { get; set; }
        public string Foto { get; set; }
        public bool Estado { get; set; }
        public Rol Rol { get; set; }

        public string NombreCompleto
        {
            get
            {
                return Nombre + " " + PrimerApellido + " " + SegundoApellido;
            }
        }
    }
}
