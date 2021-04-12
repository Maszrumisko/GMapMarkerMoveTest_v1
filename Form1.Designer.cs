
namespace GMapMarkerMoveTest_v1
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
            this.components = new System.ComponentModel.Container();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.tableLayoutPanel_main = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_buttons = new System.Windows.Forms.TableLayoutPanel();
            this.button_addMarker = new System.Windows.Forms.Button();
            this.buttonRemoveAllMarkers = new System.Windows.Forms.Button();
            this.label_markerID = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label_globalPosition = new System.Windows.Forms.Label();
            this.label_previousPosition = new System.Windows.Forms.Label();
            this.tableLayoutPanel_main.SuspendLayout();
            this.tableLayoutPanel_buttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(3, 3);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 18;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(394, 444);
            this.gMapControl1.TabIndex = 0;
            this.gMapControl1.Zoom = 15D;
            this.gMapControl1.OnMarkerEnter += new GMap.NET.WindowsForms.MarkerEnter(this.gMapControl1_OnMarkerEnter);
            this.gMapControl1.OnMarkerLeave += new GMap.NET.WindowsForms.MarkerLeave(this.gMapControl1_OnMarkerLeave);
            this.gMapControl1.Load += new System.EventHandler(this.gMapControl1_Load);
            this.gMapControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gMapControl1_MouseDown);
            this.gMapControl1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gMapControl1_MouseMove);
            this.gMapControl1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gMapControl1_MouseUp);
            // 
            // tableLayoutPanel_main
            // 
            this.tableLayoutPanel_main.ColumnCount = 2;
            this.tableLayoutPanel_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_main.Controls.Add(this.gMapControl1, 0, 0);
            this.tableLayoutPanel_main.Controls.Add(this.tableLayoutPanel_buttons, 1, 0);
            this.tableLayoutPanel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_main.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_main.Name = "tableLayoutPanel_main";
            this.tableLayoutPanel_main.RowCount = 1;
            this.tableLayoutPanel_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_main.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel_main.TabIndex = 1;
            // 
            // tableLayoutPanel_buttons
            // 
            this.tableLayoutPanel_buttons.ColumnCount = 2;
            this.tableLayoutPanel_buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_buttons.Controls.Add(this.button_addMarker, 0, 0);
            this.tableLayoutPanel_buttons.Controls.Add(this.buttonRemoveAllMarkers, 1, 0);
            this.tableLayoutPanel_buttons.Controls.Add(this.label_markerID, 0, 1);
            this.tableLayoutPanel_buttons.Controls.Add(this.label_globalPosition, 1, 1);
            this.tableLayoutPanel_buttons.Controls.Add(this.label_previousPosition, 0, 2);
            this.tableLayoutPanel_buttons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_buttons.Location = new System.Drawing.Point(403, 3);
            this.tableLayoutPanel_buttons.Name = "tableLayoutPanel_buttons";
            this.tableLayoutPanel_buttons.RowCount = 4;
            this.tableLayoutPanel_buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_buttons.Size = new System.Drawing.Size(394, 444);
            this.tableLayoutPanel_buttons.TabIndex = 1;
            // 
            // button_addMarker
            // 
            this.button_addMarker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_addMarker.Location = new System.Drawing.Point(3, 3);
            this.button_addMarker.Name = "button_addMarker";
            this.button_addMarker.Size = new System.Drawing.Size(191, 105);
            this.button_addMarker.TabIndex = 0;
            this.button_addMarker.Text = "Add Marker";
            this.button_addMarker.UseVisualStyleBackColor = true;
            this.button_addMarker.Click += new System.EventHandler(this.button_addMarker_Click);
            // 
            // buttonRemoveAllMarkers
            // 
            this.buttonRemoveAllMarkers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonRemoveAllMarkers.Location = new System.Drawing.Point(200, 3);
            this.buttonRemoveAllMarkers.Name = "buttonRemoveAllMarkers";
            this.buttonRemoveAllMarkers.Size = new System.Drawing.Size(191, 105);
            this.buttonRemoveAllMarkers.TabIndex = 1;
            this.buttonRemoveAllMarkers.Text = "Remove All Markers";
            this.buttonRemoveAllMarkers.UseVisualStyleBackColor = true;
            this.buttonRemoveAllMarkers.Click += new System.EventHandler(this.buttonRemoveAllMarkers_Click);
            // 
            // label_markerID
            // 
            this.label_markerID.AutoSize = true;
            this.label_markerID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_markerID.Location = new System.Drawing.Point(3, 111);
            this.label_markerID.Name = "label_markerID";
            this.label_markerID.Size = new System.Drawing.Size(191, 111);
            this.label_markerID.TabIndex = 2;
            this.label_markerID.Text = "label1";
            this.label_markerID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label_globalPosition
            // 
            this.label_globalPosition.AutoSize = true;
            this.label_globalPosition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_globalPosition.Location = new System.Drawing.Point(200, 111);
            this.label_globalPosition.Name = "label_globalPosition";
            this.label_globalPosition.Size = new System.Drawing.Size(191, 111);
            this.label_globalPosition.TabIndex = 3;
            this.label_globalPosition.Text = "label1";
            this.label_globalPosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_previousPosition
            // 
            this.label_previousPosition.AutoSize = true;
            this.label_previousPosition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_previousPosition.Location = new System.Drawing.Point(3, 222);
            this.label_previousPosition.Name = "label_previousPosition";
            this.label_previousPosition.Size = new System.Drawing.Size(191, 111);
            this.label_previousPosition.TabIndex = 4;
            this.label_previousPosition.Text = "label_previousPosition";
            this.label_previousPosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel_main);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel_main.ResumeLayout(false);
            this.tableLayoutPanel_buttons.ResumeLayout(false);
            this.tableLayoutPanel_buttons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_main;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_buttons;
        private System.Windows.Forms.Button button_addMarker;
        private System.Windows.Forms.Button buttonRemoveAllMarkers;
        private System.Windows.Forms.Label label_markerID;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label_globalPosition;
        private System.Windows.Forms.Label label_previousPosition;
    }
}

