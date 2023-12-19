namespace ChatApp.Client;

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
        listBox1 = new ListBox();
        richTextBox1 = new RichTextBox();
        textBox1 = new TextBox();
        button1 = new Button();
        label1 = new Label();
        label2 = new Label();
        label3 = new Label();
        SuspendLayout();
        // 
        // listBox1
        // 
        listBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        listBox1.FormattingEnabled = true;
        listBox1.ItemHeight = 25;
        listBox1.Location = new Point(0, 50);
        listBox1.Name = "listBox1";
        listBox1.Size = new Size(212, 354);
        listBox1.TabIndex = 0;
        listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
        // 
        // richTextBox1
        // 
        richTextBox1.Location = new Point(218, 57);
        richTextBox1.Name = "richTextBox1";
        richTextBox1.ScrollBars = RichTextBoxScrollBars.Horizontal;
        richTextBox1.Size = new Size(364, 304);
        richTextBox1.TabIndex = 1;
        richTextBox1.Text = "";
        // 
        // textBox1
        // 
        textBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        textBox1.Location = new Point(218, 371);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(283, 33);
        textBox1.TabIndex = 2;
        // 
        // button1
        // 
        button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        button1.Location = new Point(507, 371);
        button1.Name = "button1";
        button1.Size = new Size(75, 30);
        button1.TabIndex = 3;
        button1.Text = "Send";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label1.Location = new Point(352, 4);
        label1.Name = "label1";
        label1.Size = new Size(68, 30);
        label1.TabIndex = 4;
        label1.Text = "label1";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label2.Location = new Point(360, 34);
        label2.Name = "label2";
        label2.Size = new Size(50, 20);
        label2.TabIndex = 5;
        label2.Text = "label2";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label3.Location = new Point(6, 9);
        label3.Name = "label3";
        label3.Size = new Size(68, 30);
        label3.TabIndex = 6;
        label3.Text = "label3";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(594, 413);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(button1);
        Controls.Add(textBox1);
        Controls.Add(richTextBox1);
        Controls.Add(listBox1);
        Name = "Form1";
        Text = "Form1";
        FormClosed += Form1_FormClosed;
        Load += Form1_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private ListBox listBox1;
    private RichTextBox richTextBox1;
    private TextBox textBox1;
    private Button button1;
    private Label label1;
    private Label label2;
    private Label label3;
}
