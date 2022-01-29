
namespace DatabaseFirst_LinqtoSql
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnRecherche = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnModifer = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnRaport = new System.Windows.Forms.Button();
            this.btnFremer = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.ListBox = new System.Windows.Forms.ListBox();
            this.cbDept = new System.Windows.Forms.ComboBox();
            this.dtpEmbauche = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtJob = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnOrderbyName = new System.Windows.Forms.Button();
            this.btnOrderSalire = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnJoinEmpWithDept = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnPerviews = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRecherche
            // 
            this.btnRecherche.Font = new System.Drawing.Font("Poppins SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecherche.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnRecherche.Location = new System.Drawing.Point(898, 29);
            this.btnRecherche.Name = "btnRecherche";
            this.btnRecherche.Size = new System.Drawing.Size(236, 40);
            this.btnRecherche.TabIndex = 0;
            this.btnRecherche.Text = "Recherche";
            this.btnRecherche.UseVisualStyleBackColor = true;
            this.btnRecherche.Click += new System.EventHandler(this.btnRecherche_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Font = new System.Drawing.Font("Poppins SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnAjouter.Location = new System.Drawing.Point(898, 167);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(236, 40);
            this.btnAjouter.TabIndex = 1;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnModifer
            // 
            this.btnModifer.Font = new System.Drawing.Font("Poppins SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifer.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnModifer.Location = new System.Drawing.Point(898, 121);
            this.btnModifer.Name = "btnModifer";
            this.btnModifer.Size = new System.Drawing.Size(236, 40);
            this.btnModifer.TabIndex = 2;
            this.btnModifer.Text = "Modifer";
            this.btnModifer.UseVisualStyleBackColor = true;
            this.btnModifer.Click += new System.EventHandler(this.btnModifer_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Font = new System.Drawing.Font("Poppins SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnSupprimer.Location = new System.Drawing.Point(898, 75);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(236, 40);
            this.btnSupprimer.TabIndex = 3;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnRaport
            // 
            this.btnRaport.Font = new System.Drawing.Font("Poppins SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaport.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnRaport.Location = new System.Drawing.Point(898, 475);
            this.btnRaport.Name = "btnRaport";
            this.btnRaport.Size = new System.Drawing.Size(236, 40);
            this.btnRaport.TabIndex = 5;
            this.btnRaport.Text = "Report";
            this.btnRaport.UseVisualStyleBackColor = true;
            // 
            // btnFremer
            // 
            this.btnFremer.Font = new System.Drawing.Font("Poppins SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFremer.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnFremer.Location = new System.Drawing.Point(898, 567);
            this.btnFremer.Name = "btnFremer";
            this.btnFremer.Size = new System.Drawing.Size(236, 40);
            this.btnFremer.TabIndex = 6;
            this.btnFremer.Text = "fermer";
            this.btnFremer.UseVisualStyleBackColor = true;
            this.btnFremer.Click += new System.EventHandler(this.btnFremer_Click);
            // 
            // dgv
            // 
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgv.Location = new System.Drawing.Point(40, 487);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(785, 283);
            this.dgv.TabIndex = 7;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            this.dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellDoubleClick);
            // 
            // ListBox
            // 
            this.ListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListBox.FormattingEnabled = true;
            this.ListBox.ItemHeight = 16;
            this.ListBox.Location = new System.Drawing.Point(40, 270);
            this.ListBox.Name = "ListBox";
            this.ListBox.Size = new System.Drawing.Size(785, 176);
            this.ListBox.TabIndex = 8;
            // 
            // cbDept
            // 
            this.cbDept.FormattingEnabled = true;
            this.cbDept.Location = new System.Drawing.Point(579, 193);
            this.cbDept.Name = "cbDept";
            this.cbDept.Size = new System.Drawing.Size(246, 24);
            this.cbDept.TabIndex = 45;
            this.cbDept.SelectionChangeCommitted += new System.EventHandler(this.cbDept_SelectionChangeCommitted);
            // 
            // dtpEmbauche
            // 
            this.dtpEmbauche.Location = new System.Drawing.Point(579, 235);
            this.dtpEmbauche.Name = "dtpEmbauche";
            this.dtpEmbauche.Size = new System.Drawing.Size(246, 22);
            this.dtpEmbauche.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(483, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 17);
            this.label7.TabIndex = 43;
            this.label7.Text = "Département";
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(579, 136);
            this.txtSalary.Multiline = true;
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(246, 30);
            this.txtSalary.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(500, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 41;
            this.label6.Text = "Salaire";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(461, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 17);
            this.label5.TabIndex = 40;
            this.label5.Text = "Date d\'embauche";
            // 
            // txtJob
            // 
            this.txtJob.Location = new System.Drawing.Point(183, 232);
            this.txtJob.Multiline = true;
            this.txtJob.Name = "txtJob";
            this.txtJob.Size = new System.Drawing.Size(246, 30);
            this.txtJob.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 38;
            this.label4.Text = "Fonction";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(183, 184);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(246, 30);
            this.txtName.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 36;
            this.label3.Text = "Nom";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(183, 146);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(246, 30);
            this.txtID.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 17);
            this.label2.TabIndex = 34;
            this.label2.Text = "ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(39, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 53);
            this.label1.TabIndex = 33;
            this.label1.Text = "Détails des employés";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Poppins SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnClear.Location = new System.Drawing.Point(898, 521);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(236, 40);
            this.btnClear.TabIndex = 46;
            this.btnClear.Text = "Effacer";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Poppins SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.DarkBlue;
            this.button7.Location = new System.Drawing.Point(898, 431);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(236, 38);
            this.button7.TabIndex = 53;
            this.button7.Text = "select Sepecfic Columns";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Poppins SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkBlue;
            this.button1.Location = new System.Drawing.Point(898, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(236, 38);
            this.button1.TabIndex = 52;
            this.button1.Text = "Count Emplyees by job < 5";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Poppins SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.DarkBlue;
            this.button4.Location = new System.Drawing.Point(898, 299);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(236, 38);
            this.button4.TabIndex = 49;
            this.button4.Text = "Count Employees by Job ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnOrderbyName
            // 
            this.btnOrderbyName.Font = new System.Drawing.Font("Poppins SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderbyName.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnOrderbyName.Location = new System.Drawing.Point(898, 255);
            this.btnOrderbyName.Name = "btnOrderbyName";
            this.btnOrderbyName.Size = new System.Drawing.Size(236, 38);
            this.btnOrderbyName.TabIndex = 48;
            this.btnOrderbyName.Text = "Order EmpName Descending";
            this.btnOrderbyName.UseVisualStyleBackColor = true;
            this.btnOrderbyName.Click += new System.EventHandler(this.btnOrderbyName_Click);
            // 
            // btnOrderSalire
            // 
            this.btnOrderSalire.Font = new System.Drawing.Font("Poppins SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderSalire.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnOrderSalire.Location = new System.Drawing.Point(898, 213);
            this.btnOrderSalire.Name = "btnOrderSalire";
            this.btnOrderSalire.Size = new System.Drawing.Size(236, 37);
            this.btnOrderSalire.TabIndex = 47;
            this.btnOrderSalire.Text = "Order  Salary Asecending";
            this.btnOrderSalire.UseVisualStyleBackColor = true;
            this.btnOrderSalire.Click += new System.EventHandler(this.btnOrderSalire_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Indigo;
            this.label8.Location = new System.Drawing.Point(354, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(251, 53);
            this.label8.TabIndex = 54;
            this.label8.Text = "DataBase First ";
            // 
            // BtnJoinEmpWithDept
            // 
            this.BtnJoinEmpWithDept.Font = new System.Drawing.Font("Poppins SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnJoinEmpWithDept.ForeColor = System.Drawing.Color.DarkBlue;
            this.BtnJoinEmpWithDept.Location = new System.Drawing.Point(898, 387);
            this.BtnJoinEmpWithDept.Name = "BtnJoinEmpWithDept";
            this.BtnJoinEmpWithDept.Size = new System.Drawing.Size(236, 38);
            this.BtnJoinEmpWithDept.TabIndex = 55;
            this.BtnJoinEmpWithDept.Text = "Join emp with Dept";
            this.BtnJoinEmpWithDept.UseVisualStyleBackColor = true;
            this.BtnJoinEmpWithDept.Click += new System.EventHandler(this.BtnJoinEmpWithDept_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Font = new System.Drawing.Font("Poppins SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirst.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnFirst.Location = new System.Drawing.Point(898, 623);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(109, 40);
            this.btnFirst.TabIndex = 56;
            this.btnFirst.Text = "First";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnLast
            // 
            this.btnLast.Font = new System.Drawing.Font("Poppins SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnLast.Location = new System.Drawing.Point(1025, 623);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(109, 40);
            this.btnLast.TabIndex = 57;
            this.btnLast.Text = "Last";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnPerviews
            // 
            this.btnPerviews.Font = new System.Drawing.Font("Poppins SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerviews.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnPerviews.Location = new System.Drawing.Point(898, 669);
            this.btnPerviews.Name = "btnPerviews";
            this.btnPerviews.Size = new System.Drawing.Size(109, 40);
            this.btnPerviews.TabIndex = 59;
            this.btnPerviews.Text = "Previews";
            this.btnPerviews.UseVisualStyleBackColor = true;
            this.btnPerviews.Click += new System.EventHandler(this.btnPerviews_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Poppins SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnNext.Location = new System.Drawing.Point(1025, 669);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(109, 40);
            this.btnNext.TabIndex = 58;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Font = new System.Drawing.Font("Poppins SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnAddNew.Location = new System.Drawing.Point(1025, 715);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(109, 40);
            this.btnAddNew.TabIndex = 60;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 794);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnPerviews);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.BtnJoinEmpWithDept);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnOrderbyName);
            this.Controls.Add(this.btnOrderSalire);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.cbDept);
            this.Controls.Add(this.dtpEmbauche);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtJob);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListBox);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btnFremer);
            this.Controls.Add(this.btnRaport);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifer);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnRecherche);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "DataBase first ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRecherche;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnModifer;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnRaport;
        private System.Windows.Forms.Button btnFremer;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.ListBox ListBox;
        private System.Windows.Forms.ComboBox cbDept;
        private System.Windows.Forms.DateTimePicker dtpEmbauche;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtJob;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnOrderbyName;
        private System.Windows.Forms.Button btnOrderSalire;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnJoinEmpWithDept;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnPerviews;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnAddNew;
    }
}

