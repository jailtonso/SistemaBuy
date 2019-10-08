﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace Sistema.Dominio.Entidades
{
     class Usuario
    {
        public int Id { get; set; }

        public string Email { get; set; } 

        public string Senha { get; set; }


        public string Nome { get; set; }

        public string SobreNome { get; set; }



        /// <summary>
        /// User pode ter nenhum ou muitos pedidos
        /// </summary>
        
        public ICollection<Pedido> Pedidos { get; set; }
    
    }
}
