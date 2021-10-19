using ExpoCenter.Dominio.Entidades;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpoCenter.Mvc.Filters
{
    public class AuthorizeRole : AuthorizeAttribute
    {
        public AuthorizeRole(params PerfilUsuario[] perfis)
        {
            foreach (var perfil in perfis)
            {
                Roles += perfil + ",";
            }

            //Roles = Roles.TrimEnd(',');
            //Roles.TrimEnd(',');

            Roles = string.Join(',', perfis);
        }
    }
}
