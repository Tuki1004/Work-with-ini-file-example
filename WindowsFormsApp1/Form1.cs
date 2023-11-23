using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        IniFile INI = new IniFile(@"D:\example\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\config.ini");
        public Form1()
        {
            InitializeComponent();
            auto_read();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // сохраняет значения и обновляет их в config
        private void bSave_Click(object sender, EventArgs e)
        {
            INI.WriteValue("SettingForm", "Width", numWidth.Value.ToString());
            INI.WriteValue("SettingForm", "Height", numHeight.Value.ToString());
            INI.WriteValue("Other", "Text", tbOther.Text);
            MessageBox.Show("Настройки SettingForm и Other сохранены", "Информация",
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        // сохраняет значения и обновляет их в config
        private void bWork_Click(object sender, EventArgs e)
        {
            INI.WriteValue("SettingForm", "Width", numWidth.Value.ToString());
            INI.WriteValue("SettingForm", "Height", numHeight.Value.ToString());
            this.Width = int.Parse(numWidth.Value.ToString());
            this.Height = int.Parse(numHeight.Value.ToString());
            MessageBox.Show("Настройки SettingForm сохранены и применены", "Информация",
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
         
        }

        private void auto_read()
        {
            if(INI.KeyExists("Width", "SettingForm"))
            {
                numHeight.Value = int.Parse(INI.ReadValue("SettingForm", "Height"));
            }
            else
            {
                numWidth.Value = this.MinimumSize.Height;
            }
            if(INI.KeyExists("Height", "SettingForm"))
            {
                numWidth.Value = int.Parse(INI.ReadValue("SettingForm", "Width"));
            }
            else
            {
                numHeight.Value = 380;
            }
            if (INI.KeyExists("Width", "SettingForm"))
            {
                tbOther.Text = INI.ReadValue("Other", "Text");
            }

            this.Height = int.Parse(numHeight.Value.ToString());
            this.Width = int.Parse(numWidth.Value.ToString());
        }

        private void bLoad_Click(object sender, EventArgs e)
        {
            auto_read();
        }
    }
}
