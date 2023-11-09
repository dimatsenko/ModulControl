using System.Windows.Forms;

namespace ModulControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CalculateAndDisplayResults(int knightsCount, int elephantsCount, int infantryCount)
        {
            // Create instances of your units
            IUnit knights = new Knights();
            IUnit elephant = new Elephant();
            IUnit infantry = new Infantry();

            // Clear existing rows and columns in the DataGridView
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            // Add columns to the DataGridView
            dataGridView1.Columns.Add("UnitType", "Unit Type");
            dataGridView1.Columns.Add("Count", "Count");
            dataGridView1.Columns.Add("Cost", "Cost");
            dataGridView1.Columns.Add("Speed", "Speed");

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            // Calculate total costs and average speed
            double totalCost = (knights.GetCost() * knightsCount) + (elephant.GetCost() * elephantsCount) + (infantry.GetCost() * infantryCount);
            double totalSpeed = (knights.GetSpeed() * knightsCount) + (elephant.GetSpeed() * elephantsCount) + (infantry.GetSpeed() * infantryCount);
            double totalFoodCost = (knights.GetFeed() * knightsCount) + (elephant.GetFeed() * elephantsCount);

            double averageSpeed = Math.Round(totalSpeed / (knightsCount + elephantsCount + infantryCount), 2);



            dataGridView1.Rows.Add("Лицарі", knightsCount, FormatCost(knights.GetCost() * knightsCount, knights.GetFeed() * knightsCount), knights.GetSpeed());
            dataGridView1.Rows.Add("Слони", elephantsCount, FormatCost(elephant.GetCost() * elephantsCount, elephant.GetFeed() * elephantsCount), elephant.GetSpeed());
            dataGridView1.Rows.Add("Піхота", infantryCount, FormatCost(infantry.GetCost() * infantryCount, 0), infantry.GetSpeed());
            dataGridView1.Rows.Add("", "", "");
            dataGridView1.Rows.Add("","",  "Загальні витрати", "Середня швидкість");
            dataGridView1.Rows.Add("", "", FormatCost(totalCost, totalFoodCost), averageSpeed);
         

            // Method to format cost
            string FormatCost(double cost, double food)
            {
                return $"Золото {cost}, Корм {food}";
            }
            // Update DataGridView
            dataGridView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int knightsCount = int.Parse(textBox1.Text);
            int elephantsCount = int.Parse(textBox2.Text);
            int infantryCount = int.Parse(textBox3.Text);

            // Clear existing rows in DataGridView
            dataGridView1.Rows.Clear();

            // Calculate and display details for each unit
            CalculateAndDisplayResults(knightsCount, elephantsCount, infantryCount);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}