using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace custom_user_control
{
    public partial class ucContry : UserControl
    {
        public ucContry()
        {
            InitializeComponent();
        }
        public Contry SelectContry
        {
            get
            {
                return (Contry)cboContrys.SelectedItem;
            }
        }

        private void ucState_Load(object sender, EventArgs e)
        {
            List<Contry> contries_List = new List<Contry>();
            contries_List.Add(new Contry() { Id = 1, Name = "Jordan" });
            contries_List.Add(new Contry() { Id = 2, Name = "Palestine" });
            contries_List.Add(new Contry() { Id = 3, Name = "Russia" });
            contries_List.Add(new Contry() { Id = 4, Name = "Canada" });
            cboContrys.DataSource = contries_List;
            cboContrys.ValueMember = "Id";
            cboContrys.DisplayMember= "Name";
        }
    }
}
