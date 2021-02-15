using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScooterRent.BaseLibraries;
using ScooterRent.MemoryBasedDAL;

namespace ScooterRent.PresentationLayer
{
    public partial class FormRemoveScooter : Form
    {

        IScooterController _scooterController;
        ScooterRepository _scooterRepository;

        public FormRemoveScooter()
        {
            InitializeComponent();
        }

        public FormRemoveScooter(IScooterController scooterController, ScooterRepository scooterRepository)
        {
            _scooterController = scooterController;
            _scooterRepository = scooterRepository;
            InitializeComponent();

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (ScootersDropDownList.SelectedIndex > -1)
            {
                _scooterController.RemoveScooter(ScootersDropDownList.SelectedItem.ToString());
                this.Close();
            }
            else
            {
                MessageBox.Show("No scooter was selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormRemoveScooter_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < _scooterRepository.Count(); i++)
            {
                ScootersDropDownList.Items.Add(_scooterRepository.GetScooterByIndex(i).Tittle);
            }
        }
    }
}
