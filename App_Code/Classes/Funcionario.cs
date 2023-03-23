using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de Funcionario
/// </summary>

namespace WebSiteExemplo.Classes
{
    public class Funcionario
    {
        //PROPRIEDADES
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }
        public string Cracha { get; set; }

        //CONSTRUTOR
        public Funcionario()
        {
            //
            // TODO: Adicionar lógica do construtor aqui
            //
        }
    }
}