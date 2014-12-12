using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace ResourceStrings
{
    public partial class frmMain : Form
    {
        private ListViewColumnSorter lvColumnSorter;
        private string title = "Resource Strings";
        private string droppedFile = "";
        private string findText = "";
        private int searchRow = 0;
        private int searchCol = 0;

        #region PInvoke Declarations

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int LoadString(IntPtr hInst, int id, StringBuilder buf, int buflen);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr LoadLibrary(string path);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool FreeLibrary(IntPtr hInst);

        #endregion

        public frmMain()
        {
            InitializeComponent();
            // Create an instance of a ListView column sorter and assign it 
            // to the ListView control.
            lvColumnSorter = new ListViewColumnSorter();
            this.lvMain.ListViewItemSorter = lvColumnSorter;

            // Handle dropping a file on the icon, or running with a full path parameter
            string[] args = Environment.GetCommandLineArgs();
            if (args.Length > 1)
            {
                string fName = args[1];
                string fUpper = fName.ToUpper();
                if (fUpper.EndsWith(".DLL") || fUpper.EndsWith(".EXE"))
                {
                    droppedFile = fName;
                }
            }
        }

        #region File Menu

        private void openMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "DLL files (*.dll)|*.dll|EXE files (*.exe)|*.exe";
            ofd.FilterIndex = 1;
            ofd.DefaultExt = ".dll";
            ofd.Title = "Select Resource File";
            if (DialogResult.OK == ofd.ShowDialog())
            {
                ReadResources(ofd.FileName);
            }
        }

        private void saveMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Title = "Save Text to File";
            sfd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            sfd.FilterIndex = 1;
            sfd.RestoreDirectory = true;

            // Guess at a good default name, based on resource file is possible...
            sfd.FileName = "ResourceStrings.txt";
            int ind = this.Text.IndexOf(" - ");
            if (ind > 0)
            {
                string fName = this.Text.Substring(ind + 3);
                fName = fName.Remove(fName.Length - 4);
                fName += ".txt";
                sfd.FileName = fName;
            }

            if (DialogResult.OK == sfd.ShowDialog())
            {
                try
                {
                    using (StreamWriter sw = File.CreateText(sfd.FileName))
                    {
                        string content = GetContentsAsText(false);
                        sw.Write(content);
                        sw.Close();
                    }
                }
                catch
                {
                    // TBD: error message
                }
            }
        }

        private void closeMenuItem_Click(object sender, EventArgs e)
        {
            statusNoStrings.DisplayStyle = ToolStripItemDisplayStyle.None;
            ResetDisplay();
        }

        private void quitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region Edit Menu

        private void selectAllMenuItem_Click(object sender, EventArgs e)
        {
            SelectAll(true);
        }

        private void selectNoneMenuItem_Click(object sender, EventArgs e)
        {
            SelectAll(false);
        }

        private void copyMenuItem_Click(object sender, EventArgs e)
        {
            string content = GetContentsAsText(true);
            Clipboard.Clear();
            Clipboard.SetText(content);
        }

        private void findFirstMenuItem_Click(object sender, EventArgs e)
        {
            frmFind findDlg = new frmFind();
            findDlg.findString = findText;
            if (DialogResult.OK == findDlg.ShowDialog())
            {
                findText = findDlg.findString;
                statusFind.Text = findText;
                searchRow = searchCol = 0;
                SearchForText(findText);
            }
        }

        private void findNextMenuItem_Click(object sender, EventArgs e)
        {
            SearchForText(findText);
        }

        private void findAllMenuItem_Click(object sender, EventArgs e)
        {
            searchRow = searchCol = 0;
            SearchForText(findText, true);
        }

        #endregion


        #region Drag Drop Events

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                Array a = (Array)e.Data.GetData(DataFormats.FileDrop);
                if (a != null)
                {
                    // Extract string from first array element
                    // (ignore all files except first if number of files are dropped).
                    string s = a.GetValue(0).ToString();
                    ReadResources(s);
                }

            }
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.None;
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                Array a = (Array)e.Data.GetData(DataFormats.FileDrop);
                if (a != null)
                {
                    // Extract string from first array element
                    // (ignore all files except first if number of files are dropped).
                    string s = a.GetValue(0).ToString().ToUpper();
                    if (s.EndsWith(".DLL") || s.EndsWith(".EXE"))
                    {
                        e.Effect = DragDropEffects.Copy;
                    }
                }
            }
        }

        #endregion

        #region Click Events

        private void lvMain_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == lvColumnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                if (lvColumnSorter.Order == SortOrder.Ascending)
                {
                    lvColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    lvColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                lvColumnSorter.SortColumn = e.Column;
                lvColumnSorter.Order = SortOrder.Ascending;
            }

            // Perform the sort with these new sort options.
            this.lvMain.Sort();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            SearchForText(findText);
        }

        private void lvMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            AdjustSelectionCount();
        }

        #endregion

        #region Form Events

        private void frmMain_Shown(object sender, EventArgs e)
        {
            if (droppedFile.Length > 0)
                ReadResources(droppedFile);
        }

        #endregion


        #region Functions

        private void ResetDisplay()
        {
            this.Text = title;
            lvMain.Items.Clear();
            statusCount.Text = "0";
            statusSelected.Text = "0";
            lvMain.Columns[0].Text = "";
            lvMain.Columns[1].Text = "";
            lvMain.Columns[2].Text = "";
            lvMain.Columns[0].Width = lvMain.Columns[1].Width = lvMain.Columns[2].Width = lvMain.Width / 3;
        }

        private void ReadResources(string fileName)
        {
            lvMain.BeginUpdate();
            lvMain.Items.Clear();

            if (!ReadManagedStrings(fileName))
                ReadNativeStrings(fileName);
            if (0 == lvMain.Items.Count)
            {
                statusNoStrings.DisplayStyle = ToolStripItemDisplayStyle.Text;
                ResetDisplay();
            }
            else
            {
                statusNoStrings.DisplayStyle = ToolStripItemDisplayStyle.None;
                lvMain.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                statusSelected.Text = "0";
            }
            string[] parts = fileName.Split('\\');
            this.Text = title + " - " + parts[parts.Length - 1];
            statusCount.Text = lvMain.Items.Count.ToString();

            lvMain.EndUpdate();
        }

        private bool ReadManagedStrings(string fileName)
        {
            try
            {
                Assembly asm = Assembly.LoadFile(fileName);
                lvMain.Columns[0].Text = "Name";
                lvMain.Columns[1].Text = "Value";
                lvMain.Columns[2].Text = "Resource";
                foreach (string name in asm.GetManifestResourceNames())
                {
                    ResourceManager rm = new ResourceManager(name, asm);
                    try
                    {
                        ResourceSet rs = new ResourceSet(asm.GetManifestResourceStream(name));
                        foreach (DictionaryEntry kvp in rs)
                        {
                            if (kvp.Value.GetType() == typeof(String))
                            {
                                ListViewItem lvi = new ListViewItem(kvp.Key.ToString());
                                lvi.SubItems.Add(kvp.Value.ToString());
                                lvi.SubItems.Add(name);
                                lvMain.Items.Add(lvi);
                            }
                        }
                        lvMain.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                        string[] parts = fileName.Split('\\');
                        this.Text = title + " - " + parts[parts.Length - 1];
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        return true;
                    }
                }
            }
            catch (BadImageFormatException)
            {
                return false;
            }
            return true;
        }

        private bool ReadNativeStrings(string fileName)
        {
            try
            {
                IntPtr hInst = LoadLibrary(fileName);
                if (null == hInst)
                    return false;
                else
                {
                    lvMain.Columns[0].Text = "ID";
                    lvMain.Columns[1].Text = "String";
                    lvMain.Columns[2].Text = "";
                    StringBuilder sb = new StringBuilder(1024);
                    for (int id = 1; id < 65536; ++id)
                    {
                        int len = LoadString(hInst, id, sb, sb.Capacity);
                        if (0 != len)
                        {
                            ListViewItem lvi = new ListViewItem(id.ToString());
                            lvi.SubItems.Add(sb.ToString());
                            lvi.SubItems.Add("");
                            lvMain.Items.Add(lvi);
                        }
                    }
                    FreeLibrary(hInst);
                }
            }
            catch
            {
                return false;
            }
            return true;
        }

        private void SelectAll(bool select)
        {
            foreach (ListViewItem lvi in lvMain.Items) lvi.Selected = select;
            statusSelected.Text = (select) ? lvMain.Items.Count.ToString() : "0";
        }

        private string GetContentsAsText(bool selectedOnly)
        {
            StringBuilder sb = new StringBuilder();

            // Add headers
            foreach (ColumnHeader ch in lvMain.Columns)
            {
                sb.Append(ch.Text);
                sb.Append('\t');
            }
            sb.Remove(sb.Length - 1, 1);
            sb.Append("\r\n");

            // Add all rows or just the selected ones, depending on selectedOnly
            foreach (ListViewItem lvi in lvMain.Items)
            {
                if (!selectedOnly || lvi.Selected)
                {
                    sb.Append(lvi.Text);
                    sb.Append('\t');
                    sb.Append(lvi.SubItems[1].Text);
                    sb.Append('\t');
                    sb.Append(lvi.SubItems[2].Text);
                    sb.Append("\r\n");
                }
            }
            return sb.ToString();
        }

        private void SearchForText(string text, bool findAll = false)
        {
            SelectAll(false);
            lvMain.Focus();
            text = text.ToUpper();
            if (searchCol > 0)
            {
                searchCol = 0;
                searchRow++;
                if (searchRow >= lvMain.Items.Count)
                    searchRow = 0;
            }
            while (searchRow < lvMain.Items.Count)
            {
                ListViewItem lvi = lvMain.Items[searchRow];
                // Search all columns
                while (searchCol < 3)
                {
                    string str = lvi.SubItems[searchCol++].Text.ToUpper();
                    if (str.Contains(text))
                    {
                        lvi.Selected = true;
                        lvi.EnsureVisible();
                        if (!findAll)
                        {
                            statusSelected.Text = "1";
                            return;
                        }
                    }
                }
                searchCol = 0;
                searchRow++;
            }
            searchRow = searchCol = 0;
            AdjustSelectionCount();
        }

        private void AdjustSelectionCount()
        {
            int selected = 0;
            foreach (ListViewItem lvi in lvMain.Items)
                if (lvi.Selected) selected++;
            statusSelected.Text = selected.ToString();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox ab = new AboutBox();
            ab.ShowDialog();
        }

        #endregion

    }
}
