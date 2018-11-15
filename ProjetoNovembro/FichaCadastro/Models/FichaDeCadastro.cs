using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FichaCadastro.Models
{
    public class FichaDeCadastro
    {
        //Analista Rh
        public string NomeRh { get; set; }
        public DateTime Data { get; set; }
        public string Cargo { get; set; }
        public double PretencaoSalarial { get; set; }
        public string FonteRecrutamento { get; set; }
        public TimeSpan TimeDisponibilidade { get; set; }

        //Ficha candidato
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sexo { get; set; }
        public string Endereco { get; set; }
        public int NumeroCasa { get; set; }
        public string Complemento { get; set; }
        public long Cep { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Regiao { get; set; }
        public string Estado { get; set; }
        public DateTime DataNascimento { get; set; }
        public string LocalNascimento { get; set; }
        public string EstadoCivil { get; set; }
        public string Raca { get; set; }
        public string Email { get; set; }
        public int NumTelefoneRes { get; set; }
        public int NumCelular { get; set; }
        public int Rg { get; set; }
        public DateTime RgDataExpe { get; set; }
        public string RgOrgaoEmissor { get; set; }
        public long Cpf { get; set; }
        public string NomeMae { get; set; }
        public string NomePai { get; set; }
        public long Pis { get; set; }
        public string Dependentes { get; set; }
        public string TrabalhouResource { get; set; }
        public string Idioma { get; set; }

    }
}