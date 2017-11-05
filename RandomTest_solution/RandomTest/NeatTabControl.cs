using System;
using System.Drawing;
using System.Windows.Forms;

namespace RandomTest
{
    public partial class NeatTabControl : TabControl
    {
        /// <summary>The brush of active tabTask ColorGround.</summary>
        Brush _activeTabBrush;
        /// <summary>The brush of passive tabTask ColorGround.</summary>
        Brush _passiveTabBrush;
        /// <summary>The Font for drawing active Page in TabControl.</summary>
        Font _activeTabFont;
        /// <summary>The Pen for masking bottom separate line on active Page in TabControl.</summary>
        Pen _activeTabPen;

        public NeatTabControl()
        {
            InitializeComponent();

            DrawMode = TabDrawMode.OwnerDrawFixed; // allows to use own DrawOnTab()

            SetActiveTabPen(BackColor); // here only for visualization in Visual Studio
            _activeTabFont = new Font(Font.FontFamily, Font.Size + 1, FontStyle.Regular);
            _passiveTabBrush = new SolidBrush(SystemColors.ScrollBar);
        }

        public void Initialize()
        {
            _activeTabBrush.Dispose();
            _activeTabPen.Dispose();
            SetActiveTabPen(TabPages[SelectedIndex].BackColor);
            // *** set Item width
            // fix SizeMode to change and save tabs size
            // Initially it set to Normal to comfortable view tabs in MainForm[Design]
            SizeMode = TabSizeMode.Fixed;
            Size sz = ItemSize;
            sz.Width = Width / TabCount - 2;
            ItemSize = sz;
        }

        /// <summary>Sets active tab brush pen and.</summary>
        /// <param name="color">The new brush colour.</param>
        void SetActiveTabPen(Color color)
        {
            _activeTabBrush = new SolidBrush(color);
            _activeTabPen = new Pen(_activeTabBrush, 2);
        }

        /// <summary>Declares the event handler DrawOnTab.
        /// DrawOnTab is a method that draws a string and a Rectangle on the tabView tab.</summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DrawOnTab(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Font font;
            SizeF sz;
            Rectangle rect;
            int y = 0, selectedInd = this.SelectedIndex;
            
            // draw tab foreground and text
            for (int i = 0; i < this.TabCount; i++)
            {
                rect = this.GetTabRect(i);
                if (i == selectedInd)
                {
                    rect.X++; rect.Y++; rect.Width -= 2; rect.Height--;
                    // fill white line on the bottom of the active tab
                    y = rect.Height + rect.Y + 1;
                    g.DrawLine(_activeTabPen, rect.X, y, rect.X + rect.Width, y);
                    // fill active tab
                    g.FillRectangle(_activeTabBrush, rect);
                    font = _activeTabFont;  // set active font
                }
                else
                {
                    g.FillRectangle(_passiveTabBrush, rect);
                    font = Font;            // set passive font
                }
                // draw tab text
                sz = g.MeasureString(this.TabPages[i].Text, font);
                g.DrawString(this.TabPages[i].Text, font, Brushes.Black,
                    rect.Location.X + ((rect.Width - (int)sz.Width) >> 1) - 1,
                    rect.Location.Y + ((rect.Height - (int)sz.Height) >> 1)
                    );
            }
        }
    }
}
