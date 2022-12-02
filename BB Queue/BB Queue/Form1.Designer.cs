namespace BB_Queue
{
  partial class Form1
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.panel1 = new System.Windows.Forms.Panel();
      this.dgvReceivedOrders = new System.Windows.Forms.DataGridView();
      this.label1 = new System.Windows.Forms.Label();
      this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.panel2 = new System.Windows.Forms.Panel();
      this.dgvCompletedOrders = new System.Windows.Forms.DataGridView();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.startButton = new System.Windows.Forms.Button();
      this.timeValue = new System.Windows.Forms.TextBox();
      this.toyCountTextBox = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.button1 = new System.Windows.Forms.Button();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvReceivedOrders)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
      this.panel2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvCompletedOrders)).BeginInit();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.dgvReceivedOrders);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Location = new System.Drawing.Point(0, 45);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(931, 735);
      this.panel1.TabIndex = 0;
      // 
      // dgvReceivedOrders
      // 
      this.dgvReceivedOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvReceivedOrders.Location = new System.Drawing.Point(0, 41);
      this.dgvReceivedOrders.Name = "dgvReceivedOrders";
      this.dgvReceivedOrders.RowHeadersWidth = 51;
      this.dgvReceivedOrders.RowTemplate.Height = 29;
      this.dgvReceivedOrders.Size = new System.Drawing.Size(930, 678);
      this.dgvReceivedOrders.TabIndex = 17;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(417, 10);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(101, 20);
      this.label1.TabIndex = 11;
      this.label1.Text = "Orders Placed";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // orderBindingSource
      // 
      this.orderBindingSource.DataSource = typeof(BB_Queue.Order);
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.dgvCompletedOrders);
      this.panel2.Controls.Add(this.label2);
      this.panel2.Location = new System.Drawing.Point(936, 45);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(920, 734);
      this.panel2.TabIndex = 1;
      // 
      // dgvCompletedOrders
      // 
      this.dgvCompletedOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvCompletedOrders.Location = new System.Drawing.Point(0, 41);
      this.dgvCompletedOrders.Name = "dgvCompletedOrders";
      this.dgvCompletedOrders.RowHeadersWidth = 51;
      this.dgvCompletedOrders.RowTemplate.Height = 29;
      this.dgvCompletedOrders.Size = new System.Drawing.Size(930, 678);
      this.dgvCompletedOrders.TabIndex = 18;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(388, 10);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(195, 20);
      this.label2.TabIndex = 1;
      this.label2.Text = "Orders Completed/Rejected";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(12, 9);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(101, 20);
      this.label3.TabIndex = 2;
      this.label3.Text = "Current Time: ";
      // 
      // startButton
      // 
      this.startButton.Location = new System.Drawing.Point(805, 7);
      this.startButton.Name = "startButton";
      this.startButton.Size = new System.Drawing.Size(125, 29);
      this.startButton.TabIndex = 4;
      this.startButton.Text = "Start Simulation";
      this.startButton.UseVisualStyleBackColor = true;
      this.startButton.Click += new System.EventHandler(this.startButton_Click);
      // 
      // timeValue
      // 
      this.timeValue.Location = new System.Drawing.Point(119, 6);
      this.timeValue.Name = "timeValue";
      this.timeValue.ReadOnly = true;
      this.timeValue.Size = new System.Drawing.Size(125, 27);
      this.timeValue.TabIndex = 5;
      this.timeValue.Text = "08:50";
      this.timeValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.timeValue.TextChanged += new System.EventHandler(this.timeValue_TextChanged);
      // 
      // toyCountTextBox
      // 
      this.toyCountTextBox.Location = new System.Drawing.Point(1754, 9);
      this.toyCountTextBox.Name = "toyCountTextBox";
      this.toyCountTextBox.ReadOnly = true;
      this.toyCountTextBox.Size = new System.Drawing.Size(60, 27);
      this.toyCountTextBox.TabIndex = 7;
      this.toyCountTextBox.Text = "50";
      this.toyCountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(1666, 12);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(82, 20);
      this.label4.TabIndex = 6;
      this.label4.Text = "Toy Count: ";
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(936, 7);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(125, 29);
      this.button1.TabIndex = 8;
      this.button1.Text = "Stop Simulation";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1859, 765);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.toyCountTextBox);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.timeValue);
      this.Controls.Add(this.startButton);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.panel1);
      this.Name = "Form1";
      this.Text = "BB Queue";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
      this.Load += new System.EventHandler(this.Form1_Load);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvReceivedOrders)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvCompletedOrders)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private Panel panel1;
    private Panel panel2;
    private Label label2;
    private Label label3;
    private Button startButton;
    private TextBox timeValue;
    private Label label1;
    private BindingSource orderBindingSource;
    private DataGridView dgvReceivedOrders;
    private DataGridView dgvCompletedOrders;
    private TextBox toyCountTextBox;
    private Label label4;
    private Button button1;
  }
}