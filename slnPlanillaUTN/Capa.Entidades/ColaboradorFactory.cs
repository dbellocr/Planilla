using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Entidades
{
  public class ColaboradorFactory
    {

        public static Colaborador CrearColaborador(string id, string nombre, string primerApellido, string segundoApellido, string telefono, string email, string rutaCurriculum, string rutaImagen, bool estado)
        {

            Colaborador oColaborador = new Colaborador()
            {
                Curriculum = rutaCurriculum,
                Email = email,
                Estado = estado,
                Foto = rutaImagen,
                ID = id,
                Nombre = nombre,
                PrimerApellido = primerApellido,
                SegundoApellido = segundoApellido,
                Telefono= telefono

            };

            return oColaborador;

        }


    }
}
