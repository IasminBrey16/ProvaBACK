using System;

namespace ProvaBACK.Models
{
    public class Pessoa
    {
        public Pessoa() => CriadoEm = DateTime.Now;

        public int Id { get; set; }
        public string Nome { get; set; }
        public double Cpf { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public DateTime CriadoEm { get; set; }

    }
}