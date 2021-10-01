﻿using System;
using System.ComponentModel;

namespace GatewayPagamento.Apoio
{
    public static class EnumHelper
    {
        public static string ObterDescricao(this Enum valor)
        {
            var campo = valor.GetType().GetField(valor.ToString());

            if (campo == null) return string.Empty;

            //var atributo = (DescriptionAttribute)Attribute.GetCustomAttribute(campo, typeof(DescriptionAttribute));
            var atributo = Attribute.GetCustomAttribute(campo, typeof(DescriptionAttribute)) as DescriptionAttribute;

            return atributo == null ? valor.ToString() : atributo.Description;
        }
    }
}
