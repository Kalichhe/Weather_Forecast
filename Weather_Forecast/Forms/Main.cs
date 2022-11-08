using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weather_Forecast.Forms
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Predict_button1_Click(object sender, EventArgs e)
        {
            using (Predict predict = new Predict())
                predict.ShowDialog();
        }

        private void SearchLog_button2_Click(object sender, EventArgs e)
        {
            using (Search_Log search = new Search_Log())
                search.ShowDialog();
        }
    }
}
