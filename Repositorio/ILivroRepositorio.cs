using System;
using System.Collections.Generic;
using System.Text;
using ExemploAula01.Negocio;

namespace ExemploAula01.Repositorio
{
    interface ILivroRepositorio
    {
        ListaDeLeitura ParaLer { get; }

        ListaDeLeitura Lendo { get; }

        ListaDeLeitura Lidos { get; }

        IEnumerable<Livro> Todos { get; }

        void Incluir(Livro livro);
    }
}
