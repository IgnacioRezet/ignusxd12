﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class categoria
    {
        public string id_categoria { get; set; }
        public string nombre_categoria { get; set; }
        public List<subCategorias> subCategoria { get; set; }

    }

    public class subCategorias
    {
        public string id_categoria { get; set; }
        public string nombre_categoria { get; set; }

    }
}
