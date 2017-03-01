namespace async_await
{
    partial class Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listPeople = new System.Windows.Forms.ListBox();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.comboCountry = new System.Windows.Forms.ComboBox();
            this.comboGender = new System.Windows.Forms.ComboBox();
            this.comboCompany = new System.Windows.Forms.ComboBox();
            this.textLoad = new System.Windows.Forms.TextBox();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelLoadTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listPeople
            // 
            this.listPeople.FormattingEnabled = true;
            this.listPeople.Location = new System.Drawing.Point(10, 92);
            this.listPeople.Name = "listPeople";
            this.listPeople.Size = new System.Drawing.Size(368, 264);
            this.listPeople.TabIndex = 1;
            // 
            // textSearch
            // 
            this.textSearch.Enabled = false;
            this.textSearch.Location = new System.Drawing.Point(10, 40);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(243, 20);
            this.textSearch.TabIndex = 3;
            // 
            // comboCountry
            // 
            this.comboCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCountry.Enabled = false;
            this.comboCountry.FormattingEnabled = true;
            this.comboCountry.Location = new System.Drawing.Point(10, 12);
            this.comboCountry.Name = "comboCountry";
            this.comboCountry.Size = new System.Drawing.Size(118, 21);
            this.comboCountry.TabIndex = 4;
            // 
            // comboGender
            // 
            this.comboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboGender.Enabled = false;
            this.comboGender.FormattingEnabled = true;
            this.comboGender.Location = new System.Drawing.Point(135, 12);
            this.comboGender.Name = "comboGender";
            this.comboGender.Size = new System.Drawing.Size(118, 21);
            this.comboGender.TabIndex = 5;
            // 
            // comboCompany
            // 
            this.comboCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCompany.Enabled = false;
            this.comboCompany.FormattingEnabled = true;
            this.comboCompany.Location = new System.Drawing.Point(260, 12);
            this.comboCompany.Name = "comboCompany";
            this.comboCompany.Size = new System.Drawing.Size(118, 21);
            this.comboCompany.TabIndex = 6;
            // 
            // textLoad
            // 
            this.textLoad.Location = new System.Drawing.Point(10, 362);
            this.textLoad.Name = "textLoad";
            this.textLoad.Size = new System.Drawing.Size(243, 20);
            this.textLoad.TabIndex = 7;
            this.textLoad.TextChanged += new System.EventHandler(this.textLoad_TextChanged);
            this.textLoad.DoubleClick += new System.EventHandler(this.textLoad_DoubleClick);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Enabled = false;
            this.buttonLoad.Location = new System.Drawing.Point(260, 362);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(118, 21);
            this.buttonLoad.TabIndex = 8;
            this.buttonLoad.Text = "Cargar";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Enabled = false;
            this.buttonSearch.Location = new System.Drawing.Point(260, 39);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(118, 21);
            this.buttonSearch.TabIndex = 9;
            this.buttonSearch.Text = "Buscar";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // labelLoadTime
            // 
            this.labelLoadTime.Location = new System.Drawing.Point(10, 63);
            this.labelLoadTime.Name = "labelLoadTime";
            this.labelLoadTime.Size = new System.Drawing.Size(368, 21);
            this.labelLoadTime.TabIndex = 10;
            this.labelLoadTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 392);
            this.Controls.Add(this.labelLoadTime);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.textLoad);
            this.Controls.Add(this.comboCompany);
            this.Controls.Add(this.comboGender);
            this.Controls.Add(this.comboCountry);
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.listPeople);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form";
            this.ShowIcon = false;
            this.Text = "Pablo González";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listPeople;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.ComboBox comboCountry;
        private System.Windows.Forms.ComboBox comboGender;
        private System.Windows.Forms.ComboBox comboCompany;
        private System.Windows.Forms.TextBox textLoad;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelLoadTime;
    }
}

