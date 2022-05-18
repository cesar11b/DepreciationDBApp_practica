using DepreciationDBApp.Applications.Interfaces;
using DepreciationDBApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DepreciationDBApp.Forms
{
    public partial class FrmAsset : Form
    {
        private IAssetService assetService;

        public FrmAsset(IAssetService assetService)
        {
            this.assetService = assetService;
            InitializeComponent();
        }

        public FrmAsset()
        {
        }

        private void btnAddAsset_Click(object sender, EventArgs e)
        {
            Asset asset = new Asset()
            {
                Name = txtNombre.Text,
                Description = txtDescripcion.Text,
                Amount = 22433.33M,
                AmountResidual = 0,
                Terms = 2,
                Code = Guid.NewGuid().ToString(),
                Status = "Disponible",
                IsActive = true
            };

            assetService.Create(asset);
            LoadDataGridView();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            dgvAsset.DataSource = assetService.GetAll();
        }

        private void btnActivo_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {

        }
    }
}
