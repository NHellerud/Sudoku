namespace SudokuSolver
{
    partial class Form1
    {
        public string[] boxItems = new string[]{"1", "2", "3", "4", "5", "6", "7", "8", "9", "-1" };
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
            this.Picture = new System.Windows.Forms.PictureBox();
            this.box11 = new System.Windows.Forms.ComboBox();
            this.box12 = new System.Windows.Forms.ComboBox();
            this.box14 = new System.Windows.Forms.ComboBox();
            this.box13 = new System.Windows.Forms.ComboBox();
            this.box18 = new System.Windows.Forms.ComboBox();
            this.box17 = new System.Windows.Forms.ComboBox();
            this.box16 = new System.Windows.Forms.ComboBox();
            this.box15 = new System.Windows.Forms.ComboBox();
            this.box19 = new System.Windows.Forms.ComboBox();
            this.solveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.box29 = new System.Windows.Forms.ComboBox();
            this.box28 = new System.Windows.Forms.ComboBox();
            this.box27 = new System.Windows.Forms.ComboBox();
            this.box26 = new System.Windows.Forms.ComboBox();
            this.box25 = new System.Windows.Forms.ComboBox();
            this.box24 = new System.Windows.Forms.ComboBox();
            this.box23 = new System.Windows.Forms.ComboBox();
            this.box22 = new System.Windows.Forms.ComboBox();
            this.box21 = new System.Windows.Forms.ComboBox();
            this.box39 = new System.Windows.Forms.ComboBox();
            this.box38 = new System.Windows.Forms.ComboBox();
            this.box37 = new System.Windows.Forms.ComboBox();
            this.box36 = new System.Windows.Forms.ComboBox();
            this.box35 = new System.Windows.Forms.ComboBox();
            this.box34 = new System.Windows.Forms.ComboBox();
            this.box33 = new System.Windows.Forms.ComboBox();
            this.box32 = new System.Windows.Forms.ComboBox();
            this.box31 = new System.Windows.Forms.ComboBox();
            this.box69 = new System.Windows.Forms.ComboBox();
            this.box68 = new System.Windows.Forms.ComboBox();
            this.box67 = new System.Windows.Forms.ComboBox();
            this.box66 = new System.Windows.Forms.ComboBox();
            this.box65 = new System.Windows.Forms.ComboBox();
            this.box64 = new System.Windows.Forms.ComboBox();
            this.box63 = new System.Windows.Forms.ComboBox();
            this.box62 = new System.Windows.Forms.ComboBox();
            this.box61 = new System.Windows.Forms.ComboBox();
            this.box59 = new System.Windows.Forms.ComboBox();
            this.box58 = new System.Windows.Forms.ComboBox();
            this.box57 = new System.Windows.Forms.ComboBox();
            this.box56 = new System.Windows.Forms.ComboBox();
            this.box55 = new System.Windows.Forms.ComboBox();
            this.box54 = new System.Windows.Forms.ComboBox();
            this.box53 = new System.Windows.Forms.ComboBox();
            this.box52 = new System.Windows.Forms.ComboBox();
            this.box51 = new System.Windows.Forms.ComboBox();
            this.box49 = new System.Windows.Forms.ComboBox();
            this.box48 = new System.Windows.Forms.ComboBox();
            this.box47 = new System.Windows.Forms.ComboBox();
            this.box46 = new System.Windows.Forms.ComboBox();
            this.box45 = new System.Windows.Forms.ComboBox();
            this.box44 = new System.Windows.Forms.ComboBox();
            this.box43 = new System.Windows.Forms.ComboBox();
            this.box42 = new System.Windows.Forms.ComboBox();
            this.box41 = new System.Windows.Forms.ComboBox();
            this.box99 = new System.Windows.Forms.ComboBox();
            this.box98 = new System.Windows.Forms.ComboBox();
            this.box97 = new System.Windows.Forms.ComboBox();
            this.box96 = new System.Windows.Forms.ComboBox();
            this.box95 = new System.Windows.Forms.ComboBox();
            this.box94 = new System.Windows.Forms.ComboBox();
            this.box93 = new System.Windows.Forms.ComboBox();
            this.box92 = new System.Windows.Forms.ComboBox();
            this.box91 = new System.Windows.Forms.ComboBox();
            this.box89 = new System.Windows.Forms.ComboBox();
            this.box88 = new System.Windows.Forms.ComboBox();
            this.box87 = new System.Windows.Forms.ComboBox();
            this.box86 = new System.Windows.Forms.ComboBox();
            this.box85 = new System.Windows.Forms.ComboBox();
            this.box84 = new System.Windows.Forms.ComboBox();
            this.box83 = new System.Windows.Forms.ComboBox();
            this.box82 = new System.Windows.Forms.ComboBox();
            this.box81 = new System.Windows.Forms.ComboBox();
            this.box79 = new System.Windows.Forms.ComboBox();
            this.box78 = new System.Windows.Forms.ComboBox();
            this.box77 = new System.Windows.Forms.ComboBox();
            this.box76 = new System.Windows.Forms.ComboBox();
            this.box75 = new System.Windows.Forms.ComboBox();
            this.box74 = new System.Windows.Forms.ComboBox();
            this.box73 = new System.Windows.Forms.ComboBox();
            this.box72 = new System.Windows.Forms.ComboBox();
            this.box71 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CountLabel = new System.Windows.Forms.Label();
            this.ResetButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Preset1Button = new System.Windows.Forms.Button();
            this.Preset2Button = new System.Windows.Forms.Button();
            this.Preset3Button = new System.Windows.Forms.Button();
            this.Preset4Button = new System.Windows.Forms.Button();
            this.parallelCheckBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // Picture
            // 
            this.Picture.Image = global::SudokuSolver.Properties.Resources.grid;
            this.Picture.Location = new System.Drawing.Point(323, 102);
            this.Picture.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(784, 798);
            this.Picture.TabIndex = 0;
            this.Picture.TabStop = false;
            // 
            // box11
            // 
            this.box11.FormattingEnabled = true;
            this.box11.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "-1"});
            this.box11.Location = new System.Drawing.Point(343, 135);
            this.box11.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box11.MaxLength = 1;
            this.box11.Name = "box11";
            this.box11.Size = new System.Drawing.Size(48, 28);
            this.box11.TabIndex = 1;
            this.box11.Text = "-1";
            // 
            // box12
            // 
            this.box12.FormattingEnabled = true;
            this.box12.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "-1"});
            this.box12.Location = new System.Drawing.Point(428, 135);
            this.box12.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box12.MaxLength = 1;
            this.box12.Name = "box12";
            this.box12.Size = new System.Drawing.Size(48, 28);
            this.box12.TabIndex = 2;
            this.box12.Text = "-1";
            // 
            // box14
            // 
            this.box14.FormattingEnabled = true;
            this.box14.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "-1"});
            this.box14.Location = new System.Drawing.Point(598, 135);
            this.box14.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box14.MaxLength = 1;
            this.box14.Name = "box14";
            this.box14.Size = new System.Drawing.Size(48, 28);
            this.box14.TabIndex = 4;
            this.box14.Text = "-1";
            // 
            // box13
            // 
            this.box13.FormattingEnabled = true;
            this.box13.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "-1"});
            this.box13.Location = new System.Drawing.Point(514, 135);
            this.box13.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box13.MaxLength = 1;
            this.box13.Name = "box13";
            this.box13.Size = new System.Drawing.Size(48, 28);
            this.box13.TabIndex = 3;
            this.box13.Text = "-1";
            // 
            // box18
            // 
            this.box18.FormattingEnabled = true;
            this.box18.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "-1"});
            this.box18.Location = new System.Drawing.Point(929, 135);
            this.box18.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box18.MaxLength = 1;
            this.box18.Name = "box18";
            this.box18.Size = new System.Drawing.Size(48, 28);
            this.box18.TabIndex = 8;
            this.box18.Text = "-1";
            // 
            // box17
            // 
            this.box17.FormattingEnabled = true;
            this.box17.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "-1"});
            this.box17.Location = new System.Drawing.Point(845, 135);
            this.box17.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box17.MaxLength = 1;
            this.box17.Name = "box17";
            this.box17.Size = new System.Drawing.Size(48, 28);
            this.box17.TabIndex = 7;
            this.box17.Text = "-1";
            // 
            // box16
            // 
            this.box16.FormattingEnabled = true;
            this.box16.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "-1"});
            this.box16.Location = new System.Drawing.Point(758, 135);
            this.box16.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box16.MaxLength = 1;
            this.box16.Name = "box16";
            this.box16.Size = new System.Drawing.Size(48, 28);
            this.box16.TabIndex = 6;
            this.box16.Text = "-1";
            // 
            // box15
            // 
            this.box15.FormattingEnabled = true;
            this.box15.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "-1"});
            this.box15.Location = new System.Drawing.Point(674, 135);
            this.box15.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box15.MaxLength = 1;
            this.box15.Name = "box15";
            this.box15.Size = new System.Drawing.Size(48, 28);
            this.box15.TabIndex = 5;
            this.box15.Text = "-1";
            // 
            // box19
            // 
            this.box19.FormattingEnabled = true;
            this.box19.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "-1"});
            this.box19.Location = new System.Drawing.Point(1011, 135);
            this.box19.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box19.MaxLength = 1;
            this.box19.Name = "box19";
            this.box19.Size = new System.Drawing.Size(48, 28);
            this.box19.TabIndex = 9;
            this.box19.Text = "-1";
            // 
            // solveButton
            // 
            this.solveButton.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solveButton.Location = new System.Drawing.Point(398, 949);
            this.solveButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.solveButton.Name = "solveButton";
            this.solveButton.Size = new System.Drawing.Size(191, 71);
            this.solveButton.TabIndex = 82;
            this.solveButton.Text = "Solve";
            this.solveButton.UseVisualStyleBackColor = true;
            this.solveButton.Click += new System.EventHandler(this.solveButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(315, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 46);
            this.label1.TabIndex = 83;
            this.label1.Text = "Input Grid";
            // 
            // box29
            // 
            this.box29.FormattingEnabled = true;
            this.box29.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "-1"});
            this.box29.Location = new System.Drawing.Point(1011, 219);
            this.box29.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box29.MaxLength = 1;
            this.box29.Name = "box29";
            this.box29.Size = new System.Drawing.Size(48, 28);
            this.box29.TabIndex = 92;
            this.box29.Text = "-1";
            // 
            // box28
            // 
            this.box28.FormattingEnabled = true;
            this.box28.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "-1"});
            this.box28.Location = new System.Drawing.Point(929, 219);
            this.box28.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box28.MaxLength = 1;
            this.box28.Name = "box28";
            this.box28.Size = new System.Drawing.Size(48, 28);
            this.box28.TabIndex = 91;
            this.box28.Text = "-1";
            // 
            // box27
            // 
            this.box27.FormattingEnabled = true;
            this.box27.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "-1"});
            this.box27.Location = new System.Drawing.Point(845, 219);
            this.box27.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box27.MaxLength = 1;
            this.box27.Name = "box27";
            this.box27.Size = new System.Drawing.Size(48, 28);
            this.box27.TabIndex = 90;
            this.box27.Text = "-1";
            // 
            // box26
            // 
            this.box26.FormattingEnabled = true;
            this.box26.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "-1"});
            this.box26.Location = new System.Drawing.Point(758, 219);
            this.box26.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box26.MaxLength = 1;
            this.box26.Name = "box26";
            this.box26.Size = new System.Drawing.Size(48, 28);
            this.box26.TabIndex = 89;
            this.box26.Text = "-1";
            // 
            // box25
            // 
            this.box25.FormattingEnabled = true;
            this.box25.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "-1"});
            this.box25.Location = new System.Drawing.Point(674, 219);
            this.box25.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box25.MaxLength = 1;
            this.box25.Name = "box25";
            this.box25.Size = new System.Drawing.Size(48, 28);
            this.box25.TabIndex = 88;
            this.box25.Text = "-1";
            // 
            // box24
            // 
            this.box24.FormattingEnabled = true;
            this.box24.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "-1"});
            this.box24.Location = new System.Drawing.Point(598, 219);
            this.box24.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box24.MaxLength = 1;
            this.box24.Name = "box24";
            this.box24.Size = new System.Drawing.Size(48, 28);
            this.box24.TabIndex = 87;
            this.box24.Text = "-1";
            // 
            // box23
            // 
            this.box23.FormattingEnabled = true;
            this.box23.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "-1"});
            this.box23.Location = new System.Drawing.Point(514, 219);
            this.box23.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box23.MaxLength = 1;
            this.box23.Name = "box23";
            this.box23.Size = new System.Drawing.Size(48, 28);
            this.box23.TabIndex = 86;
            this.box23.Text = "-1";
            // 
            // box22
            // 
            this.box22.FormattingEnabled = true;
            this.box22.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "-1"});
            this.box22.Location = new System.Drawing.Point(428, 219);
            this.box22.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box22.MaxLength = 1;
            this.box22.Name = "box22";
            this.box22.Size = new System.Drawing.Size(48, 28);
            this.box22.TabIndex = 85;
            this.box22.Text = "-1";
            // 
            // box21
            // 
            this.box21.FormattingEnabled = true;
            this.box21.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "-1"});
            this.box21.Location = new System.Drawing.Point(343, 219);
            this.box21.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box21.MaxLength = 1;
            this.box21.Name = "box21";
            this.box21.Size = new System.Drawing.Size(48, 28);
            this.box21.TabIndex = 84;
            this.box21.Text = "-1";
            // 
            // box39
            // 
            this.box39.FormattingEnabled = true;
            this.box39.Location = new System.Drawing.Point(1011, 306);
            this.box39.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box39.MaxLength = 1;
            this.box39.Name = "box39";
            this.box39.Size = new System.Drawing.Size(48, 28);
            this.box39.TabIndex = 101;
            this.box39.Text = "-1";
            // 
            // box38
            // 
            this.box38.FormattingEnabled = true;
            this.box38.Location = new System.Drawing.Point(929, 306);
            this.box38.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box38.MaxLength = 1;
            this.box38.Name = "box38";
            this.box38.Size = new System.Drawing.Size(48, 28);
            this.box38.TabIndex = 100;
            this.box38.Text = "-1";
            // 
            // box37
            // 
            this.box37.FormattingEnabled = true;
            this.box37.Location = new System.Drawing.Point(845, 306);
            this.box37.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box37.MaxLength = 1;
            this.box37.Name = "box37";
            this.box37.Size = new System.Drawing.Size(48, 28);
            this.box37.TabIndex = 99;
            this.box37.Text = "-1";
            // 
            // box36
            // 
            this.box36.FormattingEnabled = true;
            this.box36.Location = new System.Drawing.Point(758, 306);
            this.box36.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box36.MaxLength = 1;
            this.box36.Name = "box36";
            this.box36.Size = new System.Drawing.Size(48, 28);
            this.box36.TabIndex = 98;
            this.box36.Text = "-1";
            // 
            // box35
            // 
            this.box35.FormattingEnabled = true;
            this.box35.Location = new System.Drawing.Point(674, 306);
            this.box35.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box35.MaxLength = 1;
            this.box35.Name = "box35";
            this.box35.Size = new System.Drawing.Size(48, 28);
            this.box35.TabIndex = 97;
            this.box35.Text = "-1";
            // 
            // box34
            // 
            this.box34.FormattingEnabled = true;
            this.box34.Location = new System.Drawing.Point(598, 306);
            this.box34.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box34.MaxLength = 1;
            this.box34.Name = "box34";
            this.box34.Size = new System.Drawing.Size(48, 28);
            this.box34.TabIndex = 96;
            this.box34.Text = "-1";
            // 
            // box33
            // 
            this.box33.FormattingEnabled = true;
            this.box33.Location = new System.Drawing.Point(514, 306);
            this.box33.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box33.MaxLength = 1;
            this.box33.Name = "box33";
            this.box33.Size = new System.Drawing.Size(48, 28);
            this.box33.TabIndex = 95;
            this.box33.Text = "-1";
            // 
            // box32
            // 
            this.box32.FormattingEnabled = true;
            this.box32.Location = new System.Drawing.Point(428, 306);
            this.box32.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box32.MaxLength = 1;
            this.box32.Name = "box32";
            this.box32.Size = new System.Drawing.Size(48, 28);
            this.box32.TabIndex = 94;
            this.box32.Text = "-1";
            // 
            // box31
            // 
            this.box31.FormattingEnabled = true;
            this.box31.Location = new System.Drawing.Point(343, 306);
            this.box31.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box31.MaxLength = 1;
            this.box31.Name = "box31";
            this.box31.Size = new System.Drawing.Size(48, 28);
            this.box31.TabIndex = 93;
            this.box31.Text = "-1";
            // 
            // box69
            // 
            this.box69.FormattingEnabled = true;
            this.box69.Location = new System.Drawing.Point(1011, 558);
            this.box69.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box69.MaxLength = 1;
            this.box69.Name = "box69";
            this.box69.Size = new System.Drawing.Size(48, 28);
            this.box69.TabIndex = 128;
            this.box69.Text = "-1";
            // 
            // box68
            // 
            this.box68.FormattingEnabled = true;
            this.box68.Location = new System.Drawing.Point(929, 558);
            this.box68.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box68.MaxLength = 1;
            this.box68.Name = "box68";
            this.box68.Size = new System.Drawing.Size(48, 28);
            this.box68.TabIndex = 127;
            this.box68.Text = "-1";
            // 
            // box67
            // 
            this.box67.FormattingEnabled = true;
            this.box67.Location = new System.Drawing.Point(845, 558);
            this.box67.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box67.MaxLength = 1;
            this.box67.Name = "box67";
            this.box67.Size = new System.Drawing.Size(48, 28);
            this.box67.TabIndex = 126;
            this.box67.Text = "-1";
            // 
            // box66
            // 
            this.box66.FormattingEnabled = true;
            this.box66.Location = new System.Drawing.Point(758, 558);
            this.box66.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box66.MaxLength = 1;
            this.box66.Name = "box66";
            this.box66.Size = new System.Drawing.Size(48, 28);
            this.box66.TabIndex = 125;
            this.box66.Text = "-1";
            // 
            // box65
            // 
            this.box65.FormattingEnabled = true;
            this.box65.Location = new System.Drawing.Point(674, 558);
            this.box65.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box65.MaxLength = 1;
            this.box65.Name = "box65";
            this.box65.Size = new System.Drawing.Size(48, 28);
            this.box65.TabIndex = 124;
            this.box65.Text = "-1";
            // 
            // box64
            // 
            this.box64.FormattingEnabled = true;
            this.box64.Location = new System.Drawing.Point(598, 558);
            this.box64.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box64.MaxLength = 1;
            this.box64.Name = "box64";
            this.box64.Size = new System.Drawing.Size(48, 28);
            this.box64.TabIndex = 123;
            this.box64.Text = "-1";
            // 
            // box63
            // 
            this.box63.FormattingEnabled = true;
            this.box63.Location = new System.Drawing.Point(514, 558);
            this.box63.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box63.MaxLength = 1;
            this.box63.Name = "box63";
            this.box63.Size = new System.Drawing.Size(48, 28);
            this.box63.TabIndex = 122;
            this.box63.Text = "-1";
            // 
            // box62
            // 
            this.box62.FormattingEnabled = true;
            this.box62.Location = new System.Drawing.Point(428, 558);
            this.box62.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box62.MaxLength = 1;
            this.box62.Name = "box62";
            this.box62.Size = new System.Drawing.Size(48, 28);
            this.box62.TabIndex = 121;
            this.box62.Text = "-1";
            // 
            // box61
            // 
            this.box61.FormattingEnabled = true;
            this.box61.Location = new System.Drawing.Point(343, 558);
            this.box61.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box61.MaxLength = 1;
            this.box61.Name = "box61";
            this.box61.Size = new System.Drawing.Size(48, 28);
            this.box61.TabIndex = 120;
            this.box61.Text = "-1";
            // 
            // box59
            // 
            this.box59.FormattingEnabled = true;
            this.box59.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "-1"});
            this.box59.Location = new System.Drawing.Point(1011, 470);
            this.box59.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box59.MaxLength = 1;
            this.box59.Name = "box59";
            this.box59.Size = new System.Drawing.Size(48, 28);
            this.box59.TabIndex = 119;
            this.box59.Text = "-1";
            // 
            // box58
            // 
            this.box58.FormattingEnabled = true;
            this.box58.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "-1"});
            this.box58.Location = new System.Drawing.Point(929, 470);
            this.box58.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box58.MaxLength = 1;
            this.box58.Name = "box58";
            this.box58.Size = new System.Drawing.Size(48, 28);
            this.box58.TabIndex = 118;
            this.box58.Text = "-1";
            // 
            // box57
            // 
            this.box57.FormattingEnabled = true;
            this.box57.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "-1"});
            this.box57.Location = new System.Drawing.Point(845, 470);
            this.box57.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box57.MaxLength = 1;
            this.box57.Name = "box57";
            this.box57.Size = new System.Drawing.Size(48, 28);
            this.box57.TabIndex = 117;
            this.box57.Text = "-1";
            // 
            // box56
            // 
            this.box56.FormattingEnabled = true;
            this.box56.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "-1"});
            this.box56.Location = new System.Drawing.Point(758, 470);
            this.box56.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box56.MaxLength = 1;
            this.box56.Name = "box56";
            this.box56.Size = new System.Drawing.Size(48, 28);
            this.box56.TabIndex = 116;
            this.box56.Text = "-1";
            // 
            // box55
            // 
            this.box55.FormattingEnabled = true;
            this.box55.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "-1"});
            this.box55.Location = new System.Drawing.Point(674, 470);
            this.box55.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box55.MaxLength = 1;
            this.box55.Name = "box55";
            this.box55.Size = new System.Drawing.Size(48, 28);
            this.box55.TabIndex = 115;
            this.box55.Text = "-1";
            // 
            // box54
            // 
            this.box54.FormattingEnabled = true;
            this.box54.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "-1"});
            this.box54.Location = new System.Drawing.Point(598, 470);
            this.box54.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box54.MaxLength = 1;
            this.box54.Name = "box54";
            this.box54.Size = new System.Drawing.Size(48, 28);
            this.box54.TabIndex = 114;
            this.box54.Text = "-1";
            // 
            // box53
            // 
            this.box53.FormattingEnabled = true;
            this.box53.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "-1"});
            this.box53.Location = new System.Drawing.Point(514, 470);
            this.box53.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box53.MaxLength = 1;
            this.box53.Name = "box53";
            this.box53.Size = new System.Drawing.Size(48, 28);
            this.box53.TabIndex = 113;
            this.box53.Text = "-1";
            // 
            // box52
            // 
            this.box52.FormattingEnabled = true;
            this.box52.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "-1"});
            this.box52.Location = new System.Drawing.Point(428, 470);
            this.box52.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box52.MaxLength = 1;
            this.box52.Name = "box52";
            this.box52.Size = new System.Drawing.Size(48, 28);
            this.box52.TabIndex = 112;
            this.box52.Text = "-1";
            // 
            // box51
            // 
            this.box51.FormattingEnabled = true;
            this.box51.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "-1"});
            this.box51.Location = new System.Drawing.Point(343, 470);
            this.box51.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box51.MaxLength = 1;
            this.box51.Name = "box51";
            this.box51.Size = new System.Drawing.Size(48, 28);
            this.box51.TabIndex = 111;
            this.box51.Text = "-1";
            // 
            // box49
            // 
            this.box49.FormattingEnabled = true;
            this.box49.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "-1"});
            this.box49.Location = new System.Drawing.Point(1011, 386);
            this.box49.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box49.MaxLength = 1;
            this.box49.Name = "box49";
            this.box49.Size = new System.Drawing.Size(48, 28);
            this.box49.TabIndex = 110;
            this.box49.Text = "-1";
            // 
            // box48
            // 
            this.box48.FormattingEnabled = true;
            this.box48.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "-1"});
            this.box48.Location = new System.Drawing.Point(929, 386);
            this.box48.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box48.MaxLength = 1;
            this.box48.Name = "box48";
            this.box48.Size = new System.Drawing.Size(48, 28);
            this.box48.TabIndex = 109;
            this.box48.Text = "-1";
            // 
            // box47
            // 
            this.box47.FormattingEnabled = true;
            this.box47.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "-1"});
            this.box47.Location = new System.Drawing.Point(845, 386);
            this.box47.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box47.MaxLength = 1;
            this.box47.Name = "box47";
            this.box47.Size = new System.Drawing.Size(48, 28);
            this.box47.TabIndex = 108;
            this.box47.Text = "-1";
            // 
            // box46
            // 
            this.box46.FormattingEnabled = true;
            this.box46.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "-1"});
            this.box46.Location = new System.Drawing.Point(758, 386);
            this.box46.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box46.MaxLength = 1;
            this.box46.Name = "box46";
            this.box46.Size = new System.Drawing.Size(48, 28);
            this.box46.TabIndex = 107;
            this.box46.Text = "-1";
            // 
            // box45
            // 
            this.box45.FormattingEnabled = true;
            this.box45.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "-1"});
            this.box45.Location = new System.Drawing.Point(674, 386);
            this.box45.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box45.MaxLength = 1;
            this.box45.Name = "box45";
            this.box45.Size = new System.Drawing.Size(48, 28);
            this.box45.TabIndex = 106;
            this.box45.Text = "-1";
            // 
            // box44
            // 
            this.box44.FormattingEnabled = true;
            this.box44.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "-1"});
            this.box44.Location = new System.Drawing.Point(598, 386);
            this.box44.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box44.MaxLength = 1;
            this.box44.Name = "box44";
            this.box44.Size = new System.Drawing.Size(48, 28);
            this.box44.TabIndex = 105;
            this.box44.Text = "-1";
            // 
            // box43
            // 
            this.box43.FormattingEnabled = true;
            this.box43.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "-1"});
            this.box43.Location = new System.Drawing.Point(514, 386);
            this.box43.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box43.MaxLength = 1;
            this.box43.Name = "box43";
            this.box43.Size = new System.Drawing.Size(48, 28);
            this.box43.TabIndex = 104;
            this.box43.Text = "-1";
            // 
            // box42
            // 
            this.box42.FormattingEnabled = true;
            this.box42.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "-1"});
            this.box42.Location = new System.Drawing.Point(428, 386);
            this.box42.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box42.MaxLength = 1;
            this.box42.Name = "box42";
            this.box42.Size = new System.Drawing.Size(48, 28);
            this.box42.TabIndex = 103;
            this.box42.Text = "-1";
            // 
            // box41
            // 
            this.box41.FormattingEnabled = true;
            this.box41.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "-1"});
            this.box41.Location = new System.Drawing.Point(343, 386);
            this.box41.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box41.MaxLength = 1;
            this.box41.Name = "box41";
            this.box41.Size = new System.Drawing.Size(48, 28);
            this.box41.TabIndex = 102;
            this.box41.Text = "-1";
            // 
            // box99
            // 
            this.box99.FormattingEnabled = true;
            this.box99.Location = new System.Drawing.Point(1011, 816);
            this.box99.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box99.MaxLength = 1;
            this.box99.Name = "box99";
            this.box99.Size = new System.Drawing.Size(48, 28);
            this.box99.TabIndex = 155;
            this.box99.Text = "-1";
            // 
            // box98
            // 
            this.box98.FormattingEnabled = true;
            this.box98.Location = new System.Drawing.Point(929, 816);
            this.box98.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box98.MaxLength = 1;
            this.box98.Name = "box98";
            this.box98.Size = new System.Drawing.Size(48, 28);
            this.box98.TabIndex = 154;
            this.box98.Text = "-1";
            // 
            // box97
            // 
            this.box97.FormattingEnabled = true;
            this.box97.Location = new System.Drawing.Point(845, 816);
            this.box97.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box97.MaxLength = 1;
            this.box97.Name = "box97";
            this.box97.Size = new System.Drawing.Size(48, 28);
            this.box97.TabIndex = 153;
            this.box97.Text = "-1";
            // 
            // box96
            // 
            this.box96.FormattingEnabled = true;
            this.box96.Location = new System.Drawing.Point(758, 816);
            this.box96.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box96.MaxLength = 1;
            this.box96.Name = "box96";
            this.box96.Size = new System.Drawing.Size(48, 28);
            this.box96.TabIndex = 152;
            this.box96.Text = "-1";
            // 
            // box95
            // 
            this.box95.FormattingEnabled = true;
            this.box95.Location = new System.Drawing.Point(674, 816);
            this.box95.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box95.MaxLength = 1;
            this.box95.Name = "box95";
            this.box95.Size = new System.Drawing.Size(48, 28);
            this.box95.TabIndex = 151;
            this.box95.Text = "-1";
            // 
            // box94
            // 
            this.box94.FormattingEnabled = true;
            this.box94.Location = new System.Drawing.Point(598, 816);
            this.box94.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box94.MaxLength = 1;
            this.box94.Name = "box94";
            this.box94.Size = new System.Drawing.Size(48, 28);
            this.box94.TabIndex = 150;
            this.box94.Text = "-1";
            // 
            // box93
            // 
            this.box93.FormattingEnabled = true;
            this.box93.Location = new System.Drawing.Point(514, 816);
            this.box93.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box93.MaxLength = 1;
            this.box93.Name = "box93";
            this.box93.Size = new System.Drawing.Size(48, 28);
            this.box93.TabIndex = 149;
            this.box93.Text = "-1";
            // 
            // box92
            // 
            this.box92.FormattingEnabled = true;
            this.box92.Location = new System.Drawing.Point(428, 816);
            this.box92.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box92.MaxLength = 1;
            this.box92.Name = "box92";
            this.box92.Size = new System.Drawing.Size(48, 28);
            this.box92.TabIndex = 148;
            this.box92.Text = "-1";
            // 
            // box91
            // 
            this.box91.FormattingEnabled = true;
            this.box91.Location = new System.Drawing.Point(343, 816);
            this.box91.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box91.MaxLength = 1;
            this.box91.Name = "box91";
            this.box91.Size = new System.Drawing.Size(48, 28);
            this.box91.TabIndex = 147;
            this.box91.Text = "-1";
            // 
            // box89
            // 
            this.box89.FormattingEnabled = true;
            this.box89.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "-1"});
            this.box89.Location = new System.Drawing.Point(1011, 729);
            this.box89.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box89.MaxLength = 1;
            this.box89.Name = "box89";
            this.box89.Size = new System.Drawing.Size(48, 28);
            this.box89.TabIndex = 146;
            this.box89.Text = "-1";
            // 
            // box88
            // 
            this.box88.FormattingEnabled = true;
            this.box88.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "-1"});
            this.box88.Location = new System.Drawing.Point(929, 729);
            this.box88.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box88.MaxLength = 1;
            this.box88.Name = "box88";
            this.box88.Size = new System.Drawing.Size(48, 28);
            this.box88.TabIndex = 145;
            this.box88.Text = "-1";
            // 
            // box87
            // 
            this.box87.FormattingEnabled = true;
            this.box87.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "-1"});
            this.box87.Location = new System.Drawing.Point(845, 729);
            this.box87.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box87.MaxLength = 1;
            this.box87.Name = "box87";
            this.box87.Size = new System.Drawing.Size(48, 28);
            this.box87.TabIndex = 144;
            this.box87.Text = "-1";
            // 
            // box86
            // 
            this.box86.FormattingEnabled = true;
            this.box86.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "-1"});
            this.box86.Location = new System.Drawing.Point(758, 729);
            this.box86.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box86.MaxLength = 1;
            this.box86.Name = "box86";
            this.box86.Size = new System.Drawing.Size(48, 28);
            this.box86.TabIndex = 143;
            this.box86.Text = "-1";
            // 
            // box85
            // 
            this.box85.FormattingEnabled = true;
            this.box85.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "-1"});
            this.box85.Location = new System.Drawing.Point(674, 729);
            this.box85.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box85.MaxLength = 1;
            this.box85.Name = "box85";
            this.box85.Size = new System.Drawing.Size(48, 28);
            this.box85.TabIndex = 142;
            this.box85.Text = "-1";
            // 
            // box84
            // 
            this.box84.FormattingEnabled = true;
            this.box84.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "-1"});
            this.box84.Location = new System.Drawing.Point(598, 729);
            this.box84.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box84.MaxLength = 1;
            this.box84.Name = "box84";
            this.box84.Size = new System.Drawing.Size(48, 28);
            this.box84.TabIndex = 141;
            this.box84.Text = "-1";
            // 
            // box83
            // 
            this.box83.FormattingEnabled = true;
            this.box83.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "-1"});
            this.box83.Location = new System.Drawing.Point(514, 729);
            this.box83.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box83.MaxLength = 1;
            this.box83.Name = "box83";
            this.box83.Size = new System.Drawing.Size(48, 28);
            this.box83.TabIndex = 140;
            this.box83.Text = "-1";
            // 
            // box82
            // 
            this.box82.FormattingEnabled = true;
            this.box82.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "-1"});
            this.box82.Location = new System.Drawing.Point(428, 729);
            this.box82.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box82.MaxLength = 1;
            this.box82.Name = "box82";
            this.box82.Size = new System.Drawing.Size(48, 28);
            this.box82.TabIndex = 139;
            this.box82.Text = "-1";
            // 
            // box81
            // 
            this.box81.FormattingEnabled = true;
            this.box81.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "-1"});
            this.box81.Location = new System.Drawing.Point(343, 729);
            this.box81.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box81.MaxLength = 1;
            this.box81.Name = "box81";
            this.box81.Size = new System.Drawing.Size(48, 28);
            this.box81.TabIndex = 138;
            this.box81.Text = "-1";
            // 
            // box79
            // 
            this.box79.FormattingEnabled = true;
            this.box79.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "-1"});
            this.box79.Location = new System.Drawing.Point(1011, 645);
            this.box79.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box79.MaxLength = 1;
            this.box79.Name = "box79";
            this.box79.Size = new System.Drawing.Size(48, 28);
            this.box79.TabIndex = 137;
            this.box79.Text = "-1";
            // 
            // box78
            // 
            this.box78.FormattingEnabled = true;
            this.box78.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "-1"});
            this.box78.Location = new System.Drawing.Point(929, 645);
            this.box78.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box78.MaxLength = 1;
            this.box78.Name = "box78";
            this.box78.Size = new System.Drawing.Size(48, 28);
            this.box78.TabIndex = 136;
            this.box78.Text = "-1";
            // 
            // box77
            // 
            this.box77.FormattingEnabled = true;
            this.box77.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "-1"});
            this.box77.Location = new System.Drawing.Point(845, 645);
            this.box77.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box77.MaxLength = 1;
            this.box77.Name = "box77";
            this.box77.Size = new System.Drawing.Size(48, 28);
            this.box77.TabIndex = 135;
            this.box77.Text = "-1";
            // 
            // box76
            // 
            this.box76.FormattingEnabled = true;
            this.box76.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "-1"});
            this.box76.Location = new System.Drawing.Point(758, 645);
            this.box76.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box76.MaxLength = 1;
            this.box76.Name = "box76";
            this.box76.Size = new System.Drawing.Size(48, 28);
            this.box76.TabIndex = 134;
            this.box76.Text = "-1";
            // 
            // box75
            // 
            this.box75.FormattingEnabled = true;
            this.box75.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "-1"});
            this.box75.Location = new System.Drawing.Point(674, 645);
            this.box75.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box75.MaxLength = 1;
            this.box75.Name = "box75";
            this.box75.Size = new System.Drawing.Size(48, 28);
            this.box75.TabIndex = 133;
            this.box75.Text = "-1";
            // 
            // box74
            // 
            this.box74.FormattingEnabled = true;
            this.box74.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "-1"});
            this.box74.Location = new System.Drawing.Point(598, 645);
            this.box74.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box74.MaxLength = 1;
            this.box74.Name = "box74";
            this.box74.Size = new System.Drawing.Size(48, 28);
            this.box74.TabIndex = 132;
            this.box74.Text = "-1";
            // 
            // box73
            // 
            this.box73.FormattingEnabled = true;
            this.box73.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "-1"});
            this.box73.Location = new System.Drawing.Point(514, 645);
            this.box73.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box73.MaxLength = 1;
            this.box73.Name = "box73";
            this.box73.Size = new System.Drawing.Size(48, 28);
            this.box73.TabIndex = 131;
            this.box73.Text = "-1";
            // 
            // box72
            // 
            this.box72.FormattingEnabled = true;
            this.box72.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "-1"});
            this.box72.Location = new System.Drawing.Point(428, 645);
            this.box72.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box72.MaxLength = 1;
            this.box72.Name = "box72";
            this.box72.Size = new System.Drawing.Size(48, 28);
            this.box72.TabIndex = 130;
            this.box72.Text = "-1";
            // 
            // box71
            // 
            this.box71.FormattingEnabled = true;
            this.box71.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "-1"});
            this.box71.Location = new System.Drawing.Point(343, 645);
            this.box71.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.box71.MaxLength = 1;
            this.box71.Name = "box71";
            this.box71.Size = new System.Drawing.Size(48, 28);
            this.box71.TabIndex = 129;
            this.box71.Text = "-1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(666, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(322, 46);
            this.label2.TabIndex = 156;
            this.label2.Text = "Possible Solutions:";
            // 
            // CountLabel
            // 
            this.CountLabel.AutoSize = true;
            this.CountLabel.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountLabel.Location = new System.Drawing.Point(990, 25);
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(0, 46);
            this.CountLabel.TabIndex = 157;
            // 
            // ResetButton
            // 
            this.ResetButton.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.Location = new System.Drawing.Point(615, 949);
            this.ResetButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(191, 71);
            this.ResetButton.TabIndex = 158;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Enabled = false;
            this.NextButton.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextButton.Location = new System.Drawing.Point(832, 949);
            this.NextButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(191, 71);
            this.NextButton.TabIndex = 159;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 46);
            this.label3.TabIndex = 160;
            this.label3.Text = "Presets";
            // 
            // Preset1Button
            // 
            this.Preset1Button.Location = new System.Drawing.Point(30, 190);
            this.Preset1Button.Name = "Preset1Button";
            this.Preset1Button.Size = new System.Drawing.Size(114, 57);
            this.Preset1Button.TabIndex = 161;
            this.Preset1Button.Text = "Easy 1";
            this.Preset1Button.UseVisualStyleBackColor = true;
            this.Preset1Button.Click += new System.EventHandler(this.Preset1Button_Click);
            // 
            // Preset2Button
            // 
            this.Preset2Button.Location = new System.Drawing.Point(30, 278);
            this.Preset2Button.Name = "Preset2Button";
            this.Preset2Button.Size = new System.Drawing.Size(114, 57);
            this.Preset2Button.TabIndex = 162;
            this.Preset2Button.Text = "Easy 2";
            this.Preset2Button.UseVisualStyleBackColor = true;
            this.Preset2Button.Click += new System.EventHandler(this.Preset2Button_Click);
            // 
            // Preset3Button
            // 
            this.Preset3Button.Location = new System.Drawing.Point(30, 366);
            this.Preset3Button.Name = "Preset3Button";
            this.Preset3Button.Size = new System.Drawing.Size(114, 57);
            this.Preset3Button.TabIndex = 163;
            this.Preset3Button.Text = "Medium 1";
            this.Preset3Button.UseVisualStyleBackColor = true;
            this.Preset3Button.Click += new System.EventHandler(this.Preset3Button_Click);
            // 
            // Preset4Button
            // 
            this.Preset4Button.Location = new System.Drawing.Point(30, 454);
            this.Preset4Button.Name = "Preset4Button";
            this.Preset4Button.Size = new System.Drawing.Size(114, 57);
            this.Preset4Button.TabIndex = 164;
            this.Preset4Button.Text = "Hard 1";
            this.Preset4Button.UseVisualStyleBackColor = true;
            this.Preset4Button.Click += new System.EventHandler(this.Preset4Button_Click);
            // 
            // parallelCheckBox
            // 
            this.parallelCheckBox.AutoSize = true;
            this.parallelCheckBox.Checked = true;
            this.parallelCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.parallelCheckBox.Location = new System.Drawing.Point(398, 1057);
            this.parallelCheckBox.Name = "parallelCheckBox";
            this.parallelCheckBox.Size = new System.Drawing.Size(95, 24);
            this.parallelCheckBox.TabIndex = 165;
            this.parallelCheckBox.Text = "Parallel?";
            this.parallelCheckBox.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(548, 1038);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 46);
            this.label4.TabIndex = 166;
            this.label4.Text = "Time:";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(707, 1038);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(0, 46);
            this.timeLabel.TabIndex = 167;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 1188);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.parallelCheckBox);
            this.Controls.Add(this.Preset4Button);
            this.Controls.Add(this.Preset3Button);
            this.Controls.Add(this.Preset2Button);
            this.Controls.Add(this.Preset1Button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.CountLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.box99);
            this.Controls.Add(this.box98);
            this.Controls.Add(this.box97);
            this.Controls.Add(this.box96);
            this.Controls.Add(this.box95);
            this.Controls.Add(this.box94);
            this.Controls.Add(this.box93);
            this.Controls.Add(this.box92);
            this.Controls.Add(this.box91);
            this.Controls.Add(this.box89);
            this.Controls.Add(this.box88);
            this.Controls.Add(this.box87);
            this.Controls.Add(this.box86);
            this.Controls.Add(this.box85);
            this.Controls.Add(this.box84);
            this.Controls.Add(this.box83);
            this.Controls.Add(this.box82);
            this.Controls.Add(this.box81);
            this.Controls.Add(this.box79);
            this.Controls.Add(this.box78);
            this.Controls.Add(this.box77);
            this.Controls.Add(this.box76);
            this.Controls.Add(this.box75);
            this.Controls.Add(this.box74);
            this.Controls.Add(this.box73);
            this.Controls.Add(this.box72);
            this.Controls.Add(this.box71);
            this.Controls.Add(this.box69);
            this.Controls.Add(this.box68);
            this.Controls.Add(this.box67);
            this.Controls.Add(this.box66);
            this.Controls.Add(this.box65);
            this.Controls.Add(this.box64);
            this.Controls.Add(this.box63);
            this.Controls.Add(this.box62);
            this.Controls.Add(this.box61);
            this.Controls.Add(this.box59);
            this.Controls.Add(this.box58);
            this.Controls.Add(this.box57);
            this.Controls.Add(this.box56);
            this.Controls.Add(this.box55);
            this.Controls.Add(this.box54);
            this.Controls.Add(this.box53);
            this.Controls.Add(this.box52);
            this.Controls.Add(this.box51);
            this.Controls.Add(this.box49);
            this.Controls.Add(this.box48);
            this.Controls.Add(this.box47);
            this.Controls.Add(this.box46);
            this.Controls.Add(this.box45);
            this.Controls.Add(this.box44);
            this.Controls.Add(this.box43);
            this.Controls.Add(this.box42);
            this.Controls.Add(this.box41);
            this.Controls.Add(this.box39);
            this.Controls.Add(this.box38);
            this.Controls.Add(this.box37);
            this.Controls.Add(this.box36);
            this.Controls.Add(this.box35);
            this.Controls.Add(this.box34);
            this.Controls.Add(this.box33);
            this.Controls.Add(this.box32);
            this.Controls.Add(this.box31);
            this.Controls.Add(this.box29);
            this.Controls.Add(this.box28);
            this.Controls.Add(this.box27);
            this.Controls.Add(this.box26);
            this.Controls.Add(this.box25);
            this.Controls.Add(this.box24);
            this.Controls.Add(this.box23);
            this.Controls.Add(this.box22);
            this.Controls.Add(this.box21);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.solveButton);
            this.Controls.Add(this.box19);
            this.Controls.Add(this.box18);
            this.Controls.Add(this.box17);
            this.Controls.Add(this.box16);
            this.Controls.Add(this.box15);
            this.Controls.Add(this.box14);
            this.Controls.Add(this.box13);
            this.Controls.Add(this.box12);
            this.Controls.Add(this.box11);
            this.Controls.Add(this.Picture);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1354, 1244);
            this.MinimumSize = new System.Drawing.Size(1354, 1244);
            this.Name = "Form1";
            this.Text = "Sudoku Solver";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Picture;
        private System.Windows.Forms.ComboBox box11;
        private System.Windows.Forms.ComboBox box12;
        private System.Windows.Forms.ComboBox box14;
        private System.Windows.Forms.ComboBox box13;
        private System.Windows.Forms.ComboBox box18;
        private System.Windows.Forms.ComboBox box17;
        private System.Windows.Forms.ComboBox box16;
        private System.Windows.Forms.ComboBox box15;
        private System.Windows.Forms.ComboBox box19;
        private System.Windows.Forms.Button solveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox box29;
        private System.Windows.Forms.ComboBox box28;
        private System.Windows.Forms.ComboBox box27;
        private System.Windows.Forms.ComboBox box26;
        private System.Windows.Forms.ComboBox box25;
        private System.Windows.Forms.ComboBox box24;
        private System.Windows.Forms.ComboBox box23;
        private System.Windows.Forms.ComboBox box22;
        private System.Windows.Forms.ComboBox box21;
        private System.Windows.Forms.ComboBox box39;
        private System.Windows.Forms.ComboBox box38;
        private System.Windows.Forms.ComboBox box37;
        private System.Windows.Forms.ComboBox box36;
        private System.Windows.Forms.ComboBox box35;
        private System.Windows.Forms.ComboBox box34;
        private System.Windows.Forms.ComboBox box33;
        private System.Windows.Forms.ComboBox box32;
        private System.Windows.Forms.ComboBox box31;
        private System.Windows.Forms.ComboBox box69;
        private System.Windows.Forms.ComboBox box68;
        private System.Windows.Forms.ComboBox box67;
        private System.Windows.Forms.ComboBox box66;
        private System.Windows.Forms.ComboBox box65;
        private System.Windows.Forms.ComboBox box64;
        private System.Windows.Forms.ComboBox box63;
        private System.Windows.Forms.ComboBox box62;
        private System.Windows.Forms.ComboBox box61;
        private System.Windows.Forms.ComboBox box59;
        private System.Windows.Forms.ComboBox box58;
        private System.Windows.Forms.ComboBox box57;
        private System.Windows.Forms.ComboBox box56;
        private System.Windows.Forms.ComboBox box55;
        private System.Windows.Forms.ComboBox box54;
        private System.Windows.Forms.ComboBox box53;
        private System.Windows.Forms.ComboBox box52;
        private System.Windows.Forms.ComboBox box51;
        private System.Windows.Forms.ComboBox box49;
        private System.Windows.Forms.ComboBox box48;
        private System.Windows.Forms.ComboBox box47;
        private System.Windows.Forms.ComboBox box46;
        private System.Windows.Forms.ComboBox box45;
        private System.Windows.Forms.ComboBox box44;
        private System.Windows.Forms.ComboBox box43;
        private System.Windows.Forms.ComboBox box42;
        private System.Windows.Forms.ComboBox box41;
        private System.Windows.Forms.ComboBox box99;
        private System.Windows.Forms.ComboBox box98;
        private System.Windows.Forms.ComboBox box97;
        private System.Windows.Forms.ComboBox box96;
        private System.Windows.Forms.ComboBox box95;
        private System.Windows.Forms.ComboBox box94;
        private System.Windows.Forms.ComboBox box93;
        private System.Windows.Forms.ComboBox box92;
        private System.Windows.Forms.ComboBox box91;
        private System.Windows.Forms.ComboBox box89;
        private System.Windows.Forms.ComboBox box88;
        private System.Windows.Forms.ComboBox box87;
        private System.Windows.Forms.ComboBox box86;
        private System.Windows.Forms.ComboBox box85;
        private System.Windows.Forms.ComboBox box84;
        private System.Windows.Forms.ComboBox box83;
        private System.Windows.Forms.ComboBox box82;
        private System.Windows.Forms.ComboBox box81;
        private System.Windows.Forms.ComboBox box79;
        private System.Windows.Forms.ComboBox box78;
        private System.Windows.Forms.ComboBox box77;
        private System.Windows.Forms.ComboBox box76;
        private System.Windows.Forms.ComboBox box75;
        private System.Windows.Forms.ComboBox box74;
        private System.Windows.Forms.ComboBox box73;
        private System.Windows.Forms.ComboBox box72;
        private System.Windows.Forms.ComboBox box71;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label CountLabel;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Preset1Button;
        private System.Windows.Forms.Button Preset2Button;
        private System.Windows.Forms.Button Preset3Button;
        private System.Windows.Forms.Button Preset4Button;
        private System.Windows.Forms.CheckBox parallelCheckBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label timeLabel;
    }
}