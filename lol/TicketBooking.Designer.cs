namespace AirlineManagmentSystem
{
    partial class TicketBooking
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicketBooking));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Tid = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.FCodeCb = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PIdCb = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PnameTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PPassTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.PNatTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.PAmtTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TicketDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TicketDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(737, 31);
            this.panel1.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(710, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 23);
            this.label7.TabIndex = 22;
            this.label7.Text = "X";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(283, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 27);
            this.label2.TabIndex = 24;
            this.label2.Text = "Booking Ticket";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(236, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 34);
            this.label1.TabIndex = 23;
            this.label1.Text = "SilverWing Airlines";
            // 
            // Tid
            // 
            this.Tid.Animated = true;
            this.Tid.AutoRoundedCorners = true;
            this.Tid.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.Tid.BorderRadius = 11;
            this.Tid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Tid.DefaultText = "";
            this.Tid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Tid.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Tid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Tid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Tid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Tid.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.Tid.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Tid.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Tid.Location = new System.Drawing.Point(147, 128);
            this.Tid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Tid.Name = "Tid";
            this.Tid.PasswordChar = '\0';
            this.Tid.PlaceholderForeColor = System.Drawing.Color.CornflowerBlue;
            this.Tid.PlaceholderText = "ID";
            this.Tid.SelectedText = "";
            this.Tid.Size = new System.Drawing.Size(201, 24);
            this.Tid.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label9.Location = new System.Drawing.Point(6, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 23);
            this.label9.TabIndex = 25;
            this.label9.Text = "Ticket ID";
            // 
            // FCodeCb
            // 
            this.FCodeCb.AutoRoundedCorners = true;
            this.FCodeCb.BackColor = System.Drawing.Color.Transparent;
            this.FCodeCb.BorderRadius = 17;
            this.FCodeCb.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.FCodeCb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.FCodeCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FCodeCb.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FCodeCb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FCodeCb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.FCodeCb.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.FCodeCb.ItemHeight = 30;
            this.FCodeCb.Location = new System.Drawing.Point(513, 119);
            this.FCodeCb.Name = "FCodeCb";
            this.FCodeCb.Size = new System.Drawing.Size(193, 36);
            this.FCodeCb.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Location = new System.Drawing.Point(381, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 23);
            this.label3.TabIndex = 28;
            this.label3.Text = "Flight ID";
            // 
            // PIdCb
            // 
            this.PIdCb.AutoRoundedCorners = true;
            this.PIdCb.BackColor = System.Drawing.Color.Transparent;
            this.PIdCb.BorderRadius = 17;
            this.PIdCb.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.PIdCb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.PIdCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PIdCb.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PIdCb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PIdCb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.PIdCb.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.PIdCb.ItemHeight = 30;
            this.PIdCb.Location = new System.Drawing.Point(147, 165);
            this.PIdCb.Name = "PIdCb";
            this.PIdCb.Size = new System.Drawing.Size(201, 36);
            this.PIdCb.TabIndex = 31;
            this.PIdCb.SelectionChangeCommitted += new System.EventHandler(this.PIdCb_SelectionChangeCommitted);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label4.Location = new System.Drawing.Point(6, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 23);
            this.label4.TabIndex = 30;
            this.label4.Text = "Passenger ID";
            // 
            // PnameTb
            // 
            this.PnameTb.Animated = true;
            this.PnameTb.AutoRoundedCorners = true;
            this.PnameTb.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.PnameTb.BorderRadius = 11;
            this.PnameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PnameTb.DefaultText = "";
            this.PnameTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PnameTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PnameTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PnameTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PnameTb.Enabled = false;
            this.PnameTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PnameTb.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.PnameTb.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.PnameTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PnameTb.Location = new System.Drawing.Point(513, 171);
            this.PnameTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PnameTb.Name = "PnameTb";
            this.PnameTb.PasswordChar = '\0';
            this.PnameTb.PlaceholderForeColor = System.Drawing.Color.CornflowerBlue;
            this.PnameTb.PlaceholderText = "";
            this.PnameTb.SelectedText = "";
            this.PnameTb.Size = new System.Drawing.Size(193, 24);
            this.PnameTb.TabIndex = 59;
            this.PnameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label5.Location = new System.Drawing.Point(381, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 23);
            this.label5.TabIndex = 58;
            this.label5.Text = "Name";
            // 
            // PPassTb
            // 
            this.PPassTb.Animated = true;
            this.PPassTb.AutoRoundedCorners = true;
            this.PPassTb.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.PPassTb.BorderRadius = 11;
            this.PPassTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PPassTb.DefaultText = "";
            this.PPassTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PPassTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PPassTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PPassTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PPassTb.Enabled = false;
            this.PPassTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PPassTb.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.PPassTb.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.PPassTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PPassTb.Location = new System.Drawing.Point(147, 216);
            this.PPassTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PPassTb.Name = "PPassTb";
            this.PPassTb.PasswordChar = '\0';
            this.PPassTb.PlaceholderForeColor = System.Drawing.Color.CornflowerBlue;
            this.PPassTb.PlaceholderText = "";
            this.PPassTb.SelectedText = "";
            this.PPassTb.Size = new System.Drawing.Size(201, 24);
            this.PPassTb.TabIndex = 57;
            this.PPassTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label6.Location = new System.Drawing.Point(6, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 23);
            this.label6.TabIndex = 56;
            this.label6.Text = "Passp Num";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label8.Location = new System.Drawing.Point(381, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 23);
            this.label8.TabIndex = 54;
            this.label8.Text = "Nationality";
            // 
            // PNatTb
            // 
            this.PNatTb.Animated = true;
            this.PNatTb.AutoRoundedCorners = true;
            this.PNatTb.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.PNatTb.BorderRadius = 11;
            this.PNatTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PNatTb.DefaultText = "";
            this.PNatTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PNatTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PNatTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PNatTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PNatTb.Enabled = false;
            this.PNatTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PNatTb.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.PNatTb.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.PNatTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PNatTb.Location = new System.Drawing.Point(513, 217);
            this.PNatTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PNatTb.Name = "PNatTb";
            this.PNatTb.PasswordChar = '\0';
            this.PNatTb.PlaceholderForeColor = System.Drawing.Color.CornflowerBlue;
            this.PNatTb.PlaceholderText = "";
            this.PNatTb.SelectedText = "";
            this.PNatTb.Size = new System.Drawing.Size(193, 24);
            this.PNatTb.TabIndex = 60;
            this.PNatTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PAmtTb
            // 
            this.PAmtTb.Animated = true;
            this.PAmtTb.AutoRoundedCorners = true;
            this.PAmtTb.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.PAmtTb.BorderRadius = 11;
            this.PAmtTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PAmtTb.DefaultText = "";
            this.PAmtTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PAmtTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PAmtTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PAmtTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PAmtTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PAmtTb.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.PAmtTb.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.PAmtTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PAmtTb.Location = new System.Drawing.Point(347, 257);
            this.PAmtTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PAmtTb.Name = "PAmtTb";
            this.PAmtTb.PasswordChar = '\0';
            this.PAmtTb.PlaceholderForeColor = System.Drawing.Color.CornflowerBlue;
            this.PAmtTb.PlaceholderText = "";
            this.PAmtTb.SelectedText = "";
            this.PAmtTb.Size = new System.Drawing.Size(193, 24);
            this.PAmtTb.TabIndex = 64;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label11.Location = new System.Drawing.Point(215, 258);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 23);
            this.label11.TabIndex = 63;
            this.label11.Text = "Amount";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button3.Location = new System.Drawing.Point(441, 309);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 35);
            this.button3.TabIndex = 68;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Location = new System.Drawing.Point(320, 309);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 35);
            this.button2.TabIndex = 67;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(202, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 35);
            this.button1.TabIndex = 66;
            this.button1.Text = "Book";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 591);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(736, 23);
            this.panel2.TabIndex = 70;
            // 
            // TicketDGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.TicketDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TicketDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.TicketDGV.ColumnHeadersHeight = 30;
            this.TicketDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TicketDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.TicketDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.TicketDGV.Location = new System.Drawing.Point(1, 375);
            this.TicketDGV.Name = "TicketDGV";
            this.TicketDGV.RowHeadersVisible = false;
            this.TicketDGV.RowHeadersWidth = 51;
            this.TicketDGV.RowTemplate.Height = 24;
            this.TicketDGV.Size = new System.Drawing.Size(733, 214);
            this.TicketDGV.TabIndex = 69;
            this.TicketDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.TicketDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.TicketDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.TicketDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.TicketDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.TicketDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.TicketDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.TicketDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.CornflowerBlue;
            this.TicketDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.TicketDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TicketDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.TicketDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.TicketDGV.ThemeStyle.HeaderStyle.Height = 30;
            this.TicketDGV.ThemeStyle.ReadOnly = false;
            this.TicketDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.TicketDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.TicketDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TicketDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.TicketDGV.ThemeStyle.RowsStyle.Height = 24;
            this.TicketDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.TicketDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // TicketBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 614);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.TicketDGV);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PAmtTb);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.PNatTb);
            this.Controls.Add(this.PnameTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PPassTb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.PIdCb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FCodeCb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Tid);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TicketBooking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicketBooking";
            this.Load += new System.EventHandler(this.TicketBooking_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TicketDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox Tid;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2ComboBox FCodeCb;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox PIdCb;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox PnameTb;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox PPassTb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox PNatTb;
        private Guna.UI2.WinForms.Guna2TextBox PAmtTb;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2DataGridView TicketDGV;
    }
}