namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.Columns.Add("Producte", 100);
            listView1.Columns.Add("Preu", 50);
            ListViewItem item = new ListViewItem("Poma");
            item.SubItems.Add("1.50€");
            listView1.Items.Add(item);
        }
    }

}
