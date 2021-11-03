using Equipe4.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using static Equipe4.Model.CadastroDoacaoModel;

namespace Equipe4.Service
{

    public class DoacaoService
    {
        public bool verificarId(CadastroDoacaoModel item)
        {
            if(item.IdDoItem < 0)
            {
                return false;
            }
            return true;
        }

        public bool verificarNome(CadastroDoacaoModel item)
        {
            return !string.IsNullOrEmpty(item.NomeDoItem);
        }


    }
}
