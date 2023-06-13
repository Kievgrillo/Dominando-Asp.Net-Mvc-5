using Microsofty.Business.Core.Models;
using Microsofty.Business.Models.Produtos;
using System.Collections.Generic;

namespace Microsofty.Business.Models.Fornecedores
{
    class Fornecedor : Entity
    {
        public string Nome { get; set; }
        public string Documento { get; set; }
        public TipoFornecedor TipoFornecedor { get; set; }
        public Endereco Endereco { get; set; }
        public bool Ativo { get; set; }

        /* Entity FrameWork Relations */
        public ICollection<Produto> Produtos { get; set; }
    }

}
