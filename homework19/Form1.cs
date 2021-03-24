using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace homeword19
{
    public partial class Form1 : Form
    {
        char Sign = ' ';
        BindingList<double> Memories = new BindingList<double>();
        public Form1()
        {
            InitializeComponent();
        }

        private void PointBtn_Click(object sender, EventArgs e)
        {
            if (LowerValueLbl.Text.Contains("."))
                return;

            LowerValueLbl.Text += ".";
        }

        private void NegateBtn_Click(object sender, EventArgs e)
        {
            if (LowerValueLbl.Text.Equals("0"))
                return;

            if (LowerValueLbl.Text.Contains("-"))
                LowerValueLbl.Text = LowerValueLbl.Text.Replace("-", "");
            else
                LowerValueLbl.Text = "-" + LowerValueLbl.Text;
        }

        private void ZeroBtn_Click(object sender, EventArgs e)
        {
            if (LowerValueLbl.Text.Equals("0"))
                return;

            if (LowerValueLbl.Text.Length >= 15)
                return;

            LowerValueLbl.Text += "0";
        }

        private void OneBtn_Click(object sender, EventArgs e)
        {
            if (LowerValueLbl.Text.Length >= 15)
                return;

            if (LowerValueLbl.Text.Equals("0"))
            {
                LowerValueLbl.Text = "1";
                return;
            }

            LowerValueLbl.Text += "1";
        }

        private void TwoBtn_Click(object sender, EventArgs e)
        {
            if (LowerValueLbl.Text.Length >= 15)
                return;

            if (LowerValueLbl.Text.Equals("0"))
            {
                LowerValueLbl.Text = "2";
                return;
            }

            LowerValueLbl.Text += "2";
        }

        private void ThreeBtn_Click(object sender, EventArgs e)
        {
            if (LowerValueLbl.Text.Length >= 15)
                return;

            if (LowerValueLbl.Text.Equals("0"))
            {
                LowerValueLbl.Text = "3";
                return;
            }

            LowerValueLbl.Text += "3";
        }

        private void FourBtn_Click(object sender, EventArgs e)
        {
            if (LowerValueLbl.Text.Length >= 15)
                return;

            if (LowerValueLbl.Text.Equals("0"))
            {
                LowerValueLbl.Text = "4";
                return;
            }

            LowerValueLbl.Text += "4";
        }

        private void FiveBtn_Click(object sender, EventArgs e)
        {
            if (LowerValueLbl.Text.Length >= 15)
                return;

            if (LowerValueLbl.Text.Equals("0"))
            {
                LowerValueLbl.Text = "5";
                return;
            }

            LowerValueLbl.Text += "5";
        }

        private void SixBtn_Click(object sender, EventArgs e)
        {
            if (LowerValueLbl.Text.Length >= 15)
                return;

            if (LowerValueLbl.Text.Equals("0"))
            {
                LowerValueLbl.Text = "6";
                return;
            }

            LowerValueLbl.Text += "6";
        }

        private void SevenBtn_Click(object sender, EventArgs e)
        {
            if (LowerValueLbl.Text.Length >= 15)
                return;

            if (LowerValueLbl.Text.Equals("0"))
            {
                LowerValueLbl.Text = "7";
                return;
            }

            LowerValueLbl.Text += "7";
        }

        private void EightBtn_Click(object sender, EventArgs e)
        {
            if (LowerValueLbl.Text.Length >= 15)
                return;

            if (LowerValueLbl.Text.Equals("0"))
            {
                LowerValueLbl.Text = "8";
                return;
            }

            LowerValueLbl.Text += "8";
        }

        private void NineBtn_Click(object sender, EventArgs e)
        {
            if (LowerValueLbl.Text.Length >= 15)
                return;

            if (LowerValueLbl.Text.Equals("0"))
            {
                LowerValueLbl.Text = "9";
                return;
            }

            LowerValueLbl.Text += "9";
        }

        private void CEBtn_Click(object sender, EventArgs e)
        {
            LowerValueLbl.Text = "0";
        }

        private void CBtn_Click(object sender, EventArgs e)
        {
            LowerValueLbl.Text = "0";
            UpperValueLbl.Text = "";
            SignLbl.Text = "";
            Sign = ' ';
        }

        private void BackSpaceBtn_Click(object sender, EventArgs e)
        {
            if (LowerValueLbl.Text.Equals("0"))
                return;

            LowerValueLbl.Text = LowerValueLbl.Text.Substring(0, LowerValueLbl.Text.Length - 1);

            if (LowerValueLbl.Text.Length == 0)
                LowerValueLbl.Text = "0";
        }

        private void PercentBtn_Click(object sender, EventArgs e)
        {
            if (UpperValueLbl.Text.Equals("") || SignLbl.Text.Equals(""))
                return;

            LowerValueLbl.Text = (Convert.ToDouble(LowerValueLbl.Text) / 100).ToString();
        }

        private void OneOverXBtn_Click(object sender, EventArgs e)
        {
            var result = (1 / Convert.ToDouble(LowerValueLbl.Text)).ToString();

            LowerValueLbl.Text = result;
        }

        private void PowerOfTwoBtn_Click(object sender, EventArgs e)
        {
            var result = (Convert.ToDouble(LowerValueLbl.Text) * Convert.ToDouble(LowerValueLbl.Text)).ToString();

            LowerValueLbl.Text = result;
        }

        private void RootOfXBtn_Click(object sender, EventArgs e)
        {
            var result = (Math.Sqrt(Convert.ToDouble(LowerValueLbl.Text))).ToString();

            LowerValueLbl.Text = result;
        }

        private void DivisionBtn_Click(object sender, EventArgs e)
        {
            UpperValueLbl.Text = Sign == ' '
                ? LowerValueLbl.Text
                : (Convert.ToDouble(UpperValueLbl.Text) / Convert.ToDouble(LowerValueLbl.Text)).ToString();
            Sign = '/';
            SignLbl.Text = "÷";
            LowerValueLbl.Text = "0";
        }

        private void MultiplicationBtn_Click(object sender, EventArgs e)
        {
            UpperValueLbl.Text = Sign == ' '
                ? LowerValueLbl.Text
                : (Convert.ToDouble(UpperValueLbl.Text) * Convert.ToDouble(LowerValueLbl.Text)).ToString();
            Sign = '*';
            SignLbl.Text = "×";
            LowerValueLbl.Text = "0";
        }

        private void MinusBtn_Click(object sender, EventArgs e)
        {
            UpperValueLbl.Text = Sign == ' '
                ? LowerValueLbl.Text
                : (Convert.ToDouble(UpperValueLbl.Text) - Convert.ToDouble(LowerValueLbl.Text)).ToString();
            Sign = '-';
            SignLbl.Text = "–";
            LowerValueLbl.Text = "0";
        }

        private void PlusBtn_Click(object sender, EventArgs e)
        {
            UpperValueLbl.Text = Sign == ' '
                ? LowerValueLbl.Text
                : (Convert.ToDouble(UpperValueLbl.Text) + Convert.ToDouble(LowerValueLbl.Text)).ToString();
            Sign = '+';
            SignLbl.Text = "+";
            LowerValueLbl.Text = "0";
        }

        private void EqualBtn_Click(object sender, EventArgs e)
        {
            if (Sign == ' ')
                return;

            var num1 = Convert.ToDouble(UpperValueLbl.Text);
            var num2 = Convert.ToDouble(LowerValueLbl.Text);

            var result = Sign switch
            {
                '*' => num1 * num2,
                '/' => num1 / num2,
                '-' => num1 - num2,
                '+' => num1 + num2,
                _ => 0
            };

            LowerValueLbl.Text = result.ToString();
            UpperValueLbl.Text = "";
            SignLbl.Text = "";
            Sign = ' ';
        }

        private void Btn_EnabledChanged(object sender, EventArgs e)
        {
            var button = sender as Button;

            if (button.Enabled)
            {
                button.ForeColor = Color.Black;
                return;
            }

            button.ForeColor = Color.Gray;
        }

        private void MCBtn_Click(object sender, EventArgs e) => Memories.Clear();

        private void MRBtn_Click(object sender, EventArgs e) => LowerValueLbl.Text = Memories[Memories.Count - 1].ToString();

        private void MBtn_Click(object sender, EventArgs e)
        {
            MemoriesListBox.Items.Clear();
            for (int i = Memories.Count - 1; i >= 0; i--) { MemoriesListBox.Items.Add(Memories[i]); }
            MemoriesHolderPanel.Visible = true;
        }

        private void MPlusBtn_Click(object sender, EventArgs e)
        {
            if (Memories.Count == 0)
            {
                Memories.Add(Convert.ToDouble(LowerValueLbl.Text));
                LowerValueLbl.Text = "0";
                return;
            }

            var lastItemIndex = Memories.Count - 1;
            var last = Convert.ToDouble(Memories[lastItemIndex]);
            Memories.RemoveAt(lastItemIndex);
            Memories.Add(last + Convert.ToDouble(LowerValueLbl.Text));
            LowerValueLbl.Text = "0";
        }

        private void MMinusBtn_Click(object sender, EventArgs e)
        {
            if (Memories.Count == 0)
            {
                Memories.Add(Convert.ToDouble(LowerValueLbl.Text));
                LowerValueLbl.Text = "0";
                return;
            }

            var lastItemIndex = Memories.Count - 1;
            var last = Convert.ToDouble(Memories[lastItemIndex]);
            Memories.RemoveAt(lastItemIndex);
            Memories.Add(last - Convert.ToDouble(LowerValueLbl.Text));
            LowerValueLbl.Text = "0";
        }

        private void MSBtn_Click(object sender, EventArgs e)
        {
            Memories.Add(Convert.ToDouble(LowerValueLbl.Text));
            LowerValueLbl.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Memories.ListChanged += new ListChangedEventHandler(Memories_ListChanged);

            void Memories_ListChanged(object sender, ListChangedEventArgs e)
            {
                switch (e.ListChangedType)
                {
                    case ListChangedType.ItemAdded:
                        {
                            MBtn.Enabled = true;
                            MRBtn.Enabled = true;
                            MCBtn.Enabled = true;
                            break;
                        }
                    case ListChangedType.ItemDeleted:
                        {
                            if (Memories.Count == 0)
                                return;

                            MBtn.Enabled = false;
                            MRBtn.Enabled = false;
                            MCBtn.Enabled = false;
                            break;
                        }
                    case ListChangedType.Reset:
                        {
                            MBtn.Enabled = false;
                            MRBtn.Enabled = false;
                            MCBtn.Enabled = false;
                            break;
                        }
                }
            }
        }

        private void MCloseBtn_Click(object sender, EventArgs e) => MemoriesHolderPanel.Visible = false;

        private void MemoriesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LowerValueLbl.Text = MemoriesListBox.SelectedItem.ToString();
            MemoriesHolderPanel.Visible = false;
        }
    }
}
