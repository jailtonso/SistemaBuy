﻿using Sistema.Dominio.ObjetodeValor;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Sistema.Dominio.Entidades
{
    class Pedido
    {
        public int Id { get; set; }

        public DateTime  DataPedido { get; set; }


        public int UsuarioId { get; set; }

        public ICollection <IntemPedido> ItensPedido { get; set; }

        public DateTime DataPrevisaoEntrega { get; set; }

        public string CEP { get; set; }

        public string Estado { get; set; }

        public string Cidade { get; set; }

        public string EnderecoCompleto { get; set; }

        public string NumeroEndereco { get; set; }

        public int FormaPagamentoId { get; set; }

        public FormaPagamento FormaPagamento { get; set; }

    }
}
