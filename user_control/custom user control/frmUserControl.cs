namespace custom_user_control
{
    public partial class frmUserControl : Form
    {
        public frmUserControl()
        {
            InitializeComponent();
        }

        private void btnContries_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format("Contry id = {0}, name {1}", ucContry1.SelectContry.Id, ucContry1.SelectContry.Name));
        }
    }
}