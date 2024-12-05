using System.Windows.Forms;

namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        private MenuStrip mainMenuStrip;
        private ToolStripMenuItem rootMenuItem;
        private int subMenuCounter = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (mainMenuStrip == null)
            {
                mainMenuStrip = new MenuStrip();
                this.Controls.Add(mainMenuStrip);

                rootMenuItem = new ToolStripMenuItem("Menu 1");
                mainMenuStrip.Items.Add(rootMenuItem);

                rootMenuItem.Click += RootMenuItem_Click;
            }
        }

        private void RootMenuItem_Click(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem clickedMenuItem)
            {
                if (clickedMenuItem.DropDownItems.Count == 0)
                {
                    subMenuCounter++;
                    ToolStripMenuItem newSubMenuItem = new ToolStripMenuItem($"Submenu {subMenuCounter}");
                    clickedMenuItem.DropDownItems.Add(newSubMenuItem);
                    newSubMenuItem.Click += RootMenuItem_Click;
                }
            }
        }
    }
}
