using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;

namespace KursProject
{
    public partial class FormChart : Form
    {
        public FormChart()
        {
            InitializeComponent();
        }

        private void FormChart_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=kpkserver.kpk.local;Initial Catalog=KP_2024_Suslov;Persist Security Info=True;User ID=user;Password=1234567";
            string query = @"
        SELECT 
            Сотрудник.ФИО,
            COUNT(История_Обработки.ID_Записи) AS Количество_Обработанных
        FROM 
            История_Обработки
        JOIN 
            Сотрудник ON История_Обработки.ID_Сотрудника = Сотрудник.ID_Сотрудника
        GROUP BY 
            Сотрудник.ФИО
        ORDER BY 
            Количество_Обработанных DESC;
    ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                chart1.Series.Clear();
                chart1.Series.Add("Обработка");
                chart1.Series["Обработка"].ChartType = SeriesChartType.Column;

                while (reader.Read())
                {
                    string фио = reader.GetString(0);
                    int количество = reader.GetInt32(1);
                    chart1.Series["Обработка"].Points.AddXY(фио, количество);
                }

                reader.Close();
            }
        }
    }
}
