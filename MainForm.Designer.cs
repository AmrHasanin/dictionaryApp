namespace DIgitalDictionary
{
    partial class MainForm
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
            panel1 = new Panel();
            WelcomeLabel = new Label();
            DeleteButton = new Button();
            UpdateButton = new Button();
            AddButton = new Button();
            AddPanel = new Panel();
            AddSubmit = new Button();
            label2 = new Label();
            AddTranlation = new TextBox();
            label1 = new Label();
            AddWord = new TextBox();
            UpdatePanel = new Panel();
            SubmitUpdate = new Button();
            label4 = new Label();
            label3 = new Label();
            UpdateTranslation = new TextBox();
            UpdateWord = new TextBox();
            DeletePanel = new Panel();
            Word = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            MainPanel = new Panel();
            DictionaryGrid = new DataGridView();
            Words = new DataGridViewTextBoxColumn();
            Translations = new DataGridViewTextBoxColumn();
            SaveToDatabase = new Button();
            SaveToJSON = new Button();
            panel1.SuspendLayout();
            AddPanel.SuspendLayout();
            UpdatePanel.SuspendLayout();
            DeletePanel.SuspendLayout();
            MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DictionaryGrid).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(WelcomeLabel);
            panel1.Controls.Add(DeleteButton);
            panel1.Controls.Add(UpdateButton);
            panel1.Controls.Add(AddButton);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(146, 450);
            panel1.TabIndex = 1;
            // 
            // WelcomeLabel
            // 
            WelcomeLabel.AutoSize = true;
            WelcomeLabel.BorderStyle = BorderStyle.Fixed3D;
            WelcomeLabel.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            WelcomeLabel.ForeColor = SystemColors.ButtonHighlight;
            WelcomeLabel.Location = new Point(19, 23);
            WelcomeLabel.Name = "WelcomeLabel";
            WelcomeLabel.Size = new Size(67, 27);
            WelcomeLabel.TabIndex = 3;
            WelcomeLabel.Text = "label1";
            WelcomeLabel.Click += WelcomeLabel_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.BackColor = Color.DeepSkyBlue;
            DeleteButton.Font = new Font("Trebuchet MS", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteButton.ForeColor = SystemColors.ButtonHighlight;
            DeleteButton.Location = new Point(3, 352);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(140, 69);
            DeleteButton.TabIndex = 2;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = false;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // UpdateButton
            // 
            UpdateButton.BackColor = Color.DeepSkyBlue;
            UpdateButton.Font = new Font("Trebuchet MS", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UpdateButton.ForeColor = SystemColors.ButtonHighlight;
            UpdateButton.Location = new Point(3, 260);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(140, 69);
            UpdateButton.TabIndex = 1;
            UpdateButton.Text = "Update";
            UpdateButton.UseVisualStyleBackColor = false;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // AddButton
            // 
            AddButton.BackColor = Color.DeepSkyBlue;
            AddButton.Font = new Font("Trebuchet MS", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddButton.ForeColor = SystemColors.ButtonHighlight;
            AddButton.Location = new Point(3, 170);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(140, 71);
            AddButton.TabIndex = 0;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // AddPanel
            // 
            AddPanel.BackColor = SystemColors.ActiveCaptionText;
            AddPanel.Controls.Add(AddSubmit);
            AddPanel.Controls.Add(label2);
            AddPanel.Controls.Add(AddTranlation);
            AddPanel.Controls.Add(label1);
            AddPanel.Controls.Add(AddWord);
            AddPanel.Location = new Point(152, 3);
            AddPanel.Name = "AddPanel";
            AddPanel.Size = new Size(657, 447);
            AddPanel.TabIndex = 2;
            // 
            // AddSubmit
            // 
            AddSubmit.BackColor = Color.DeepSkyBlue;
            AddSubmit.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddSubmit.ForeColor = SystemColors.ButtonHighlight;
            AddSubmit.Location = new Point(276, 285);
            AddSubmit.Name = "AddSubmit";
            AddSubmit.Size = new Size(177, 61);
            AddSubmit.TabIndex = 4;
            AddSubmit.Text = "Add";
            AddSubmit.UseVisualStyleBackColor = false;
            AddSubmit.Click += AddSubmit_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(143, 216);
            label2.Name = "label2";
            label2.Size = new Size(113, 25);
            label2.TabIndex = 3;
            label2.Text = "Translation";
            // 
            // AddTranlation
            // 
            AddTranlation.Location = new Point(276, 210);
            AddTranlation.Name = "AddTranlation";
            AddTranlation.Size = new Size(260, 31);
            AddTranlation.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(143, 125);
            label1.Name = "label1";
            label1.Size = new Size(62, 25);
            label1.TabIndex = 1;
            label1.Text = "Word";
            // 
            // AddWord
            // 
            AddWord.Location = new Point(276, 119);
            AddWord.Name = "AddWord";
            AddWord.Size = new Size(257, 31);
            AddWord.TabIndex = 0;
            // 
            // UpdatePanel
            // 
            UpdatePanel.BackColor = SystemColors.ActiveCaptionText;
            UpdatePanel.Controls.Add(SubmitUpdate);
            UpdatePanel.Controls.Add(label4);
            UpdatePanel.Controls.Add(label3);
            UpdatePanel.Controls.Add(UpdateTranslation);
            UpdatePanel.Controls.Add(UpdateWord);
            UpdatePanel.Location = new Point(158, 3);
            UpdatePanel.Name = "UpdatePanel";
            UpdatePanel.Size = new Size(636, 447);
            UpdatePanel.TabIndex = 3;
            // 
            // SubmitUpdate
            // 
            SubmitUpdate.BackColor = Color.DeepSkyBlue;
            SubmitUpdate.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SubmitUpdate.ForeColor = SystemColors.ButtonHighlight;
            SubmitUpdate.Location = new Point(254, 307);
            SubmitUpdate.Name = "SubmitUpdate";
            SubmitUpdate.Size = new Size(187, 77);
            SubmitUpdate.TabIndex = 4;
            SubmitUpdate.Text = "Update";
            SubmitUpdate.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(116, 173);
            label4.Name = "label4";
            label4.Size = new Size(62, 25);
            label4.TabIndex = 3;
            label4.Text = "Word";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(116, 251);
            label3.Name = "label3";
            label3.Size = new Size(113, 25);
            label3.TabIndex = 2;
            label3.Text = "Translation";
            // 
            // UpdateTranslation
            // 
            UpdateTranslation.Location = new Point(254, 248);
            UpdateTranslation.Name = "UpdateTranslation";
            UpdateTranslation.Size = new Size(251, 31);
            UpdateTranslation.TabIndex = 1;
            // 
            // UpdateWord
            // 
            UpdateWord.Location = new Point(254, 170);
            UpdateWord.Name = "UpdateWord";
            UpdateWord.Size = new Size(251, 31);
            UpdateWord.TabIndex = 0;
            // 
            // DeletePanel
            // 
            DeletePanel.BackColor = SystemColors.ActiveCaptionText;
            DeletePanel.Controls.Add(Word);
            DeletePanel.Controls.Add(textBox1);
            DeletePanel.Controls.Add(button1);
            DeletePanel.Location = new Point(155, 3);
            DeletePanel.Name = "DeletePanel";
            DeletePanel.Size = new Size(642, 447);
            DeletePanel.TabIndex = 4;
            // 
            // Word
            // 
            Word.AutoSize = true;
            Word.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Word.ForeColor = SystemColors.ButtonHighlight;
            Word.Location = new Point(273, 49);
            Word.Name = "Word";
            Word.Size = new Size(74, 30);
            Word.TabIndex = 2;
            Word.Text = "Word";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(140, 136);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(368, 62);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.DeepSkyBlue;
            button1.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(225, 285);
            button1.Name = "button1";
            button1.Size = new Size(168, 74);
            button1.TabIndex = 0;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = false;
            // 
            // MainPanel
            // 
            MainPanel.BackColor = SystemColors.ActiveCaptionText;
            MainPanel.Controls.Add(SaveToJSON);
            MainPanel.Controls.Add(SaveToDatabase);
            MainPanel.Controls.Add(DictionaryGrid);
            MainPanel.Location = new Point(155, 3);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(642, 447);
            MainPanel.TabIndex = 5;
            // 
            // DictionaryGrid
            // 
            DictionaryGrid.BackgroundColor = SystemColors.ButtonHighlight;
            DictionaryGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DictionaryGrid.Columns.AddRange(new DataGridViewColumn[] { Words, Translations });
            DictionaryGrid.GridColor = Color.DeepSkyBlue;
            DictionaryGrid.Location = new Point(119, 23);
            DictionaryGrid.Name = "DictionaryGrid";
            DictionaryGrid.RowHeadersWidth = 62;
            DictionaryGrid.Size = new Size(364, 278);
            DictionaryGrid.TabIndex = 0;
            // 
            // Words
            // 
            Words.HeaderText = "Words";
            Words.MinimumWidth = 8;
            Words.Name = "Words";
            Words.Width = 150;
            // 
            // Translations
            // 
            Translations.HeaderText = "Translations";
            Translations.MinimumWidth = 8;
            Translations.Name = "Translations";
            Translations.ReadOnly = true;
            Translations.Width = 150;
            // 
            // SaveToDatabase
            // 
            SaveToDatabase.BackColor = Color.DeepSkyBlue;
            SaveToDatabase.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SaveToDatabase.ForeColor = Color.White;
            SaveToDatabase.Location = new Point(433, 360);
            SaveToDatabase.Name = "SaveToDatabase";
            SaveToDatabase.Size = new Size(159, 50);
            SaveToDatabase.TabIndex = 1;
            SaveToDatabase.Text = "SaveToDb";
            SaveToDatabase.UseVisualStyleBackColor = false;
            SaveToDatabase.Click += SaveToDatabase_Click;
            // 
            // SaveToJSON
            // 
            SaveToJSON.BackColor = SystemColors.ButtonHighlight;
            SaveToJSON.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SaveToJSON.ForeColor = SystemColors.ActiveCaptionText;
            SaveToJSON.Location = new Point(62, 360);
            SaveToJSON.Name = "SaveToJSON";
            SaveToJSON.Size = new Size(140, 50);
            SaveToJSON.TabIndex = 2;
            SaveToJSON.Text = "SaveToJSON";
            SaveToJSON.UseVisualStyleBackColor = false;
            SaveToJSON.Click += SaveToJSON_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(MainPanel);
            Controls.Add(AddPanel);
            Controls.Add(UpdatePanel);
            Controls.Add(DeletePanel);
            Name = "MainForm";
            Text = "MainForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            AddPanel.ResumeLayout(false);
            AddPanel.PerformLayout();
            UpdatePanel.ResumeLayout(false);
            UpdatePanel.PerformLayout();
            DeletePanel.ResumeLayout(false);
            DeletePanel.PerformLayout();
            MainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DictionaryGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label WelcomeLabel;
        private Button DeleteButton;
        private Button UpdateButton;
        private Button AddButton;
        private Panel AddPanel;
        private Panel UpdatePanel;
        private Panel DeletePanel;
        private Panel MainPanel;
        private Button AddSubmit;
        private Label label2;
        private TextBox AddTranlation;
        private Label label1;
        private TextBox AddWord;
        private Button SubmitUpdate;
        private Label label4;
        private Label label3;
        private TextBox UpdateTranslation;
        private TextBox UpdateWord;
        private Label Word;
        private TextBox textBox1;
        private Button button1;
        private DataGridView DictionaryGrid;
        private DataGridViewTextBoxColumn Words;
        private DataGridViewTextBoxColumn Translations;
        private Button SaveToJSON;
        private Button SaveToDatabase;
    }
}