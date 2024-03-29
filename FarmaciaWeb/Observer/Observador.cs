﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FarmaciaWeb.Models;

namespace FarmaciaWeb.Observer
{
    public class Observador: IRegistros
    {
        arqfarmaciaEntities dbc = new arqfarmaciaEntities();

        public void Update(int idC, int idNotify)
        {
            detalles_notificaciones detn = new detalles_notificaciones();
            detn.fk_cliente = idC;
            detn.estado = true;
            detn.fk_notificacion = idNotify;
            dbc.detalles_notificaciones.Add(detn);
            dbc.SaveChanges();
        }
    }
}