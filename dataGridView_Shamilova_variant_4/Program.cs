using System;
using dataGridView.Standart.TourManager;
using System.Windows.Forms;
using dataGridView.Standart.TourStorage;

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
            //var factory = LoggerFactory.Create(builder => builder.AddDebug());
            //var logger = factory.CreateLogger("LastMinuteTours");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var storage = new TourStorage();
            var manager = new TourManager(storage);

            Application.Run(new MainForm(manager));
        }
    }
}
