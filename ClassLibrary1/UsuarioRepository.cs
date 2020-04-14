using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly DadosContext _context;

        public UsuarioRepository(DadosContext context)
        {
            _context = context;
        }
    }
}
