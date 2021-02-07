using System.Collections.Generic;

namespace ClinAPI.Model
{
    public class PessoaTitular : PessoaBase
    {
        public ICollection<PessoaDependente> Dependentes { get; set; }
    }
}