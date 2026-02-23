using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace InicioSesion
{
    class User
    {
        public string userName { get; set; }
        public string userPassword { get; set; }
        public string userMail { get; set; }
        public int userId { get; set; }
        public int userPoints { get; set; }

    }

    class GestorUsers
    {
        public List<User> users = new List<User>();
        public void GestorUsuarios(string nombre, string mail, string password, int id)
        {
            User user = new User();
            user.userName = nombre;
            user.userMail = mail;
            user.userPassword = password;
            user.userId = id;
            user.userPoints = 0;
            users.Add(user);
            LogIn.hayUsuariosCreados = true;
        }
    }
}
