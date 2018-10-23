using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoNull.Models
{
    public class CadastroCandidato
    {
        public int CandidatoId { get; set; }
        public string AnalistaRH { get; set; }
        public DateTime DataCadastro { get; set; }
        public string Cargo { get; set; }
        public float PretSalarial { get; set; }
        public string FonteRecrutamento { get; set; }
        public Disponibilidade Disponibilidade { get; set; }
        public string NomeCandidato { get; set; }
        public Sexo Sexo { get; set; }
        public Endereco Endereco { get; set; }
        public DateTime DataNascimento { get; set; }
        public string LocalNascimento { get; set; }
        public EstadoCivil EstadoCivil { get; set; }
        public Raca Raca { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string RG { get; set; }
        public DateTime DataExpedicao { get; set; }
        public string OrgaoEmissor { get; set; }
        public string CPF { get; set; }
        public string NomeMae { get; set; }
        public string NomePai { get; set; }
        public int PIS { get; set; }
        public bool PossuiDependente { get; set; }
        public int QuantDependente { get; set; }
        public bool TrabalhouResource { get; set; }
        public string OndeTrabalhou { get; set; }
        public Idioma Idioma { get; set; }

        public int DependenteId { get; set; }
        public Dependente Dependente { get; set; }
    }
    
}