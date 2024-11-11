using dataGridView.Contracts.Models;
using dataGridView_Shamilova_variant_4.Bindings;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace dataGridView_Shamilova_variant_4.Forms
{
    public partial class TourForm : Form
    {
        private Tour tour;
        public Tour Tour => tour;

        /// <summary>
        /// Инициализация формы для работы с турами.
        /// </summary>
        public TourForm(Tour tour = null)
        {
            InitializeComponent();

            this.tour = tour == null
               ? DateGenerate.CreateTour()
               : new Tour
               {
                   Id = tour.Id,
                   Direction = tour.Direction,
                   DepartureDate = tour.DepartureDate,
                   NumberOfNights = tour.NumberOfNights,
                   CostVacationer = tour.CostVacationer,
                   NumberOfVacationer = tour.NumberOfVacationer,
                   WiFi = tour.WiFi,
                   Surcharges = tour.Surcharges,
               };

            foreach (var item in Enum.GetValues(typeof(Direction)))
            {
                comboBoxDirection.Items.Add(item);
            }

            if (comboBoxDirection.Items.Count > 0)
            {
                comboBoxDirection.SelectedIndex = 0;
            }

            comboBoxDirection.AddBinding(x => x.SelectedItem, this.tour, x => x.Direction, errorProvider1);
            dateTimePickerDepartureDate.AddBinding(x => x.Value, this.tour, x => x.DepartureDate, errorProvider1);
            numericUpDownNumberOfNights.AddBinding(x => x.Value, this.tour, x => x.NumberOfNights, errorProvider1);
            numericUpDownCostVacationer.AddBinding(x => x.Value, this.tour, x => x.CostVacationer, errorProvider1);
            numericUpDownNumberOfVacationer.AddBinding(x => x.Value, this.tour, x => x.NumberOfVacationer, errorProvider1);
            checkBoxWiFi.AddBinding(x => x.Checked, this.tour, x => x.WiFi, errorProvider1);
            numericUpDownSurcharges.AddBinding(x => x.Value, this.tour, x => x.Surcharges, errorProvider1);
        }

        private void comboBoxDirection_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();

            // Создаем прямоугольник
            using (var path = new GraphicsPath())
            {
                path.AddRectangle(new Rectangle(e.Bounds.X + 2, e.Bounds.Y + 2, e.Bounds.Height - 4, e.Bounds.Height - 4));
                e.Graphics.FillPath(Brushes.MediumPurple, path);
            }

            if (e.Index > -1)
            {
                var value = (Direction)(sender as ComboBox).Items[e.Index];
                e.Graphics.DrawString(GetDisplayValue(value),
                    e.Font,
                    new SolidBrush(e.ForeColor),
                    e.Bounds.X + 20,
                    e.Bounds.Y);
            }
        }

        private string GetDisplayValue(Direction value)
        {
            var field = value.GetType().GetField(value.ToString());
            var attributes = field.GetCustomAttributes<DescriptionAttribute>(false);

            return attributes.FirstOrDefault()?.Description;
        }
    }
}
