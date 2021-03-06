﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Curso.Core.Application.Pedido.ViewModels.AgregracaoPedidos
{
    public class PedidosViewModel
    {
        public PedidosViewModel()
        {
            ListaErros = new List<string>();
        }
        public int Id { get; set; }
        public List<string> ListaErros { get; set; }
        public string DataPedido { get; set; }
        public string DataEntrega { get; set; }
        public string Observacao { get; set; }
        public int IdCliente { get; set; }
        public int QtdTotalProdutos { get; set; }
        public string ValorTotalProdutos { get; set; }
        public string NomeCliente { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public string CEP { get; set; }
    }
}
