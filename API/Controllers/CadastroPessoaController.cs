using Equipe4.Model;
using Equipe4.Service;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Equipe4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CadastroPessoaController : ControllerBase
    {
        private static List<CadastroPessoaModel> listaDeUsuarios = new List<CadastroPessoaModel>();
        CadastroPessoaService verificador = new();

        // GET: api/<CadastroPessoaController>
        [HttpGet]
        [HttpGet("ListaDeUsuarios")]
        public List<CadastroPessoaModel> GetLista()
        {
            return listaDeUsuarios;
        }
        // GET api/<CadastroPessoaController>/5
        [HttpGet("{cpf}")]
        public CadastroPessoaModel GetCpf(string cpf)
        {
            foreach(CadastroPessoaModel element in listaDeUsuarios)
            {
                if(element.CPFPessoa == cpf)
                {
                    return element;
                }
            }
            return null;
        }

        [HttpGet("{Id}")]
        public CadastroPessoaModel GetIdPessoa(int id)
        {
            foreach (CadastroPessoaModel element in listaDeUsuarios)
            {
                if (element.IdDaPessoa == id)
                {
                    return element;
                }
            }
            return null;
        }

        // POST api/<CadastroPessoaController>
        [HttpPost]
        public bool AdicionarLista(CadastroPessoaModel usuario)
        {
            if (usuario == null)
            {
                return false;
            }
            if (verificador.verificarID(usuario.IdDaPessoa) && verificador.VerificarCpf(usuario.CPFPessoa))
            {
                listaDeUsuarios.Add(usuario);
                return true;
            }
            return false;

        }

        // DELETE api/<CadastroPessoaController>/5
        [HttpDelete("{deletar}")]
        public CadastroPessoaModel DeletarPessoa(string cpf)
        {
            foreach(CadastroPessoaModel element in listaDeUsuarios)
            {
                if (element.CPFPessoa == cpf)
                {
                    listaDeUsuarios.Remove(element);
                    return element;
                }
            }
            return null;
        }
    }
}
