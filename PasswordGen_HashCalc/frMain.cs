using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Security.Cryptography;
using System.Windows.Forms;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Crypto.Engines;

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
                tbPath.Text = dialog.FileName;
            }
        }
        
        private void buCalculate_Click(object sender, EventArgs e) {
            clearTextBoxes();
            checkHash();
        }

        public void checkHash() {
            Application.DoEvents();
            computeHash(cbMD5, tbMD5, "md5");
            computeHash(cbSHA1, tbSHA1, "sha1");
            computeHash(cbSHA256, tbSHA256, "sha256");
            computeHash(cbSHA512, tbSHA512, "sha512");
            computeHash(cbGost, tbGost, "gost");
            computeHash(cbRipeMD128, tbRipeMD128, "ripemd128");
            computeHash(cbRipeMD160, tbRipeMD160, "ripemd160");
            computeHash(cbRipeMD256, tbRipeMD256, "ripemd256");
            computeHash(cbRipeMD320, tbRipeMD320, "ripemd320");
            computeHash(cbTiger, tbTiger, "tiger");
            computeHash(cbWhirlpool, tbWhirlpool, "whirlpool");

            //computeHash();
        }

        private static string getFileHashMS(string filePath, HashAlgorithm hash) {
            return BitConverter.ToString(hash.ComputeHash(new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))).Replace("-", string.Empty).ToLowerInvariant();
        }

        private static string getTextHashMS(string s, HashAlgorithm hash) {
            return BitConverter.ToString(hash.ComputeHash(Encoding.UTF8.GetBytes(s), 0, Encoding.UTF8.GetBytes(s).Length)).Replace("-", string.Empty).ToLowerInvariant();
        } 

        private static string getFileHashBC(string filePath, IDigest hash) {
           byte[] result = new byte[hash.GetDigestSize()];
            using (var fs = new FileStream(filePath, FileMode.Open, FileAccess.Read,FileShare.Delete | FileShare.ReadWrite)) {
                byte[] buffer = new byte[16000000];
                int bytesRead;
                while ((bytesRead = fs.Read(buffer, 0, buffer.Length)) > 0) {
                    hash.BlockUpdate(buffer, 0, bytesRead);
                }
                hash.DoFinal(result, 0);
            }
            return BitConverter.ToString(result).Replace("-", string.Empty).ToLowerInvariant();
        }

        private static string getTextHashBC(string s, IDigest hash) {
            byte[] msgBytes = Encoding.ASCII.GetBytes(s);
            hash.BlockUpdate(msgBytes, 0, msgBytes.Length);
            byte[] result = new byte[hash.GetDigestSize()];
            hash.DoFinal(result, 0);
            return BitConverter.ToString(result).Replace("-", string.Empty).ToLowerInvariant();
        }

        //After doing a lot of comparisons, the MS hash algorithms are MUCH faster on large files compared to
        //BouncyCastle (around 10x). MS does not seem to support the number of algorithms that BC does, so the MS functions
        //are used whenever possible. Otherwise, BC is used.
        //Hashes tested against https://www.functions-online.com/hash.html
        
        public void computeHash(CheckBox cb, TextBox tb, string alg) {
            if (cb.Checked) {
                if (tb.Text == "" && tbPath.Text != "" || tbText.Text != "") {
                    colorTextBox(tb, true);
                    switch (alg) {
                        case "md5":
                            if (tbText.Text != "") {
                                tb.Text = getTextHashMS(tbText.Text, new MD5CryptoServiceProvider());
                            }
                            else {
                                try { 
                                    tb.Text = getFileHashMS(tbPath.Text, new MD5CryptoServiceProvider());
                                }
                                catch (Exception e) {
                                    tb.Text = e.Message;
                                }
                            }
                            tb.Refresh();
                            break;
                        case "sha1":
                            if (tbText.Text != "") {
                                tb.Text = getTextHashMS(tbText.Text, new SHA1CryptoServiceProvider());
                            }
                            else {
                                try {
                                    tb.Text = getFileHashMS(tbPath.Text, new SHA1CryptoServiceProvider());
                                }
                                catch (Exception e) {
                                    tb.Text = e.Message;
                                }
                            }
                            tb.Refresh();
                            break;
                        case "sha256":
                            if (tbText.Text != "") {
                                tb.Text = getTextHashMS(tbText.Text, new SHA256CryptoServiceProvider());
                            }
                            else {
                                try {
                                    tb.Text = getFileHashMS(tbPath.Text, new SHA256CryptoServiceProvider());
                                }
                                catch (Exception e) {
                                    tb.Text = e.Message;
                                }
                            }
                            tb.Refresh();
                            break;
                        case "sha512":
                            if (tbText.Text != "") {
                                tb.Text = getTextHashMS(tbText.Text, new SHA512CryptoServiceProvider());
                            }
                            else {
                                try {
                                    tb.Text = getFileHashMS(tbPath.Text, new SHA512CryptoServiceProvider());
                                }
                                catch (Exception e) {
                                    tb.Text = e.Message;
                                }
                            }
                            tb.Refresh();
                            break;
                        case "gost":
                            if (tbText.Text != "") {
                                tb.Text = getTextHashBC(tbText.Text, new Gost3411Digest(Gost28147Engine.GetSBox("Default")));
                            }
                            else {
                                try {
                                    tb.Text = getFileHashBC(tbPath.Text, new Gost3411Digest(Gost28147Engine.GetSBox("Default")));
                                }
                                catch (Exception e) {
                                    tb.Text = e.Message;
                                }
                            }
                            tb.Refresh();
                            break;
                        case "ripemd128":
                            if (tbText.Text != "") {
                                tb.Text = getTextHashBC(tbText.Text, new RipeMD128Digest());
                            }
                            else {
                                try {
                                    tb.Text = getFileHashBC(tbPath.Text, new RipeMD128Digest());
                                }
                                catch (Exception e) {
                                    tb.Text = e.Message;
                                }
                            }
                            tb.Refresh();
                            break;
                        case "ripemd160":
                            if (tbText.Text != "") {
                                tb.Text = getTextHashBC(tbText.Text, new RipeMD160Digest());
                            }
                            else {
                                try {
                                    tb.Text = getFileHashBC(tbPath.Text, new RipeMD160Digest());
                                }
                                catch (Exception e) {
                                    tb.Text = e.Message;
                                }
                            }
                            tb.Refresh();
                            break;
                        case "ripemd256":
                            if (tbText.Text != "") {
                                tb.Text = getTextHashBC(tbText.Text, new RipeMD256Digest());
                            }
                            else {
                                try {
                                    tb.Text = getFileHashBC(tbPath.Text, new RipeMD256Digest());
                                }
                                catch (Exception e) {
                                    tb.Text = e.Message;
                                }
                            }
                            tb.Refresh();
                            break;
                        case "ripemd320":
                            if (tbText.Text != "") {
                                tb.Text = getTextHashBC(tbText.Text, new RipeMD320Digest());
                            }
                            else {
                                try {
                                    tb.Text = getFileHashBC(tbPath.Text, new RipeMD320Digest());
                                }
                                catch (Exception e) {
                                    tb.Text = e.Message;
                                }
                            }
                            tb.Refresh();
                            break;
                        case "tiger":
                            if (tbText.Text != "") {
                                tb.Text = getTextHashBC(tbText.Text, new TigerDigest());
                            }
                            else {
                                try {
                                    tb.Text = getFileHashBC(tbPath.Text, new TigerDigest());
                                }
                                catch (Exception e) {
                                    tb.Text = e.Message;
                                }
                            }
                            tb.Refresh();
                            break;
                        case "whirlpool":
                            if (tbText.Text != "") {
                                tb.Text = getTextHashBC(tbText.Text, new WhirlpoolDigest());
                            }
                            else {
                                try {
                                    tb.Text = getFileHashBC(tbPath.Text, new WhirlpoolDigest());
                                }
                                catch (Exception e) {
                                    tb.Text = e.Message;
                                }
                            }
                            tb.Refresh();
                            break;

                    } // END OF SWITCH

                    Application.DoEvents();
                }
            }
            else {
                tb.Text = "";
            }
            colorTextBox(tb);
        }

        public void clearTextBoxes() {
            tbMD5.Text = string.Empty;
            colorTextBox(tbMD5);
            tbSHA1.Text = string.Empty;
            colorTextBox(tbSHA1);
            tbSHA256.Text = string.Empty;
            colorTextBox(tbSHA256);
            tbSHA512.Text = string.Empty;
            colorTextBox(tbSHA512);
            tbGost.Text = string.Empty;
            colorTextBox(tbGost);
            tbRipeMD128.Text = string.Empty;
            colorTextBox(tbRipeMD128);
            tbRipeMD160.Text = string.Empty;
            colorTextBox(tbRipeMD160);
            tbRipeMD256.Text = string.Empty;
            colorTextBox(tbRipeMD256);
            tbRipeMD320.Text = string.Empty;
            colorTextBox(tbRipeMD320);
            tbTiger.Text = string.Empty;
            colorTextBox(tbTiger);
            tbWhirlpool.Text = string.Empty;
            colorTextBox(tbWhirlpool);
        }

        public void colorTextBox(TextBox tb, bool Calc=false) {
            if (Calc) {
                tb.BackColor = Color.LightYellow;
                tb.Text = "Calculating.....";
                tb.Refresh();
                Application.DoEvents();
                return;
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
            if (minLength <= 0 || maxLength <= 0 || minLength > maxLength) {
                return null;
            }
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
            if (minLength < maxLength) {
                password = new char[random.Next(minLength, maxLength + 1)];
            }
            else {
                password = new char[minLength];
            }
            int nextCharIdx;
            int nextGroupIdx;
            int nextLeftGroupsOrderIdx;
            int lastCharIdx;
            int lastLeftGroupsOrderIdx = leftGroupsOrder.Length - 1;
            for (int i = 0; i < password.Length; i++) {
                if (lastLeftGroupsOrderIdx == 0) {
                    nextLeftGroupsOrderIdx = 0;
                }
                else {
                    nextLeftGroupsOrderIdx = random.Next(0,lastLeftGroupsOrderIdx);
                }
                nextGroupIdx = leftGroupsOrder[nextLeftGroupsOrderIdx];
                lastCharIdx = charsLeftInGroup[nextGroupIdx] - 1;
                if (lastCharIdx == 0) {
                    nextCharIdx = 0;
                }
                else {
                    nextCharIdx = random.Next(0, lastCharIdx + 1);
                }
                password[i] = charGroups[nextGroupIdx][nextCharIdx];
                if (lastCharIdx == 0) {
                    charsLeftInGroup[nextGroupIdx] = charGroups[nextGroupIdx].Length;
                }
                else {
                    if (lastCharIdx != nextCharIdx) {
                        char temp = charGroups[nextGroupIdx][lastCharIdx];
                        charGroups[nextGroupIdx][lastCharIdx] = charGroups[nextGroupIdx][nextCharIdx];
                        charGroups[nextGroupIdx][nextCharIdx] = temp;
                    }
                    charsLeftInGroup[nextGroupIdx]--;
                }
                if (lastLeftGroupsOrderIdx == 0) {
                    lastLeftGroupsOrderIdx = leftGroupsOrder.Length - 1;
                }
                else {
                    if (lastLeftGroupsOrderIdx != nextLeftGroupsOrderIdx) {
                        int temp = leftGroupsOrder[lastLeftGroupsOrderIdx];
                        leftGroupsOrder[lastLeftGroupsOrderIdx] = leftGroupsOrder[nextLeftGroupsOrderIdx];
                        leftGroupsOrder[nextLeftGroupsOrderIdx] = temp;
                    }
                    lastLeftGroupsOrderIdx--;
                }
            }
            return new string(password);
        }

    }
}