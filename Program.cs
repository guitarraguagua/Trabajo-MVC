using System;
using Blockbuster.Models;
using Blockbuster.Views;

namespace Blockbuster
{
    class Program
    {
        static void Main(string[] args)
        {
            Database db = new Database();
            db.GetConnection();

            ApplicationConfiguration.Initialize();
            Application.Run(new viewPrincipal());
        }
    }
}