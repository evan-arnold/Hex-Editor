using System;
using System.IO;
using System.Windows.Forms;

namespace SHex
{
    public partial class Form_Main : Form
    {
        #region Variables & Initilization
        bool FileLoaded = false;
        string FileName;
        SHex.Forms.Form_Strings strings = new SHex.Forms.Form_Strings();
        SHex.Forms.Form_Options options = new SHex.Forms.Form_Options();
        public Form_Main()
        {
            InitializeComponent();
            Init();
            UpdateBitControl();
        }
        #endregion

        #region Methods
        void OpenStrings()
        {
            if (FileLoaded == false || HexBox_Main == null)
            {
                MessageBox.Show("Please load a file first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                //Variables.HexBoxText = HexBox_Main.ByteProvider.

                if (strings.IsDisposed)
                    strings = new SHex.Forms.Form_Strings();

                strings.ShowDialog();
            }
        }
        void Init()
        {
            DisplayText();
            ManageAbility();
        }
        void DisplayText()
        {
            if (FileName != null && FileName.Length > 0)
            {
                string textFormat = "{0}{1} - {2}";
                string readOnly = ((DynamicFileByteProvider)HexBox_Main.ByteProvider).ReadOnly ? "[read-only]" : "";
                string text = Path.GetFileName(FileName);
                this.Text = string.Format(textFormat, text, readOnly, "SHex");
            }
            else
            {
                this.Text = "SHex";
            }
        }
        void CleanUp()
        {
            if (HexBox_Main.ByteProvider != null)
            {
                IDisposable byteProvider = HexBox_Main.ByteProvider as IDisposable;
                if (byteProvider != null)
                    byteProvider.Dispose();
                HexBox_Main.ByteProvider = null;
            }
            FileName = null;
            DisplayText();
        }
        void ManageAbility()
        {
            if (HexBox_Main.ByteProvider == null)
            {
                ToolStrip_Top_File_Save.Enabled = false;
                ToolStrip_Top_Edit_Find.Enabled = false;
                ToolStrip_Top_Edit_FindNext.Enabled = false;
                ToolStrip_Top_Edit_Goto.Enabled = false;
                ToolStrip_Top_Edit_SelectAll.Enabled = false;
            }
            else
            {
                ToolStrip_Top_File_Save.Enabled = HexBox_Main.ByteProvider.HasChanges();
                ToolStrip_Top_Edit_Find.Enabled = true;
                ToolStrip_Top_Edit_FindNext.Enabled = true;
                ToolStrip_Top_Edit_Goto.Enabled = true;
                ToolStrip_Top_Edit_SelectAll.Enabled = true;
            }

            ManageAbilityForCopyAndPaste();
        }
        void UpdatePosition()
        {
            this.StatusStrip_Bottom_Label_LnCol.Text = string.Format("Line: {0} Column: {1}",
                HexBox_Main.CurrentLine, HexBox_Main.CurrentPositionInLine);

            string bitPresentation = string.Empty;

            byte? currentByte = HexBox_Main.ByteProvider != null && HexBox_Main.ByteProvider.Length > HexBox_Main.SelectionStart
                ? HexBox_Main.ByteProvider.ReadByte(HexBox_Main.SelectionStart)
                : (byte?)null;

            BitInfo bitInfo = currentByte != null ? new BitInfo((byte)currentByte, HexBox_Main.SelectionStart) : null;

            if (bitInfo != null)
            {
                byte currentByteNotNull = (byte)currentByte;
                bitPresentation = string.Format("Bits of Byte {0}: {1}"
                    , HexBox_Main.SelectionStart
                    , bitInfo.ToString()
                    );
            }

            this.BitControl_Hidden.BitInfo = bitInfo;
            try
            {
                StatusStrip_Bottom_Label_Bit.Text = "Bit: " + BitControl_Hidden.BitInfo.Position;
                StatusStrip_Bottom_Label_Value.Text = "Value: " + Convert.ToString(BitControl_Hidden.BitInfo.Value, 2).PadLeft(8, '0') + " (" + BitControl_Hidden.BitInfo.Value + ")";
            }
            catch
            {
                return;
            }
        }
        void ManageAbilityForCopyAndPaste()
        {
            ToolStrip_Top_Edit_CopyHex.Enabled = ToolStrip_Top_Edit_Copy.Enabled = HexBox_Main.CanCopy();
            ToolStrip_Top_Edit_Cut.Enabled = HexBox_Main.CanCut();
            ToolStrip_Top_Edit_Paste.Enabled = HexBox_Main.CanPaste();
            ToolStrip_Top_Edit_PasteHex.Enabled = HexBox_Main.CanPasteHex();
        }
        void OpenFile(string FilePath)
        {
            if (HexBox_Main.IsDisposed)
                HexBox_Main = new HexBox();

            if (!File.Exists(FilePath))
            {
                MessageBox.Show("File does not exist.");
                return;
            }

            try
            {
                DynamicFileByteProvider dynamicFileByteProvider;
                try
                {
                    dynamicFileByteProvider = new DynamicFileByteProvider(FilePath);
                    dynamicFileByteProvider.Changed += new EventHandler(byteProvider_Changed);
                    dynamicFileByteProvider.LengthChanged += new EventHandler(byteProvider_LengthChanged);
                }
                catch (IOException)
                {
                    try
                    {
                        dynamicFileByteProvider = new DynamicFileByteProvider(FilePath, true);
                        if (MessageBox.Show("Can only be open in read-only mode.", "Continue?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.No)
                        {
                            dynamicFileByteProvider.Dispose();
                            return;
                        }
                    }
                    catch (IOException) // read-only also failed
                    {
                        Methods.ErrorMessage("File cannot be opened.");
                        return;
                    }
                }
                HexBox_Main.ByteProvider = dynamicFileByteProvider;
                FileLoaded = true;
            }
            catch (Exception ex)
            {
                Methods.ErrorMessage(ex.Message);
                return;
            }
            finally
            {
                ManageAbility();
                UpdateFileSizeStatus();
            }
        }
        void byteProvider_Changed(object sender, EventArgs e)
        {
            ManageAbility();
        }
        void byteProvider_LengthChanged(object sender, EventArgs e)
        {
            UpdateFileSizeStatus();
        }
        void UpdateFileSizeStatus()
        {
            long Size = 0;
            var fileInfo = new FileInfo(FileName);
            if (HexBox_Main.ByteProvider == null)
                MenuStrip_Top_Size.Text = "Size: 0";
            else
                Size = fileInfo.Length;
                //MenuStrip_Top_Size.Text = "Size: " + Util.GetDisplayBytes(HexBox_Main.ByteProvider.Length);
                MenuStrip_Top_Size.Text = "Size: " + Size + " bytes";
        }
        void SaveFile()
        {
            if (HexBox_Main.ByteProvider == null)
                return;

            try
            {
                DynamicFileByteProvider dynamicFileByteProvider = HexBox_Main.ByteProvider as DynamicFileByteProvider;
                dynamicFileByteProvider.ApplyChanges();
            }
            catch (Exception ex)
            {
                Methods.ErrorMessage(ex.Message);
            }
        }
        void ShowFind()
        {

        }
        void UpdateBitControl()
        {
            bool True = true;
            if (True == true)
            {
                BitControl_Hidden.Visible = true;
            }
            else
            {
                BitControl_Hidden.Visible = false;
            }
        }
        void UpdateInfo()
        {
            HexBox_Main.BackColor = Variables.Background;
            HexBox_Main.ForeColor = Variables.Foreground;
            HexBox_Main.InfoForeColor = Variables.InfoText;

            HexBox_Main.SelectionBackColor = Variables.HighlightBack;
            HexBox_Main.SelectionForeColor = Variables.HighlightFore;
            HexBox_Main.ShadowSelectionColor = Variables.HighlightBack;

            HexBox_Main.StringViewVisible = Variables.StringsVisible;
            HexBox_Main.LineInfoVisible = Variables.InfoVisible;
            HexBox_Main.ColumnInfoVisible = Variables.InfoVisible;
        }
        #endregion

        #region ToolStrip Events
        private void Form_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (FileLoaded == false)
                Application.Exit();
            else
            {
                if (HexBox_Main != null && HexBox_Main.ByteProvider.HasChanges())
                {
                    if (MessageBox.Show("There are unsaved changes, would you like to save them now?", "Warning",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        SaveFile();
                        this.Close();
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
            }
        }
        private void ToolStrip_Top_File_Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog ocd = new OpenFileDialog();
            if (ocd.ShowDialog() == DialogResult.OK)
            {
                FileName = ocd.FileName;
                OpenFile(ocd.FileName);
                Variables.FilePath = ocd.FileName;
            }
            else
            {
                Methods.ErrorMessage("No file selected.");
                return;
            }
        }
        private void ToolStrip_Top_File_Save_Click(object sender, EventArgs e)
        {
            SaveFile();
        }
        private void ToolStrip_Top_File_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ToolStrip_Top_Options_Open_Click(object sender, EventArgs e)
        {
            if (options.IsDisposed)
                options = new SHex.Forms.Form_Options();

            options.ShowDialog();
        }
        private void ToolStrip_Top_Options_Apply_Click(object sender, EventArgs e)
        {
            UpdateInfo();
        }
        private void ToolStrip_Top_Edit_Find_Click(object sender, EventArgs e)
        {
            ShowFind();
        }
        private void ToolStrip_Top_Edit_SelectAll_Click(object sender, EventArgs e)
        {
            HexBox_Main.SelectAll();
        }
        private void ToolStrip_Top_Edit_Cut_Click(object sender, EventArgs e)
        {
            HexBox_Main.Cut();
        }
        private void ToolStrip_Top_Edit_Copy_Click(object sender, EventArgs e)
        {
            HexBox_Main.Copy();
        }
        private void ToolStrip_Top_Edit_Paste_Click(object sender, EventArgs e)
        {
            HexBox_Main.Paste();
        }
        private void ToolStrip_Top_Edit_CopyHex_Click(object sender, EventArgs e)
        {
            HexBox_Main.CopyHex();
        }
        private void ToolStrip_Top_Edit_PasteHex_Click(object sender, EventArgs e)
        {
            HexBox_Main.PasteHex();
        }
        private void ToolStrip_Top_Edit_FindStrings_Click(object sender, EventArgs e)
        {
            OpenStrings();
        }
        #endregion

        #region HexBox Events
        private void HexBox_Main_SelectionStartChanged(object sender, EventArgs e)
        {
            ManageAbilityForCopyAndPaste();
        }
        private void HexBox_Main_SelectionLengthChanged(object sender, EventArgs e)
        {
            ManageAbilityForCopyAndPaste();
        }
        private void HexBox_Main_CurrentPositionInLineChanged(object sender, EventArgs e)
        {
            UpdatePosition();
        }
        private void HexBox_Main_CurrentLineChanged(object sender, EventArgs e)
        {
            UpdatePosition();
        }
        private void HexBox_Main_CopiedHex(object sender, EventArgs e)
        {
            ManageAbilityForCopyAndPaste();
        }
        private void HexBox_Main_Copied(object sender, EventArgs e)
        {
            ManageAbilityForCopyAndPaste();
        }
        #endregion
    }
}