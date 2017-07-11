using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace PasswordGen_HashCalc {
    public partial class frMain : Form {
        // Supported password characters add to or remove characters from these groups.
        private static string PASSWORD_LCASE = "abcdefgijkmnopqrstwxyz";
        private static string PASSWORD_UCASE = "ABCDEFGHJKLMNPQRSTWXYZ";
        private static string PASSWORD_NUMERIC = "23456789";
        private static string PASSWORD_SPECIAL = "*$-+?_&=!%{}/";
        private static string PASSWORD_ADDITIONAL = "IO10";
        private static string PASSWORD_HEX_LCASE = "abcdef0123456789";
        private static string PASSWORD_HEX_UCASE = "ABCDEF0123456789";

        public frMain() {
            InitializeComponent();
        }

        private void buBrowsePath_Click(object sender, EventArgs e) {
            var dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK) {
                string fileToOpen = dialog.FileName;
                tbPath.Text = dialog.FileName;
                checkHash();
            }
        }

        public void clearTextBoxes() {
            tbMD5.Text = "";
            tbSHA1.Text = "";
            tbSHA256.Text = "";
            tbSHA512.Text = "";
        }

        private void buCalculate_Click(object sender, EventArgs e) {

        }

        public void checkHash() {
            Application.DoEvents();
            computeHash(cbMD5, tbMD5, "md5");
            computeHash(cbSHA1, tbSHA1, "sha1");
            computeHash(cbSHA256, tbSHA256, "sha256");
            computeHash(cbSHA512, tbSHA512, "sha512");
        }

        private static string getFileHash(string filePath, HashAlgorithm hasher) {
            using (var fs = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                return getFileHash(fs, hasher);
        }

        private static string getFileHash(Stream s, HashAlgorithm hasher) {
            return BitConverter.ToString(hasher.ComputeHash(s)).Replace("-", "").ToLowerInvariant();
        }

        private static string getTextHash(string s, HashAlgorithm hasher) {
            return BitConverter.ToString(hasher.ComputeHash(Encoding.UTF8.GetBytes(s), 0, Encoding.UTF8.GetBytes(s).Length)).Replace("-", "").ToLowerInvariant();
        }

        public void computeHash(CheckBox cb, TextBox tb, string alg) {
            if (cb.Checked) {
                if (tb.Text == "" && tbPath.Text != "" || tbText.Text != "") {
                    HashAlgorithm algo = null;
                    if (alg == "md5")
                        algo = new MD5CryptoServiceProvider();
                    else if (alg == "sha1")
                        algo = new SHA1CryptoServiceProvider();
                    else if (alg == "sha256")
                        algo = new SHA256CryptoServiceProvider();
                    else if (alg == "sha512")
                        algo = new SHA512CryptoServiceProvider();

                    if (algo != null) {
                        if (tbText.Text != "") {
                            tb.BackColor = Color.LightYellow;
                            tb.Text = "Calculation...";
                            tb.Text = getTextHash(tbText.Text, algo);
                        }
                        else {
                            try {
                                tb.BackColor = Color.LightYellow;
                                tb.Text = "Calculation...";
                                tb.Text = getFileHash(tbPath.Text, algo);
                            }
                            catch (Exception e) {
                                tb.Text = e.Message;
                            }
                        }
                        tb.Refresh();
                    }
                    else {
                        tb.Text = "Unknown algorithm.";
                    }
                }
            }
            else {
                tb.Text = "";
            }
            if ((tbCheck.Text.Trim() == "") || (tb.Text == "")) {
                tb.BackColor = Color.LightGray;
            }
            else if (tbCheck.Text.Trim() == tb.Text) {
                tb.BackColor = Color.LightGreen;
            }
            else {
                tb.BackColor = Color.LightCoral;
            }
            tb.Refresh();
            Application.DoEvents();
        }

        private void tbText_TextChanged(object sender, EventArgs e) {
            clearTextBoxes();
        }

        private void tbPath_TextChanged(object sender, EventArgs e) {
            clearTextBoxes();
        }

        private void tbCheck_TextChanged(object sender, EventArgs e) {
            checkHash();
        }

        private void cbMD5_CheckedChanged(object sender, EventArgs e) {
            checkHash();
        }

        private void cbSHA1_CheckedChanged(object sender, EventArgs e) {
            checkHash();
        }

        private void cbSHA256_CheckedChanged(object sender, EventArgs e) {
            checkHash();
        }

        private void cbSHA512_CheckedChanged(object sender, EventArgs e) {
            checkHash();
        }

        // Password Tab functions

        private void buGeneratePasswords_Click(object sender, EventArgs e) {
            if (!cbUpper.Checked && !cbLower.Checked && !cbNumeric.Checked && !cbSpecial.Checked && !cbAdditional.Checked && !cbHexUpper.Checked && !cbHexLower.Checked) {
                MessageBox.Show("You must include one of the character sets!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (tbMaximumLength.Text == "" || tbMinimumLength.Text == "" || tbNumberofPasswords.Text == "") {
                MessageBox.Show("Please set Minimum Length, Maximum Length and Number of Passwords!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Convert.ToInt16(tbMaximumLength.Text) < Convert.ToInt16(tbMinimumLength.Text)) {
                MessageBox.Show("Maximum length is less than Minimum length!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            lbPasswordList.Items.Clear();
            for (int i = 0; i < Convert.ToInt16(tbNumberofPasswords.Text); i++)
                lbPasswordList.Items.Add(generatePasswords(Convert.ToInt16(tbMinimumLength.Text), Convert.ToInt16(tbMaximumLength.Text), cbUpper.Checked, cbLower.Checked, cbNumeric.Checked, cbSpecial.Checked,cbAdditional.Checked, cbHexUpper.Checked, cbHexLower.Checked));
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e) {
            try {
                string s = "";
                foreach (object o in lbPasswordList.SelectedItems) {
                    s += o.ToString() + "\n";
                }
                Clipboard.SetText(s);
            }
            catch (Exception) {
                MessageBox.Show("Select a password first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void copyAllToolStripMenuItem1_Click(object sender, EventArgs e) {
            try {
                string s = "";
                foreach (object o in lbPasswordList.Items) {
                    s += o.ToString() + "\n";
                }
                Clipboard.SetText(s);
            }
            catch (Exception) {

            }
        }

        private void clearListToolStripMenuItem_Click(object sender, EventArgs e) {
            lbPasswordList.Items.Clear();
        }

        public static string generatePasswords(int minLength, int maxLength, bool upper, bool lower, bool numeric, bool special, bool additional, bool hexu, bool hexl) {
            // Make sure that input parameters are valid.
            if (minLength <= 0 || maxLength <= 0 || minLength > maxLength)
                return null;

            string characters = "";
            if (upper) {
                characters = characters + PASSWORD_UCASE;
            }
            if (lower) {
                characters = characters + PASSWORD_LCASE;
            }
            if (numeric) {
                characters = characters + PASSWORD_NUMERIC;
            }
            if (special) {
                characters = characters + PASSWORD_SPECIAL;
            }
            if (additional) {
                characters = characters + PASSWORD_ADDITIONAL;
            }
            if (hexu) {
                characters = characters + PASSWORD_HEX_UCASE;
            }
            if (hexl) {
                characters = characters + PASSWORD_HEX_LCASE;
            }

            char[][] charGroups = new char[][]
            {
                characters.ToCharArray()
            };

            int[] charsLeftInGroup = new int[charGroups.Length];

            for (int i = 0; i < charsLeftInGroup.Length; i++)
                charsLeftInGroup[i] = charGroups[i].Length;

            int[] leftGroupsOrder = new int[charGroups.Length];

            for (int i = 0; i < leftGroupsOrder.Length; i++)
                leftGroupsOrder[i] = i;

            byte[] randomBytes = new byte[4];

            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            rng.GetBytes(randomBytes);

            int seed = BitConverter.ToInt32(randomBytes, 0);

            Random random = new Random(seed);

            char[] password = null;

            if (minLength < maxLength)
                password = new char[random.Next(minLength, maxLength + 1)];
            else
                password = new char[minLength];

            int nextCharIdx;

            int nextGroupIdx;

            int nextLeftGroupsOrderIdx;

            int lastCharIdx;

            int lastLeftGroupsOrderIdx = leftGroupsOrder.Length - 1;

            for (int i = 0; i < password.Length; i++) {
                if (lastLeftGroupsOrderIdx == 0)
                    nextLeftGroupsOrderIdx = 0;
                else
                    nextLeftGroupsOrderIdx = random.Next(0,
                        lastLeftGroupsOrderIdx);
                nextGroupIdx = leftGroupsOrder[nextLeftGroupsOrderIdx];

                lastCharIdx = charsLeftInGroup[nextGroupIdx] - 1;
                
                if (lastCharIdx == 0)
                    nextCharIdx = 0;
                else
                    nextCharIdx = random.Next(0, lastCharIdx + 1);
                
                password[i] = charGroups[nextGroupIdx][nextCharIdx];
                
                if (lastCharIdx == 0)
                    charsLeftInGroup[nextGroupIdx] =
                        charGroups[nextGroupIdx].Length;
                else {
                    if (lastCharIdx != nextCharIdx) {
                        char temp = charGroups[nextGroupIdx][lastCharIdx];
                        charGroups[nextGroupIdx][lastCharIdx] =
                            charGroups[nextGroupIdx][nextCharIdx];
                        charGroups[nextGroupIdx][nextCharIdx] = temp;
                    }
                    charsLeftInGroup[nextGroupIdx]--;
                }
                
                if (lastLeftGroupsOrderIdx == 0)
                    lastLeftGroupsOrderIdx = leftGroupsOrder.Length - 1;

                else {
                    if (lastLeftGroupsOrderIdx != nextLeftGroupsOrderIdx) {
                        int temp = leftGroupsOrder[lastLeftGroupsOrderIdx];
                        leftGroupsOrder[lastLeftGroupsOrderIdx] =
                            leftGroupsOrder[nextLeftGroupsOrderIdx];
                        leftGroupsOrder[nextLeftGroupsOrderIdx] = temp;
                    }
                    lastLeftGroupsOrderIdx--;
                }
            }
            return new string(password);
        }

    }
}
