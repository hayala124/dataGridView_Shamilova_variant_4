using dataGridView.Framework.Contracts;
using dataGridView.Framework.Contracts.Models;
using dataGridView_Shamilova_variant_4.Forms;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dataGridView_Shamilova_variant_4
{
    /// <summary>
    /// Главная форма
    /// </summary>
    public partial class MainForm : Form
    {
        private ITourManager tourManager;
        private BindingSource bindingSource;

        /// <summary>
        /// Инициализирует новый экземпляр <see cref="MainForm" />
        /// </summary>
        public MainForm(ITourManager tourManager)
        {
            this.tourManager = tourManager;
            this.bindingSource = new BindingSource();

            InitializeComponent();

            dataGridViewTours.AutoGenerateColumns = false;
            dataGridViewTours.DataSource = bindingSource;
        }

        private async void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            var tourForm = new TourForm();

            if (tourForm.ShowDialog(this) == DialogResult.OK)
            {
                await tourManager.AddAsync(tourForm.Tour);
                bindingSource.ResetBindings(false);
                await SetStats();
            }
        }

        private async void toolStripButtonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewTours.SelectedRows.Count != 0)
            {
                var data = (Tour)dataGridViewTours.Rows[dataGridViewTours.SelectedRows[0].Index].DataBoundItem;
                var tourForm = new TourForm(data);
                if (tourForm.ShowDialog(this) == DialogResult.OK)
                {
                    await tourManager.EditAsync(tourForm.Tour);
                    bindingSource.ResetBindings(false);
                    await SetStats();
                }
            }
        }

        private async void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewTours.SelectedRows.Count != 0)
            {
                var data = (Tour)dataGridViewTours.Rows[dataGridViewTours.SelectedRows[0].Index].DataBoundItem;
                if (MessageBox.Show($"Вы действительно хотите удалить {data.Direction}?", "Удаление записи", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    await tourManager.DeleteAsync(data.Id);
                    bindingSource.ResetBindings(false);
                    await SetStats();
                }
            }
        }

        private void dataGridViewTours_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewTours.Columns[e.ColumnIndex].Name == "WiFiColumn")
            {
                var data = (Tour)dataGridViewTours.Rows[e.RowIndex].DataBoundItem;
                e.Value = data.WiFi ? "Да" : "Нет";
            }
        }

        /// <summary>
        /// Асинхронно обновляет статистику по турам и отображает её на главной форме.
        /// </summary>
        public async Task SetStats()
        {
            var result = await tourManager.GetStatsAsync();
            toolStripLabel1.Text = $"Общее количество туров: {result.TotalCountTours}";
            toolStripLabel2.Text = $"Общая сумма: {result.TotalCostTours}";
            toolStripLabel3.Text = $"Количество туров с доплатами: {result.CountToursWithSurcharges}";
            toolStripLabel4.Text = $"Общая сумма доплат: {result.TotalCostOfSurcharges}";
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            bindingSource.DataSource = await tourManager.GetAllAsync();
            await SetStats();
        }
    }
}
