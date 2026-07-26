using System;
using System.Windows.Forms;
using DateTimeFormatterPro.Helpers;
using DateTimeFormatterPro.Repository;

namespace DateTimeFormatterPro
{
    public partial class FrmMain : Form
    {
        private readonly FormatRepository repository = new FormatRepository();

        public FrmMain()
        {
            InitializeComponent();

            UIStyleHelper.StyleButtons(
                btnConvert,
                btnCopy,
                btnClear,
                btnSave,
                btnDelete);

            btnConvert.Click += btnConvert_Click;
            btnCopy.Click += btnCopy_Click;
            btnClear.Click += btnClear_Click;
            btnDelete.Click += btnDelete_Click;

            cmbFormatPreset.SelectedIndexChanged += cmbFormatPreset_SelectedIndexChanged;

            txtFormat.TextChanged += UpdatePreview;
            dtpDateTime.ValueChanged += UpdatePreview;

            FormatPresetHelper.Load(cmbFormatPreset);

            LoadHistory();

            UpdatePreview(null, EventArgs.Empty);
        }

        private void LoadHistory()
        {
            dgvHistory.DataSource = repository.GetAll();

            DataGridViewHelper.Style(dgvHistory);
        }

        private void cmbFormatPreset_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFormat.Text =
                FormatPresetHelper.GetFormat(cmbFormatPreset.Text);
        }

        private void UpdatePreview(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtFormat.Text))
                {
                    txtPreview.Clear();
                    return;
                }

                txtPreview.Text =
                    dtpDateTime.Value.ToString(txtFormat.Text);
            }
            catch
            {
                txtPreview.Text = "Invalid format";
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            UpdatePreview(null, EventArgs.Empty);
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtPreview.Text) &&
                txtPreview.Text != "Invalid format")
            {
                Clipboard.SetText(txtPreview.Text);

                MessageBox.Show(
                    "Copied successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFormat.Clear();
            txtPreview.Clear();
            dtpDateTime.Value = DateTime.Now;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                repository.Save(
                    dtpDateTime.Value,
                    txtFormat.Text,
                    txtPreview.Text);

                LoadHistory();

                MessageBox.Show(
                    "Saved successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvHistory.CurrentRow == null)
            {
                MessageBox.Show(
                    "Please select a record to delete.",
                    "Delete",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this record?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.No)
                return;

            int id = Convert.ToInt32(
                dgvHistory.CurrentRow.Cells["Id"].Value);

            repository.Delete(id);

            LoadHistory();

            MessageBox.Show(
                "Deleted successfully!",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}