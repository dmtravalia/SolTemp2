using ClassLibrary1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public IEnumerable<Usuario> ObterUsuarios()
        {
            return _context.Usuarios.ToList();
        }
    }
}
