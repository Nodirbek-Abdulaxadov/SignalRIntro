namespace ChatApp.Client;

partial class Register
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
        label1 = new Label();
        textBox1 = new TextBox();
        button1 = new Button();
        label2 = new Label();
        label3 = new Label();
        textBox2 = new TextBox();
        label4 = new Label();
        textBox3 = new TextBox();
        linkLabel1 = new LinkLabel();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label1.Location = new Point(143, 33);
        label1.Name = "label1";
        label1.Size = new Size(99, 32);
        label1.TabIndex = 0;
        label1.Text = "Register";
        // 
        // textBox1
        // 
        textBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        textBox1.Location = new Point(43, 132);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(318, 33);
        textBox1.TabIndex = 1;
        // 
        // button1
        // 
        button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        button1.Location = new Point(132, 374);
        button1.Name = "button1";
        button1.Size = new Size(132, 51);
        button1.TabIndex = 2;
        button1.Text = "Register";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label2.Location = new Point(43, 105);
        label2.Name = "label2";
        label2.Size = new Size(77, 21);
        label2.TabIndex = 3;
        label2.Text = "FullName";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label3.Location = new Point(43, 176);
        label3.Name = "label3";
        label3.Size = new Size(112, 21);
        label3.TabIndex = 5;
        label3.Text = "PhoneNumber";
        // 
        // textBox2
        // 
        textBox2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        textBox2.Location = new Point(43, 203);
        textBox2.Name = "textBox2";
        textBox2.Size = new Size(318, 33);
        textBox2.TabIndex = 4;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label4.Location = new Point(43, 254);
        label4.Name = "label4";
        label4.Size = new Size(76, 21);
        label4.TabIndex = 7;
        label4.Text = "Password";
        // 
        // textBox3
        // 
        textBox3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        textBox3.Location = new Point(43, 281);
        textBox3.Name = "textBox3";
        textBox3.Size = new Size(318, 33);
        textBox3.TabIndex = 6;
        // 
        // linkLabel1
        // 
        linkLabel1.AutoSize = true;
        linkLabel1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        linkLabel1.Location = new Point(43, 338);
        linkLabel1.Name = "linkLabel1";
        linkLabel1.Size = new Size(59, 25);
        linkLabel1.TabIndex = 8;
        linkLabel1.TabStop = true;
        linkLabel1.Text = "Login";
        linkLabel1.LinkClicked += linkLabel1_LinkClicked;
        // 
        // Register
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(406, 437);
        Controls.Add(linkLabel1);
        Controls.Add(label4);
        Controls.Add(textBox3);
        Controls.Add(label3);
        Controls.Add(textBox2);
        Controls.Add(label2);
        Controls.Add(button1);
        Controls.Add(textBox1);
        Controls.Add(label1);
        Name = "Register";
        Text = "Register";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private TextBox textBox1;
    private Button button1;
    private Label label2;
    private Label label3;
    private TextBox textBox2;
    private Label label4;
    private TextBox textBox3;
    private LinkLabel linkLabel1;
}