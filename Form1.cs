using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;

namespace Steganografia
{
    public partial class Form1 : Form
    {
        private String imagePath;
        private String messagePath;
        private const String KEY = "KLUCZ ";
        private const int zeroEndingBytes = 8;

        private int messageWidth = 0;
        private int messageSpace = 0;
        private int[] decipheredRGBnoiseLevels = { 1, 1, 1};
        private Bitmap image;

        private int showUsedSpaceMode = 0;

        private int lastDecipheredFileSizeBit = 0;
        private int lastDecipheredImageSpaceBit = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Bitmapy(*.bmp)|*.bmp";
            openFileDialog1.ShowDialog();
            imagePath = openFileDialog1.FileName;

            Bitmap bitmap = new Bitmap(imagePath);
            image = new Bitmap(bitmap);
            image = (Bitmap)image.Clone();
            bitmap.Dispose();

            IniitalImge.Image = image;

            showUsedSpace();

            panel1.Visible = true;
            flowLayoutPanel2.Visible = true;

            resultImage.Image = null;
        }

        private void showUsedSpace()
        {
            if (messagePath != null) messageWidth = messageAndKeyToBits(messagePath).Length;
            else messageWidth = 0;

            messageSpace = image.Width * image.Height * (NoiseLevelSliderR.Value + NoiseLevelSliderG.Value + NoiseLevelSliderB.Value);

            int[] byteMult = { 8, 8 * 1024, 8 * 1024 * 1024, messageSpace / 100};
            String[] byteMultDesc = { "B", "KB", "MB", "%"};

            if (messageWidth > messageSpace)
                dostepneBajty.ForeColor = Color.Red;
            else
                dostepneBajty.ForeColor = Color.Black;

            if (byteMult[showUsedSpaceMode] != 0)
            {
                dostepneBajty.Text = (messageWidth / byteMult[showUsedSpaceMode]).ToString() + " / "
                    + (messageSpace / byteMult[showUsedSpaceMode]).ToString() + " " + byteMultDesc[showUsedSpaceMode];

                labelDecipheredFile.Text = (lastDecipheredFileSizeBit / byteMult[showUsedSpaceMode]).ToString() + " / "
                    + (lastDecipheredImageSpaceBit / byteMult[showUsedSpaceMode]).ToString() + " " + byteMultDesc[showUsedSpaceMode];
            }
            else
            {
                dostepneBajty.Text = "NAN " + byteMultDesc[showUsedSpaceMode];
                labelDecipheredFile.Text = "NAN " + byteMultDesc[showUsedSpaceMode];
            }
            
        }

        private void IniitalImge_Click(object sender, EventArgs e)
        {

        }

        private BitArray messageAndKeyToBits(String path)
        {
            byte[] key = Encoding.UTF8.GetBytes(KEY + Path.GetExtension(messagePath) + "\0");
            byte[] message = File.ReadAllBytes(path);
            byte[] bytes = new byte[key.Length + message.Length + zeroEndingBytes];

            key.CopyTo(bytes, 0);
            message.CopyTo(bytes, key.Length);
            for (int i = 1; i < zeroEndingBytes; i++) bytes[bytes.Length - i] = 0;

            return new BitArray(bytes);
        }


        private Bitmap cipher()
        {
            int height = image.Height;
            int width = image.Width;

            BitArray messageBits = messageAndKeyToBits(messagePath);

            int[] noiseLevelRGB = { NoiseLevelSliderR.Value, NoiseLevelSliderG.Value, NoiseLevelSliderB.Value };

            if (messageBits.Length + 12 > noiseLevelRGB.Sum() * height * width)
            {
                if (MessageBox.Show("Czy zaszyfrować mimo to? Wiadomość zostanie ucięta do wymaganego poziomu.", 
                        "Cała wiadomość nie zostanie zaszyfrowana.", 
                        MessageBoxButtons.OKCancel, 
                        MessageBoxIcon.Warning, 
                        MessageBoxDefaultButton.Button1)
                        == System.Windows.Forms.DialogResult.Cancel)
                    return null;
            }

            int index = 0;
            for (int j = 0; j < height; j++)
            {
                for (int i = 0; i < width; i++)
                {
                    Color color = image.GetPixel(i, j);
                    int[] rgb = { color.R, color.G, color.B };

                    for (int k = 0; k < 3; k++)
                    {
                        if (i == 0 && j == 0) //Cipher noise levels on first pixel
                        {
                            rgb[k] &= ~((1 << noiseLevelRGB[k]) - 1);
                            rgb[k] |= (1 << noiseLevelRGB[k]) & ((1 << 8) - 1);
                        }
                        else //Cipher message
                        {
                            for (int l = 0; l < noiseLevelRGB[k]; l++)
                            {
                                rgb[k] &= ~(1 << l);
                                if (index < messageBits.Length) rgb[k] |= (messageBits.Get(index) ? 1 : 0) << l;
                                else break;
                                index++;
                            }
                            if (index >= messageBits.Length) break;
                        }
                    }
                    image.SetPixel(i, j, Color.FromArgb(rgb[0], rgb[1], rgb[2]));

                    if (index >= messageBits.Length) break;
                }
                if (index >= messageBits.Length) break;
            }
            return image;
        }

