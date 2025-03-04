namespace RealProjectWinFormCoures19
{
    partial class PeopleScreen
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
            this.components = new System.ComponentModel.Container();
            this.LManageScreen = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DGVManagePeople = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsShowDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsAddNewPerson = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsPhoneCall = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsSendEmail = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.LNumberOfPeople = new System.Windows.Forms.Label();
            this.CBFilterBy = new System.Windows.Forms.ComboBox();
            this.TBSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BTRefrash = new System.Windows.Forms.Button();
            this.PAddNewPerson = new System.Windows.Forms.PictureBox();
            this.BExPeopleScreen = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVManagePeople)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PAddNewPerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LManageScreen
            // 
            this.LManageScreen.AutoSize = true;
            this.LManageScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LManageScreen.ForeColor = System.Drawing.Color.Red;
            this.LManageScreen.Location = new System.Drawing.Point(467, 207);
            this.LManageScreen.Name = "LManageScreen";
            this.LManageScreen.Size = new System.Drawing.Size(299, 46);
            this.LManageScreen.TabIndex = 0;
            this.LManageScreen.Text = "Manage People";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(50, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filter By:";
            // 
            // DGVManagePeople
            // 
            this.DGVManagePeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVManagePeople.ContextMenuStrip = this.contextMenuStrip1;
            this.DGVManagePeople.Location = new System.Drawing.Point(36, 289);
            this.DGVManagePeople.Name = "DGVManagePeople";
            this.DGVManagePeople.RowHeadersWidth = 51;
            this.DGVManagePeople.RowTemplate.Height = 24;
            this.DGVManagePeople.Size = new System.Drawing.Size(1147, 320);
            this.DGVManagePeople.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsShowDetails,
            this.toolStripSeparator2,
            this.cmsAddNewPerson,
            this.cmsUpdate,
            this.cmsDelete,
            this.toolStripSeparator1,
            this.cmsPhoneCall,
            this.cmsSendEmail});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.contextMenuStrip1.Size = new System.Drawing.Size(215, 200);
            // 
            // cmsShowDetails
            // 
            this.cmsShowDetails.Image = global::RealProjectWinFormCoures19.Properties.Resources.business_card;
            this.cmsShowDetails.Name = "cmsShowDetails";
            this.cmsShowDetails.Size = new System.Drawing.Size(214, 26);
            this.cmsShowDetails.Text = "ShowDetails";
            this.cmsShowDetails.Click += new System.EventHandler(this.cmsShowDetails_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(211, 6);
            // 
            // cmsAddNewPerson
            // 
            this.cmsAddNewPerson.Image = global::RealProjectWinFormCoures19.Properties.Resources.add_group;
            this.cmsAddNewPerson.Name = "cmsAddNewPerson";
            this.cmsAddNewPerson.Size = new System.Drawing.Size(214, 26);
            this.cmsAddNewPerson.Text = "Add New Person";
            this.cmsAddNewPerson.Click += new System.EventHandler(this.cmsAddNewPerson_Click);
            // 
            // cmsUpdate
            // 
            this.cmsUpdate.Image = global::RealProjectWinFormCoures19.Properties.Resources.update;
            this.cmsUpdate.Name = "cmsUpdate";
            this.cmsUpdate.Size = new System.Drawing.Size(214, 26);
            this.cmsUpdate.Text = "Update";
            this.cmsUpdate.Click += new System.EventHandler(this.cmsUpdate_Click);
            // 
            // cmsDelete
            // 
            this.cmsDelete.Image = global::RealProjectWinFormCoures19.Properties.Resources.delete1;
            this.cmsDelete.Name = "cmsDelete";
            this.cmsDelete.Size = new System.Drawing.Size(214, 26);
            this.cmsDelete.Text = "Delete";
            this.cmsDelete.Click += new System.EventHandler(this.cmsDelete_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(211, 6);
            // 
            // cmsPhoneCall
            // 
            this.cmsPhoneCall.Image = global::RealProjectWinFormCoures19.Properties.Resources.phone_call;
            this.cmsPhoneCall.Name = "cmsPhoneCall";
            this.cmsPhoneCall.Size = new System.Drawing.Size(214, 26);
            this.cmsPhoneCall.Text = "Phone Call";
            // 
            // cmsSendEmail
            // 
            this.cmsSendEmail.Image = global::RealProjectWinFormCoures19.Properties.Resources.message;
            this.cmsSendEmail.Name = "cmsSendEmail";
            this.cmsSendEmail.Size = new System.Drawing.Size(214, 26);
            this.cmsSendEmail.Text = "Send Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SkyBlue;
            this.label2.Location = new System.Drawing.Point(33, 634);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "#Recorde:";
            // 
            // LNumberOfPeople
            // 
            this.LNumberOfPeople.AutoSize = true;
            this.LNumberOfPeople.BackColor = System.Drawing.Color.SkyBlue;
            this.LNumberOfPeople.Location = new System.Drawing.Point(110, 634);
            this.LNumberOfPeople.Name = "LNumberOfPeople";
            this.LNumberOfPeople.Size = new System.Drawing.Size(14, 16);
            this.LNumberOfPeople.TabIndex = 5;
            this.LNumberOfPeople.Text = "0";
            // 
            // CBFilterBy
            // 
            this.CBFilterBy.BackColor = System.Drawing.SystemColors.HighlightText;
            this.CBFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBFilterBy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CBFilterBy.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.CBFilterBy.FormattingEnabled = true;
            this.CBFilterBy.Items.AddRange(new object[] {
            "None",
            "PersonID",
            "National No",
            "First Name",
            "Secend Name",
            "Therd Name",
            "Last Name",
            "Nationatity",
            "Gendor",
            "Phone",
            "Email"});
            this.CBFilterBy.Location = new System.Drawing.Point(137, 254);
            this.CBFilterBy.Name = "CBFilterBy";
            this.CBFilterBy.Size = new System.Drawing.Size(130, 24);
            this.CBFilterBy.TabIndex = 7;
            this.CBFilterBy.SelectedIndexChanged += new System.EventHandler(this.CBFilterBy_SelectedIndexChanged);
            // 
            // TBSearch
            // 
            this.TBSearch.Location = new System.Drawing.Point(403, 254);
            this.TBSearch.Name = "TBSearch";
            this.TBSearch.Size = new System.Drawing.Size(146, 22);
            this.TBSearch.TabIndex = 9;
            this.TBSearch.TextChanged += new System.EventHandler(this.TBSearch_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(283, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Search By ID:";
            // 
            // BTRefrash
            // 
            this.BTRefrash.Location = new System.Drawing.Point(952, 240);
            this.BTRefrash.Name = "BTRefrash";
            this.BTRefrash.Size = new System.Drawing.Size(108, 38);
            this.BTRefrash.TabIndex = 11;
            this.BTRefrash.Text = "Refrash";
            this.BTRefrash.UseVisualStyleBackColor = true;
            this.BTRefrash.Click += new System.EventHandler(this.BTRefrash_Click);
            // 
            // PAddNewPerson
            // 
            this.PAddNewPerson.Image = global::RealProjectWinFormCoures19.Properties.Resources.add_group;
            this.PAddNewPerson.Location = new System.Drawing.Point(1095, 228);
            this.PAddNewPerson.Name = "PAddNewPerson";
            this.PAddNewPerson.Size = new System.Drawing.Size(88, 55);
            this.PAddNewPerson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PAddNewPerson.TabIndex = 8;
            this.PAddNewPerson.TabStop = false;
            this.PAddNewPerson.Click += new System.EventHandler(this.pictureBox2_Click);
            this.PAddNewPerson.MouseEnter += new System.EventHandler(this.PAddNewPerson_MouseEnter);
            this.PAddNewPerson.MouseLeave += new System.EventHandler(this.PAddNewPerson_MouseLeave);
            // 
            // BExPeopleScreen
            // 
            this.BExPeopleScreen.BackColor = System.Drawing.Color.SkyBlue;
            this.BExPeopleScreen.Image = global::RealProjectWinFormCoures19.Properties.Resources.close;
            this.BExPeopleScreen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BExPeopleScreen.Location = new System.Drawing.Point(1044, 628);
            this.BExPeopleScreen.Name = "BExPeopleScreen";
            this.BExPeopleScreen.Size = new System.Drawing.Size(139, 29);
            this.BExPeopleScreen.TabIndex = 6;
            this.BExPeopleScreen.Text = "Close";
            this.BExPeopleScreen.UseVisualStyleBackColor = false;
            this.BExPeopleScreen.Click += new System.EventHandler(this.BExPeopleScreen_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RealProjectWinFormCoures19.Properties.Resources.group;
            this.pictureBox1.Location = new System.Drawing.Point(453, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(329, 171);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // PeopleScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1224, 684);
            this.Controls.Add(this.BTRefrash);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBSearch);
            this.Controls.Add(this.PAddNewPerson);
            this.Controls.Add(this.CBFilterBy);
            this.Controls.Add(this.BExPeopleScreen);
            this.Controls.Add(this.LNumberOfPeople);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DGVManagePeople);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LManageScreen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PeopleScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PeopleScreen";
            this.Load += new System.EventHandler(this.PeopleScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVManagePeople)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PAddNewPerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LManageScreen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGVManagePeople;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LNumberOfPeople;
        private System.Windows.Forms.Button BExPeopleScreen;
        private System.Windows.Forms.ComboBox CBFilterBy;
        private System.Windows.Forms.PictureBox PAddNewPerson;
        private System.Windows.Forms.TextBox TBSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cmsUpdate;
        private System.Windows.Forms.ToolStripMenuItem cmsDelete;
        private System.Windows.Forms.Button BTRefrash;
        private System.Windows.Forms.ToolStripMenuItem cmsShowDetails;
        private System.Windows.Forms.ToolStripMenuItem cmsAddNewPerson;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem cmsPhoneCall;
        private System.Windows.Forms.ToolStripMenuItem cmsSendEmail;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}