using System;
using dataGridView.TourManager;
using System.Windows.Forms;
using dataGridView.TourStorage;
using Microsoft.Extensions.Logging;

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
            var factory = LoggerFactory.Create(builder => builder.AddDebug());
            var logger = factory.CreateLogger(nameof(dataGridView_Shamilova_variant_4));

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var storage = new TourStorage();
            var manager = new TourManager(storage, logger);

            Application.Run(new MainForm(manager));
        }
    }
}
