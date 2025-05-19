using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.IO;

namespace CompressionFormsC_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void EncodeBtn_Click(object sender, EventArgs e)
        {
            if (LZ77RadioBtn.Checked)
            {
                Console.Clear();
                Outputdata.Clear();

                string data = Inputdata.Text;
                float dataLength = data.Length;

                InitialSize.Text = $"Initial size: {dataLength * 8} bit";

                string window = SearchWinTxtBox.Text;
                string lookahead = LookaheadWindTxtBox.Text;

                LZ77 lz77 = new LZ77(Convert.ToInt32(window), Convert.ToInt32(lookahead));

                Stopwatch sw = new Stopwatch();

                sw.Start();
                //System.Threading.Thread.Sleep(500);
                var compressedData = lz77.Compress(data);
                sw.Stop();

                EncodeTime.Text = $"Time spent on encoding: {sw.Elapsed.TotalMilliseconds} ms";

                float labelLength = lz77.CalculateCompressedSize(compressedData);

                EncodedSize.Text = $"Encoded size: {string.Format("{0:F0}", labelLength)} bit";

                foreach (var token in compressedData)
                {
                    Outputdata.Text += $"({token.Offset},{token.Length},{token.NextChar})\r\n";
                }

                Stopwatch DecodeTimer = new Stopwatch();

                DecodeTimer.Start();
                //System.Threading.Thread.Sleep(500);
                var decompressedData = lz77.Decompress(compressedData);
                DecodeTimer.Stop();

                DecodeTime.Text = $"Time spent on decoding: {DecodeTimer.Elapsed.TotalMilliseconds} ms";

                ComprRatio.Text = $"Compression ratio: {string.Format("{0:F4}", (dataLength * 8 / labelLength))}";

                if (decompressedData == data)
                {
                    label2.Text = "true";
                }
                else
                {
                    label2.Text = "false";
                }

                Console.WriteLine(decompressedData);
            }
            else if (LZ78RadioBtn.Checked)
            {
                Console.Clear();
                Outputdata.Clear();

                string data = Inputdata.Text;
                float dataLength = data.Length;

                InitialSize.Text = $"Initial size: {dataLength * 8} bit";

                LZ78 lz78 = new LZ78();

                Stopwatch sw78 = new Stopwatch();

                sw78.Start();
                var compressedData = lz78.Compress(data);
                sw78.Stop();

                EncodeTime.Text = $"Time spent on encoding: {sw78.Elapsed.TotalMilliseconds} ms";

                float labelLength = 0;

                int dictionaryBits = data.Length > 0 ? (int)Math.Ceiling(Math.Log(data.Length) / Math.Log(2)) : 1;

                foreach (var token in compressedData) {
                    labelLength = labelLength + dictionaryBits + 8;
                }

                EncodedSize.Text = $"Encoded size: {string.Format("{0:F0}", labelLength)} bit";

                foreach (var token in compressedData) {
                    Outputdata.Text += $"({token.Index},{token.NextChar})\r\n";
                }

                Stopwatch DecodeTimer78 = new Stopwatch();

                DecodeTimer78.Start();
                var decompressedData = lz78.Decompress(compressedData);
                DecodeTimer78.Stop();

                DecodeTime.Text = $"Time spent on decoding: {DecodeTimer78.Elapsed.TotalMilliseconds} ms";

                ComprRatio.Text = $"Compression ratio: {string.Format("{0:F4}", (dataLength * 8 / labelLength))}";

                if(decompressedData == data)
                {
                    label2.Text = "true";
                }
                else
                {
                    label2.Text = "false";
                }

                Console.WriteLine(decompressedData);
            }
            else if (LZWRadioBtn.Checked)
            {
                Console.Clear();
                Outputdata.Clear();

                string data = Inputdata.Text;
                float dataLength = data.Length;

                InitialSize.Text = $"Initial size: {dataLength * 8} bit";

                string window = SearchWinTxtBox.Text;
                string lookahead = LookaheadWindTxtBox.Text;

                LZW lzw = new LZW();

                Stopwatch swW = new Stopwatch();

                swW.Start();
                var compressedData = lzw.Compress(data);
                swW.Stop();

                EncodeTime.Text = $"Time spent on encoding: {swW.Elapsed.TotalMilliseconds} ms";

                int labelLength = lzw.CalculateBitSize(compressedData);

                EncodedSize.Text = $"Encoded size: {string.Format("{0:F0}", labelLength)} bit";

                Outputdata.Text += "[ ";
                foreach (var code in compressedData)
                {
                    Outputdata.Text += $"{code} ";
                }
                Outputdata.Text += " ]";

                Stopwatch DecodeTimerW = new Stopwatch();

                DecodeTimerW.Start();
                var decompressedData = lzw.Decompress(compressedData);
                DecodeTimerW.Stop();

                DecodeTime.Text = $"Time spent on decoding: {DecodeTimerW.Elapsed.TotalMilliseconds} ms";

                ComprRatio.Text = $"Compression ratio: {string.Format("{0:F4}", (dataLength * 8 / labelLength))}";

                if (decompressedData == data)
                {
                    label2.Text = "true";
                }
                else
                {
                    label2.Text = "false";
                }

                Console.WriteLine(decompressedData);
            }
        }

        private void LZ77RadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            LZ77ParamGroupBox.Enabled = true;
        }
        private void LZ78RadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            LZ77ParamGroupBox.Enabled = false;
        }
        private void LZWRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            LZ77ParamGroupBox.Enabled = false;
        }
        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog
            {
                Title = "Import",
                Filter = "Text Files|*.txt",
                DefaultExt = "txt",
                CheckFileExists = true,
                CheckPathExists = true,
                InitialDirectory = "\"D:\\University Labs\\CompressionFormsC#\"",
                
            };

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(dlg.FileName);
                Inputdata.Text = sr.ReadToEnd();
                sr.Close();
            }
        }
        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dlg = new SaveFileDialog
            {
                FileName = "New File.txt"
            };

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(dlg.FileName);
                sw.Write(Outputdata.Text);
                sw.Close();
            }
        }
    }
}
