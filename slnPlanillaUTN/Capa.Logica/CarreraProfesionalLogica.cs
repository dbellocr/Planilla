using Capa.Datos;
using Capa.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Logica
{
    public class CarreraProfesionalLogica
    {


        public static CarreraProfesional SeleccionarPorID(string carreraID)
        {
            return CarreraProfesionalDatos.SeleccionarPorID(carreraID);

        }
        public static List<CarreraProfesional> SeleccionarTodos()
        {
            return CarreraProfesionalDatos.SeleccionarTodos();
        }
    }
    }
