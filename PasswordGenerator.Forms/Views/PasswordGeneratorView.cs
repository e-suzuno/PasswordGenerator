using PasswordGenerator.Forms.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            MessageBox.Show("クリップボードにコピーしました。");
            Clipboard.SetText(this.PasswordLabel.Text);
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