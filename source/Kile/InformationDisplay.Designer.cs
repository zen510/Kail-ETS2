namespace Kile
{
    partial class InformationDisplay
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InformationDisplay));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.light = new System.Windows.Forms.PictureBox();
            this.parkbrake = new System.Windows.Forms.PictureBox();
            this.airpressure = new System.Windows.Forms.PictureBox();
            this.warning = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.truckspeed = new System.Windows.Forms.Label();
            this.cruisecontrolspeed = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.eta = new System.Windows.Forms.Label();
            this.distance = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.city = new System.Windows.Forms.Label();
            this.arrives = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.nextreststoptime = new System.Windows.Forms.Label();
            this.remainingTime = new System.Windows.Forms.Label();
            this.company = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cargo = new System.Windows.Forms.Label();
            this.gear = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.speedlimit = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.light)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkbrake)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airpressure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warning)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.light, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.parkbrake, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.airpressure, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.warning, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(424, 180);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(128, 130);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // light
            // 
            this.light.Dock = System.Windows.Forms.DockStyle.Fill;
            this.light.Image = global::Kile.Properties.Resources.lowbeam;
            this.light.Location = new System.Drawing.Point(3, 68);
            this.light.Name = "light";
            this.light.Size = new System.Drawing.Size(58, 59);
            this.light.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.light.TabIndex = 5;
            this.light.TabStop = false;
            // 
            // parkbrake
            // 
            this.parkbrake.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parkbrake.Image = ((System.Drawing.Image)(resources.GetObject("parkbrake.Image")));
            this.parkbrake.Location = new System.Drawing.Point(67, 3);
            this.parkbrake.Name = "parkbrake";
            this.parkbrake.Size = new System.Drawing.Size(58, 59);
            this.parkbrake.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.parkbrake.TabIndex = 5;
            this.parkbrake.TabStop = false;
            // 
            // airpressure
            // 
            this.airpressure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.airpressure.Image = global::Kile.Properties.Resources.airpressure;
            this.airpressure.Location = new System.Drawing.Point(3, 3);
            this.airpressure.Name = "airpressure";
            this.airpressure.Size = new System.Drawing.Size(58, 59);
            this.airpressure.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.airpressure.TabIndex = 2;
            this.airpressure.TabStop = false;
            // 
            // warning
            // 
            this.warning.Dock = System.Windows.Forms.DockStyle.Fill;
            this.warning.Image = ((System.Drawing.Image)(resources.GetObject("warning.Image")));
            this.warning.Location = new System.Drawing.Point(67, 68);
            this.warning.Name = "warning";
            this.warning.Size = new System.Drawing.Size(58, 59);
            this.warning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.warning.TabIndex = 6;
            this.warning.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.label3, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox7, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.truckspeed, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.cruisecontrolspeed, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(251, 143);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(190, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "km/h";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Image = global::Kile.Properties.Resources.speedmeter;
            this.pictureBox3.Location = new System.Drawing.Point(4, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(92, 64);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox7.Image = global::Kile.Properties.Resources.cruisecontrol;
            this.pictureBox7.Location = new System.Drawing.Point(4, 75);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(92, 64);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 5;
            this.pictureBox7.TabStop = false;
            // 
            // truckspeed
            // 
            this.truckspeed.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.truckspeed.AutoSize = true;
            this.truckspeed.Font = new System.Drawing.Font("メイリオ", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.truckspeed.ForeColor = System.Drawing.Color.White;
            this.truckspeed.Location = new System.Drawing.Point(103, 14);
            this.truckspeed.Name = "truckspeed";
            this.truckspeed.Size = new System.Drawing.Size(80, 44);
            this.truckspeed.TabIndex = 6;
            this.truckspeed.Text = "000";
            this.truckspeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cruisecontrolspeed
            // 
            this.cruisecontrolspeed.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cruisecontrolspeed.AutoSize = true;
            this.cruisecontrolspeed.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cruisecontrolspeed.ForeColor = System.Drawing.Color.White;
            this.cruisecontrolspeed.Location = new System.Drawing.Point(104, 85);
            this.cruisecontrolspeed.Name = "cruisecontrolspeed";
            this.cruisecontrolspeed.Size = new System.Drawing.Size(79, 43);
            this.cruisecontrolspeed.TabIndex = 7;
            this.cruisecontrolspeed.Text = "000";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(190, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "km/h";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel3.Controls.Add(this.eta, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.distance, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.city, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.arrives, 1, 3);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 180);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(418, 127);
            this.tableLayoutPanel3.TabIndex = 7;
            // 
            // eta
            // 
            this.eta.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.eta.AutoSize = true;
            this.eta.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.eta.ForeColor = System.Drawing.Color.White;
            this.eta.Location = new System.Drawing.Point(365, 66);
            this.eta.Name = "eta";
            this.eta.Size = new System.Drawing.Size(49, 24);
            this.eta.TabIndex = 5;
            this.eta.Text = "8:10";
            // 
            // distance
            // 
            this.distance.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.distance.AutoSize = true;
            this.distance.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.distance.ForeColor = System.Drawing.Color.White;
            this.distance.Location = new System.Drawing.Point(345, 35);
            this.distance.Name = "distance";
            this.distance.Size = new System.Drawing.Size(69, 24);
            this.distance.TabIndex = 4;
            this.distance.Text = "334km";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("メイリオ", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(24, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 28);
            this.label4.TabIndex = 0;
            this.label4.Text = "目的地:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("メイリオ", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(31, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 28);
            this.label5.TabIndex = 1;
            this.label5.Text = "距離  :";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("メイリオ", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(31, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 28);
            this.label6.TabIndex = 2;
            this.label6.Text = "ETA  :";
            // 
            // city
            // 
            this.city.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.city.AutoSize = true;
            this.city.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.city.ForeColor = System.Drawing.Color.White;
            this.city.Location = new System.Drawing.Point(308, 4);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(106, 24);
            this.city.TabIndex = 3;
            this.city.Text = "Strasbourg";
            // 
            // arrives
            // 
            this.arrives.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.arrives.AutoSize = true;
            this.arrives.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.arrives.ForeColor = System.Drawing.Color.White;
            this.arrives.Location = new System.Drawing.Point(328, 98);
            this.arrives.Name = "arrives";
            this.arrives.Size = new System.Drawing.Size(86, 24);
            this.arrives.TabIndex = 6;
            this.arrives.Text = "3h34min";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel4.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label7, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(424, 146);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(125, 30);
            this.tableLayoutPanel4.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Kile.Properties.Resources.if_fuel_103260;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AccessibleDescription = "fuel";
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(43, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 30);
            this.label7.TabIndex = 1;
            this.label7.Text = "0000";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Controls.Add(this.nextreststoptime, 1, 3);
            this.tableLayoutPanel5.Controls.Add(this.remainingTime, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.company, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.label11, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.label10, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.label9, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.cargo, 1, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(261, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 4;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(210, 143);
            this.tableLayoutPanel5.TabIndex = 9;
            // 
            // nextreststoptime
            // 
            this.nextreststoptime.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.nextreststoptime.AutoSize = true;
            this.nextreststoptime.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nextreststoptime.ForeColor = System.Drawing.Color.White;
            this.nextreststoptime.Location = new System.Drawing.Point(142, 115);
            this.nextreststoptime.Name = "nextreststoptime";
            this.nextreststoptime.Size = new System.Drawing.Size(64, 18);
            this.nextreststoptime.TabIndex = 7;
            this.nextreststoptime.Text = "8h93min";
            // 
            // remainingTime
            // 
            this.remainingTime.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.remainingTime.AutoSize = true;
            this.remainingTime.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.remainingTime.ForeColor = System.Drawing.Color.White;
            this.remainingTime.Location = new System.Drawing.Point(142, 79);
            this.remainingTime.Name = "remainingTime";
            this.remainingTime.Size = new System.Drawing.Size(64, 18);
            this.remainingTime.TabIndex = 6;
            this.remainingTime.Text = "33h4min";
            // 
            // company
            // 
            this.company.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.company.AutoSize = true;
            this.company.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.company.ForeColor = System.Drawing.Color.White;
            this.company.Location = new System.Drawing.Point(148, 44);
            this.company.Name = "company";
            this.company.Size = new System.Drawing.Size(58, 18);
            this.company.TabIndex = 5;
            this.company.Text = "Trameri";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("メイリオ", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(37, 2);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 31);
            this.label8.TabIndex = 0;
            this.label8.Text = "貨物:";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(21, 112);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 24);
            this.label11.TabIndex = 3;
            this.label11.Text = "休憩まで:";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("メイリオ", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(16, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 31);
            this.label10.TabIndex = 2;
            this.label10.Text = "配送先:";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(21, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 24);
            this.label9.TabIndex = 1;
            this.label9.Text = "残り時間:";
            // 
            // cargo
            // 
            this.cargo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cargo.AutoSize = true;
            this.cargo.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cargo.ForeColor = System.Drawing.Color.White;
            this.cargo.Location = new System.Drawing.Point(149, 9);
            this.cargo.Name = "cargo";
            this.cargo.Size = new System.Drawing.Size(57, 18);
            this.cargo.TabIndex = 4;
            this.cargo.Text = "野菜(1t)";
            // 
            // gear
            // 
            this.gear.AutoSize = true;
            this.gear.Font = new System.Drawing.Font("メイリオ", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.gear.ForeColor = System.Drawing.Color.White;
            this.gear.Location = new System.Drawing.Point(474, 87);
            this.gear.Name = "gear";
            this.gear.Size = new System.Drawing.Size(83, 44);
            this.gear.TabIndex = 10;
            this.gear.Text = "D12";
            this.gear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.ForeColor = System.Drawing.Color.White;
            this.time.Location = new System.Drawing.Point(159, 147);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(135, 32);
            this.time.TabIndex = 11;
            this.time.Text = "11:45:14";
            this.time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // speedlimit
            // 
            this.speedlimit.Font = new System.Drawing.Font("メイリオ", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.speedlimit.ForeColor = System.Drawing.Color.Red;
            this.speedlimit.Image = global::Kile.Properties.Resources.speedlimit;
            this.speedlimit.Location = new System.Drawing.Point(477, 0);
            this.speedlimit.Name = "speedlimit";
            this.speedlimit.Size = new System.Drawing.Size(72, 72);
            this.speedlimit.TabIndex = 1;
            this.speedlimit.Text = "90";
            this.speedlimit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InformationDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(22)))));
            this.Controls.Add(this.time);
            this.Controls.Add(this.gear);
            this.Controls.Add(this.tableLayoutPanel5);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.speedlimit);
            this.Name = "InformationDisplay";
            this.Size = new System.Drawing.Size(552, 310);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.light)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkbrake)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airpressure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warning)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label speedlimit;
        private System.Windows.Forms.PictureBox airpressure;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox light;
        private System.Windows.Forms.PictureBox parkbrake;
        private System.Windows.Forms.PictureBox warning;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label truckspeed;
        private System.Windows.Forms.Label cruisecontrolspeed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label nextreststoptime;
        private System.Windows.Forms.Label remainingTime;
        private System.Windows.Forms.Label company;
        private System.Windows.Forms.Label cargo;
        private System.Windows.Forms.Label gear;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label city;
        private System.Windows.Forms.Label eta;
        private System.Windows.Forms.Label distance;
        private System.Windows.Forms.Label arrives;
    }
}
