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
    public class Cuenta
    {
        /// <summary>
        /// Declarar las variables
        /// </summary>
        public int ID { get; set; }
        public string NombreUsuario { get; set; }
        public Colaborador Colaborador { get; set; }
        public string Contraseña { get; set; }
    }
}
