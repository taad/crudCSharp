using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaMedica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void medicosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.medicosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet1.Convenios' table. You can move, or remove it, as needed.
            this.conveniosTableAdapter.Fill(this.database1DataSet1.Convenios);
            // TODO: This line of code loads data into the 'database1DataSet1.Agenda' table. You can move, or remove it, as needed.
            this.agendaTableAdapter.Fill(this.database1DataSet1.Agenda);
            // TODO: This line of code loads data into the 'database1DataSet1.Pacientes' table. You can move, or remove it, as needed.
            this.pacientesTableAdapter1.Fill(this.database1DataSet1.Pacientes);
            // TODO: This line of code loads data into the 'database1DataSet1.Medicos' table. You can move, or remove it, as needed.
            this.medicosTableAdapter1.Fill(this.database1DataSet1.Medicos);
            // TODO: This line of code loads data into the 'database1DataSet.Pacientes' table. You can move, or remove it, as needed.
            this.pacientesTableAdapter.Fill(this.database1DataSet.Pacientes);
            // TODO: This line of code loads data into the 'database1DataSet.Medicos' table. You can move, or remove it, as needed.
            this.medicosTableAdapter.Fill(this.database1DataSet.Medicos);

        }

        private void Convênios_Click(object sender, EventArgs e)
        {

        }
    }
}
