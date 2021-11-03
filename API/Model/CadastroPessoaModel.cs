using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Equipe4.Model
{
    public class CadastroPessoaModel
    {
        private int idDaPessoa;
        private string nomePessoa;
        private string cpfPessoa;
        private string emailPessoa;
        private string senhaPessoa;
        private string enderecoPessoa;
        private int idadePessoa;

        public CadastroPessoaModel(int idDaPessoa, String nomePessoa, String emailPessoa, String cpfPessoa, String endereco, int idade, String senhaPessoa)
        {
            this.idDaPessoa = idDaPessoa;
            this.nomePessoa = nomePessoa;
            this.emailPessoa = emailPessoa;
            this.cpfPessoa = cpfPessoa;
            this.EnderecoPessoa = enderecoPessoa;
            this.idadePessoa= IdadePessoa;
            this.senhaPessoa = senhaPessoa;
        }

        public string NomePessoa { get; set; }
        public string EmailPessoa { get; set; }
        public string EnderecoPessoa { get; set; }
        public int IdadePessoa { get; set; }
        public string SenhaPessoa { get; set; }

        public string CPFPessoa { get; set; }

        public int IdDaPessoa { get; set; }
    }
}
