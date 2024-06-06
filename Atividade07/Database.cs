using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade07
{
    public class Database : IDatabase
    {
        /* Estrutura que vai simular o banco de de dados */
        private static List<User> _users = new List<User>();
        
        public void SaveUser(User user)
        {
            // Salvar usuário no banco de dados
            _users.Add(user);
        }

        public List<User> GetAllUsers()
        {
            return new List<User>(_users);
        }

        public void ClearUsers()
        {
            _users.Clear();
        }
    }
}
