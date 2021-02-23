using PasswordGenerator.Forms.ViewModels;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace PasswordGenerator.Forms.Views
{
    public partial class PasswordGeneratorView : Form
    {
        private PasswordGeneratorViewModel _viewModel = new PasswordGeneratorViewModel();


        public PasswordGeneratorView()
        {
            InitializeComponent();


            this.length8radioButton.Tag = 8;
            this.length8radioButton.CheckedChanged += new EventHandler(radioButton_CheckedChanged);

            this.length10radioButton.Tag = 10;
            this.length10radioButton.CheckedChanged += new EventHandler(radioButton_CheckedChanged);

            this.length12radioButton.Tag = 12;
            this.length12radioButton.CheckedChanged += new EventHandler(radioButton_CheckedChanged);


            this.alphabetCheckBox.DataBindings.Add(new Binding
                (nameof(alphabetCheckBox.Checked), _viewModel, nameof(_viewModel.AlphabetCheck)));
            this.numberCheckBox.DataBindings.Add(new Binding
                (nameof(numberCheckBox.Checked), _viewModel, nameof(_viewModel.NumberCheck)));


            this.PasswordLabel.DataBindings.Add(new Binding
                (nameof(PasswordLabel.Text), _viewModel, nameof(_viewModel.PasswordText)));


            this.PasswordLabel.Click += new EventHandler(PasswordLabelClick);
        }


        private void PasswordLabelClick(object sender, EventArgs e)
        {
            string text = this.PasswordLabel.Text;


            if (text != "")
            {
                try
                {
                    Clipboard.Clear();
                    Clipboard.SetData(DataFormats.Text, text);
                    MessageBox.Show("クリップボードにコピーしました。");
                }
                catch (ExternalException ex)
                {
                    MessageBox.Show("クリップボードのコピーに失敗しました。");
                }
            }
        }


        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            if (rb == null)
            {
                MessageBox.Show("Sender is not a RadioButton");
                return;
            }

            if (rb.Checked)
            {
                _viewModel.PasswordLength = Convert.ToInt32(rb.Tag);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                _viewModel.Create();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}