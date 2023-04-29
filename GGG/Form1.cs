namespace GGG
{
    public partial class Form1 : Form
    {
        List<Sick> Sick_list;
        public Form1()
        {
            InitializeComponent();
            Sick_list = new List<Sick>() { new Sick("Сережа", "Простуда", "Хорошее"), new Sick("Андрей", "Сифилис", "Плохое") };
            
            dataGridView1.DataSource = Sick_list.ToList();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                        {
                            dataGridView1.Rows[i].Selected = true;
                            break;
                        }
            }
        }
    }
}