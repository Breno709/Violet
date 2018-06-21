using System;
using System.Collections.Generic;
using System.Text;

namespace Violet
{
    public interface IPessoa
    {
        string CEP { get; set; }
        string Email { get; set; }
        string Endereco { get; set; }
        Guid ID { get; }
        string Nome { get; set; }
        string Telefone { get; set; }
    }
}
