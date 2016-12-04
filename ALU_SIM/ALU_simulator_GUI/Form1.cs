using System;
using System.Windows.Forms;

namespace ALU_simulator_GUI
{
    public partial class Form1 : Form
    {
        private byte _regBInput, _regAInput, _regCInput, _cBit; // the 8bit integer value that the user inputs
        private int _cTmp;
        public Form1()
        {
            InitializeComponent();
        }

        private void RegAcInputConvert2Byte() // converts regA and C textbox to byte
        {
            _regAInput = Convert.ToByte(RegisterA_Input.Text);
            _regCInput = Convert.ToByte(RegisterC_Input.Text);
        }

        private void RegAc_lbl_txt_convertBin()
        {
            RegisterA_LBL.Text = Convert.ToString(Convert.ToByte(RegisterA_Input.Text), 2).PadLeft(8, '0');
            RegisterC_LBL.Text = Convert.ToString(Convert.ToByte(RegisterC_Input.Text), 2).PadLeft(8, '0');
        }

        private void REGabc_inputTxt_bin_lbl_Convert() // input to binary converter
        {
            RegisterA_LBL.Text = Convert.ToString(_regAInput, 2).PadLeft(8, '0'); // converts user input to binary and 
            RegisterB_LBL.Text = Convert.ToString(_regBInput, 2).PadLeft(8, '0');
            // pads the binary representation with 0s
            RegisterC_LBL.Text = Convert.ToString(_regCInput, 2).PadLeft(8, '0'); //
            RegisterA_Input.Text = Convert.ToString(_regAInput);
            RegisterB_Input.Text = Convert.ToString(_regBInput);
            RegisterC_Input.Text = Convert.ToString(_regCInput);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RegisterA_Input.Text = Convert.ToString(0); // 
            RegisterB_Input.Text = Convert.ToString(0); // init input values
            RegisterC_Input.Text = Convert.ToString(0); // 
            ZeroCcr();
        }
        /***************************** ARITHMETIC OPERATIONS and STORE start ********************************/
        private void ADD_BUTTON_EVENT(object sender, EventArgs e) // RegB <- RegA + RegC
        {
            ZeroCcr();
            RegAc_lbl_txt_convertBin();
            RegAcInputConvert2Byte();
            _regBInput = (byte)(_regAInput + _regCInput);
            RegisterB_LBL.Text = Convert.ToString(_regBInput, 2).PadLeft(8, '0');
            RegisterB_Input.Text = Convert.ToString(_regBInput);
            if (_regAInput + _regCInput > 127)
            {
                v_txtbox.Text = "1"; // sets the ccr bit v and c
                if (_regAInput + _regCInput > 255)
                {
                    c_txtbox.Text = "1";
                }
            }
            ZnBitTest();
        }

        private void ADD_CARRY_BTN(object sender, EventArgs e) // RegB <- RegA + RegC + Cin
        {
            _cTmp = Convert.ToInt32(c_txtbox.Text);
            _cBit = Convert.ToByte(_cTmp);
            RegAc_lbl_txt_convertBin();
            RegAcInputConvert2Byte();
            _regBInput = (byte)(_regAInput + _regCInput + _cBit);
            RegisterB_LBL.Text = Convert.ToString(_regBInput, 2).PadLeft(8, '0');
            RegisterB_Input.Text = Convert.ToString(_regBInput);
            if (_regAInput + _regCInput + _cBit > 127)
            {
                v_txtbox.Text = "1"; // sets the ccr bit v and c
                if (_regAInput + _regCInput > 255)
                {
                    c_txtbox.Text = "1";
                }
            }
            ZnBitTest();
        }

        private void SUB_BUTTON_EVENT(object sender, EventArgs e) // RegB <- RegA - RegC
        {
            ZeroCcr();
            RegAc_lbl_txt_convertBin();
            RegAcInputConvert2Byte();
            _regBInput = (byte)(_regAInput - _regCInput);
            RegisterB_LBL.Text = Convert.ToString(_regBInput, 2).PadLeft(8, '0');
            RegisterB_Input.Text = Convert.ToString(_regBInput);
            ZnBitTest();
        }

        private void INCREMENT_BUTTON_EVENT(object sender, EventArgs e) // RegB <- RegB + 1
        {
            ZeroCcr();
            _regBInput = Convert.ToByte(RegisterB_Input.Text);
            _regBInput++; // inc reg b
            RegisterB_Input.Text = Convert.ToString(_regBInput); // writes the value back into the input
            RegisterB_LBL.Text = Convert.ToString(_regBInput, 2).PadLeft(8, '0');
            ZnBitTest();
        }

