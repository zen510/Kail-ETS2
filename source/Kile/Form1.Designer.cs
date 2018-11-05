namespace Kile
{
    partial class Form1
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

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.powerbutton = new System.Windows.Forms.Button();
            this.updatetimer = new System.Windows.Forms.Timer(this.components);
            this.CloseButton = new System.Windows.Forms.Button();
            this.settingbutton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.day = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.eta = new System.Windows.Forms.Label();
            this.distance = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.city = new System.Windows.Forms.Label();
            this.arrives = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fuel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.light = new System.Windows.Forms.PictureBox();
            this.parkbrake = new System.Windows.Forms.PictureBox();
            this.airpressure = new System.Windows.Forms.PictureBox();
            this.hazard = new System.Windows.Forms.PictureBox();
            this.gear = new System.Windows.Forms.Label();
            this.speedlimit = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.nextreststoptime = new System.Windows.Forms.Label();
            this.remainingTime = new System.Windows.Forms.Label();
            this.company = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cargo = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.truckspeed = new System.Windows.Forms.Label();
            this.cruisecontrolspeed = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.indicator = new System.Windows.Forms.Label();
            this.settingDisplay = new Kile.SettingDisplay();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.light)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkbrake)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airpressure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hazard)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // powerbutton
            // 
            this.powerbutton.BackColor = System.Drawing.Color.Gray;
            resources.ApplyResources(this.powerbutton, "powerbutton");
            this.powerbutton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.powerbutton.Name = "powerbutton";
            this.powerbutton.UseMnemonic = false;
            this.powerbutton.UseVisualStyleBackColor = false;
            this.powerbutton.Click += new System.EventHandler(this.powerbutton_Click);
            // 
            // updatetimer
            // 
            this.updatetimer.Interval = 20;
            this.updatetimer.Tick += new System.EventHandler(this.updatetimer_Tick);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            resources.ApplyResources(this.CloseButton, "CloseButton");
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // settingbutton
            // 
            this.settingbutton.BackColor = System.Drawing.Color.Gray;
            resources.ApplyResources(this.settingbutton, "settingbutton");
            this.settingbutton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.settingbutton.Name = "settingbutton";
            this.settingbutton.UseVisualStyleBackColor = false;
            this.settingbutton.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gray;
            resources.ApplyResources(this.button3, "button3");
            this.button3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.day);
            this.panel1.Controls.Add(this.tableLayoutPanel3);
            this.panel1.Controls.Add(this.time);
            this.panel1.Controls.Add(this.tableLayoutPanel4);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.gear);
            this.panel1.Controls.Add(this.speedlimit);
            this.panel1.Controls.Add(this.tableLayoutPanel5);
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // day
            // 
            resources.ApplyResources(this.day, "day");
            this.day.ForeColor = System.Drawing.Color.White;
            this.day.Name = "day";
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel3.Controls.Add(this.eta, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.distance, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.city, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.arrives, 1, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // eta
            // 
            resources.ApplyResources(this.eta, "eta");
            this.eta.ForeColor = System.Drawing.Color.White;
            this.eta.Name = "eta";
            // 
            // distance
            // 
            resources.ApplyResources(this.distance, "distance");
            this.distance.ForeColor = System.Drawing.Color.White;
            this.distance.Name = "distance";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Name = "label6";
            // 
            // city
            // 
            resources.ApplyResources(this.city, "city");
            this.city.ForeColor = System.Drawing.Color.White;
            this.city.Name = "city";
            // 
            // arrives
            // 
            resources.ApplyResources(this.arrives, "arrives");
            this.arrives.ForeColor = System.Drawing.Color.White;
            this.arrives.Name = "arrives";
            // 
            // time
            // 
            resources.ApplyResources(this.time, "time");
            this.time.ForeColor = System.Drawing.Color.White;
            this.time.Name = "time";
            // 
            // tableLayoutPanel4
            // 
            resources.ApplyResources(this.tableLayoutPanel4, "tableLayoutPanel4");
            this.tableLayoutPanel4.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.fuel, 1, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Kile.Properties.Resources.if_fuel_103260;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // fuel
            // 
            resources.ApplyResources(this.fuel, "fuel");
            this.fuel.ForeColor = System.Drawing.Color.White;
            this.fuel.Name = "fuel";
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.light, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.parkbrake, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.airpressure, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.hazard, 1, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // light
            // 
            resources.ApplyResources(this.light, "light");
            this.light.Image = global::Kile.Properties.Resources.lowbeam;
            this.light.Name = "light";
            this.light.TabStop = false;
            // 
            // parkbrake
            // 
            resources.ApplyResources(this.parkbrake, "parkbrake");
            this.parkbrake.Name = "parkbrake";
            this.parkbrake.TabStop = false;
            // 
            // airpressure
            // 
            resources.ApplyResources(this.airpressure, "airpressure");
            this.airpressure.Image = global::Kile.Properties.Resources.airpressure;
            this.airpressure.Name = "airpressure";
            this.airpressure.TabStop = false;
            // 
            // hazard
            // 
            resources.ApplyResources(this.hazard, "hazard");
            this.hazard.Name = "hazard";
            this.hazard.TabStop = false;
            // 
            // gear
            // 
            resources.ApplyResources(this.gear, "gear");
            this.gear.ForeColor = System.Drawing.Color.White;
            this.gear.Name = "gear";
            // 
            // speedlimit
            // 
            resources.ApplyResources(this.speedlimit, "speedlimit");
            this.speedlimit.ForeColor = System.Drawing.Color.White;
            this.speedlimit.Image = global::Kile.Properties.Resources.speedlimit;
            this.speedlimit.Name = "speedlimit";
            // 
            // tableLayoutPanel5
            // 
            resources.ApplyResources(this.tableLayoutPanel5, "tableLayoutPanel5");
            this.tableLayoutPanel5.Controls.Add(this.nextreststoptime, 1, 3);
            this.tableLayoutPanel5.Controls.Add(this.remainingTime, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.company, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.label11, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.label10, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.label9, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.cargo, 1, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            // 
            // nextreststoptime
            // 
            resources.ApplyResources(this.nextreststoptime, "nextreststoptime");
            this.nextreststoptime.ForeColor = System.Drawing.Color.White;
            this.nextreststoptime.Name = "nextreststoptime";
            // 
            // remainingTime
            // 
            resources.ApplyResources(this.remainingTime, "remainingTime");
            this.remainingTime.ForeColor = System.Drawing.Color.White;
            this.remainingTime.Name = "remainingTime";
            // 
            // company
            // 
            resources.ApplyResources(this.company, "company");
            this.company.ForeColor = System.Drawing.Color.White;
            this.company.Name = "company";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Name = "label8";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Name = "label11";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Name = "label10";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Name = "label9";
            // 
            // cargo
            // 
            resources.ApplyResources(this.cargo, "cargo");
            this.cargo.ForeColor = System.Drawing.Color.White;
            this.cargo.Name = "cargo";
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.label3, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox7, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.truckspeed, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.cruisecontrolspeed, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Name = "label3";
            // 
            // pictureBox3
            // 
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.Image = global::Kile.Properties.Resources.speedmeter;
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox7
            // 
            resources.ApplyResources(this.pictureBox7, "pictureBox7");
            this.pictureBox7.Image = global::Kile.Properties.Resources.cruisecontrol;
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.TabStop = false;
            // 
            // truckspeed
            // 
            resources.ApplyResources(this.truckspeed, "truckspeed");
            this.truckspeed.ForeColor = System.Drawing.Color.White;
            this.truckspeed.Name = "truckspeed";
            // 
            // cruisecontrolspeed
            // 
            resources.ApplyResources(this.cruisecontrolspeed, "cruisecontrolspeed");
            this.cruisecontrolspeed.ForeColor = System.Drawing.Color.White;
            this.cruisecontrolspeed.Name = "cruisecontrolspeed";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Name = "label2";
            // 
            // indicator
            // 
            this.indicator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            this.indicator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.indicator.FlatStyle = System.Windows.Forms.FlatStyle.System;
            resources.ApplyResources(this.indicator, "indicator");
            this.indicator.Name = "indicator";
            // 
            // settingDisplay
            // 
            this.settingDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(22)))));
            resources.ApplyResources(this.settingDisplay, "settingDisplay");
            this.settingDisplay.Name = "settingDisplay";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(22)))));
            this.Controls.Add(this.indicator);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.settingDisplay);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.settingbutton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.powerbutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.light)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkbrake)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airpressure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hazard)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button powerbutton;
        private System.Windows.Forms.Timer updatetimer;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button settingbutton;
        private System.Windows.Forms.Button button3;
        private SettingDisplay settingDisplay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label truckspeed;
        private System.Windows.Forms.Label cruisecontrolspeed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label nextreststoptime;
        private System.Windows.Forms.Label remainingTime;
        private System.Windows.Forms.Label company;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label cargo;
        private System.Windows.Forms.Label speedlimit;
        private System.Windows.Forms.Label gear;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label eta;
        private System.Windows.Forms.Label distance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label city;
        private System.Windows.Forms.Label arrives;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox light;
        private System.Windows.Forms.PictureBox parkbrake;
        private System.Windows.Forms.PictureBox airpressure;
        private System.Windows.Forms.PictureBox hazard;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label fuel;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label day;
        private System.Windows.Forms.Label indicator;
    }
}

