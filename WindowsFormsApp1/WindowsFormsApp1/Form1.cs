using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace WindowsFormsApp1
{
    

    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox3.Checked)
            {
                textBox1.Enabled = true;
                button1.Enabled = true;
            }
            else
            {
                textBox1.Enabled = false;
                button1.Enabled = false;
                textBox1.Text = "C:\\Program Files\\ChipStorage";
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "C:\\Program Files\\ChipStorage";
        }

        void createShortcutDesktop()
        {
            IShellLink link = (IShellLink)new ShellLink();

            // setup shortcut information
            link.SetDescription("This is the description when hovered over.");
            link.SetPath(textBox1.Text+"\\ChipStorage.exe");

            // save it
            IPersistFile file = (IPersistFile)link;
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            file.Save(Path.Combine(desktopPath, "ChipStorage.lnk"), false);
        }

        void createShortcutStart()
        {
            IShellLink link = (IShellLink)new ShellLink();

            // setup shortcut information
            link.SetDescription("This is the description when hovered over.");
            link.SetPath(textBox1.Text + "\\ChipStorage.exe");

            // save it
            IPersistFile file = (IPersistFile)link;
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.StartMenu);
            file.Save(Path.Combine(desktopPath, "ChipStorage.lnk"), false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String from = Path.GetFullPath("./src");
            String destination = textBox1.Text;

            Directory.CreateDirectory("C:\\Program Files\\ChipStorage");

            File.Copy(from+"\\ChipStorage.exe", destination+"\\ChipStorage.exe", true);
            File.Copy(from + "\\ChipStorage.exe.config", destination + "\\ChipStorage.exe.config", true);
            File.Copy(from + "\\ChipStorage.pdb", destination + "\\ChipStorage.pdb", true);
            File.Copy(from + "\\cip.bacpac", destination + "\\cip.bacpac", true);
            File.Copy(from + "\\Double-J-Design-Diagram-Free-Chip.ico", destination + "\\Double-J-Design-Diagram-Free-Chip.ico", true);
            Directory.CreateDirectory("C:\\Program Files\\ChipStorage" + "\\slike");
            var AllFiles = Directory.GetFiles(from+"\\slike");
            
            foreach (var file in AllFiles)
            {
                File.Copy(file, file.Replace(from, "C:\\Program Files\\ChipStorage"), true);  
            }

            if (checkBox1.Checked)
            {
                createShortcutDesktop();
            }

            if(checkBox2.Checked)
            {
                createShortcutStart();
            }

            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1 = new FolderBrowserDialog();
            saveFileDialog1.SelectedPath = textBox1.Text;
            saveFileDialog1.ShowDialog();
            textBox1.Text = saveFileDialog1.SelectedPath;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            String destination = textBox1.Text;

            Directory.CreateDirectory("C:\\Program Files\\ChipStorage");

            File.Delete( destination + "\\ChipStorage.exe");
            File.Delete(destination + "\\ChipStorage.exe.config");
            File.Delete(destination + "\\ChipStorage.pdb");
            File.Delete(destination + "\\cip.bacpac");
            File.Delete(destination + "\\Double-J-Design-Diagram-Free-Chip.ico");
            Directory.CreateDirectory("C:\\Program Files\\ChipStorage" + "\\slike");
            var AllFiles = Directory.GetFiles("C:\\Program Files\\ChipStorage\\slike");

            foreach (var file in AllFiles)
            {
                File.Delete(file);
            }
            Directory.Delete("C:\\Program Files\\ChipStorage" + "\\slike");
            if (checkBox1.Checked)
            {
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);

                File.Delete(Path.Combine(desktopPath, "ChipStorage.lnk"));
            }

            if (checkBox2.Checked)
            {
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.StartMenu);

                File.Delete(Path.Combine(desktopPath, "ChipStorage.lnk"));
            }

            Close();
        }
    }
    [ComImport]
    [Guid("00021401-0000-0000-C000-000000000046")]
    internal class ShellLink
    {
    }
    [ComImport]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    [Guid("000214F9-0000-0000-C000-000000000046")]
    internal interface IShellLink
    {
        void GetPath([Out, MarshalAs(UnmanagedType.LPWStr)] StringBuilder pszFile, int cchMaxPath, out IntPtr pfd, int fFlags);
        void GetIDList(out IntPtr ppidl);
        void SetIDList(IntPtr pidl);
        void GetDescription([Out, MarshalAs(UnmanagedType.LPWStr)] StringBuilder pszName, int cchMaxName);
        void SetDescription([MarshalAs(UnmanagedType.LPWStr)] string pszName);
        void GetWorkingDirectory([Out, MarshalAs(UnmanagedType.LPWStr)] StringBuilder pszDir, int cchMaxPath);
        void SetWorkingDirectory([MarshalAs(UnmanagedType.LPWStr)] string pszDir);
        void GetArguments([Out, MarshalAs(UnmanagedType.LPWStr)] StringBuilder pszArgs, int cchMaxPath);
        void SetArguments([MarshalAs(UnmanagedType.LPWStr)] string pszArgs);
        void GetHotkey(out short pwHotkey);
        void SetHotkey(short wHotkey);
        void GetShowCmd(out int piShowCmd);
        void SetShowCmd(int iShowCmd);
        void GetIconLocation([Out, MarshalAs(UnmanagedType.LPWStr)] StringBuilder pszIconPath, int cchIconPath, out int piIcon);
        void SetIconLocation([MarshalAs(UnmanagedType.LPWStr)] string pszIconPath, int iIcon);
        void SetRelativePath([MarshalAs(UnmanagedType.LPWStr)] string pszPathRel, int dwReserved);
        void Resolve(IntPtr hwnd, int fFlags);
        void SetPath([MarshalAs(UnmanagedType.LPWStr)] string pszFile);
    }
}