        private void CipherButton_Click(object sender, EventArgs e)
        {
            Bitmap cipheredImage = cipher();
            if (cipheredImage == null)
            {
                return;
            }
            resultImage.Image = cipheredImage;

            cipheredImage.Save(imagePath);
        }

        private BitArray decipher()
        {
            BitArray key = new BitArray(Encoding.UTF8.GetBytes(KEY));

            int height = image.Height;
            int width = image.Width;
            int[] noiseLevelRGB = { 0, 0, 0};
            List<bool> bitList = new List<bool>();
            int zeroCounter = 0;
            int keyIndex = 0;
            bool getExtention = false;
            List<bool> extentionBits = new List<bool>();
            for (int i = 0; i < height; i++)
            {
                for(int j = 0; j < width; j++)
                {
                    Color color = image.GetPixel(j, i);
                    int[] rgb = { color.R, color.G, color.B };
                    for(int k = 0; k < 3; k++)
                    {
                        if (i == 0 && j == 0) //Set decipher noise levels
                        {
                            while ((rgb[k] & 1) == 0 && noiseLevelRGB[k] < 8)
                            {
                                noiseLevelRGB[k]++;
                                rgb[k] >>= 1;
                            }
                        }
                        else  //Decipher message
                        {
                            for(int l = 0; l < noiseLevelRGB[k]; l++)
                            {
                                bool bit = (rgb[k] & 1) == 1;
                                rgb[k] >>= 1;

                                if (keyIndex < key.Count)
                                {
                                    if (bit != key.Get(keyIndex)) return null; //bad key
                                    keyIndex++;
                                    if (keyIndex == key.Count) getExtention = true;
                                } else if (getExtention) {
                                    if (!bit) zeroCounter++;
                                    else zeroCounter = 0;
                                    extentionBits.Add(bit);
                                    if (zeroCounter >= 8 && extentionBits.Count % 8 == 0) //end of extention
                                    {
                                        getExtention = false;
                                        byte[] extentionBytes = new byte[extentionBits.Count / 8 + 1];
                                        new BitArray(extentionBits.ToArray()).CopyTo(extentionBytes, 0);
                                        saveFileDialog1.Filter = "plik|*" + Encoding.UTF8.GetString(extentionBytes);
                                    }
                                } else {
                                    if (!bit) zeroCounter++;
                                    else zeroCounter = 0;
                                    bitList.Add(bit);
                                }

                                if (zeroCounter == 8 * zeroEndingBytes) break;
                            }
                        }
                        if (zeroCounter == 8 * zeroEndingBytes) break;
                    }
                    if (noiseLevelRGB.Sum() == 0) return null;
                    if (zeroCounter == 8  * zeroEndingBytes) break;
                }
                if (zeroCounter == 8 * zeroEndingBytes) break;
            }

            decipheredRGBnoiseLevels = noiseLevelRGB;

            BitArray dataArray = new BitArray(bitList.Count - 8 * zeroEndingBytes);
            for (int i = 0; i < bitList.Count - 8 * zeroEndingBytes; i++)
            {
                dataArray.Set(i, bitList[i]);
            }

            return dataArray;
        }

        private void MessageText_TextChanged(object sender, EventArgs e)
        {
            showUsedSpace();
        }

        private void DecipherButton_Click(object sender, EventArgs e)
        {
            BitArray fileBits = decipher();

            if (fileBits != null)
            {
                byte[] fileBytes = new byte[fileBits.Count / 8 + 1];
                fileBits.CopyTo(fileBytes, 0);

                NoiseLevelSliderR.Value = decipheredRGBnoiseLevels[0];
                NoiseLevelSliderG.Value = decipheredRGBnoiseLevels[1];
                NoiseLevelSliderB.Value = decipheredRGBnoiseLevels[2];

                saveFileDialog1.ShowDialog();
                File.WriteAllBytes(saveFileDialog1.FileName, fileBytes);

                lastDecipheredFileSizeBit = fileBytes.Length * 8;
                lastDecipheredImageSpaceBit = image.Width * image.Height * (decipheredRGBnoiseLevels.Sum());

                showUsedSpace(); 
            }
            else
            {
                MessageBox.Show("Nie znaleziono klucza.",
                        "Nie rozszyfrowano wiadomości.",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
            }
            
        }

        private void dostepneBajty_Click(object sender, EventArgs e)
        {
            showUsedSpaceMode++;
            if (showUsedSpaceMode > 3) showUsedSpaceMode = 0;

            showUsedSpace();
        }

        private void NoiseLevelSliderR_ValueChanged(object sender, EventArgs e)
        {
            SliderRLabel.Text = "R: " + NoiseLevelSliderR.Value.ToString();
            showUsedSpace();
        }

        private void NoiseLevelSliderG_ValueChanged(object sender, EventArgs e)
        {
            SliderGLabel.Text = "G: " + NoiseLevelSliderG.Value.ToString();
            showUsedSpace();
        }

        private void NoiseLevelSliderB_ValueChanged(object sender, EventArgs e)
        {
            SliderBLabel.Text = "B: " + NoiseLevelSliderB.Value.ToString();
            showUsedSpace();
        }

        private void messagePathChooseButton_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
            messagePath = openFileDialog2.FileName;
            showUsedSpace();
        }
    }
}
