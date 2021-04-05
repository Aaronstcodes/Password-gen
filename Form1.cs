using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Password_Generator
{ 
   
    public partial class Form1 : Form
    {
        private PasswordGenerator _PasswdGenerator = new PasswordGenerator();
        
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            _PasswdGenerator.hasUpperCaseLetters = UpperCaseLetters_chBox.Checked;
            _PasswdGenerator.hasLowerCaseLetters = LowerCaseLetters_chBox.Checked;
            _PasswdGenerator.hasDigits = Digits_chBox.Checked;
            _PasswdGenerator.hasSpace = Space_chBox.Checked;
            _PasswdGenerator.hasSpecialCharacters = SpecialCharacters_chBox.Checked;
            _PasswdGenerator.hasUnderline = Underline_chBox.Checked;

            _PasswdGenerator.passwdLength = (uint)PasswdLength_numUpDwn.Value;
        }
        private void UpperCaseLetters_chBox_CheckedChanged(object sender, EventArgs e)
            => _PasswdGenerator.hasUpperCaseLetters = UpperCaseLetters_chBox.Checked;


        private void LowerCaseLetters_chBox_CheckedChanged(object sender, EventArgs e)
            => _PasswdGenerator.hasLowerCaseLetters = LowerCaseLetters_chBox.Checked;


        private void Digits_chBox_CheckedChanged(object sender, EventArgs e)
            => _PasswdGenerator.hasDigits = Digits_chBox.Checked;


        private void Space_chBox_CheckedChanged(object sender, EventArgs e)
            => _PasswdGenerator.hasSpace = Digits_chBox.Checked;


        private void specialCharacters_chBox_CheckedChanged(object sender, EventArgs e)
            => _PasswdGenerator.hasSpecialCharacters = SpecialCharacters_chBox.Checked;

        private void Underline_chBox_CheckedChanged(object sender, EventArgs e)
            => _PasswdGenerator.hasUnderline = Underline_chBox.Checked;

        private void Generate_btn_Click(object sender, EventArgs e)
        {
            if (HasNoException()) Passwd_tb.Text = GenerateNewPassword();
        }

        ///////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////// PASSWORD GENERATOR //////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////

        private bool HasNoException()
        {
            if (HasNoCheckBoxMarked())
            {
                MessageBox.Show("You can't have no check box marked, select at least one option");
                return false;
            }
            else if (HasSpaceCheckBoxOnly())
            {
                MessageBox.Show("You can't have space check box marked only, select more option(s).");
                return false;
            }
            else if (HasUnderlineCheckboxOnly())
            {
                MessageBox.Show("You can't have underline check box marked only, select more option(s).");
                return false;
            }
            return true;
        }

        private string GenerateNewPassword()
        {
            return _PasswdGenerator.Generate();
        }

        public bool HasNoCheckBoxMarked()
        {
            return !UpperCaseLetters_chBox.Checked && !LowerCaseLetters_chBox.Checked && !SpecialCharacters_chBox.Checked
                && !Digits_chBox.Checked && !Underline_chBox.Checked && !Space_chBox.Checked;
        }

        public bool HasUnderlineCheckboxOnly()
        {
            if (!(UpperCaseLetters_chBox.Checked && LowerCaseLetters_chBox.Checked && SpecialCharacters_chBox.Checked 
                && Digits_chBox.Checked && Space_chBox.Checked))
            {
                if (Underline_chBox.Checked) return true;
            } 
            return false;
        }

        public bool HasSpaceCheckBoxOnly()
        {
            if (!(UpperCaseLetters_chBox.Checked && LowerCaseLetters_chBox.Checked && SpecialCharacters_chBox.Checked 
                && Digits_chBox.Checked && Underline_chBox.Checked))
            {
                if (Space_chBox.Checked) return true;
            }
            return false;
        }

        private void PasswdLength_numUpDwn_ValueChanged(object sender, EventArgs e)
        {
            _PasswdGenerator.passwdLength = (uint)PasswdLength_numUpDwn.Value;
        }

        private void CopyToClipboard_btn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(Passwd_tb.Text);
        }
    }
    public class PasswordGenerator
    {
        private readonly char[] lowerCaseLetters  = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        private readonly char[] upperCaseLetters  = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        private readonly char[] specialCharacters = new char[] { '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '<', '>', ',', '.', '/', '`', '~', ';', ':', '"', '\'', '|', '\\', ' ', '_'};

        public bool hasLowerCaseLetters  = true;
        public bool hasUpperCaseLetters  = true;
        public bool hasSpecialCharacters = true;
        public bool hasDigits            = true;
        public bool hasUnderline         = false;
        public bool hasSpace             = false;

        public uint passwdLength = 16;
        public List<char> excludedChars = new List<char>();

        public PasswordGenerator()
        {
            // default..
        }
        
        public string Generate()
        {
            string randomPasswd = "";
            for (uint i = 0; i < passwdLength; i++)
                while (true)
                {
                    char charToAppend = RandomCharacter();
                    if (IsCharValid(charToAppend))
                    {
                        randomPasswd += charToAppend;
                        break;
                    }
                }
            return randomPasswd;
        }    

        

        private bool IsCharValid(char ch)
        {
            if (excludedChars.Contains(ch)) return false;
            if (hasUnderline) if (ch == '_') return false;
            if (hasSpace) if (ch == ' ') return false;
            return true;

        }
        public char RandomCharacter()
        {
            while (true)
                switch (RandomNumber(4))
                {
                    case 0: 
                        if (!hasLowerCaseLetters) 
                            continue;
                        return RandomLowerCaseLetter();

                    case 1:
                        if (!hasUpperCaseLetters)
                            continue;
                        return RandomUpperCaseLetter();

                    case 2:
                        if (!hasSpecialCharacters)
                            continue;
                        return RandomSpecialCharacter();

                    case 3:
                        if (!hasDigits)
                            continue;
                        return Convert.ToChar((uint)'0' + RandomNumber(10));
                }
        }
        public char RandomLowerCaseLetter() => lowerCaseLetters.ElementAt(RandomNumber(lowerCaseLetters.Length));
        public char RandomUpperCaseLetter() => upperCaseLetters.ElementAt(RandomNumber(upperCaseLetters.Length));
        public char RandomSpecialCharacter() => specialCharacters.ElementAt(RandomNumber(specialCharacters.Length));

        public int RandomNumber(int max)
        {
            using (RNGCryptoServiceProvider rg = new RNGCryptoServiceProvider())
            {
                byte[] rno = new byte[5];
                rg.GetBytes(rno);

                return Math.Abs(BitConverter.ToInt32(rno, 0)) % max;
            }
        }
    }
}
