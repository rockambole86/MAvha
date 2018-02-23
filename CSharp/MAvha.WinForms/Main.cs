using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MAvha.WinForms.MAvhaService;

namespace MAvha.WinForms
{
    public partial class Main : Form
    {
        private readonly ServiceSoapClient _serviceClient = new ServiceSoapClient();

        public Person CurrentPerson { get; set; } = new Person();

        public Main()
        {
            InitializeComponent();
        }

        #region Form Events
        
        private void Main_Load(object sender, EventArgs e)
        {
            dtpDOB.Value = DateTime.Today;

            ddlGender.DataSource = Enum.GetValues(typeof(Gender));
            ddlGender.Refresh();

            LoadResults();

            btnDelete.Enabled = false;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadResults(_serviceClient.List());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CurrentPerson.Fullname = txtFullname.Text;
            CurrentPerson.Gender = (Gender) ddlGender.SelectedValue;
            CurrentPerson.Age = Convert.ToInt16(txtAge.Value);
            CurrentPerson.DOB = dtpDOB.Value.Date;

            //Call web service to save info
            _serviceClient.Save(CurrentPerson);

            LoadResults();

            Reset();

            btnRefresh.Enabled = true;
            btnDelete.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _serviceClient.Delete(CurrentPerson.Id);

            Reset();

            LoadResults();

            btnRefresh.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Reset();

            btnRefresh.Enabled = true;
            btnDelete.Enabled = false;
        }

        private void grdResults_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            CurrentPerson = (Person)grdResults.Rows[e.RowIndex].DataBoundItem;

            txtFullname.Text = CurrentPerson.Fullname;
            dtpDOB.Value = CurrentPerson.DOB;
            txtAge.Text = CurrentPerson.Age.ToString();
            ddlGender.SelectedItem = CurrentPerson.Gender;

            btnRefresh.Enabled = false;
            btnDelete.Enabled = true;
        }

        #endregion

        #region Functions
        
        private void LoadResults(IEnumerable<Person> results = null)
        {
            grdResults.DataSource = results ?? _serviceClient.List();
            grdResults.Refresh();

            SetupGrid();
        }

        private void SetupGrid()
        {
            foreach (DataGridViewColumn column in grdResults.Columns)
                column.Visible = false;

            grdResults.Columns["Id"].Visible = false;
            grdResults.Columns["Id"].HeaderText = $@"Id";
            grdResults.Columns["Id"].DisplayIndex = 0;

            grdResults.Columns["Fullname"].Visible = true;
            grdResults.Columns["Fullname"].HeaderText = $@"Nombre completo";
            grdResults.Columns["Fullname"].Width = 350;
            grdResults.Columns["Fullname"].DisplayIndex = 1;

            grdResults.Columns["DOB"].Visible = true;
            grdResults.Columns["DOB"].HeaderText = $@"Fecha nacimiento";
            grdResults.Columns["DOB"].Width = 150;
            grdResults.Columns["DOB"].DisplayIndex = 2;

            grdResults.Columns["Age"].Visible = true;
            grdResults.Columns["Age"].HeaderText = $@"Edad";
            grdResults.Columns["Age"].Width = 50;
            grdResults.Columns["Age"].DisplayIndex = 3;

            grdResults.Columns["Gender"].Visible = true;
            grdResults.Columns["Gender"].HeaderText = $@"Sexo";
            grdResults.Columns["Gender"].Width = 100;
            grdResults.Columns["Gender"].DisplayIndex = 4;

            grdResults.Columns["IsActive"].Visible = false;
            grdResults.Columns["IsActive"].HeaderText = $@"Activo";
            grdResults.Columns["IsActive"].DisplayIndex = 5;
        }

        private void Reset()
        {
            CurrentPerson = new Person();

            txtFullname.Text = string.Empty;
            dtpDOB.Value = DateTime.Today;
            txtAge.Value = txtAge.Minimum;
            ddlGender.SelectedItem = Gender.Masculino;
        }

        #endregion
    }
}