        private void STORE_BUTTON_EVENT(object sender, EventArgs e) // RegC <- RegB
        {
            _regBInput = Convert.ToByte(RegisterB_Input.Text);
            RegisterB_LBL.Text = Convert.ToString(_regBInput, 2).PadLeft(8, '0');
            RegisterC_LBL.Text = RegisterB_LBL.Text;
            RegisterC_Input.Text = Convert.ToString(_regBInput); // writes the value back into the input
        }
        /***************************** ARITHMETIC OPERATIONS and STORE end ********************************/

        /********************** LOGICAL SHIFTS start ******************************************************/
        private void SHR_BUTTON_EVENT(object sender, EventArgs e) // Shift right RegB
        {
            _regBInput = Convert.ToByte(RegisterB_Input.Text);
            _regBInput = (byte)(_regBInput / 2);
            // dividing by 2 same as shift right, rounds the number up do to rounding
            RegisterB_Input.Text = Convert.ToString(_regBInput); // writes the value back into the input
            RegisterB_LBL.Text = Convert.ToString(_regBInput, 2).PadLeft(8, '0');
            ZnBitTest();
        }

        private void SHL_BUTTON_EVENT(object sender, EventArgs e) // Shift left RegB
        {
            _regBInput = Convert.ToByte(RegisterB_Input.Text);
            _regBInput = (byte)(_regBInput * 2); // multiply by 2 is the same as shift left
            RegisterB_Input.Text = Convert.ToString(_regBInput);
            RegisterB_LBL.Text = Convert.ToString(_regBInput, 2).PadLeft(8, '0');
            ZnBitTest();
        }
        /********************** LOGICAL SHIFTS end ******************************************************/

        /********************** LOGIC OPERATIONS start ******************************************************/
        private void XOR_BUTTON_EVENT(object sender, EventArgs e) // RegB <- RegA xor RegC
        {
            ZeroCcr();
            RegAcInputConvert2Byte();
            _regBInput = (byte)(_regAInput ^ _regCInput); // xor operation
            REGabc_inputTxt_bin_lbl_Convert();
            ZnBitTest();
        }

        private void OR_BUTTON_EVENT(object sender, EventArgs e) // RegB <- RegA or RegC
        {
            ZeroCcr();
            RegAcInputConvert2Byte();
            _regBInput = (byte)(_regAInput | _regCInput); // or operation
            REGabc_inputTxt_bin_lbl_Convert();
            ZnBitTest();
        }

        private void AND_BUTTON_EVENT(object sender, EventArgs e) // RegB <- RegA and RegC
        {
            ZeroCcr();
            RegAcInputConvert2Byte();
            _regBInput = (byte)(_regAInput & _regCInput); // and operation
            REGabc_inputTxt_bin_lbl_Convert();
            ZnBitTest();
        }

        private void INVERT_BUTTON_EVENT(object sender, EventArgs e) // Compliment RegB
        {
            ZeroCcr();
            _regBInput = Convert.ToByte(RegisterB_Input.Text);
            _regBInput = (byte)~_regBInput; // negation operation
            RegisterB_LBL.Text = Convert.ToString(_regBInput, 2).PadLeft(8, '0');
            RegisterB_Input.Text = Convert.ToString(_regBInput);
            ZnBitTest();
        }
        /********************** LOGIC OPERATIONS end ******************************************************/
        private void HELP_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                @"Enter an integer value in Register A
Enter an integer value in Register C
then choose an opcode
Adding, B <- A + C
Subtracting, B <- A - C
Shifts, Compliment work on B only
Store, C <- B
AND,OR,XOR, B = A logicOp C");
        }

        private void BranchCarry_btn_Click(object sender, EventArgs e)
        {
            if (c_txtbox.Text == "1")
                MessageBox.Show(@"successful branch");
        }

        private void ZnBitTest() // sets z and n bits if condition is met
        {
            if (_regBInput != 0)
            {
                z_txtbox.Text = "0";
                n_txtbox.Text = _regBInput > 127 ? "1" : "0";
            }
            else
            {
                z_txtbox.Text = "1";
            }
        }

        private void ccrCLR_Click(object sender, EventArgs e)
        {
            ZeroCcr();
        }

        private void Branch_0_btn_Click(object sender, EventArgs e)
        {
            if (z_txtbox.Text == "1")
                MessageBox.Show(@"successful branch");
        }

        private void ZeroCcr() // clears ccr
        {
            c_txtbox.Text = z_txtbox.Text = n_txtbox.Text = v_txtbox.Text = "0";
        }
    }
}
