using System;
using dataGridView.Framework.TourManager;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using dataGridView.Framework.TourStorage;

namespace dataGridView_Shamilova_variant_4
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var storage = new TourStorage();
            var manager = new TourManager(storage);

            Application.Run(new MainForm(manager));
        }
    }
}
