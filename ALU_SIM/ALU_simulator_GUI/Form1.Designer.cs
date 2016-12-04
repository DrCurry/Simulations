namespace ALU_simulator_GUI // auto generated
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
            this.ADD_btn = new System.Windows.Forms.Button();
            this.SUB_btn = new System.Windows.Forms.Button();
            this.INV_btn = new System.Windows.Forms.Button();
            this.AND_btn = new System.Windows.Forms.Button();
            this.OR_btn = new System.Windows.Forms.Button();
            this.XOR_btn = new System.Windows.Forms.Button();
            this.shiftLeft_btn = new System.Windows.Forms.Button();
            this.shiftRight_btn = new System.Windows.Forms.Button();
            this.INC_btn = new System.Windows.Forms.Button();
            this.RegisterB_LBL = new System.Windows.Forms.Label();
            this.RegisterC_LBL = new System.Windows.Forms.Label();
            this.RegisterA_LBL = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.STORE_btn = new System.Windows.Forms.Button();
            this.RegisterB_Input = new System.Windows.Forms.TextBox();
            this.RegisterC_Input = new System.Windows.Forms.TextBox();
            this.RegisterA_Input = new System.Windows.Forms.TextBox();
            this.regB_msg = new System.Windows.Forms.Label();
            this.regC_msg = new System.Windows.Forms.Label();
            this.regA_msg = new System.Windows.Forms.Label();
            this.HELP_btn = new System.Windows.Forms.Button();
            this.C_bit_lbl = new System.Windows.Forms.Label();
            this.z_bit_lbl = new System.Windows.Forms.Label();
            this.n_bit_lbl = new System.Windows.Forms.Label();
            this.v_bit_lbl = new System.Windows.Forms.Label();
            this.c_txtbox = new System.Windows.Forms.TextBox();
            this.v_txtbox = new System.Windows.Forms.TextBox();
            this.n_txtbox = new System.Windows.Forms.TextBox();
            this.z_txtbox = new System.Windows.Forms.TextBox();
            this.BranchCarry_btn = new System.Windows.Forms.Button();
            this.Branch_0_btn = new System.Windows.Forms.Button();
            this.ccrCLR = new System.Windows.Forms.Button();
            this.ADC_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ADD_btn
            // 
            this.ADD_btn.Location = new System.Drawing.Point(12, 12);
            this.ADD_btn.Name = "ADD_btn";
            this.ADD_btn.Size = new System.Drawing.Size(100, 23);
            this.ADD_btn.TabIndex = 0;
            this.ADD_btn.Text = "ADD";
            this.ADD_btn.UseVisualStyleBackColor = true;
            this.ADD_btn.Click += new System.EventHandler(this.ADD_BUTTON_EVENT);
            // 
            // SUB_btn
            // 
            this.SUB_btn.Location = new System.Drawing.Point(12, 70);
            this.SUB_btn.Name = "SUB_btn";
            this.SUB_btn.Size = new System.Drawing.Size(100, 23);
            this.SUB_btn.TabIndex = 1;
            this.SUB_btn.Text = "SUBTRACT";
            this.SUB_btn.UseVisualStyleBackColor = true;
            this.SUB_btn.Click += new System.EventHandler(this.SUB_BUTTON_EVENT);
            // 
            // INV_btn
            // 
            this.INV_btn.Location = new System.Drawing.Point(12, 99);
            this.INV_btn.Name = "INV_btn";
            this.INV_btn.Size = new System.Drawing.Size(100, 23);
            this.INV_btn.TabIndex = 2;
            this.INV_btn.Text = "COMPLEMENT";
            this.INV_btn.UseVisualStyleBackColor = true;
            this.INV_btn.Click += new System.EventHandler(this.INVERT_BUTTON_EVENT);
            // 
            // AND_btn
            // 
            this.AND_btn.Location = new System.Drawing.Point(12, 128);
            this.AND_btn.Name = "AND_btn";
            this.AND_btn.Size = new System.Drawing.Size(100, 23);
            this.AND_btn.TabIndex = 3;
            this.AND_btn.Text = "AND";
            this.AND_btn.UseVisualStyleBackColor = true;
            this.AND_btn.Click += new System.EventHandler(this.AND_BUTTON_EVENT);
            // 
            // OR_btn
            // 
            this.OR_btn.Location = new System.Drawing.Point(12, 157);
            this.OR_btn.Name = "OR_btn";
            this.OR_btn.Size = new System.Drawing.Size(100, 23);
            this.OR_btn.TabIndex = 4;
            this.OR_btn.Text = "OR";
            this.OR_btn.UseVisualStyleBackColor = true;
            this.OR_btn.Click += new System.EventHandler(this.OR_BUTTON_EVENT);
            // 
            // XOR_btn
            // 
            this.XOR_btn.Location = new System.Drawing.Point(12, 186);
            this.XOR_btn.Name = "XOR_btn";
            this.XOR_btn.Size = new System.Drawing.Size(100, 23);
            this.XOR_btn.TabIndex = 5;
            this.XOR_btn.Text = "XOR";
            this.XOR_btn.UseVisualStyleBackColor = true;
            this.XOR_btn.Click += new System.EventHandler(this.XOR_BUTTON_EVENT);
            // 
            // shiftLeft_btn
            // 
            this.shiftLeft_btn.Location = new System.Drawing.Point(118, 12);
            this.shiftLeft_btn.Name = "shiftLeft_btn";
            this.shiftLeft_btn.Size = new System.Drawing.Size(100, 23);
            this.shiftLeft_btn.TabIndex = 6;
            this.shiftLeft_btn.Text = "SHIFT-LEFT";
            this.shiftLeft_btn.UseVisualStyleBackColor = true;
            this.shiftLeft_btn.Click += new System.EventHandler(this.SHL_BUTTON_EVENT);
            // 
            // shiftRight_btn
            // 
            this.shiftRight_btn.Location = new System.Drawing.Point(118, 41);
            this.shiftRight_btn.Name = "shiftRight_btn";
            this.shiftRight_btn.Size = new System.Drawing.Size(100, 23);
            this.shiftRight_btn.TabIndex = 7;
            this.shiftRight_btn.Text = "SHIFT_RIGHT";
            this.shiftRight_btn.UseVisualStyleBackColor = true;
            this.shiftRight_btn.Click += new System.EventHandler(this.SHR_BUTTON_EVENT);
            // 
            // INC_btn
            // 
            this.INC_btn.Location = new System.Drawing.Point(118, 70);
            this.INC_btn.Name = "INC_btn";
            this.INC_btn.Size = new System.Drawing.Size(100, 23);
            this.INC_btn.TabIndex = 8;
            this.INC_btn.Text = "INCREMENT";
            this.INC_btn.UseVisualStyleBackColor = true;
            this.INC_btn.Click += new System.EventHandler(this.INCREMENT_BUTTON_EVENT);
            // 
            // RegisterB_LBL
            // 
            this.RegisterB_LBL.AutoSize = true;
            this.RegisterB_LBL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RegisterB_LBL.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterB_LBL.Location = new System.Drawing.Point(383, 232);
            this.RegisterB_LBL.Name = "RegisterB_LBL";
            this.RegisterB_LBL.Size = new System.Drawing.Size(112, 24);
            this.RegisterB_LBL.TabIndex = 9;
            this.RegisterB_LBL.Text = "REGISTER B";
            // 
            // RegisterC_LBL
            // 
            this.RegisterC_LBL.AutoSize = true;
            this.RegisterC_LBL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RegisterC_LBL.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterC_LBL.Location = new System.Drawing.Point(383, 145);
            this.RegisterC_LBL.Name = "RegisterC_LBL";
            this.RegisterC_LBL.Size = new System.Drawing.Size(112, 24);
            this.RegisterC_LBL.TabIndex = 10;
            this.RegisterC_LBL.Text = "REGISTER C";
            // 
            // RegisterA_LBL
            // 
            this.RegisterA_LBL.AutoSize = true;
            this.RegisterA_LBL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RegisterA_LBL.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterA_LBL.Location = new System.Drawing.Point(383, 61);
            this.RegisterA_LBL.Name = "RegisterA_LBL";
            this.RegisterA_LBL.Size = new System.Drawing.Size(112, 24);
            this.RegisterA_LBL.TabIndex = 11;
            this.RegisterA_LBL.Text = "REGISTER A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(318, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Binary form";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(318, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Binary form";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(318, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Binary form";
            // 
            // STORE_btn
            // 
            this.STORE_btn.Location = new System.Drawing.Point(12, 41);
            this.STORE_btn.Name = "STORE_btn";
            this.STORE_btn.Size = new System.Drawing.Size(100, 23);
            this.STORE_btn.TabIndex = 18;
            this.STORE_btn.Text = "STORE";
            this.STORE_btn.UseVisualStyleBackColor = true;
            this.STORE_btn.Click += new System.EventHandler(this.STORE_BUTTON_EVENT);
            // 
            // RegisterB_Input
            // 
            this.RegisterB_Input.Location = new System.Drawing.Point(383, 209);
            this.RegisterB_Input.Name = "RegisterB_Input";
            this.RegisterB_Input.Size = new System.Drawing.Size(112, 20);
            this.RegisterB_Input.TabIndex = 19;
            // 
            // RegisterC_Input
            // 
            this.RegisterC_Input.Location = new System.Drawing.Point(383, 122);
            this.RegisterC_Input.Name = "RegisterC_Input";
            this.RegisterC_Input.Size = new System.Drawing.Size(112, 20);
            this.RegisterC_Input.TabIndex = 20;
            // 
            // RegisterA_Input
            // 
            this.RegisterA_Input.Location = new System.Drawing.Point(383, 38);
            this.RegisterA_Input.Name = "RegisterA_Input";
            this.RegisterA_Input.Size = new System.Drawing.Size(112, 20);
            this.RegisterA_Input.TabIndex = 21;
            // 
            // regB_msg
            // 
            this.regB_msg.AutoSize = true;
            this.regB_msg.Location = new System.Drawing.Point(307, 212);
            this.regB_msg.Name = "regB_msg";
            this.regB_msg.Size = new System.Drawing.Size(70, 13);
            this.regB_msg.TabIndex = 23;
            this.regB_msg.Text = "# btwn 0-255";
            // 
            // regC_msg
            //
            this.regC_msg.AutoSize = true;
            this.regC_msg.Location = new System.Drawing.Point(307, 125);
            this.regC_msg.Name = "regC_msg";
            this.regC_msg.Size = new System.Drawing.Size(70, 13);
            this.regC_msg.TabIndex = 24;
            this.regC_msg.Text = "# btwn 0-255";
            // 
            // regA_msg
            // 
            this.regA_msg.AutoSize = true;
            this.regA_msg.Location = new System.Drawing.Point(307, 41);
            this.regA_msg.Name = "regA_msg";
            this.regA_msg.Size = new System.Drawing.Size(70, 13);
            this.regA_msg.TabIndex = 25;
            this.regA_msg.Text = "# btwn 0-255";
            // 
            // HELP_btn
            // 
            this.HELP_btn.Location = new System.Drawing.Point(12, 215);
            this.HELP_btn.Name = "HELP_btn";
            this.HELP_btn.Size = new System.Drawing.Size(100, 23);
            this.HELP_btn.TabIndex = 26;
            this.HELP_btn.Text = "HELP";
            this.HELP_btn.UseVisualStyleBackColor = true;
            this.HELP_btn.Click += new System.EventHandler(this.HELP_btn_Click);
            // 
            // C_bit_lbl
            // 
            this.C_bit_lbl.AutoSize = true;
            this.C_bit_lbl.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C_bit_lbl.Location = new System.Drawing.Point(607, 53);
            this.C_bit_lbl.Name = "C_bit_lbl";
            this.C_bit_lbl.Size = new System.Drawing.Size(14, 15);
            this.C_bit_lbl.TabIndex = 27;
            this.C_bit_lbl.Text = "C";
            // 
            // z_bit_lbl
            // 
            this.z_bit_lbl.AutoSize = true;
            this.z_bit_lbl.Location = new System.Drawing.Point(607, 96);
            this.z_bit_lbl.Name = "z_bit_lbl";
            this.z_bit_lbl.Size = new System.Drawing.Size(14, 13);
            this.z_bit_lbl.TabIndex = 28;
            this.z_bit_lbl.Text = "Z";
            // 
            // n_bit_lbl
            // 
            this.n_bit_lbl.AutoSize = true;
            this.n_bit_lbl.Location = new System.Drawing.Point(607, 138);
            this.n_bit_lbl.Name = "n_bit_lbl";
            this.n_bit_lbl.Size = new System.Drawing.Size(15, 13);
            this.n_bit_lbl.TabIndex = 29;
            this.n_bit_lbl.Text = "N";
            // 
            // v_bit_lbl
            // 
            this.v_bit_lbl.AutoSize = true;
            this.v_bit_lbl.Location = new System.Drawing.Point(607, 188);
            this.v_bit_lbl.Name = "v_bit_lbl";
            this.v_bit_lbl.Size = new System.Drawing.Size(14, 13);
            this.v_bit_lbl.TabIndex = 30;
            this.v_bit_lbl.Text = "V";
            // 
            // c_txtbox
            // 
            this.c_txtbox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_txtbox.Location = new System.Drawing.Point(627, 48);
            this.c_txtbox.Name = "c_txtbox";
            this.c_txtbox.Size = new System.Drawing.Size(33, 23);
            this.c_txtbox.TabIndex = 31;
            // 
            // v_txtbox
            // 
            this.v_txtbox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.v_txtbox.Location = new System.Drawing.Point(627, 178);
            this.v_txtbox.Name = "v_txtbox";
            this.v_txtbox.Size = new System.Drawing.Size(33, 23);
            this.v_txtbox.TabIndex = 32;
            // 
            // n_txtbox
            // 
            this.n_txtbox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n_txtbox.Location = new System.Drawing.Point(627, 132);
            this.n_txtbox.Name = "n_txtbox";
            this.n_txtbox.Size = new System.Drawing.Size(33, 23);
            this.n_txtbox.TabIndex = 33;
            // 
            // z_txtbox
            // 
            this.z_txtbox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.z_txtbox.Location = new System.Drawing.Point(627, 92);
            this.z_txtbox.Name = "z_txtbox";
            this.z_txtbox.Size = new System.Drawing.Size(33, 23);
            this.z_txtbox.TabIndex = 34;
            // 
            // BranchCarry_btn
            // 
            this.BranchCarry_btn.Location = new System.Drawing.Point(118, 99);
            this.BranchCarry_btn.Name = "BranchCarry_btn";
            this.BranchCarry_btn.Size = new System.Drawing.Size(100, 23);
            this.BranchCarry_btn.TabIndex = 35;
            this.BranchCarry_btn.Text = "BRANCH-C";
            this.BranchCarry_btn.UseVisualStyleBackColor = true;
            this.BranchCarry_btn.Click += new System.EventHandler(this.BranchCarry_btn_Click);
            // 
            // Branch_0_btn
            // 
            this.Branch_0_btn.Location = new System.Drawing.Point(118, 128);
            this.Branch_0_btn.Name = "Branch_0_btn";
            this.Branch_0_btn.Size = new System.Drawing.Size(100, 23);
            this.Branch_0_btn.TabIndex = 36;
            this.Branch_0_btn.Text = "BRANCH0";
            this.Branch_0_btn.UseVisualStyleBackColor = true;
            this.Branch_0_btn.Click += new System.EventHandler(this.Branch_0_btn_Click);
            // 
            // ccrCLR
            // 
            this.ccrCLR.Location = new System.Drawing.Point(118, 157);
            this.ccrCLR.Name = "ccrCLR";
            this.ccrCLR.Size = new System.Drawing.Size(100, 23);
            this.ccrCLR.TabIndex = 37;
            this.ccrCLR.Text = "Zero CCR";
            this.ccrCLR.UseVisualStyleBackColor = true;
            this.ccrCLR.Click += new System.EventHandler(this.ccrCLR_Click);
            // 
            // ADC_btn
            // 
            this.ADC_btn.Location = new System.Drawing.Point(118, 186);
            this.ADC_btn.Name = "ADC_btn";
            this.ADC_btn.Size = new System.Drawing.Size(100, 23);
            this.ADC_btn.TabIndex = 38;
            this.ADC_btn.Text = "ADD w/ CARRY";
            this.ADC_btn.UseVisualStyleBackColor = true;
            this.ADC_btn.Click += new System.EventHandler(this.ADD_CARRY_BTN);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 477);
            this.Controls.Add(this.ADC_btn);
            this.Controls.Add(this.ccrCLR);
            this.Controls.Add(this.Branch_0_btn);
            this.Controls.Add(this.BranchCarry_btn);
            this.Controls.Add(this.z_txtbox);
            this.Controls.Add(this.n_txtbox);
            this.Controls.Add(this.v_txtbox);
            this.Controls.Add(this.c_txtbox);
            this.Controls.Add(this.v_bit_lbl);
            this.Controls.Add(this.n_bit_lbl);
            this.Controls.Add(this.z_bit_lbl);
            this.Controls.Add(this.C_bit_lbl);
            this.Controls.Add(this.HELP_btn);
            this.Controls.Add(this.regA_msg);
            this.Controls.Add(this.regC_msg);
            this.Controls.Add(this.regB_msg);
            this.Controls.Add(this.RegisterA_Input);
            this.Controls.Add(this.RegisterC_Input);
            this.Controls.Add(this.RegisterB_Input);
            this.Controls.Add(this.STORE_btn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RegisterA_LBL);
            this.Controls.Add(this.RegisterC_LBL);
            this.Controls.Add(this.RegisterB_LBL);
            this.Controls.Add(this.INC_btn);
            this.Controls.Add(this.shiftRight_btn);
            this.Controls.Add(this.shiftLeft_btn);
            this.Controls.Add(this.XOR_btn);
            this.Controls.Add(this.OR_btn);
            this.Controls.Add(this.AND_btn);
            this.Controls.Add(this.INV_btn);
            this.Controls.Add(this.SUB_btn);
            this.Controls.Add(this.ADD_btn);
            this.Name = "Form1";
            this.Text = "ALU";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        #region Button init()
        private System.Windows.Forms.Button ADD_btn;
        private System.Windows.Forms.Button SUB_btn;
        private System.Windows.Forms.Button INV_btn;
        private System.Windows.Forms.Button AND_btn;
        private System.Windows.Forms.Button OR_btn;
        private System.Windows.Forms.Button XOR_btn;
        private System.Windows.Forms.Button shiftLeft_btn;
        private System.Windows.Forms.Button shiftRight_btn;
        private System.Windows.Forms.Button INC_btn;
        private System.Windows.Forms.Label RegisterB_LBL;
        private System.Windows.Forms.Label RegisterC_LBL;
        private System.Windows.Forms.Label RegisterA_LBL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button STORE_btn;
        private System.Windows.Forms.TextBox RegisterB_Input;
        private System.Windows.Forms.TextBox RegisterC_Input;
        private System.Windows.Forms.TextBox RegisterA_Input;
        private System.Windows.Forms.Label regB_msg;
        private System.Windows.Forms.Label regC_msg;
        private System.Windows.Forms.Label regA_msg;
        #endregion

        private System.Windows.Forms.Button HELP_btn;
        private System.Windows.Forms.Label C_bit_lbl;
        private System.Windows.Forms.Label z_bit_lbl;
        private System.Windows.Forms.Label n_bit_lbl;
        private System.Windows.Forms.Label v_bit_lbl;
        private System.Windows.Forms.TextBox c_txtbox;
        private System.Windows.Forms.TextBox v_txtbox;
        private System.Windows.Forms.TextBox n_txtbox;
        private System.Windows.Forms.TextBox z_txtbox;
        private System.Windows.Forms.Button BranchCarry_btn;
        private System.Windows.Forms.Button Branch_0_btn;
        private System.Windows.Forms.Button ccrCLR;
        private System.Windows.Forms.Button ADC_btn;
    }
}

