using System;
using dataGridView.TourManager;
using System.Windows.Forms;
using dataGridView.TourStorage;
using Serilog;
using Serilog.Extensions.Logging;

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

            var serilogLogger = new LoggerConfiguration()
                .MinimumLevel.Verbose()
                .WriteTo.Seq("http://localhost:5341", apiKey: "sKTu9ZLxtxTl4xe6SVDU")
                .CreateLogger();
            var logger = new SerilogLoggerFactory(serilogLogger).CreateLogger("dataGridView_Shamilova_variant_4");

            var storage = new TourStorage();
            var manager = new TourManager(storage, logger);

            Application.Run(new MainForm(manager));
        }
    }
}
