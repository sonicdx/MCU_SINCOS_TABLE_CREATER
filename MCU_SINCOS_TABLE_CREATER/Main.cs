using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MCU_SINCOS_TABLE_CREATER
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void lnkCopyClipBoard_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clipboard.SetDataObject(txtOut.Text);
            System.Media.SystemSounds.Beep.Play();
        }

        private void btGen_Click(object sender, EventArgs e)
        {
            int sampler_len = (int)numLen.Value;
            long sampler_logic_start = 0;
            long sampler_logic_end = 1 << sampler_len;

            double max, min;
            double sampler_circle_start = 0.0;
            double sampler_circle_final = Math.PI * 2;

            if (!double.TryParse(txtDown.Text.Trim(), out min))
            {
                MessageBox.Show("下限格式错误");
                return;
            }

            if (!double.TryParse(txtUp.Text.Trim(), out max))
            {
                MessageBox.Show("上限格式错误");
                return;
            }

            var maxstrLen = (max.ToString()).ToString().Length;
            maxstrLen = Math.Max(maxstrLen,min.ToString().Length);
            int max_level = 0;
            int min_level = 0;

            string datatype = string.Empty;
            if (Math.Min(max, min) >= 0)
            {
                datatype = "unsigned ";
                if (Math.Abs(max) < 256)
                    max_level = 1;
                else if (Math.Abs(max) < 65536)
                    max_level = 2;
                else
                    max_level = 3;

                if (Math.Abs(min) < 256)
                    min_level = 1;
                else if (Math.Abs(min) < 65536)
                    min_level = 2;
                else
                    min_level = 3; 
            }
            else
            {
                datatype = "signed ";
                if (Math.Abs(max) < (1 << 7))
                    max_level = 1;
                else if (Math.Abs(max) < (1 << 15))
                    max_level = 2;
                else
                    max_level = 3;

                if (Math.Abs(min) < (1 << 7))
                    min_level = 1;
                else if (Math.Abs(min) < (1 << 15))
                    min_level = 2;
                else
                    min_level = 3; 
            }




            max_level = Math.Max(max_level,min_level);
            if (max_level == 1)
                datatype += "char ";
            else if (max_level == 2)
                datatype += "short ";
            else
                datatype += "long ";


            long current_logic_v;
            double delta = 0.0;
            long final_point = 0;
            var outsb = new System.Text.StringBuilder();
            outsb.AppendLine(String.Format("#define MAX_WAVEINDEX {0}",sampler_logic_end - 1));
            outsb.AppendLine(String.Format(@"// 最大值:{0}  最小值:{1}",max,min));
            outsb.AppendLine(string.Format(@"code {0} SINWAVE[] = {{", datatype));
            int newLineCnt = 0;
            for (current_logic_v = sampler_logic_start; current_logic_v < sampler_logic_end; current_logic_v++)
            {
                delta = (sampler_circle_final - sampler_circle_start) * (double)current_logic_v / (double)sampler_logic_end;
                delta = (Math.Sin(delta) + 1.0)/ 2;
                final_point = (long)(delta * (max - min) + min);
                outsb.Append(final_point.ToString().PadLeft(maxstrLen + 1,' ')).Append(",");
                if (newLineCnt >= 15)
                {
                    outsb.AppendLine();
                    newLineCnt = 0;
                }
                else
                    newLineCnt++;
            }
            if (newLineCnt != 0)
                outsb.AppendLine();

            outsb.AppendLine("};");
            txtOut.Text = outsb.ToString();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
