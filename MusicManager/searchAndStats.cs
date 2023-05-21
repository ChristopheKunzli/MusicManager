using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MusicManager
{
    public partial class searchAndStats : Form
    {
        private List<Trade> list;

        public searchAndStats()
        {
            InitializeComponent();
        }

        private void searchAndStats_Load(object sender, EventArgs e)
        {
            //TradesDAO dao = new TradesDAO();

            //list = dao.getTradeList();

            //dgvTrades.DataSource = list;


            list = new List<Trade>();

            Random random = new Random();

            for (int i = 1; i <= 10; ++i)
            {
                double amount = random.NextDouble() * (double)i;
                DateTime dateTime = new DateTime(random.Next(2000, 2023), random.Next(1, 12), random.Next(1, 25));

                list.Add(new Trade(i, amount, dateTime));
            }

            list = list.OrderBy(o => o.Date).ToList();

            chart1.DataSource = list;
            chart1.Series[0].Name = "Factures";
            chart1.Series[0].ChartType = SeriesChartType.Line;
            chart1.Series[0].YValueMembers = "amount";
            chart1.Series[0].XValueMember = "date";


        }
        public class Record
        {
            int id, age;
            string name;
            public Record(int id, string name, int age)
            {
                this.id = id;
                this.name = name;
                this.age = age;
            }
            public int ID
            {
                get { return id; }
                set { id = value; }
            }
            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            public int Age
            {
                get { return age; }
                set { age = value; }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvTrades.DataSource = "";
            list.RemoveRange(0, 10);
            dgvTrades.DataSource = list;
        }
    }
}
