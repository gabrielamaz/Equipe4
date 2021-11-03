
using Equipe4.Model;
using Equipe4.Service;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;

using static Equipe4.Service.DoacaoService;

namespace Equipe4.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class DoacaoController : ControllerBase
    {
        private static List<CadastroDoacaoModel> listaDeDoacao = new();
        DoacaoService verificador = new DoacaoService();

        [HttpGet("ListaDeDoacao")]
        public List<CadastroDoacaoModel> GetLista()
        {
            return listaDeDoacao;
        }

        [HttpPost]
        public bool AdicionarLista(CadastroDoacaoModel item)
        {
            if (item == null)
            {
                return false;
            }
            if (!verificador.verificarNome(item) && !verificador.verificarId(item))
            {

                return false;
            }
            listaDeDoacao.Add(item);
            return true;

        }

        [HttpGet("GetId")]

        public CadastroDoacaoModel GetId(int id)
        {

            foreach (CadastroDoacaoModel element in listaDeDoacao)
            {
                if (element.IdDoItem == id)
                {
                    return element;
                }
            }
            return null;

        }

        [HttpDelete("DeleteDoacao")]

        public CadastroDoacaoModel DeletarItem(int id)
        {
            foreach(CadastroDoacaoModel element in listaDeDoacao)
            {
                if(element.IdDoItem == id)
                {
                    listaDeDoacao.Remove(element);
                    return element;
                }

            }
            return null;
        }



    
    }
}
