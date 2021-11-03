using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Equipe4.Model
{
    public enum TipoDeItem
    {
        Notebook=1,
        Celular=2,
        Perifericos=3,
        Tablets=4,
        Outros=5,
    }
    public class CadastroDoacaoModel
    {
        public string NomeDoItem { get; set; }
        public int IdDoItem { get; set; }

        public string DescricaoDoItem { get; set; }

        public TipoDeItem TipoDeItem { get; set; }














    }
}
