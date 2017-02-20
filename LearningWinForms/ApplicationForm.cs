using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearningWinForms
{
    public partial class ApplicationForm : Form
    {

        public ApplicationForm()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
        }

        private void ApplicationForm_Load(object sender, System.EventArgs e)
        {
            LinkLabel.Link link = new LinkLabel.Link();
            link.LinkData = "http://www.sage.co.uk/legal-and-site-information/legal";
            linkLabelAgreement.Links.Add(link);
        }

        private void linkLabelAgreement_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData as string);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialogCV_FileOk(object sender, CancelEventArgs e)
        {

        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void groupBoxExperience_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxJobTitle_TextChanged(object sender, EventArgs e)
        {

        }


        private void textBoxEmail_Validating(object sender, CancelEventArgs e)
        {
            bool cancel = false;
            if (string.IsNullOrEmpty(this.textBoxEmail.Text))
            {
                //This fails validation. Email cannot be empty.
                cancel = true;
                this.errorProvider1.SetError(this.textBoxEmail, "You must provide an email address");
            }
            e.Cancel = cancel;
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            // some random comment
            if (checkBoxAgreement.Checked == false)
            {
                MessageBox.Show("Please indicate that you agree to the Terms");
                checkBoxAgreement.Focus();
                return;
            }

            if (!textBoxEmail.Text.Contains('@'))
            {
                MessageBox.Show("Please Enter A Valid Email", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxEmail.Focus();
                return;
            }

            if (textBoxNationalInsurance.Text.Length < 6)
            {
                MessageBox.Show("National Insurance Number must be 6 or more characters");
                textBoxNationalInsurance.Focus();
                return;
            }

     

            if (TextBoxFirstName.Text == "")
            {
                MessageBox.Show("Please complete all sections before submitting");
                TextBoxFirstName.Focus();
                return;
            }
        
            if (this.ValidateChildren(ValidationConstraints.Enabled))
            {
                string successline = "Thank you for your application " + TextBoxFirstName.Text + Environment.NewLine + "A confirmation of your submission will be sent to " + textBoxEmail.Text;
                MessageBox.Show(successline);
            }
            else
            {
                MessageBox.Show("There are missing details in the form. Please complete all sections before submitting.");
                this.DialogResult = System.Windows.Forms.DialogResult.None;
                return;
            }


        }

        Image File;

        public void buttonCVBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog cv = new OpenFileDialog();
            cv.Filter = "Text files | *.txt"; // applicant can only add txt files
            cv.Multiselect = false; 
            if (cv.ShowDialog() == DialogResult.OK) // if applicants clicked Browse button
            {
                String cvname = cv.FileName; // get name of file
                textBoxCV.Text = cvname;
                }
            }

        public void buttonCVUpload_Click(object sender, EventArgs e)
        {
            SaveFileDialog cv = new SaveFileDialog();
            cv.Filter = "Text files | *.txt";

            if (cv.ShowDialog() == DialogResult.OK)
            {
                File.Save(cv.FileName);
            }

        }
    }
    }

