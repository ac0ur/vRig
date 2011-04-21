using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using CIV756P_Control;

namespace vRig
{
    public partial class Form1 : Form
    {

        CIV756P myRadio = new CIV756P();
        
        int mode = 0;
        decimal freq = 7258.000M;
        bool split = false;
        int vfo = 0;
        int memoCh = 1;
        bool memo = false;
        int rigAddress = 40;
        int comPort = 1;
        int baudrate = 1200;
        int radioType = 1;  // 1 icom, 2 yaesu, 3 kenwood, 4-... not yet assigned

        public Form1()
        {
            InitializeComponent();
            Image img = Image.FromFile(@"C:\Users\Matthew Chambers\Documents\Visual Studio 2010\Projects\vRig\vRig\serial-port.png");
            
            icomRadioMenuSetCheck(rigAddress);
            

            foreach (string port in SerialPort.GetPortNames())
            {
                serialPortToolStripMenuItem.DropDownItems.Add(port);


            }
            
            //PollTimer.Start();
            init_radio();
        }

        public void init_radio()
        {
            myRadio.get_Address(rigAddress, 224);
            myRadio.get_OpenComm(true, 1200, comPort);
            
            myRadio.set_DTREnable(true);
            myRadio.set_RTSEnable(true);

            display_freq(freq);
            update_radio_freq(freq);
            display_mode(mode);
            update_radio_mode(mode);
            display_memo_vfo(vfo);
            numericUpDown3.Value = memoCh;
            myRadio.set_PutMemCh(memoCh);
        }

        public void get_frequency()
        {

            frequency_display.Value = freq;
        }

        public void get_mode()
        {
        }

        public void update_radio_mode(int mode)
        {
            myRadio.get_DirectAccess(1, mode, "");
        }

        public void update_radio_freq(decimal freq)
        {
            myRadio.get_SetOpFreq((double) freq);
        }

        public void display_memo_vfo(int mode)
        {
            switch (mode)
            {
                case 0:
                    lbl_VFOA.Visible = true;
                    lbl_VFOB.Visible = false;
                    lbl_MEMO.Visible = false;
                    break;
                case 1:
                    lbl_VFOA.Visible = false;
                    lbl_VFOB.Visible = true;
                    lbl_MEMO.Visible = false;
                    break;
                case 2:
                    lbl_VFOA.Visible = false;
                    lbl_VFOB.Visible = false;
                    lbl_MEMO.Visible = true;
                    break;
            }

        }

        public void display_freq(decimal freq)
        {
            frequency_display.Value = freq;
        }

        public void display_mode(int mode)
        {
            switch (mode)
            {
                case 0:
                    lbl_LSB.Visible = true;
                    lbl_USB.Visible = false;
                    lbl_CW.Visible = false;
                    lbl_N.Visible = false;
                    lbl_AM.Visible = false;
                    lbl_FM.Visible = false;
                    break;
                case 1:
                    lbl_LSB.Visible = false;
                    lbl_USB.Visible = true;
                    lbl_CW.Visible = false;
                    lbl_N.Visible = false;
                    lbl_AM.Visible = false;
                    lbl_FM.Visible = false;
                    break;
                case 2:
                    lbl_LSB.Visible = false;
                    lbl_USB.Visible = false;
                    lbl_CW.Visible = false;
                    lbl_N.Visible = false;
                    lbl_AM.Visible = true;
                    lbl_FM.Visible = false;
                    break;
                case 3:
                    lbl_LSB.Visible = false;
                    lbl_USB.Visible = false;
                    lbl_CW.Visible = true;
                    lbl_N.Visible = false;
                    lbl_AM.Visible = false;
                    lbl_FM.Visible = false;
                    break;
                case 5:
                    lbl_LSB.Visible = false;
                    lbl_USB.Visible = false;
                    lbl_CW.Visible = false;
                    lbl_N.Visible = false;
                    lbl_AM.Visible = false;
                    lbl_FM.Visible = true;
                    break;
            }
            
        }

        private void btn_1MHz_Click(object sender, EventArgs e)
        {
            if (frequency_display.Increment != 1000)
            {
                frequency_display.Increment = 1000;
                btn_1MHz.ForeColor = Color.Red;
            }
            else
            {
                frequency_display.Increment = 0.01M;
                btn_1MHz.ForeColor = Color.Black;
            }
        }

        private void btn_1kHz_Click(object sender, EventArgs e)
        {
            if (frequency_display.Increment != 1)
            {
                frequency_display.Increment = 1;
                btn_1kHz.ForeColor = Color.Red;
            }
            else
            {
                frequency_display.Increment = 0.01M;
                btn_1kHz.ForeColor = Color.Black;
            }
        }

        private void btn_100Hz_Click(object sender, EventArgs e)
        {
            if (frequency_display.Increment != 0.1M)
            {
                frequency_display.Increment = 0.1M;
                btn_100Hz.ForeColor = Color.Red;
            }
            else
            {
                frequency_display.Increment = 0.01M;
                btn_100Hz.ForeColor = Color.Black;
            }
        }

        private void btn_SSB_Click(object sender, EventArgs e)
        {
            if (mode == 0)
            {                
                mode = 1;
            }
            else if (mode == 1)
            {
                mode = 0;
            }
            else if (mode != 0 && mode != 1)
            {
                if (freq > 14000.00M)
                {
                    mode = 1;
                }
                else
                {
                    mode = 0;
                }
            }
            display_mode(mode);
            update_radio_mode(mode);
        }

        private void btn_CWN_Click(object sender, EventArgs e)
        {
            display_mode(3);
            update_radio_mode(3);
            mode = 3;
        }

        private void btn_AMFM_Click(object sender, EventArgs e)
        {
            if (mode == 2)
            {
                mode = 5;
            }
            else if (mode == 5)
            {
                mode = 2;
            }
            else if (mode != 2 && mode != 5)
            {
                    mode = 2;
            }
            display_mode(mode);
            update_radio_mode(mode);
        }

        private void PollTimer_Tick(object sender, EventArgs e)
        {
            //get_frequency();
            //update_radio_freq(freq);
            //get_mode();
            //update_radio_mode(mode);
        }

        private void frequency_display_ValueChanged(object sender, EventArgs e)
        {
            freq = frequency_display.Value;
            update_radio_freq(freq);
        }

        private void btn_SPLIT_Click(object sender, EventArgs e)
        {
            if (split == false)
            {
                split = true;
                lbl_SPLIT.Visible = true;
                myRadio.get_Split(true);
            }
            else if (split == true)
            {
                split = false;
                lbl_SPLIT.Visible = false;
                myRadio.get_Split(false);
            }
        }

        private void btn_VFO_Click(object sender, EventArgs e)
        {
            if (memo == false)
            {
                if (vfo == 0)
                {
                    vfo = 1;
                }
                else
                {
                    vfo = 0;
                }
            }
            display_memo_vfo(vfo);
            memo = false;
            myRadio.get_DirectAccess(7, vfo, "");
        }

        private void btn_AeqB_Click(object sender, EventArgs e)
        {
            myRadio.get_DirectAccess(7, 160, "");
        }

        private void btn_MEMO_Click(object sender, EventArgs e)
        {
            memo = true;
            display_memo_vfo(3);
            myRadio.get_DirectAccess(8, 0, "");
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            memoCh = (int) numericUpDown3.Value;
            myRadio.get_MemorySelect(memoCh);
        }

        private void btn_MW_Click(object sender, EventArgs e)
        {
            myRadio.get_MemChWrite(memoCh, freq.ToString());
        }

        private void btn_MSCAN_Click(object sender, EventArgs e)
        {
            myRadio.ScanStartMemory();
        }

        private void btn_PSCAN_Click(object sender, EventArgs e)
        {
            myRadio.ScanStartProgMemory();
        }

        private void icomRadioMenuSetCheck(int radioAddress)
        {
            switch (radioAddress)
            {
                case 26:
                    iC1271ToolStripMenuItem.Checked = true;
                    iC1275ToolStripMenuItem.Checked = false;
                    iC271ToolStripMenuItem.Checked = false;
                    iC275ToolStripMenuItem.Checked = false;
                    iC375ToolStripMenuItem.Checked = false;
                    iC471ToolStripMenuItem.Checked = false;
                    iC475ToolStripMenuItem.Checked = false;
                    iC575ToolStripMenu.Checked = false;
                    iC7000ToolStripMenuItem.Checked = false;
                    iC703ToolStripMenuItem.Checked = false;
                    iC706MkIIGToolStripMenuItem.Checked = false;
                    iC706MkIIToolStripMenuItem.Checked = false;
                    iC706ToolStripMenuItem.Checked = false;
                    iC707ToolStripMenuItem.Checked = false;
                    iC718ToolStripMenuItem.Checked = false;
                    iC7200ToolStripMenuItem.Checked = false;
                    iC725ToolStripMenuItem.Checked = false;
                    iC726ToolStripMenuItem.Checked = false;
                    iC728ToolStripMenuItem.Checked = false;
                    iC729ToolStripMenuItem.Checked = false;
                    iC735ToolStripMenuItem.Checked = false;
                    iC736ToolStripMenuItem.Checked = false;
                    iC737ToolStripMenuItem.Checked = false;
                    iC738ToolStripMenuItem.Checked = false;
                    iC7400ToolStripMenuItem.Checked = false;
                    iC746ToolStripMenuItem.Checked = false;
                    iC751AToolStripMenuItem.Checked = false;
                    iC756ProIIIToolStripMenuItem.Checked = false;
                    iC756ProIIToolStripMenuItem.Checked = false;
                    iC756ProToolStripMenuItem.Checked = false;
                    iC756ToolStripMenuItem.Checked = false;
                    iC761ToolStripMenuItem.Checked = false;
                    iC765ToolStripMenuItem.Checked = false;
                    iC7700ToolStripMenuItem.Checked = false;
                    iC775ToolStripMenuItem.Checked = false;
                    iC7800ToolStripMenuItem.Checked = false;
                    iC781ToolStripMenuItem.Checked = false;
                    iC78ToolStripMenuItem.Checked = false;
                    iC820ToolStripMenuItem.Checked = false;
                    iC821ToolStripMenuItem.Checked = false;
                    iC910ToolStripMenuItem.Checked = false;
                    iC970ToolStripMenuItem.Checked = false;
                    iCX3ToolStripMenuItem.Checked = false;
                    iD1ToolStripMenuItem.Checked = false;
                    break;
                case 24:
                    iC1271ToolStripMenuItem.Checked = false;
                    iC1275ToolStripMenuItem.Checked = true;
                    iC271ToolStripMenuItem.Checked = false;
                    iC275ToolStripMenuItem.Checked = false;
                    iC375ToolStripMenuItem.Checked = false;
                    iC471ToolStripMenuItem.Checked = false;
                    iC475ToolStripMenuItem.Checked = false;
                    iC575ToolStripMenu.Checked = false;
                    iC7000ToolStripMenuItem.Checked = false;
                    iC703ToolStripMenuItem.Checked = false;
                    iC706MkIIGToolStripMenuItem.Checked = false;
                    iC706MkIIToolStripMenuItem.Checked = false;
                    iC706ToolStripMenuItem.Checked = false;
                    iC707ToolStripMenuItem.Checked = false;
                    iC718ToolStripMenuItem.Checked = false;
                    iC7200ToolStripMenuItem.Checked = false;
                    iC725ToolStripMenuItem.Checked = false;
                    iC726ToolStripMenuItem.Checked = false;
                    iC728ToolStripMenuItem.Checked = false;
                    iC729ToolStripMenuItem.Checked = false;
                    iC735ToolStripMenuItem.Checked = false;
                    iC736ToolStripMenuItem.Checked = false;
                    iC737ToolStripMenuItem.Checked = false;
                    iC738ToolStripMenuItem.Checked = false;
                    iC7400ToolStripMenuItem.Checked = false;
                    iC746ToolStripMenuItem.Checked = false;
                    iC751AToolStripMenuItem.Checked = false;
                    iC756ProIIIToolStripMenuItem.Checked = false;
                    iC756ProIIToolStripMenuItem.Checked = false;
                    iC756ProToolStripMenuItem.Checked = false;
                    iC756ToolStripMenuItem.Checked = false;
                    iC761ToolStripMenuItem.Checked = false;
                    iC765ToolStripMenuItem.Checked = false;
                    iC7700ToolStripMenuItem.Checked = false;
                    iC775ToolStripMenuItem.Checked = false;
                    iC7800ToolStripMenuItem.Checked = false;
                    iC781ToolStripMenuItem.Checked = false;
                    iC78ToolStripMenuItem.Checked = false;
                    iC820ToolStripMenuItem.Checked = false;
                    iC821ToolStripMenuItem.Checked = false;
                    iC910ToolStripMenuItem.Checked = false;
                    iC970ToolStripMenuItem.Checked = false;
                    iCX3ToolStripMenuItem.Checked = false;
                    iD1ToolStripMenuItem.Checked = false;
                    break;
                case 32:
                    iC1271ToolStripMenuItem.Checked = false;
                    iC1275ToolStripMenuItem.Checked = false;
                    iC271ToolStripMenuItem.Checked = true;
                    iC275ToolStripMenuItem.Checked = false;
                    iC375ToolStripMenuItem.Checked = false;
                    iC471ToolStripMenuItem.Checked = false;
                    iC475ToolStripMenuItem.Checked = false;
                    iC575ToolStripMenu.Checked = false;
                    iC7000ToolStripMenuItem.Checked = false;
                    iC703ToolStripMenuItem.Checked = false;
                    iC706MkIIGToolStripMenuItem.Checked = false;
                    iC706MkIIToolStripMenuItem.Checked = false;
                    iC706ToolStripMenuItem.Checked = false;
                    iC707ToolStripMenuItem.Checked = false;
                    iC718ToolStripMenuItem.Checked = false;
                    iC7200ToolStripMenuItem.Checked = false;
                    iC725ToolStripMenuItem.Checked = false;
                    iC726ToolStripMenuItem.Checked = false;
                    iC728ToolStripMenuItem.Checked = false;
                    iC729ToolStripMenuItem.Checked = false;
                    iC735ToolStripMenuItem.Checked = false;
                    iC736ToolStripMenuItem.Checked = false;
                    iC737ToolStripMenuItem.Checked = false;
                    iC738ToolStripMenuItem.Checked = false;
                    iC7400ToolStripMenuItem.Checked = false;
                    iC746ToolStripMenuItem.Checked = false;
                    iC751AToolStripMenuItem.Checked = false;
                    iC756ProIIIToolStripMenuItem.Checked = false;
                    iC756ProIIToolStripMenuItem.Checked = false;
                    iC756ProToolStripMenuItem.Checked = false;
                    iC756ToolStripMenuItem.Checked = false;
                    iC761ToolStripMenuItem.Checked = false;
                    iC765ToolStripMenuItem.Checked = false;
                    iC7700ToolStripMenuItem.Checked = false;
                    iC775ToolStripMenuItem.Checked = false;
                    iC7800ToolStripMenuItem.Checked = false;
                    iC781ToolStripMenuItem.Checked = false;
                    iC78ToolStripMenuItem.Checked = false;
                    iC820ToolStripMenuItem.Checked = false;
                    iC821ToolStripMenuItem.Checked = false;
                    iC910ToolStripMenuItem.Checked = false;
                    iC970ToolStripMenuItem.Checked = false;
                    iCX3ToolStripMenuItem.Checked = false;
                    iD1ToolStripMenuItem.Checked = false;
                    break;
                case 16: 
                    iC1271ToolStripMenuItem.Checked = false;
                    iC1275ToolStripMenuItem.Checked = false;
                    iC271ToolStripMenuItem.Checked = false;
                    iC275ToolStripMenuItem.Checked = true;
                    iC375ToolStripMenuItem.Checked = false;
                    iC471ToolStripMenuItem.Checked = false;
                    iC475ToolStripMenuItem.Checked = false;
                    iC575ToolStripMenu.Checked = false;
                    iC7000ToolStripMenuItem.Checked = false;
                    iC703ToolStripMenuItem.Checked = false;
                    iC706MkIIGToolStripMenuItem.Checked = false;
                    iC706MkIIToolStripMenuItem.Checked = false;
                    iC706ToolStripMenuItem.Checked = false;
                    iC707ToolStripMenuItem.Checked = false;
                    iC718ToolStripMenuItem.Checked = false;
                    iC7200ToolStripMenuItem.Checked = false;
                    iC725ToolStripMenuItem.Checked = false;
                    iC726ToolStripMenuItem.Checked = false;
                    iC728ToolStripMenuItem.Checked = false;
                    iC729ToolStripMenuItem.Checked = false;
                    iC735ToolStripMenuItem.Checked = false;
                    iC736ToolStripMenuItem.Checked = false;
                    iC737ToolStripMenuItem.Checked = false;
                    iC738ToolStripMenuItem.Checked = false;
                    iC7400ToolStripMenuItem.Checked = false;
                    iC746ToolStripMenuItem.Checked = false;
                    iC751AToolStripMenuItem.Checked = false;
                    iC756ProIIIToolStripMenuItem.Checked = false;
                    iC756ProIIToolStripMenuItem.Checked = false;
                    iC756ProToolStripMenuItem.Checked = false;
                    iC756ToolStripMenuItem.Checked = false;
                    iC761ToolStripMenuItem.Checked = false;
                    iC765ToolStripMenuItem.Checked = false;
                    iC7700ToolStripMenuItem.Checked = false;
                    iC775ToolStripMenuItem.Checked = false;
                    iC7800ToolStripMenuItem.Checked = false;
                    iC781ToolStripMenuItem.Checked = false;
                    iC78ToolStripMenuItem.Checked = false;
                    iC820ToolStripMenuItem.Checked = false;
                    iC821ToolStripMenuItem.Checked = false;
                    iC910ToolStripMenuItem.Checked = false;
                    iC970ToolStripMenuItem.Checked = false;
                    iCX3ToolStripMenuItem.Checked = false;
                    iD1ToolStripMenuItem.Checked = false;
                    break;
                case 18:
                    iC1271ToolStripMenuItem.Checked = false;
                    iC1275ToolStripMenuItem.Checked = false;
                    iC271ToolStripMenuItem.Checked = false;
                    iC275ToolStripMenuItem.Checked = false;
                    iC375ToolStripMenuItem.Checked = true;
                    iC471ToolStripMenuItem.Checked = false;
                    iC475ToolStripMenuItem.Checked = false;
                    iC575ToolStripMenu.Checked = false;
                    iC7000ToolStripMenuItem.Checked = false;
                    iC703ToolStripMenuItem.Checked = false;
                    iC706MkIIGToolStripMenuItem.Checked = false;
                    iC706MkIIToolStripMenuItem.Checked = false;
                    iC706ToolStripMenuItem.Checked = false;
                    iC707ToolStripMenuItem.Checked = false;
                    iC718ToolStripMenuItem.Checked = false;
                    iC7200ToolStripMenuItem.Checked = false;
                    iC725ToolStripMenuItem.Checked = false;
                    iC726ToolStripMenuItem.Checked = false;
                    iC728ToolStripMenuItem.Checked = false;
                    iC729ToolStripMenuItem.Checked = false;
                    iC735ToolStripMenuItem.Checked = false;
                    iC736ToolStripMenuItem.Checked = false;
                    iC737ToolStripMenuItem.Checked = false;
                    iC738ToolStripMenuItem.Checked = false;
                    iC7400ToolStripMenuItem.Checked = false;
                    iC746ToolStripMenuItem.Checked = false;
                    iC751AToolStripMenuItem.Checked = false;
                    iC756ProIIIToolStripMenuItem.Checked = false;
                    iC756ProIIToolStripMenuItem.Checked = false;
                    iC756ProToolStripMenuItem.Checked = false;
                    iC756ToolStripMenuItem.Checked = false;
                    iC761ToolStripMenuItem.Checked = false;
                    iC765ToolStripMenuItem.Checked = false;
                    iC7700ToolStripMenuItem.Checked = false;
                    iC775ToolStripMenuItem.Checked = false;
                    iC7800ToolStripMenuItem.Checked = false;
                    iC781ToolStripMenuItem.Checked = false;
                    iC78ToolStripMenuItem.Checked = false;
                    iC820ToolStripMenuItem.Checked = false;
                    iC821ToolStripMenuItem.Checked = false;
                    iC910ToolStripMenuItem.Checked = false;
                    iC970ToolStripMenuItem.Checked = false;
                    iCX3ToolStripMenuItem.Checked = false;
                    iD1ToolStripMenuItem.Checked = false;
                    break;
                case 34:
                    iC1271ToolStripMenuItem.Checked = false;
                    iC1275ToolStripMenuItem.Checked = false;
                    iC271ToolStripMenuItem.Checked = false;
                    iC275ToolStripMenuItem.Checked = false;
                    iC375ToolStripMenuItem.Checked = false;
                    iC471ToolStripMenuItem.Checked = true;
                    iC475ToolStripMenuItem.Checked = false;
                    iC575ToolStripMenu.Checked = false;
                    iC7000ToolStripMenuItem.Checked = false;
                    iC703ToolStripMenuItem.Checked = false;
                    iC706MkIIGToolStripMenuItem.Checked = false;
                    iC706MkIIToolStripMenuItem.Checked = false;
                    iC706ToolStripMenuItem.Checked = false;
                    iC707ToolStripMenuItem.Checked = false;
                    iC718ToolStripMenuItem.Checked = false;
                    iC7200ToolStripMenuItem.Checked = false;
                    iC725ToolStripMenuItem.Checked = false;
                    iC726ToolStripMenuItem.Checked = false;
                    iC728ToolStripMenuItem.Checked = false;
                    iC729ToolStripMenuItem.Checked = false;
                    iC735ToolStripMenuItem.Checked = false;
                    iC736ToolStripMenuItem.Checked = false;
                    iC737ToolStripMenuItem.Checked = false;
                    iC738ToolStripMenuItem.Checked = false;
                    iC7400ToolStripMenuItem.Checked = false;
                    iC746ToolStripMenuItem.Checked = false;
                    iC751AToolStripMenuItem.Checked = false;
                    iC756ProIIIToolStripMenuItem.Checked = false;
                    iC756ProIIToolStripMenuItem.Checked = false;
                    iC756ProToolStripMenuItem.Checked = false;
                    iC756ToolStripMenuItem.Checked = false;
                    iC761ToolStripMenuItem.Checked = false;
                    iC765ToolStripMenuItem.Checked = false;
                    iC7700ToolStripMenuItem.Checked = false;
                    iC775ToolStripMenuItem.Checked = false;
                    iC7800ToolStripMenuItem.Checked = false;
                    iC781ToolStripMenuItem.Checked = false;
                    iC78ToolStripMenuItem.Checked = false;
                    iC820ToolStripMenuItem.Checked = false;
                    iC821ToolStripMenuItem.Checked = false;
                    iC910ToolStripMenuItem.Checked = false;
                    iC970ToolStripMenuItem.Checked = false;
                    iCX3ToolStripMenuItem.Checked = false;
                    iD1ToolStripMenuItem.Checked = false;
                    break;
                case 20:
                    iC1271ToolStripMenuItem.Checked = false;
                    iC1275ToolStripMenuItem.Checked = false;
                    iC271ToolStripMenuItem.Checked = false;
                    iC275ToolStripMenuItem.Checked = false;
                    iC375ToolStripMenuItem.Checked = false;
                    iC471ToolStripMenuItem.Checked = false;
                    iC475ToolStripMenuItem.Checked = true;
                    iC575ToolStripMenu.Checked = false;
                    iC7000ToolStripMenuItem.Checked = false;
                    iC703ToolStripMenuItem.Checked = false;
                    iC706MkIIGToolStripMenuItem.Checked = false;
                    iC706MkIIToolStripMenuItem.Checked = false;
                    iC706ToolStripMenuItem.Checked = false;
                    iC707ToolStripMenuItem.Checked = false;
                    iC718ToolStripMenuItem.Checked = false;
                    iC7200ToolStripMenuItem.Checked = false;
                    iC725ToolStripMenuItem.Checked = false;
                    iC726ToolStripMenuItem.Checked = false;
                    iC728ToolStripMenuItem.Checked = false;
                    iC729ToolStripMenuItem.Checked = false;
                    iC735ToolStripMenuItem.Checked = false;
                    iC736ToolStripMenuItem.Checked = false;
                    iC737ToolStripMenuItem.Checked = false;
                    iC738ToolStripMenuItem.Checked = false;
                    iC7400ToolStripMenuItem.Checked = false;
                    iC746ToolStripMenuItem.Checked = false;
                    iC751AToolStripMenuItem.Checked = false;
                    iC756ProIIIToolStripMenuItem.Checked = false;
                    iC756ProIIToolStripMenuItem.Checked = false;
                    iC756ProToolStripMenuItem.Checked = false;
                    iC756ToolStripMenuItem.Checked = false;
                    iC761ToolStripMenuItem.Checked = false;
                    iC765ToolStripMenuItem.Checked = false;
                    iC7700ToolStripMenuItem.Checked = false;
                    iC775ToolStripMenuItem.Checked = false;
                    iC7800ToolStripMenuItem.Checked = false;
                    iC781ToolStripMenuItem.Checked = false;
                    iC78ToolStripMenuItem.Checked = false;
                    iC820ToolStripMenuItem.Checked = false;
                    iC821ToolStripMenuItem.Checked = false;
                    iC910ToolStripMenuItem.Checked = false;
                    iC970ToolStripMenuItem.Checked = false;
                    iCX3ToolStripMenuItem.Checked = false;
                    iD1ToolStripMenuItem.Checked = false;
                    break;
                case 112:
                    iC1271ToolStripMenuItem.Checked = false;
                    iC1275ToolStripMenuItem.Checked = false;
                    iC271ToolStripMenuItem.Checked = false;
                    iC275ToolStripMenuItem.Checked = false;
                    iC375ToolStripMenuItem.Checked = false;
                    iC471ToolStripMenuItem.Checked = false;
                    iC475ToolStripMenuItem.Checked = false;
                    iC575ToolStripMenu.Checked = false;
                    iC7000ToolStripMenuItem.Checked = true;
                    iC703ToolStripMenuItem.Checked = false;
                    iC706MkIIGToolStripMenuItem.Checked = false;
                    iC706MkIIToolStripMenuItem.Checked = false;
                    iC706ToolStripMenuItem.Checked = false;
                    iC707ToolStripMenuItem.Checked = false;
                    iC718ToolStripMenuItem.Checked = false;
                    iC7200ToolStripMenuItem.Checked = false;
                    iC725ToolStripMenuItem.Checked = false;
                    iC726ToolStripMenuItem.Checked = false;
                    iC728ToolStripMenuItem.Checked = false;
                    iC729ToolStripMenuItem.Checked = false;
                    iC735ToolStripMenuItem.Checked = false;
                    iC736ToolStripMenuItem.Checked = false;
                    iC737ToolStripMenuItem.Checked = false;
                    iC738ToolStripMenuItem.Checked = false;
                    iC7400ToolStripMenuItem.Checked = false;
                    iC746ToolStripMenuItem.Checked = false;
                    iC751AToolStripMenuItem.Checked = false;
                    iC756ProIIIToolStripMenuItem.Checked = false;
                    iC756ProIIToolStripMenuItem.Checked = false;
                    iC756ProToolStripMenuItem.Checked = false;
                    iC756ToolStripMenuItem.Checked = false;
                    iC761ToolStripMenuItem.Checked = false;
                    iC765ToolStripMenuItem.Checked = false;
                    iC7700ToolStripMenuItem.Checked = false;
                    iC775ToolStripMenuItem.Checked = false;
                    iC7800ToolStripMenuItem.Checked = false;
                    iC781ToolStripMenuItem.Checked = false;
                    iC78ToolStripMenuItem.Checked = false;
                    iC820ToolStripMenuItem.Checked = false;
                    iC821ToolStripMenuItem.Checked = false;
                    iC910ToolStripMenuItem.Checked = false;
                    iC970ToolStripMenuItem.Checked = false;
                    iCX3ToolStripMenuItem.Checked = false;
                    iD1ToolStripMenuItem.Checked = false;
                    break;
                case 104:
                    iC1271ToolStripMenuItem.Checked = false;
                    iC1275ToolStripMenuItem.Checked = false;
                    iC271ToolStripMenuItem.Checked = false;
                    iC275ToolStripMenuItem.Checked = false;
                    iC375ToolStripMenuItem.Checked = false;
                    iC471ToolStripMenuItem.Checked = false;
                    iC475ToolStripMenuItem.Checked = false;
                    iC575ToolStripMenu.Checked = false;
                    iC7000ToolStripMenuItem.Checked = false;
                    iC703ToolStripMenuItem.Checked = true;
                    iC706MkIIGToolStripMenuItem.Checked = false;
                    iC706MkIIToolStripMenuItem.Checked = false;
                    iC706ToolStripMenuItem.Checked = false;
                    iC707ToolStripMenuItem.Checked = false;
                    iC718ToolStripMenuItem.Checked = false;
                    iC7200ToolStripMenuItem.Checked = false;
                    iC725ToolStripMenuItem.Checked = false;
                    iC726ToolStripMenuItem.Checked = false;
                    iC728ToolStripMenuItem.Checked = false;
                    iC729ToolStripMenuItem.Checked = false;
                    iC735ToolStripMenuItem.Checked = false;
                    iC736ToolStripMenuItem.Checked = false;
                    iC737ToolStripMenuItem.Checked = false;
                    iC738ToolStripMenuItem.Checked = false;
                    iC7400ToolStripMenuItem.Checked = false;
                    iC746ToolStripMenuItem.Checked = false;
                    iC751AToolStripMenuItem.Checked = false;
                    iC756ProIIIToolStripMenuItem.Checked = false;
                    iC756ProIIToolStripMenuItem.Checked = false;
                    iC756ProToolStripMenuItem.Checked = false;
                    iC756ToolStripMenuItem.Checked = false;
                    iC761ToolStripMenuItem.Checked = false;
                    iC765ToolStripMenuItem.Checked = false;
                    iC7700ToolStripMenuItem.Checked = false;
                    iC775ToolStripMenuItem.Checked = false;
                    iC7800ToolStripMenuItem.Checked = false;
                    iC781ToolStripMenuItem.Checked = false;
                    iC78ToolStripMenuItem.Checked = false;
                    iC820ToolStripMenuItem.Checked = false;
                    iC821ToolStripMenuItem.Checked = false;
                    iC910ToolStripMenuItem.Checked = false;
                    iC970ToolStripMenuItem.Checked = false;
                    iCX3ToolStripMenuItem.Checked = false;
                    iD1ToolStripMenuItem.Checked = false;
                    break;
                case 88:
                    iC1271ToolStripMenuItem.Checked = false;
                    iC1275ToolStripMenuItem.Checked = false;
                    iC271ToolStripMenuItem.Checked = false;
                    iC275ToolStripMenuItem.Checked = false;
                    iC375ToolStripMenuItem.Checked = false;
                    iC471ToolStripMenuItem.Checked = false;
                    iC475ToolStripMenuItem.Checked = false;
                    iC575ToolStripMenu.Checked = false;
                    iC7000ToolStripMenuItem.Checked = false;
                    iC703ToolStripMenuItem.Checked = false;
                    iC706MkIIGToolStripMenuItem.Checked = true;
                    iC706MkIIToolStripMenuItem.Checked = false;
                    iC706ToolStripMenuItem.Checked = false;
                    iC707ToolStripMenuItem.Checked = false;
                    iC718ToolStripMenuItem.Checked = false;
                    iC7200ToolStripMenuItem.Checked = false;
                    iC725ToolStripMenuItem.Checked = false;
                    iC726ToolStripMenuItem.Checked = false;
                    iC728ToolStripMenuItem.Checked = false;
                    iC729ToolStripMenuItem.Checked = false;
                    iC735ToolStripMenuItem.Checked = false;
                    iC736ToolStripMenuItem.Checked = false;
                    iC737ToolStripMenuItem.Checked = false;
                    iC738ToolStripMenuItem.Checked = false;
                    iC7400ToolStripMenuItem.Checked = false;
                    iC746ToolStripMenuItem.Checked = false;
                    iC751AToolStripMenuItem.Checked = false;
                    iC756ProIIIToolStripMenuItem.Checked = false;
                    iC756ProIIToolStripMenuItem.Checked = false;
                    iC756ProToolStripMenuItem.Checked = false;
                    iC756ToolStripMenuItem.Checked = false;
                    iC761ToolStripMenuItem.Checked = false;
                    iC765ToolStripMenuItem.Checked = false;
                    iC7700ToolStripMenuItem.Checked = false;
                    iC775ToolStripMenuItem.Checked = false;
                    iC7800ToolStripMenuItem.Checked = false;
                    iC781ToolStripMenuItem.Checked = false;
                    iC78ToolStripMenuItem.Checked = false;
                    iC820ToolStripMenuItem.Checked = false;
                    iC821ToolStripMenuItem.Checked = false;
                    iC910ToolStripMenuItem.Checked = false;
                    iC970ToolStripMenuItem.Checked = false;
                    iCX3ToolStripMenuItem.Checked = false;
                    iD1ToolStripMenuItem.Checked = false;
                    break;
                case 78:
                    iC1271ToolStripMenuItem.Checked = false;
                    iC1275ToolStripMenuItem.Checked = false;
                    iC271ToolStripMenuItem.Checked = false;
                    iC275ToolStripMenuItem.Checked = false;
                    iC375ToolStripMenuItem.Checked = false;
                    iC471ToolStripMenuItem.Checked = false;
                    iC475ToolStripMenuItem.Checked = false;
                    iC575ToolStripMenu.Checked = false;
                    iC7000ToolStripMenuItem.Checked = false;
                    iC703ToolStripMenuItem.Checked = false;
                    iC706MkIIGToolStripMenuItem.Checked = false;
                    iC706MkIIToolStripMenuItem.Checked = true;
                    iC706ToolStripMenuItem.Checked = false;
                    iC707ToolStripMenuItem.Checked = false;
                    iC718ToolStripMenuItem.Checked = false;
                    iC7200ToolStripMenuItem.Checked = false;
                    iC725ToolStripMenuItem.Checked = false;
                    iC726ToolStripMenuItem.Checked = false;
                    iC728ToolStripMenuItem.Checked = false;
                    iC729ToolStripMenuItem.Checked = false;
                    iC735ToolStripMenuItem.Checked = false;
                    iC736ToolStripMenuItem.Checked = false;
                    iC737ToolStripMenuItem.Checked = false;
                    iC738ToolStripMenuItem.Checked = false;
                    iC7400ToolStripMenuItem.Checked = false;
                    iC746ToolStripMenuItem.Checked = false;
                    iC751AToolStripMenuItem.Checked = false;
                    iC756ProIIIToolStripMenuItem.Checked = false;
                    iC756ProIIToolStripMenuItem.Checked = false;
                    iC756ProToolStripMenuItem.Checked = false;
                    iC756ToolStripMenuItem.Checked = false;
                    iC761ToolStripMenuItem.Checked = false;
                    iC765ToolStripMenuItem.Checked = false;
                    iC7700ToolStripMenuItem.Checked = false;
                    iC775ToolStripMenuItem.Checked = false;
                    iC7800ToolStripMenuItem.Checked = false;
                    iC781ToolStripMenuItem.Checked = false;
                    iC78ToolStripMenuItem.Checked = false;
                    iC820ToolStripMenuItem.Checked = false;
                    iC821ToolStripMenuItem.Checked = false;
                    iC910ToolStripMenuItem.Checked = false;
                    iC970ToolStripMenuItem.Checked = false;
                    iCX3ToolStripMenuItem.Checked = false;
                    iD1ToolStripMenuItem.Checked = false;
                    break;
                case 62:
                    iC1271ToolStripMenuItem.Checked = false;
                    iC1275ToolStripMenuItem.Checked = false;
                    iC271ToolStripMenuItem.Checked = false;
                    iC275ToolStripMenuItem.Checked = false;
                    iC375ToolStripMenuItem.Checked = false;
                    iC471ToolStripMenuItem.Checked = false;
                    iC475ToolStripMenuItem.Checked = false;
                    iC575ToolStripMenu.Checked = false;
                    iC7000ToolStripMenuItem.Checked = false;
                    iC703ToolStripMenuItem.Checked = false;
                    iC706MkIIGToolStripMenuItem.Checked = false;
                    iC706MkIIToolStripMenuItem.Checked = false;
                    iC706ToolStripMenuItem.Checked = false;
                    iC707ToolStripMenuItem.Checked = true;
                    iC718ToolStripMenuItem.Checked = false;
                    iC7200ToolStripMenuItem.Checked = false;
                    iC725ToolStripMenuItem.Checked = false;
                    iC726ToolStripMenuItem.Checked = false;
                    iC728ToolStripMenuItem.Checked = false;
                    iC729ToolStripMenuItem.Checked = false;
                    iC735ToolStripMenuItem.Checked = false;
                    iC736ToolStripMenuItem.Checked = false;
                    iC737ToolStripMenuItem.Checked = false;
                    iC738ToolStripMenuItem.Checked = false;
                    iC7400ToolStripMenuItem.Checked = false;
                    iC746ToolStripMenuItem.Checked = false;
                    iC751AToolStripMenuItem.Checked = false;
                    iC756ProIIIToolStripMenuItem.Checked = false;
                    iC756ProIIToolStripMenuItem.Checked = false;
                    iC756ProToolStripMenuItem.Checked = false;
                    iC756ToolStripMenuItem.Checked = false;
                    iC761ToolStripMenuItem.Checked = false;
                    iC765ToolStripMenuItem.Checked = false;
                    iC7700ToolStripMenuItem.Checked = false;
                    iC775ToolStripMenuItem.Checked = false;
                    iC7800ToolStripMenuItem.Checked = false;
                    iC781ToolStripMenuItem.Checked = false;
                    iC78ToolStripMenuItem.Checked = false;
                    iC820ToolStripMenuItem.Checked = false;
                    iC821ToolStripMenuItem.Checked = false;
                    iC910ToolStripMenuItem.Checked = false;
                    iC970ToolStripMenuItem.Checked = false;
                    iCX3ToolStripMenuItem.Checked = false;
                    iD1ToolStripMenuItem.Checked = false;
                    break;
                case 94:
                    iC1271ToolStripMenuItem.Checked = false;
                    iC1275ToolStripMenuItem.Checked = false;
                    iC271ToolStripMenuItem.Checked = false;
                    iC275ToolStripMenuItem.Checked = false;
                    iC375ToolStripMenuItem.Checked = false;
                    iC471ToolStripMenuItem.Checked = false;
                    iC475ToolStripMenuItem.Checked = false;
                    iC575ToolStripMenu.Checked = false;
                    iC7000ToolStripMenuItem.Checked = false;
                    iC703ToolStripMenuItem.Checked = false;
                    iC706MkIIGToolStripMenuItem.Checked = false;
                    iC706MkIIToolStripMenuItem.Checked = false;
                    iC706ToolStripMenuItem.Checked = false;
                    iC707ToolStripMenuItem.Checked = false;
                    iC718ToolStripMenuItem.Checked = true;
                    iC7200ToolStripMenuItem.Checked = false;
                    iC725ToolStripMenuItem.Checked = false;
                    iC726ToolStripMenuItem.Checked = false;
                    iC728ToolStripMenuItem.Checked = false;
                    iC729ToolStripMenuItem.Checked = false;
                    iC735ToolStripMenuItem.Checked = false;
                    iC736ToolStripMenuItem.Checked = false;
                    iC737ToolStripMenuItem.Checked = false;
                    iC738ToolStripMenuItem.Checked = false;
                    iC7400ToolStripMenuItem.Checked = false;
                    iC746ToolStripMenuItem.Checked = false;
                    iC751AToolStripMenuItem.Checked = false;
                    iC756ProIIIToolStripMenuItem.Checked = false;
                    iC756ProIIToolStripMenuItem.Checked = false;
                    iC756ProToolStripMenuItem.Checked = false;
                    iC756ToolStripMenuItem.Checked = false;
                    iC761ToolStripMenuItem.Checked = false;
                    iC765ToolStripMenuItem.Checked = false;
                    iC7700ToolStripMenuItem.Checked = false;
                    iC775ToolStripMenuItem.Checked = false;
                    iC7800ToolStripMenuItem.Checked = false;
                    iC781ToolStripMenuItem.Checked = false;
                    iC78ToolStripMenuItem.Checked = false;
                    iC820ToolStripMenuItem.Checked = false;
                    iC821ToolStripMenuItem.Checked = false;
                    iC910ToolStripMenuItem.Checked = false;
                    iC970ToolStripMenuItem.Checked = false;
                    iCX3ToolStripMenuItem.Checked = false;
                    iD1ToolStripMenuItem.Checked = false;
                    break;
                case 188:
                    iC1271ToolStripMenuItem.Checked = false;
                    iC1275ToolStripMenuItem.Checked = false;
                    iC271ToolStripMenuItem.Checked = false;
                    iC275ToolStripMenuItem.Checked = false;
                    iC375ToolStripMenuItem.Checked = false;
                    iC471ToolStripMenuItem.Checked = false;
                    iC475ToolStripMenuItem.Checked = false;
                    iC575ToolStripMenu.Checked = false;
                    iC7000ToolStripMenuItem.Checked = false;
                    iC703ToolStripMenuItem.Checked = false;
                    iC706MkIIGToolStripMenuItem.Checked = false;
                    iC706MkIIToolStripMenuItem.Checked = false;
                    iC706ToolStripMenuItem.Checked = false;
                    iC707ToolStripMenuItem.Checked = false;
                    iC718ToolStripMenuItem.Checked = false;
                    iC7200ToolStripMenuItem.Checked = true;
                    iC725ToolStripMenuItem.Checked = false;
                    iC726ToolStripMenuItem.Checked = false;
                    iC728ToolStripMenuItem.Checked = false;
                    iC729ToolStripMenuItem.Checked = false;
                    iC735ToolStripMenuItem.Checked = false;
                    iC736ToolStripMenuItem.Checked = false;
                    iC737ToolStripMenuItem.Checked = false;
                    iC738ToolStripMenuItem.Checked = false;
                    iC7400ToolStripMenuItem.Checked = false;
                    iC746ToolStripMenuItem.Checked = false;
                    iC751AToolStripMenuItem.Checked = false;
                    iC756ProIIIToolStripMenuItem.Checked = false;
                    iC756ProIIToolStripMenuItem.Checked = false;
                    iC756ProToolStripMenuItem.Checked = false;
                    iC756ToolStripMenuItem.Checked = false;
                    iC761ToolStripMenuItem.Checked = false;
                    iC765ToolStripMenuItem.Checked = false;
                    iC7700ToolStripMenuItem.Checked = false;
                    iC775ToolStripMenuItem.Checked = false;
                    iC7800ToolStripMenuItem.Checked = false;
                    iC781ToolStripMenuItem.Checked = false;
                    iC78ToolStripMenuItem.Checked = false;
                    iC820ToolStripMenuItem.Checked = false;
                    iC821ToolStripMenuItem.Checked = false;
                    iC910ToolStripMenuItem.Checked = false;
                    iC970ToolStripMenuItem.Checked = false;
                    iCX3ToolStripMenuItem.Checked = false;
                    iD1ToolStripMenuItem.Checked = false;
                    break;
                case 40:
                    iC1271ToolStripMenuItem.Checked = false;
                    iC1275ToolStripMenuItem.Checked = false;
                    iC271ToolStripMenuItem.Checked = false;
                    iC275ToolStripMenuItem.Checked = false;
                    iC375ToolStripMenuItem.Checked = false;
                    iC471ToolStripMenuItem.Checked = false;
                    iC475ToolStripMenuItem.Checked = false;
                    iC575ToolStripMenu.Checked = false;
                    iC7000ToolStripMenuItem.Checked = false;
                    iC703ToolStripMenuItem.Checked = false;
                    iC706MkIIGToolStripMenuItem.Checked = false;
                    iC706MkIIToolStripMenuItem.Checked = false;
                    iC706ToolStripMenuItem.Checked = false;
                    iC707ToolStripMenuItem.Checked = false;
                    iC718ToolStripMenuItem.Checked = false;
                    iC7200ToolStripMenuItem.Checked = false;
                    iC725ToolStripMenuItem.Checked = true;
                    iC726ToolStripMenuItem.Checked = false;
                    iC728ToolStripMenuItem.Checked = false;
                    iC729ToolStripMenuItem.Checked = false;
                    iC735ToolStripMenuItem.Checked = false;
                    iC736ToolStripMenuItem.Checked = false;
                    iC737ToolStripMenuItem.Checked = false;
                    iC738ToolStripMenuItem.Checked = false;
                    iC7400ToolStripMenuItem.Checked = false;
                    iC746ToolStripMenuItem.Checked = false;
                    iC751AToolStripMenuItem.Checked = false;
                    iC756ProIIIToolStripMenuItem.Checked = false;
                    iC756ProIIToolStripMenuItem.Checked = false;
                    iC756ProToolStripMenuItem.Checked = false;
                    iC756ToolStripMenuItem.Checked = false;
                    iC761ToolStripMenuItem.Checked = false;
                    iC765ToolStripMenuItem.Checked = false;
                    iC7700ToolStripMenuItem.Checked = false;
                    iC775ToolStripMenuItem.Checked = false;
                    iC7800ToolStripMenuItem.Checked = false;
                    iC781ToolStripMenuItem.Checked = false;
                    iC78ToolStripMenuItem.Checked = false;
                    iC820ToolStripMenuItem.Checked = false;
                    iC821ToolStripMenuItem.Checked = false;
                    iC910ToolStripMenuItem.Checked = false;
                    iC970ToolStripMenuItem.Checked = false;
                    iCX3ToolStripMenuItem.Checked = false;
                    iD1ToolStripMenuItem.Checked = false;
                    break;
                case 48:
                    iC1271ToolStripMenuItem.Checked = false;
                    iC1275ToolStripMenuItem.Checked = false;
                    iC271ToolStripMenuItem.Checked = false;
                    iC275ToolStripMenuItem.Checked = false;
                    iC375ToolStripMenuItem.Checked = false;
                    iC471ToolStripMenuItem.Checked = false;
                    iC475ToolStripMenuItem.Checked = false;
                    iC575ToolStripMenu.Checked = false;
                    iC7000ToolStripMenuItem.Checked = false;
                    iC703ToolStripMenuItem.Checked = false;
                    iC706MkIIGToolStripMenuItem.Checked = false;
                    iC706MkIIToolStripMenuItem.Checked = false;
                    iC706ToolStripMenuItem.Checked = false;
                    iC707ToolStripMenuItem.Checked = false;
                    iC718ToolStripMenuItem.Checked = false;
                    iC7200ToolStripMenuItem.Checked = false;
                    iC725ToolStripMenuItem.Checked = false;
                    iC726ToolStripMenuItem.Checked = true;
                    iC728ToolStripMenuItem.Checked = false;
                    iC729ToolStripMenuItem.Checked = false;
                    iC735ToolStripMenuItem.Checked = false;
                    iC736ToolStripMenuItem.Checked = false;
                    iC737ToolStripMenuItem.Checked = false;
                    iC738ToolStripMenuItem.Checked = false;
                    iC7400ToolStripMenuItem.Checked = false;
                    iC746ToolStripMenuItem.Checked = false;
                    iC751AToolStripMenuItem.Checked = false;
                    iC756ProIIIToolStripMenuItem.Checked = false;
                    iC756ProIIToolStripMenuItem.Checked = false;
                    iC756ProToolStripMenuItem.Checked = false;
                    iC756ToolStripMenuItem.Checked = false;
                    iC761ToolStripMenuItem.Checked = false;
                    iC765ToolStripMenuItem.Checked = false;
                    iC7700ToolStripMenuItem.Checked = false;
                    iC775ToolStripMenuItem.Checked = false;
                    iC7800ToolStripMenuItem.Checked = false;
                    iC781ToolStripMenuItem.Checked = false;
                    iC78ToolStripMenuItem.Checked = false;
                    iC820ToolStripMenuItem.Checked = false;
                    iC821ToolStripMenuItem.Checked = false;
                    iC910ToolStripMenuItem.Checked = false;
                    iC970ToolStripMenuItem.Checked = false;
                    iCX3ToolStripMenuItem.Checked = false;
                    iD1ToolStripMenuItem.Checked = false;
                    break;
                case 56:
                    iC1271ToolStripMenuItem.Checked = false;
                    iC1275ToolStripMenuItem.Checked = false;
                    iC271ToolStripMenuItem.Checked = false;
                    iC275ToolStripMenuItem.Checked = false;
                    iC375ToolStripMenuItem.Checked = false;
                    iC471ToolStripMenuItem.Checked = false;
                    iC475ToolStripMenuItem.Checked = false;
                    iC575ToolStripMenu.Checked = false;
                    iC7000ToolStripMenuItem.Checked = false;
                    iC703ToolStripMenuItem.Checked = false;
                    iC706MkIIGToolStripMenuItem.Checked = false;
                    iC706MkIIToolStripMenuItem.Checked = false;
                    iC706ToolStripMenuItem.Checked = false;
                    iC707ToolStripMenuItem.Checked = false;
                    iC718ToolStripMenuItem.Checked = false;
                    iC7200ToolStripMenuItem.Checked = false;
                    iC725ToolStripMenuItem.Checked = false;
                    iC726ToolStripMenuItem.Checked = false;
                    iC728ToolStripMenuItem.Checked = true;
                    iC729ToolStripMenuItem.Checked = false;
                    iC735ToolStripMenuItem.Checked = false;
                    iC736ToolStripMenuItem.Checked = false;
                    iC737ToolStripMenuItem.Checked = false;
                    iC738ToolStripMenuItem.Checked = false;
                    iC7400ToolStripMenuItem.Checked = false;
                    iC746ToolStripMenuItem.Checked = false;
                    iC751AToolStripMenuItem.Checked = false;
                    iC756ProIIIToolStripMenuItem.Checked = false;
                    iC756ProIIToolStripMenuItem.Checked = false;
                    iC756ProToolStripMenuItem.Checked = false;
                    iC756ToolStripMenuItem.Checked = false;
                    iC761ToolStripMenuItem.Checked = false;
                    iC765ToolStripMenuItem.Checked = false;
                    iC7700ToolStripMenuItem.Checked = false;
                    iC775ToolStripMenuItem.Checked = false;
                    iC7800ToolStripMenuItem.Checked = false;
                    iC781ToolStripMenuItem.Checked = false;
                    iC78ToolStripMenuItem.Checked = false;
                    iC820ToolStripMenuItem.Checked = false;
                    iC821ToolStripMenuItem.Checked = false;
                    iC910ToolStripMenuItem.Checked = false;
                    iC970ToolStripMenuItem.Checked = false;
                    iCX3ToolStripMenuItem.Checked = false;
                    iD1ToolStripMenuItem.Checked = false;
                    break;
                case 58:
                    iC1271ToolStripMenuItem.Checked = false;
                    iC1275ToolStripMenuItem.Checked = false;
                    iC271ToolStripMenuItem.Checked = false;
                    iC275ToolStripMenuItem.Checked = false;
                    iC375ToolStripMenuItem.Checked = false;
                    iC471ToolStripMenuItem.Checked = false;
                    iC475ToolStripMenuItem.Checked = false;
                    iC575ToolStripMenu.Checked = false;
                    iC7000ToolStripMenuItem.Checked = false;
                    iC703ToolStripMenuItem.Checked = false;
                    iC706MkIIGToolStripMenuItem.Checked = false;
                    iC706MkIIToolStripMenuItem.Checked = false;
                    iC706ToolStripMenuItem.Checked = false;
                    iC707ToolStripMenuItem.Checked = false;
                    iC718ToolStripMenuItem.Checked = false;
                    iC7200ToolStripMenuItem.Checked = false;
                    iC725ToolStripMenuItem.Checked = false;
                    iC726ToolStripMenuItem.Checked = false;
                    iC728ToolStripMenuItem.Checked = false;
                    iC729ToolStripMenuItem.Checked = true;
                    iC735ToolStripMenuItem.Checked = false;
                    iC736ToolStripMenuItem.Checked = false;
                    iC737ToolStripMenuItem.Checked = false;
                    iC738ToolStripMenuItem.Checked = false;
                    iC7400ToolStripMenuItem.Checked = false;
                    iC746ToolStripMenuItem.Checked = false;
                    iC751AToolStripMenuItem.Checked = false;
                    iC756ProIIIToolStripMenuItem.Checked = false;
                    iC756ProIIToolStripMenuItem.Checked = false;
                    iC756ProToolStripMenuItem.Checked = false;
                    iC756ToolStripMenuItem.Checked = false;
                    iC761ToolStripMenuItem.Checked = false;
                    iC765ToolStripMenuItem.Checked = false;
                    iC7700ToolStripMenuItem.Checked = false;
                    iC775ToolStripMenuItem.Checked = false;
                    iC7800ToolStripMenuItem.Checked = false;
                    iC781ToolStripMenuItem.Checked = false;
                    iC78ToolStripMenuItem.Checked = false;
                    iC820ToolStripMenuItem.Checked = false;
                    iC821ToolStripMenuItem.Checked = false;
                    iC910ToolStripMenuItem.Checked = false;
                    iC970ToolStripMenuItem.Checked = false;
                    iCX3ToolStripMenuItem.Checked = false;
                    iD1ToolStripMenuItem.Checked = false;
                    break;
                case 4:
                    iC1271ToolStripMenuItem.Checked = false;
                    iC1275ToolStripMenuItem.Checked = false;
                    iC271ToolStripMenuItem.Checked = false;
                    iC275ToolStripMenuItem.Checked = false;
                    iC375ToolStripMenuItem.Checked = false;
                    iC471ToolStripMenuItem.Checked = false;
                    iC475ToolStripMenuItem.Checked = false;
                    iC575ToolStripMenu.Checked = false;
                    iC7000ToolStripMenuItem.Checked = false;
                    iC703ToolStripMenuItem.Checked = false;
                    iC706MkIIGToolStripMenuItem.Checked = false;
                    iC706MkIIToolStripMenuItem.Checked = false;
                    iC706ToolStripMenuItem.Checked = false;
                    iC707ToolStripMenuItem.Checked = false;
                    iC718ToolStripMenuItem.Checked = false;
                    iC7200ToolStripMenuItem.Checked = false;
                    iC725ToolStripMenuItem.Checked = false;
                    iC726ToolStripMenuItem.Checked = false;
                    iC728ToolStripMenuItem.Checked = false;
                    iC729ToolStripMenuItem.Checked = false;
                    iC735ToolStripMenuItem.Checked = true;
                    iC736ToolStripMenuItem.Checked = false;
                    iC737ToolStripMenuItem.Checked = false;
                    iC738ToolStripMenuItem.Checked = false;
                    iC7400ToolStripMenuItem.Checked = false;
                    iC746ToolStripMenuItem.Checked = false;
                    iC751AToolStripMenuItem.Checked = false;
                    iC756ProIIIToolStripMenuItem.Checked = false;
                    iC756ProIIToolStripMenuItem.Checked = false;
                    iC756ProToolStripMenuItem.Checked = false;
                    iC756ToolStripMenuItem.Checked = false;
                    iC761ToolStripMenuItem.Checked = false;
                    iC765ToolStripMenuItem.Checked = false;
                    iC7700ToolStripMenuItem.Checked = false;
                    iC775ToolStripMenuItem.Checked = false;
                    iC7800ToolStripMenuItem.Checked = false;
                    iC781ToolStripMenuItem.Checked = false;
                    iC78ToolStripMenuItem.Checked = false;
                    iC820ToolStripMenuItem.Checked = false;
                    iC821ToolStripMenuItem.Checked = false;
                    iC910ToolStripMenuItem.Checked = false;
                    iC970ToolStripMenuItem.Checked = false;
                    iCX3ToolStripMenuItem.Checked = false;
                    iD1ToolStripMenuItem.Checked = false;
                    break;
                case 64:
                    iC1271ToolStripMenuItem.Checked = false;
                    iC1275ToolStripMenuItem.Checked = false;
                    iC271ToolStripMenuItem.Checked = false;
                    iC275ToolStripMenuItem.Checked = false;
                    iC375ToolStripMenuItem.Checked = false;
                    iC471ToolStripMenuItem.Checked = false;
                    iC475ToolStripMenuItem.Checked = false;
                    iC575ToolStripMenu.Checked = false;
                    iC7000ToolStripMenuItem.Checked = false;
                    iC703ToolStripMenuItem.Checked = false;
                    iC706MkIIGToolStripMenuItem.Checked = false;
                    iC706MkIIToolStripMenuItem.Checked = false;
                    iC706ToolStripMenuItem.Checked = false;
                    iC707ToolStripMenuItem.Checked = false;
                    iC718ToolStripMenuItem.Checked = false;
                    iC7200ToolStripMenuItem.Checked = false;
                    iC725ToolStripMenuItem.Checked = false;
                    iC726ToolStripMenuItem.Checked = false;
                    iC728ToolStripMenuItem.Checked = false;
                    iC729ToolStripMenuItem.Checked = false;
                    iC735ToolStripMenuItem.Checked = false;
                    iC736ToolStripMenuItem.Checked = true;
                    iC737ToolStripMenuItem.Checked = false;
                    iC738ToolStripMenuItem.Checked = false;
                    iC7400ToolStripMenuItem.Checked = false;
                    iC746ToolStripMenuItem.Checked = false;
                    iC751AToolStripMenuItem.Checked = false;
                    iC756ProIIIToolStripMenuItem.Checked = false;
                    iC756ProIIToolStripMenuItem.Checked = false;
                    iC756ProToolStripMenuItem.Checked = false;
                    iC756ToolStripMenuItem.Checked = false;
                    iC761ToolStripMenuItem.Checked = false;
                    iC765ToolStripMenuItem.Checked = false;
                    iC7700ToolStripMenuItem.Checked = false;
                    iC775ToolStripMenuItem.Checked = false;
                    iC7800ToolStripMenuItem.Checked = false;
                    iC781ToolStripMenuItem.Checked = false;
                    iC78ToolStripMenuItem.Checked = false;
                    iC820ToolStripMenuItem.Checked = false;
                    iC821ToolStripMenuItem.Checked = false;
                    iC910ToolStripMenuItem.Checked = false;
                    iC970ToolStripMenuItem.Checked = false;
                    iCX3ToolStripMenuItem.Checked = false;
                    iD1ToolStripMenuItem.Checked = false;
                    break;
                case 60:
                    iC1271ToolStripMenuItem.Checked = false;
                    iC1275ToolStripMenuItem.Checked = false;
                    iC271ToolStripMenuItem.Checked = false;
                    iC275ToolStripMenuItem.Checked = false;
                    iC375ToolStripMenuItem.Checked = false;
                    iC471ToolStripMenuItem.Checked = false;
                    iC475ToolStripMenuItem.Checked = false;
                    iC575ToolStripMenu.Checked = false;
                    iC7000ToolStripMenuItem.Checked = false;
                    iC703ToolStripMenuItem.Checked = false;
                    iC706MkIIGToolStripMenuItem.Checked = false;
                    iC706MkIIToolStripMenuItem.Checked = false;
                    iC706ToolStripMenuItem.Checked = false;
                    iC707ToolStripMenuItem.Checked = false;
                    iC718ToolStripMenuItem.Checked = false;
                    iC7200ToolStripMenuItem.Checked = false;
                    iC725ToolStripMenuItem.Checked = false;
                    iC726ToolStripMenuItem.Checked = false;
                    iC728ToolStripMenuItem.Checked = false;
                    iC729ToolStripMenuItem.Checked = false;
                    iC735ToolStripMenuItem.Checked = false;
                    iC736ToolStripMenuItem.Checked = false;
                    iC737ToolStripMenuItem.Checked = true;
                    iC738ToolStripMenuItem.Checked = false;
                    iC7400ToolStripMenuItem.Checked = false;
                    iC746ToolStripMenuItem.Checked = false;
                    iC751AToolStripMenuItem.Checked = false;
                    iC756ProIIIToolStripMenuItem.Checked = false;
                    iC756ProIIToolStripMenuItem.Checked = false;
                    iC756ProToolStripMenuItem.Checked = false;
                    iC756ToolStripMenuItem.Checked = false;
                    iC761ToolStripMenuItem.Checked = false;
                    iC765ToolStripMenuItem.Checked = false;
                    iC7700ToolStripMenuItem.Checked = false;
                    iC775ToolStripMenuItem.Checked = false;
                    iC7800ToolStripMenuItem.Checked = false;
                    iC781ToolStripMenuItem.Checked = false;
                    iC78ToolStripMenuItem.Checked = false;
                    iC820ToolStripMenuItem.Checked = false;
                    iC821ToolStripMenuItem.Checked = false;
                    iC910ToolStripMenuItem.Checked = false;
                    iC970ToolStripMenuItem.Checked = false;
                    iCX3ToolStripMenuItem.Checked = false;
                    iD1ToolStripMenuItem.Checked = false;
                    break;
                case 68:
                    iC1271ToolStripMenuItem.Checked = false;
                    iC1275ToolStripMenuItem.Checked = false;
                    iC271ToolStripMenuItem.Checked = false;
                    iC275ToolStripMenuItem.Checked = false;
                    iC375ToolStripMenuItem.Checked = false;
                    iC471ToolStripMenuItem.Checked = false;
                    iC475ToolStripMenuItem.Checked = false;
                    iC575ToolStripMenu.Checked = false;
                    iC7000ToolStripMenuItem.Checked = false;
                    iC703ToolStripMenuItem.Checked = false;
                    iC706MkIIGToolStripMenuItem.Checked = false;
                    iC706MkIIToolStripMenuItem.Checked = false;
                    iC706ToolStripMenuItem.Checked = false;
                    iC707ToolStripMenuItem.Checked = false;
                    iC718ToolStripMenuItem.Checked = false;
                    iC7200ToolStripMenuItem.Checked = false;
                    iC725ToolStripMenuItem.Checked = false;
                    iC726ToolStripMenuItem.Checked = false;
                    iC728ToolStripMenuItem.Checked = false;
                    iC729ToolStripMenuItem.Checked = false;
                    iC735ToolStripMenuItem.Checked = false;
                    iC736ToolStripMenuItem.Checked = false;
                    iC737ToolStripMenuItem.Checked = false;
                    iC738ToolStripMenuItem.Checked = true;
                    iC7400ToolStripMenuItem.Checked = false;
                    iC746ToolStripMenuItem.Checked = false;
                    iC751AToolStripMenuItem.Checked = false;
                    iC756ProIIIToolStripMenuItem.Checked = false;
                    iC756ProIIToolStripMenuItem.Checked = false;
                    iC756ProToolStripMenuItem.Checked = false;
                    iC756ToolStripMenuItem.Checked = false;
                    iC761ToolStripMenuItem.Checked = false;
                    iC765ToolStripMenuItem.Checked = false;
                    iC7700ToolStripMenuItem.Checked = false;
                    iC775ToolStripMenuItem.Checked = false;
                    iC7800ToolStripMenuItem.Checked = false;
                    iC781ToolStripMenuItem.Checked = false;
                    iC78ToolStripMenuItem.Checked = false;
                    iC820ToolStripMenuItem.Checked = false;
                    iC821ToolStripMenuItem.Checked = false;
                    iC910ToolStripMenuItem.Checked = false;
                    iC970ToolStripMenuItem.Checked = false;
                    iCX3ToolStripMenuItem.Checked = false;
                    iD1ToolStripMenuItem.Checked = false;
                    break;
                case 102:
                    iC1271ToolStripMenuItem.Checked = false;
                    iC1275ToolStripMenuItem.Checked = false;
                    iC271ToolStripMenuItem.Checked = false;
                    iC275ToolStripMenuItem.Checked = false;
                    iC375ToolStripMenuItem.Checked = false;
                    iC471ToolStripMenuItem.Checked = false;
                    iC475ToolStripMenuItem.Checked = false;
                    iC575ToolStripMenu.Checked = false;
                    iC7000ToolStripMenuItem.Checked = false;
                    iC703ToolStripMenuItem.Checked = false;
                    iC706MkIIGToolStripMenuItem.Checked = false;
                    iC706MkIIToolStripMenuItem.Checked = false;
                    iC706ToolStripMenuItem.Checked = false;
                    iC707ToolStripMenuItem.Checked = false;
                    iC718ToolStripMenuItem.Checked = false;
                    iC7200ToolStripMenuItem.Checked = false;
                    iC725ToolStripMenuItem.Checked = false;
                    iC726ToolStripMenuItem.Checked = false;
                    iC728ToolStripMenuItem.Checked = false;
                    iC729ToolStripMenuItem.Checked = false;
                    iC735ToolStripMenuItem.Checked = false;
                    iC736ToolStripMenuItem.Checked = false;
                    iC737ToolStripMenuItem.Checked = false;
                    iC738ToolStripMenuItem.Checked = false;
                    iC7400ToolStripMenuItem.Checked = false;
                    iC746ToolStripMenuItem.Checked = false;
                    iC751AToolStripMenuItem.Checked = false;
                    iC756ProIIIToolStripMenuItem.Checked = false;
                    iC756ProIIToolStripMenuItem.Checked = false;
                    iC756ProToolStripMenuItem.Checked = false;
                    iC756ToolStripMenuItem.Checked = false;
                    iC761ToolStripMenuItem.Checked = false;
                    iC765ToolStripMenuItem.Checked = false;
                    iC7700ToolStripMenuItem.Checked = false;
                    iC775ToolStripMenuItem.Checked = false;
                    iC7800ToolStripMenuItem.Checked = false;
                    iC781ToolStripMenuItem.Checked = false;
                    iC78ToolStripMenuItem.Checked = false;
                    iC820ToolStripMenuItem.Checked = false;
                    iC821ToolStripMenuItem.Checked = false;
                    iC910ToolStripMenuItem.Checked = false;
                    iC970ToolStripMenuItem.Checked = false;
                    iCX3ToolStripMenuItem.Checked = false;
                    iD1ToolStripMenuItem.Checked = false;
                    break;
                case 86:
                    iC1271ToolStripMenuItem.Checked = false;
                    iC1275ToolStripMenuItem.Checked = false;
                    iC271ToolStripMenuItem.Checked = false;
                    iC275ToolStripMenuItem.Checked = false;
                    iC375ToolStripMenuItem.Checked = false;
                    iC471ToolStripMenuItem.Checked = false;
                    iC475ToolStripMenuItem.Checked = false;
                    iC575ToolStripMenu.Checked = false;
                    iC7000ToolStripMenuItem.Checked = false;
                    iC703ToolStripMenuItem.Checked = false;
                    iC706MkIIGToolStripMenuItem.Checked = false;
                    iC706MkIIToolStripMenuItem.Checked = false;
                    iC706ToolStripMenuItem.Checked = false;
                    iC707ToolStripMenuItem.Checked = false;
                    iC718ToolStripMenuItem.Checked = false;
                    iC7200ToolStripMenuItem.Checked = false;
                    iC725ToolStripMenuItem.Checked = false;
                    iC726ToolStripMenuItem.Checked = false;
                    iC728ToolStripMenuItem.Checked = false;
                    iC729ToolStripMenuItem.Checked = false;
                    iC735ToolStripMenuItem.Checked = false;
                    iC736ToolStripMenuItem.Checked = false;
                    iC737ToolStripMenuItem.Checked = false;
                    iC738ToolStripMenuItem.Checked = false;
                    iC7400ToolStripMenuItem.Checked = false;
                    iC746ToolStripMenuItem.Checked = true;
                    iC751AToolStripMenuItem.Checked = false;
                    iC756ProIIIToolStripMenuItem.Checked = false;
                    iC756ProIIToolStripMenuItem.Checked = false;
                    iC756ProToolStripMenuItem.Checked = false;
                    iC756ToolStripMenuItem.Checked = false;
                    iC761ToolStripMenuItem.Checked = false;
                    iC765ToolStripMenuItem.Checked = false;
                    iC7700ToolStripMenuItem.Checked = false;
                    iC775ToolStripMenuItem.Checked = false;
                    iC7800ToolStripMenuItem.Checked = false;
                    iC781ToolStripMenuItem.Checked = false;
                    iC78ToolStripMenuItem.Checked = false;
                    iC820ToolStripMenuItem.Checked = false;
                    iC821ToolStripMenuItem.Checked = false;
                    iC910ToolStripMenuItem.Checked = false;
                    iC970ToolStripMenuItem.Checked = false;
                    iCX3ToolStripMenuItem.Checked = false;
                    iD1ToolStripMenuItem.Checked = false;
                    break;
                case 28:
                    iC1271ToolStripMenuItem.Checked = false;
                    iC1275ToolStripMenuItem.Checked = false;
                    iC271ToolStripMenuItem.Checked = false;
                    iC275ToolStripMenuItem.Checked = false;
                    iC375ToolStripMenuItem.Checked = false;
                    iC471ToolStripMenuItem.Checked = false;
                    iC475ToolStripMenuItem.Checked = false;
                    iC575ToolStripMenu.Checked = false;
                    iC7000ToolStripMenuItem.Checked = false;
                    iC703ToolStripMenuItem.Checked = false;
                    iC706MkIIGToolStripMenuItem.Checked = false;
                    iC706MkIIToolStripMenuItem.Checked = false;
                    iC706ToolStripMenuItem.Checked = false;
                    iC707ToolStripMenuItem.Checked = false;
                    iC718ToolStripMenuItem.Checked = false;
                    iC7200ToolStripMenuItem.Checked = false;
                    iC725ToolStripMenuItem.Checked = false;
                    iC726ToolStripMenuItem.Checked = false;
                    iC728ToolStripMenuItem.Checked = false;
                    iC729ToolStripMenuItem.Checked = false;
                    iC735ToolStripMenuItem.Checked = false;
                    iC736ToolStripMenuItem.Checked = false;
                    iC737ToolStripMenuItem.Checked = false;
                    iC738ToolStripMenuItem.Checked = false;
                    iC7400ToolStripMenuItem.Checked = false;
                    iC746ToolStripMenuItem.Checked = false;
                    iC751AToolStripMenuItem.Checked = true;
                    iC756ProIIIToolStripMenuItem.Checked = false;
                    iC756ProIIToolStripMenuItem.Checked = false;
                    iC756ProToolStripMenuItem.Checked = false;
                    iC756ToolStripMenuItem.Checked = false;
                    iC761ToolStripMenuItem.Checked = false;
                    iC765ToolStripMenuItem.Checked = false;
                    iC7700ToolStripMenuItem.Checked = false;
                    iC775ToolStripMenuItem.Checked = false;
                    iC7800ToolStripMenuItem.Checked = false;
                    iC781ToolStripMenuItem.Checked = false;
                    iC78ToolStripMenuItem.Checked = false;
                    iC820ToolStripMenuItem.Checked = false;
                    iC821ToolStripMenuItem.Checked = false;
                    iC910ToolStripMenuItem.Checked = false;
                    iC970ToolStripMenuItem.Checked = false;
                    iCX3ToolStripMenuItem.Checked = false;
                    iD1ToolStripMenuItem.Checked = false;
                    break;
                case 110:
                    iC1271ToolStripMenuItem.Checked = false;
                    iC1275ToolStripMenuItem.Checked = false;
                    iC271ToolStripMenuItem.Checked = false;
                    iC275ToolStripMenuItem.Checked = false;
                    iC375ToolStripMenuItem.Checked = false;
                    iC471ToolStripMenuItem.Checked = false;
                    iC475ToolStripMenuItem.Checked = false;
                    iC575ToolStripMenu.Checked = false;
                    iC7000ToolStripMenuItem.Checked = false;
                    iC703ToolStripMenuItem.Checked = false;
                    iC706MkIIGToolStripMenuItem.Checked = false;
                    iC706MkIIToolStripMenuItem.Checked = false;
                    iC706ToolStripMenuItem.Checked = false;
                    iC707ToolStripMenuItem.Checked = false;
                    iC718ToolStripMenuItem.Checked = false;
                    iC7200ToolStripMenuItem.Checked = false;
                    iC725ToolStripMenuItem.Checked = false;
                    iC726ToolStripMenuItem.Checked = false;
                    iC728ToolStripMenuItem.Checked = false;
                    iC729ToolStripMenuItem.Checked = false;
                    iC735ToolStripMenuItem.Checked = false;
                    iC736ToolStripMenuItem.Checked = false;
                    iC737ToolStripMenuItem.Checked = false;
                    iC738ToolStripMenuItem.Checked = false;
                    iC7400ToolStripMenuItem.Checked = false;
                    iC746ToolStripMenuItem.Checked = false;
                    iC751AToolStripMenuItem.Checked = false;
                    iC756ProIIIToolStripMenuItem.Checked = true;
                    iC756ProIIToolStripMenuItem.Checked = false;
                    iC756ProToolStripMenuItem.Checked = false;
                    iC756ToolStripMenuItem.Checked = false;
                    iC761ToolStripMenuItem.Checked = false;
                    iC765ToolStripMenuItem.Checked = false;
                    iC7700ToolStripMenuItem.Checked = false;
                    iC775ToolStripMenuItem.Checked = false;
                    iC7800ToolStripMenuItem.Checked = false;
                    iC781ToolStripMenuItem.Checked = false;
                    iC78ToolStripMenuItem.Checked = false;
                    iC820ToolStripMenuItem.Checked = false;
                    iC821ToolStripMenuItem.Checked = false;
                    iC910ToolStripMenuItem.Checked = false;
                    iC970ToolStripMenuItem.Checked = false;
                    iCX3ToolStripMenuItem.Checked = false;
                    iD1ToolStripMenuItem.Checked = false;
                    break;
                case 100:
                    iC1271ToolStripMenuItem.Checked = false;
                    iC1275ToolStripMenuItem.Checked = false;
                    iC271ToolStripMenuItem.Checked = false;
                    iC275ToolStripMenuItem.Checked = false;
                    iC375ToolStripMenuItem.Checked = false;
                    iC471ToolStripMenuItem.Checked = false;
                    iC475ToolStripMenuItem.Checked = false;
                    iC575ToolStripMenu.Checked = false;
                    iC7000ToolStripMenuItem.Checked = false;
                    iC703ToolStripMenuItem.Checked = false;
                    iC706MkIIGToolStripMenuItem.Checked = false;
                    iC706MkIIToolStripMenuItem.Checked = false;
                    iC706ToolStripMenuItem.Checked = false;
                    iC707ToolStripMenuItem.Checked = false;
                    iC718ToolStripMenuItem.Checked = false;
                    iC7200ToolStripMenuItem.Checked = false;
                    iC725ToolStripMenuItem.Checked = false;
                    iC726ToolStripMenuItem.Checked = false;
                    iC728ToolStripMenuItem.Checked = false;
                    iC729ToolStripMenuItem.Checked = false;
                    iC735ToolStripMenuItem.Checked = false;
                    iC736ToolStripMenuItem.Checked = false;
                    iC737ToolStripMenuItem.Checked = false;
                    iC738ToolStripMenuItem.Checked = false;
                    iC7400ToolStripMenuItem.Checked = false;
                    iC746ToolStripMenuItem.Checked = false;
                    iC751AToolStripMenuItem.Checked = false;
                    iC756ProIIIToolStripMenuItem.Checked = false;
                    iC756ProIIToolStripMenuItem.Checked = true;
                    iC756ProToolStripMenuItem.Checked = false;
                    iC756ToolStripMenuItem.Checked = false;
                    iC761ToolStripMenuItem.Checked = false;
                    iC765ToolStripMenuItem.Checked = false;
                    iC7700ToolStripMenuItem.Checked = false;
                    iC775ToolStripMenuItem.Checked = false;
                    iC7800ToolStripMenuItem.Checked = false;
                    iC781ToolStripMenuItem.Checked = false;
                    iC78ToolStripMenuItem.Checked = false;
                    iC820ToolStripMenuItem.Checked = false;
                    iC821ToolStripMenuItem.Checked = false;
                    iC910ToolStripMenuItem.Checked = false;
                    iC970ToolStripMenuItem.Checked = false;
                    iCX3ToolStripMenuItem.Checked = false;
                    iD1ToolStripMenuItem.Checked = false;
                    break;
                case 92:
                    iC1271ToolStripMenuItem.Checked = false;
                    iC1275ToolStripMenuItem.Checked = false;
                    iC271ToolStripMenuItem.Checked = false;
                    iC275ToolStripMenuItem.Checked = false;
                    iC375ToolStripMenuItem.Checked = false;
                    iC471ToolStripMenuItem.Checked = false;
                    iC475ToolStripMenuItem.Checked = false;
                    iC575ToolStripMenu.Checked = false;
                    iC7000ToolStripMenuItem.Checked = false;
                    iC703ToolStripMenuItem.Checked = false;
                    iC706MkIIGToolStripMenuItem.Checked = false;
                    iC706MkIIToolStripMenuItem.Checked = false;
                    iC706ToolStripMenuItem.Checked = false;
                    iC707ToolStripMenuItem.Checked = false;
                    iC718ToolStripMenuItem.Checked = false;
                    iC7200ToolStripMenuItem.Checked = false;
                    iC725ToolStripMenuItem.Checked = false;
                    iC726ToolStripMenuItem.Checked = false;
                    iC728ToolStripMenuItem.Checked = false;
                    iC729ToolStripMenuItem.Checked = false;
                    iC735ToolStripMenuItem.Checked = false;
                    iC736ToolStripMenuItem.Checked = false;
                    iC737ToolStripMenuItem.Checked = false;
                    iC738ToolStripMenuItem.Checked = false;
                    iC7400ToolStripMenuItem.Checked = false;
                    iC746ToolStripMenuItem.Checked = false;
                    iC751AToolStripMenuItem.Checked = false;
                    iC756ProIIIToolStripMenuItem.Checked = false;
                    iC756ProIIToolStripMenuItem.Checked = false;
                    iC756ProToolStripMenuItem.Checked = true;
                    iC756ToolStripMenuItem.Checked = false;
                    iC761ToolStripMenuItem.Checked = false;
                    iC765ToolStripMenuItem.Checked = false;
                    iC7700ToolStripMenuItem.Checked = false;
                    iC775ToolStripMenuItem.Checked = false;
                    iC7800ToolStripMenuItem.Checked = false;
                    iC781ToolStripMenuItem.Checked = false;
                    iC78ToolStripMenuItem.Checked = false;
                    iC820ToolStripMenuItem.Checked = false;
                    iC821ToolStripMenuItem.Checked = false;
                    iC910ToolStripMenuItem.Checked = false;
                    iC970ToolStripMenuItem.Checked = false;
                    iCX3ToolStripMenuItem.Checked = false;
                    iD1ToolStripMenuItem.Checked = false;
                    break;
                case 80:
                    iC1271ToolStripMenuItem.Checked = false;
                    iC1275ToolStripMenuItem.Checked = false;
                    iC271ToolStripMenuItem.Checked = false;
                    iC275ToolStripMenuItem.Checked = false;
                    iC375ToolStripMenuItem.Checked = false;
                    iC471ToolStripMenuItem.Checked = false;
                    iC475ToolStripMenuItem.Checked = false;
                    iC575ToolStripMenu.Checked = false;
                    iC7000ToolStripMenuItem.Checked = false;
                    iC703ToolStripMenuItem.Checked = false;
                    iC706MkIIGToolStripMenuItem.Checked = false;
                    iC706MkIIToolStripMenuItem.Checked = false;
                    iC706ToolStripMenuItem.Checked = false;
                    iC707ToolStripMenuItem.Checked = false;
                    iC718ToolStripMenuItem.Checked = false;
                    iC7200ToolStripMenuItem.Checked = false;
                    iC725ToolStripMenuItem.Checked = false;
                    iC726ToolStripMenuItem.Checked = false;
                    iC728ToolStripMenuItem.Checked = false;
                    iC729ToolStripMenuItem.Checked = false;
                    iC735ToolStripMenuItem.Checked = false;
                    iC736ToolStripMenuItem.Checked = false;
                    iC737ToolStripMenuItem.Checked = false;
                    iC738ToolStripMenuItem.Checked = false;
                    iC7400ToolStripMenuItem.Checked = false;
                    iC746ToolStripMenuItem.Checked = false;
                    iC751AToolStripMenuItem.Checked = false;
                    iC756ProIIIToolStripMenuItem.Checked = false;
                    iC756ProIIToolStripMenuItem.Checked = false;
                    iC756ProToolStripMenuItem.Checked = false;
                    iC756ToolStripMenuItem.Checked = true;
                    iC761ToolStripMenuItem.Checked = false;
                    iC765ToolStripMenuItem.Checked = false;
                    iC7700ToolStripMenuItem.Checked = false;
                    iC775ToolStripMenuItem.Checked = false;
                    iC7800ToolStripMenuItem.Checked = false;
                    iC781ToolStripMenuItem.Checked = false;
                    iC78ToolStripMenuItem.Checked = false;
                    iC820ToolStripMenuItem.Checked = false;
                    iC821ToolStripMenuItem.Checked = false;
                    iC910ToolStripMenuItem.Checked = false;
                    iC970ToolStripMenuItem.Checked = false;
                    iCX3ToolStripMenuItem.Checked = false;
                    iD1ToolStripMenuItem.Checked = false;
                    break;
                case 30:
                    iC1271ToolStripMenuItem.Checked = false;
                    iC1275ToolStripMenuItem.Checked = false;
                    iC271ToolStripMenuItem.Checked = false;
                    iC275ToolStripMenuItem.Checked = false;
                    iC375ToolStripMenuItem.Checked = false;
                    iC471ToolStripMenuItem.Checked = false;
                    iC475ToolStripMenuItem.Checked = false;
                    iC575ToolStripMenu.Checked = false;
                    iC7000ToolStripMenuItem.Checked = false;
                    iC703ToolStripMenuItem.Checked = false;
                    iC706MkIIGToolStripMenuItem.Checked = false;
                    iC706MkIIToolStripMenuItem.Checked = false;
                    iC706ToolStripMenuItem.Checked = false;
                    iC707ToolStripMenuItem.Checked = false;
                    iC718ToolStripMenuItem.Checked = false;
                    iC7200ToolStripMenuItem.Checked = false;
                    iC725ToolStripMenuItem.Checked = false;
                    iC726ToolStripMenuItem.Checked = false;
                    iC728ToolStripMenuItem.Checked = false;
                    iC729ToolStripMenuItem.Checked = false;
                    iC735ToolStripMenuItem.Checked = false;
                    iC736ToolStripMenuItem.Checked = false;
                    iC737ToolStripMenuItem.Checked = false;
                    iC738ToolStripMenuItem.Checked = false;
                    iC7400ToolStripMenuItem.Checked = false;
                    iC746ToolStripMenuItem.Checked = false;
                    iC751AToolStripMenuItem.Checked = false;
                    iC756ProIIIToolStripMenuItem.Checked = false;
                    iC756ProIIToolStripMenuItem.Checked = false;
                    iC756ProToolStripMenuItem.Checked = false;
                    iC756ToolStripMenuItem.Checked = false;
                    iC761ToolStripMenuItem.Checked = true;
                    iC765ToolStripMenuItem.Checked = false;
                    iC7700ToolStripMenuItem.Checked = false;
                    iC775ToolStripMenuItem.Checked = false;
                    iC7800ToolStripMenuItem.Checked = false;
                    iC781ToolStripMenuItem.Checked = false;
                    iC78ToolStripMenuItem.Checked = false;
                    iC820ToolStripMenuItem.Checked = false;
                    iC821ToolStripMenuItem.Checked = false;
                    iC910ToolStripMenuItem.Checked = false;
                    iC970ToolStripMenuItem.Checked = false;
                    iCX3ToolStripMenuItem.Checked = false;
                    iD1ToolStripMenuItem.Checked = false;
                    break;
                case 44:
                    iC1271ToolStripMenuItem.Checked = false;
                    iC1275ToolStripMenuItem.Checked = false;
                    iC271ToolStripMenuItem.Checked = false;
                    iC275ToolStripMenuItem.Checked = false;
                    iC375ToolStripMenuItem.Checked = false;
                    iC471ToolStripMenuItem.Checked = false;
                    iC475ToolStripMenuItem.Checked = false;
                    iC575ToolStripMenu.Checked = false;
                    iC7000ToolStripMenuItem.Checked = false;
                    iC703ToolStripMenuItem.Checked = false;
                    iC706MkIIGToolStripMenuItem.Checked = false;
                    iC706MkIIToolStripMenuItem.Checked = false;
                    iC706ToolStripMenuItem.Checked = false;
                    iC707ToolStripMenuItem.Checked = false;
                    iC718ToolStripMenuItem.Checked = false;
                    iC7200ToolStripMenuItem.Checked = false;
                    iC725ToolStripMenuItem.Checked = false;
                    iC726ToolStripMenuItem.Checked = false;
                    iC728ToolStripMenuItem.Checked = false;
                    iC729ToolStripMenuItem.Checked = false;
                    iC735ToolStripMenuItem.Checked = false;
                    iC736ToolStripMenuItem.Checked = false;
                    iC737ToolStripMenuItem.Checked = false;
                    iC738ToolStripMenuItem.Checked = false;
                    iC7400ToolStripMenuItem.Checked = false;
                    iC746ToolStripMenuItem.Checked = false;
                    iC751AToolStripMenuItem.Checked = false;
                    iC756ProIIIToolStripMenuItem.Checked = false;
                    iC756ProIIToolStripMenuItem.Checked = false;
                    iC756ProToolStripMenuItem.Checked = false;
                    iC756ToolStripMenuItem.Checked = false;
                    iC761ToolStripMenuItem.Checked = false;
                    iC765ToolStripMenuItem.Checked = true;
                    iC7700ToolStripMenuItem.Checked = false;
                    iC775ToolStripMenuItem.Checked = false;
                    iC7800ToolStripMenuItem.Checked = false;
                    iC781ToolStripMenuItem.Checked = false;
                    iC78ToolStripMenuItem.Checked = false;
                    iC820ToolStripMenuItem.Checked = false;
                    iC821ToolStripMenuItem.Checked = false;
                    iC910ToolStripMenuItem.Checked = false;
                    iC970ToolStripMenuItem.Checked = false;
                    iCX3ToolStripMenuItem.Checked = false;
                    iD1ToolStripMenuItem.Checked = false;
                    break;
                case 116:
                    iC1271ToolStripMenuItem.Checked = false;
                    iC1275ToolStripMenuItem.Checked = false;
                    iC271ToolStripMenuItem.Checked = false;
                    iC275ToolStripMenuItem.Checked = false;
                    iC375ToolStripMenuItem.Checked = false;
                    iC471ToolStripMenuItem.Checked = false;
                    iC475ToolStripMenuItem.Checked = false;
                    iC575ToolStripMenu.Checked = false;
                    iC7000ToolStripMenuItem.Checked = false;
                    iC703ToolStripMenuItem.Checked = false;
                    iC706MkIIGToolStripMenuItem.Checked = false;
                    iC706MkIIToolStripMenuItem.Checked = false;
                    iC706ToolStripMenuItem.Checked = false;
                    iC707ToolStripMenuItem.Checked = false;
                    iC718ToolStripMenuItem.Checked = false;
                    iC7200ToolStripMenuItem.Checked = false;
                    iC725ToolStripMenuItem.Checked = false;
                    iC726ToolStripMenuItem.Checked = false;
                    iC728ToolStripMenuItem.Checked = false;
                    iC729ToolStripMenuItem.Checked = false;
                    iC735ToolStripMenuItem.Checked = false;
                    iC736ToolStripMenuItem.Checked = false;
                    iC737ToolStripMenuItem.Checked = false;
                    iC738ToolStripMenuItem.Checked = false;
                    iC7400ToolStripMenuItem.Checked = false;
                    iC746ToolStripMenuItem.Checked = false;
                    iC751AToolStripMenuItem.Checked = false;
                    iC756ProIIIToolStripMenuItem.Checked = false;
                    iC756ProIIToolStripMenuItem.Checked = false;
                    iC756ProToolStripMenuItem.Checked = false;
                    iC756ToolStripMenuItem.Checked = false;
                    iC761ToolStripMenuItem.Checked = false;
                    iC765ToolStripMenuItem.Checked = false;
                    iC7700ToolStripMenuItem.Checked = true;
                    iC775ToolStripMenuItem.Checked = false;
                    iC7800ToolStripMenuItem.Checked = false;
                    iC781ToolStripMenuItem.Checked = false;
                    iC78ToolStripMenuItem.Checked = false;
                    iC820ToolStripMenuItem.Checked = false;
                    iC821ToolStripMenuItem.Checked = false;
                    iC910ToolStripMenuItem.Checked = false;
                    iC970ToolStripMenuItem.Checked = false;
                    iCX3ToolStripMenuItem.Checked = false;
                    iD1ToolStripMenuItem.Checked = false;
                    break;
                case 70:
                    iC1271ToolStripMenuItem.Checked = false;
                    iC1275ToolStripMenuItem.Checked = false;
                    iC271ToolStripMenuItem.Checked = false;
                    iC275ToolStripMenuItem.Checked = false;
                    iC375ToolStripMenuItem.Checked = false;
                    iC471ToolStripMenuItem.Checked = false;
                    iC475ToolStripMenuItem.Checked = false;
                    iC575ToolStripMenu.Checked = false;
                    iC7000ToolStripMenuItem.Checked = false;
                    iC703ToolStripMenuItem.Checked = false;
                    iC706MkIIGToolStripMenuItem.Checked = false;
                    iC706MkIIToolStripMenuItem.Checked = false;
                    iC706ToolStripMenuItem.Checked = false;
                    iC707ToolStripMenuItem.Checked = false;
                    iC718ToolStripMenuItem.Checked = false;
                    iC7200ToolStripMenuItem.Checked = false;
                    iC725ToolStripMenuItem.Checked = false;
                    iC726ToolStripMenuItem.Checked = false;
                    iC728ToolStripMenuItem.Checked = false;
                    iC729ToolStripMenuItem.Checked = false;
                    iC735ToolStripMenuItem.Checked = false;
                    iC736ToolStripMenuItem.Checked = false;
                    iC737ToolStripMenuItem.Checked = false;
                    iC738ToolStripMenuItem.Checked = false;
                    iC7400ToolStripMenuItem.Checked = false;
                    iC746ToolStripMenuItem.Checked = false;
                    iC751AToolStripMenuItem.Checked = false;
                    iC756ProIIIToolStripMenuItem.Checked = false;
                    iC756ProIIToolStripMenuItem.Checked = false;
                    iC756ProToolStripMenuItem.Checked = false;
                    iC756ToolStripMenuItem.Checked = false;
                    iC761ToolStripMenuItem.Checked = false;
                    iC765ToolStripMenuItem.Checked = false;
                    iC7700ToolStripMenuItem.Checked = false;
                    iC775ToolStripMenuItem.Checked = true;
                    iC7800ToolStripMenuItem.Checked = false;
                    iC781ToolStripMenuItem.Checked = false;
                    iC78ToolStripMenuItem.Checked = false;
                    iC820ToolStripMenuItem.Checked = false;
                    iC821ToolStripMenuItem.Checked = false;
                    iC910ToolStripMenuItem.Checked = false;
                    iC970ToolStripMenuItem.Checked = false;
                    iCX3ToolStripMenuItem.Checked = false;
                    iD1ToolStripMenuItem.Checked = false;
                    break;
                case 106:
                    iC1271ToolStripMenuItem.Checked = false;
                    iC1275ToolStripMenuItem.Checked = false;
                    iC271ToolStripMenuItem.Checked = false;
                    iC275ToolStripMenuItem.Checked = false;
                    iC375ToolStripMenuItem.Checked = false;
                    iC471ToolStripMenuItem.Checked = false;
                    iC475ToolStripMenuItem.Checked = false;
                    iC575ToolStripMenu.Checked = false;
                    iC7000ToolStripMenuItem.Checked = false;
                    iC703ToolStripMenuItem.Checked = false;
                    iC706MkIIGToolStripMenuItem.Checked = false;
                    iC706MkIIToolStripMenuItem.Checked = false;
                    iC706ToolStripMenuItem.Checked = false;
                    iC707ToolStripMenuItem.Checked = false;
                    iC718ToolStripMenuItem.Checked = false;
                    iC7200ToolStripMenuItem.Checked = false;
                    iC725ToolStripMenuItem.Checked = false;
                    iC726ToolStripMenuItem.Checked = false;
                    iC728ToolStripMenuItem.Checked = false;
                    iC729ToolStripMenuItem.Checked = false;
                    iC735ToolStripMenuItem.Checked = false;
                    iC736ToolStripMenuItem.Checked = false;
                    iC737ToolStripMenuItem.Checked = false;
                    iC738ToolStripMenuItem.Checked = false;
                    iC7400ToolStripMenuItem.Checked = false;
                    iC746ToolStripMenuItem.Checked = false;
                    iC751AToolStripMenuItem.Checked = false;
                    iC756ProIIIToolStripMenuItem.Checked = false;
                    iC756ProIIToolStripMenuItem.Checked = false;
                    iC756ProToolStripMenuItem.Checked = false;
                    iC756ToolStripMenuItem.Checked = false;
                    iC761ToolStripMenuItem.Checked = false;
                    iC765ToolStripMenuItem.Checked = false;
                    iC7700ToolStripMenuItem.Checked = false;
                    iC775ToolStripMenuItem.Checked = false;
                    iC7800ToolStripMenuItem.Checked = true;
                    iC781ToolStripMenuItem.Checked = false;
                    iC78ToolStripMenuItem.Checked = false;
                    iC820ToolStripMenuItem.Checked = false;
                    iC821ToolStripMenuItem.Checked = false;
                    iC910ToolStripMenuItem.Checked = false;
                    iC970ToolStripMenuItem.Checked = false;
                    iCX3ToolStripMenuItem.Checked = false;
                    iD1ToolStripMenuItem.Checked = false;
                    break;
                case 38:
                    iC1271ToolStripMenuItem.Checked = false;
                    iC1275ToolStripMenuItem.Checked = false;
                    iC271ToolStripMenuItem.Checked = false;
                    iC275ToolStripMenuItem.Checked = false;
                    iC375ToolStripMenuItem.Checked = false;
                    iC471ToolStripMenuItem.Checked = false;
                    iC475ToolStripMenuItem.Checked = false;
                    iC575ToolStripMenu.Checked = false;
                    iC7000ToolStripMenuItem.Checked = false;
                    iC703ToolStripMenuItem.Checked = false;
                    iC706MkIIGToolStripMenuItem.Checked = false;
                    iC706MkIIToolStripMenuItem.Checked = false;
                    iC706ToolStripMenuItem.Checked = false;
                    iC707ToolStripMenuItem.Checked = false;
                    iC718ToolStripMenuItem.Checked = false;
                    iC7200ToolStripMenuItem.Checked = false;
                    iC725ToolStripMenuItem.Checked = false;
                    iC726ToolStripMenuItem.Checked = false;
                    iC728ToolStripMenuItem.Checked = false;
                    iC729ToolStripMenuItem.Checked = false;
                    iC735ToolStripMenuItem.Checked = false;
                    iC736ToolStripMenuItem.Checked = false;
                    iC737ToolStripMenuItem.Checked = false;
                    iC738ToolStripMenuItem.Checked = false;
                    iC7400ToolStripMenuItem.Checked = false;
                    iC746ToolStripMenuItem.Checked = false;
                    iC751AToolStripMenuItem.Checked = false;
                    iC756ProIIIToolStripMenuItem.Checked = false;
                    iC756ProIIToolStripMenuItem.Checked = false;
                    iC756ProToolStripMenuItem.Checked = false;
                    iC756ToolStripMenuItem.Checked = false;
                    iC761ToolStripMenuItem.Checked = false;
                    iC765ToolStripMenuItem.Checked = false;
                    iC7700ToolStripMenuItem.Checked = false;
                    iC775ToolStripMenuItem.Checked = false;
                    iC7800ToolStripMenuItem.Checked = false;
                    iC781ToolStripMenuItem.Checked = true;
                    iC78ToolStripMenuItem.Checked = false;
                    iC820ToolStripMenuItem.Checked = false;
                    iC821ToolStripMenuItem.Checked = false;
                    iC910ToolStripMenuItem.Checked = false;
                    iC970ToolStripMenuItem.Checked = false;
                    iCX3ToolStripMenuItem.Checked = false;
                    iD1ToolStripMenuItem.Checked = false;
                    break;
                case 98:
                    iC1271ToolStripMenuItem.Checked = false;
                    iC1275ToolStripMenuItem.Checked = false;
                    iC271ToolStripMenuItem.Checked = false;
                    iC275ToolStripMenuItem.Checked = false;
                    iC375ToolStripMenuItem.Checked = false;
                    iC471ToolStripMenuItem.Checked = false;
                    iC475ToolStripMenuItem.Checked = false;
                    iC575ToolStripMenu.Checked = false;
                    iC7000ToolStripMenuItem.Checked = false;
                    iC703ToolStripMenuItem.Checked = false;
                    iC706MkIIGToolStripMenuItem.Checked = false;
                    iC706MkIIToolStripMenuItem.Checked = false;
                    iC706ToolStripMenuItem.Checked = false;
                    iC707ToolStripMenuItem.Checked = false;
                    iC718ToolStripMenuItem.Checked = false;
                    iC7200ToolStripMenuItem.Checked = false;
                    iC725ToolStripMenuItem.Checked = false;
                    iC726ToolStripMenuItem.Checked = false;
                    iC728ToolStripMenuItem.Checked = false;
                    iC729ToolStripMenuItem.Checked = false;
                    iC735ToolStripMenuItem.Checked = false;
                    iC736ToolStripMenuItem.Checked = false;
                    iC737ToolStripMenuItem.Checked = false;
                    iC738ToolStripMenuItem.Checked = false;
                    iC7400ToolStripMenuItem.Checked = false;
                    iC746ToolStripMenuItem.Checked = false;
                    iC751AToolStripMenuItem.Checked = false;
                    iC756ProIIIToolStripMenuItem.Checked = false;
                    iC756ProIIToolStripMenuItem.Checked = false;
                    iC756ProToolStripMenuItem.Checked = false;
                    iC756ToolStripMenuItem.Checked = false;
                    iC761ToolStripMenuItem.Checked = false;
                    iC765ToolStripMenuItem.Checked = false;
                    iC7700ToolStripMenuItem.Checked = false;
                    iC775ToolStripMenuItem.Checked = false;
                    iC7800ToolStripMenuItem.Checked = false;
                    iC781ToolStripMenuItem.Checked = false;
                    iC78ToolStripMenuItem.Checked = true;
                    iC820ToolStripMenuItem.Checked = false;
                    iC821ToolStripMenuItem.Checked = false;
                    iC910ToolStripMenuItem.Checked = false;
                    iC970ToolStripMenuItem.Checked = false;
                    iCX3ToolStripMenuItem.Checked = false;
                    iD1ToolStripMenuItem.Checked = false;
                    break;
                case 66:
                    iC1271ToolStripMenuItem.Checked = false;
                    iC1275ToolStripMenuItem.Checked = false;
                    iC271ToolStripMenuItem.Checked = false;
                    iC275ToolStripMenuItem.Checked = false;
                    iC375ToolStripMenuItem.Checked = false;
                    iC471ToolStripMenuItem.Checked = false;
                    iC475ToolStripMenuItem.Checked = false;
                    iC575ToolStripMenu.Checked = false;
                    iC7000ToolStripMenuItem.Checked = false;
                    iC703ToolStripMenuItem.Checked = false;
                    iC706MkIIGToolStripMenuItem.Checked = false;
                    iC706MkIIToolStripMenuItem.Checked = false;
                    iC706ToolStripMenuItem.Checked = false;
                    iC707ToolStripMenuItem.Checked = false;
                    iC718ToolStripMenuItem.Checked = false;
                    iC7200ToolStripMenuItem.Checked = false;
                    iC725ToolStripMenuItem.Checked = false;
                    iC726ToolStripMenuItem.Checked = false;
                    iC728ToolStripMenuItem.Checked = false;
                    iC729ToolStripMenuItem.Checked = false;
                    iC735ToolStripMenuItem.Checked = false;
                    iC736ToolStripMenuItem.Checked = false;
                    iC737ToolStripMenuItem.Checked = false;
                    iC738ToolStripMenuItem.Checked = false;
                    iC7400ToolStripMenuItem.Checked = false;
                    iC746ToolStripMenuItem.Checked = false;
                    iC751AToolStripMenuItem.Checked = false;
                    iC756ProIIIToolStripMenuItem.Checked = false;
                    iC756ProIIToolStripMenuItem.Checked = false;
                    iC756ProToolStripMenuItem.Checked = false;
                    iC756ToolStripMenuItem.Checked = false;
                    iC761ToolStripMenuItem.Checked = false;
                    iC765ToolStripMenuItem.Checked = false;
                    iC7700ToolStripMenuItem.Checked = false;
                    iC775ToolStripMenuItem.Checked = false;
                    iC7800ToolStripMenuItem.Checked = false;
                    iC781ToolStripMenuItem.Checked = false;
                    iC78ToolStripMenuItem.Checked = false;
                    iC820ToolStripMenuItem.Checked = true;
                    iC821ToolStripMenuItem.Checked = false;
                    iC910ToolStripMenuItem.Checked = false;
                    iC970ToolStripMenuItem.Checked = false;
                    iCX3ToolStripMenuItem.Checked = false;
                    iD1ToolStripMenuItem.Checked = false;
                    break;
                case 76:
                    iC1271ToolStripMenuItem.Checked = false;
                    iC1275ToolStripMenuItem.Checked = false;
                    iC271ToolStripMenuItem.Checked = false;
                    iC275ToolStripMenuItem.Checked = false;
                    iC375ToolStripMenuItem.Checked = false;
                    iC471ToolStripMenuItem.Checked = false;
                    iC475ToolStripMenuItem.Checked = false;
                    iC575ToolStripMenu.Checked = false;
                    iC7000ToolStripMenuItem.Checked = false;
                    iC703ToolStripMenuItem.Checked = false;
                    iC706MkIIGToolStripMenuItem.Checked = false;
                    iC706MkIIToolStripMenuItem.Checked = false;
                    iC706ToolStripMenuItem.Checked = false;
                    iC707ToolStripMenuItem.Checked = false;
                    iC718ToolStripMenuItem.Checked = false;
                    iC7200ToolStripMenuItem.Checked = false;
                    iC725ToolStripMenuItem.Checked = false;
                    iC726ToolStripMenuItem.Checked = false;
                    iC728ToolStripMenuItem.Checked = false;
                    iC729ToolStripMenuItem.Checked = false;
                    iC735ToolStripMenuItem.Checked = false;
                    iC736ToolStripMenuItem.Checked = false;
                    iC737ToolStripMenuItem.Checked = false;
                    iC738ToolStripMenuItem.Checked = false;
                    iC7400ToolStripMenuItem.Checked = false;
                    iC746ToolStripMenuItem.Checked = false;
                    iC751AToolStripMenuItem.Checked = false;
                    iC756ProIIIToolStripMenuItem.Checked = false;
                    iC756ProIIToolStripMenuItem.Checked = false;
                    iC756ProToolStripMenuItem.Checked = false;
                    iC756ToolStripMenuItem.Checked = false;
                    iC761ToolStripMenuItem.Checked = false;
                    iC765ToolStripMenuItem.Checked = false;
                    iC7700ToolStripMenuItem.Checked = false;
                    iC775ToolStripMenuItem.Checked = false;
                    iC7800ToolStripMenuItem.Checked = false;
                    iC781ToolStripMenuItem.Checked = false;
                    iC78ToolStripMenuItem.Checked = false;
                    iC820ToolStripMenuItem.Checked = false;
                    iC821ToolStripMenuItem.Checked = true;
                    iC910ToolStripMenuItem.Checked = false;
                    iC970ToolStripMenuItem.Checked = false;
                    iCX3ToolStripMenuItem.Checked = false;
                    iD1ToolStripMenuItem.Checked = false;
                    break;
                case 96:
                    iC1271ToolStripMenuItem.Checked = false;
                    iC1275ToolStripMenuItem.Checked = false;
                    iC271ToolStripMenuItem.Checked = false;
                    iC275ToolStripMenuItem.Checked = false;
                    iC375ToolStripMenuItem.Checked = false;
                    iC471ToolStripMenuItem.Checked = false;
                    iC475ToolStripMenuItem.Checked = false;
                    iC575ToolStripMenu.Checked = false;
                    iC7000ToolStripMenuItem.Checked = false;
                    iC703ToolStripMenuItem.Checked = false;
                    iC706MkIIGToolStripMenuItem.Checked = false;
                    iC706MkIIToolStripMenuItem.Checked = false;
                    iC706ToolStripMenuItem.Checked = false;
                    iC707ToolStripMenuItem.Checked = false;
                    iC718ToolStripMenuItem.Checked = false;
                    iC7200ToolStripMenuItem.Checked = false;
                    iC725ToolStripMenuItem.Checked = false;
                    iC726ToolStripMenuItem.Checked = false;
                    iC728ToolStripMenuItem.Checked = false;
                    iC729ToolStripMenuItem.Checked = false;
                    iC735ToolStripMenuItem.Checked = false;
                    iC736ToolStripMenuItem.Checked = false;
                    iC737ToolStripMenuItem.Checked = false;
                    iC738ToolStripMenuItem.Checked = false;
                    iC7400ToolStripMenuItem.Checked = false;
                    iC746ToolStripMenuItem.Checked = false;
                    iC751AToolStripMenuItem.Checked = false;
                    iC756ProIIIToolStripMenuItem.Checked = false;
                    iC756ProIIToolStripMenuItem.Checked = false;
                    iC756ProToolStripMenuItem.Checked = false;
                    iC756ToolStripMenuItem.Checked = false;
                    iC761ToolStripMenuItem.Checked = false;
                    iC765ToolStripMenuItem.Checked = false;
                    iC7700ToolStripMenuItem.Checked = false;
                    iC775ToolStripMenuItem.Checked = false;
                    iC7800ToolStripMenuItem.Checked = false;
                    iC781ToolStripMenuItem.Checked = false;
                    iC78ToolStripMenuItem.Checked = false;
                    iC820ToolStripMenuItem.Checked = false;
                    iC821ToolStripMenuItem.Checked = false;
                    iC910ToolStripMenuItem.Checked = true;
                    iC970ToolStripMenuItem.Checked = false;
                    iCX3ToolStripMenuItem.Checked = false;
                    iD1ToolStripMenuItem.Checked = false;
                    break;
                case 46:
                    iC1271ToolStripMenuItem.Checked = false;
                    iC1275ToolStripMenuItem.Checked = false;
                    iC271ToolStripMenuItem.Checked = false;
                    iC275ToolStripMenuItem.Checked = false;
                    iC375ToolStripMenuItem.Checked = false;
                    iC471ToolStripMenuItem.Checked = false;
                    iC475ToolStripMenuItem.Checked = false;
                    iC575ToolStripMenu.Checked = false;
                    iC7000ToolStripMenuItem.Checked = false;
                    iC703ToolStripMenuItem.Checked = false;
                    iC706MkIIGToolStripMenuItem.Checked = false;
                    iC706MkIIToolStripMenuItem.Checked = false;
                    iC706ToolStripMenuItem.Checked = false;
                    iC707ToolStripMenuItem.Checked = false;
                    iC718ToolStripMenuItem.Checked = false;
                    iC7200ToolStripMenuItem.Checked = false;
                    iC725ToolStripMenuItem.Checked = false;
                    iC726ToolStripMenuItem.Checked = false;
                    iC728ToolStripMenuItem.Checked = false;
                    iC729ToolStripMenuItem.Checked = false;
                    iC735ToolStripMenuItem.Checked = false;
                    iC736ToolStripMenuItem.Checked = false;
                    iC737ToolStripMenuItem.Checked = false;
                    iC738ToolStripMenuItem.Checked = false;
                    iC7400ToolStripMenuItem.Checked = false;
                    iC746ToolStripMenuItem.Checked = false;
                    iC751AToolStripMenuItem.Checked = false;
                    iC756ProIIIToolStripMenuItem.Checked = false;
                    iC756ProIIToolStripMenuItem.Checked = false;
                    iC756ProToolStripMenuItem.Checked = false;
                    iC756ToolStripMenuItem.Checked = false;
                    iC761ToolStripMenuItem.Checked = false;
                    iC765ToolStripMenuItem.Checked = false;
                    iC7700ToolStripMenuItem.Checked = false;
                    iC775ToolStripMenuItem.Checked = false;
                    iC7800ToolStripMenuItem.Checked = false;
                    iC781ToolStripMenuItem.Checked = false;
                    iC78ToolStripMenuItem.Checked = false;
                    iC820ToolStripMenuItem.Checked = false;
                    iC821ToolStripMenuItem.Checked = false;
                    iC910ToolStripMenuItem.Checked = false;
                    iC970ToolStripMenuItem.Checked = true;
                    iCX3ToolStripMenuItem.Checked = false;
                    iD1ToolStripMenuItem.Checked = false;
                    break;
                case 22:
                    iC1271ToolStripMenuItem.Checked = false;
                    iC1275ToolStripMenuItem.Checked = false;
                    iC271ToolStripMenuItem.Checked = false;
                    iC275ToolStripMenuItem.Checked = false;
                    iC375ToolStripMenuItem.Checked = false;
                    iC471ToolStripMenuItem.Checked = false;
                    iC475ToolStripMenuItem.Checked = false;
                    iC575ToolStripMenu.Checked = true;
                    iC7000ToolStripMenuItem.Checked = false;
                    iC703ToolStripMenuItem.Checked = false;
                    iC706MkIIGToolStripMenuItem.Checked = false;
                    iC706MkIIToolStripMenuItem.Checked = false;
                    iC706ToolStripMenuItem.Checked = false;
                    iC707ToolStripMenuItem.Checked = false;
                    iC718ToolStripMenuItem.Checked = false;
                    iC7200ToolStripMenuItem.Checked = false;
                    iC725ToolStripMenuItem.Checked = false;
                    iC726ToolStripMenuItem.Checked = false;
                    iC728ToolStripMenuItem.Checked = false;
                    iC729ToolStripMenuItem.Checked = false;
                    iC735ToolStripMenuItem.Checked = false;
                    iC736ToolStripMenuItem.Checked = false;
                    iC737ToolStripMenuItem.Checked = false;
                    iC738ToolStripMenuItem.Checked = false;
                    iC7400ToolStripMenuItem.Checked = false;
                    iC746ToolStripMenuItem.Checked = false;
                    iC751AToolStripMenuItem.Checked = false;
                    iC756ProIIIToolStripMenuItem.Checked = false;
                    iC756ProIIToolStripMenuItem.Checked = false;
                    iC756ProToolStripMenuItem.Checked = false;
                    iC756ToolStripMenuItem.Checked = false;
                    iC761ToolStripMenuItem.Checked = false;
                    iC765ToolStripMenuItem.Checked = false;
                    iC7700ToolStripMenuItem.Checked = false;
                    iC775ToolStripMenuItem.Checked = false;
                    iC7800ToolStripMenuItem.Checked = false;
                    iC781ToolStripMenuItem.Checked = false;
                    iC78ToolStripMenuItem.Checked = false;
                    iC820ToolStripMenuItem.Checked = false;
                    iC821ToolStripMenuItem.Checked = false;
                    iC910ToolStripMenuItem.Checked = false;
                    iC970ToolStripMenuItem.Checked = false;
                    iCX3ToolStripMenuItem.Checked = false;
                    iD1ToolStripMenuItem.Checked = false;
                    break;
                case 72:
                    iC1271ToolStripMenuItem.Checked = false;
                    iC1275ToolStripMenuItem.Checked = false;
                    iC271ToolStripMenuItem.Checked = false;
                    iC275ToolStripMenuItem.Checked = false;
                    iC375ToolStripMenuItem.Checked = false;
                    iC471ToolStripMenuItem.Checked = false;
                    iC475ToolStripMenuItem.Checked = false;
                    iC575ToolStripMenu.Checked = false;
                    iC7000ToolStripMenuItem.Checked = false;
                    iC703ToolStripMenuItem.Checked = false;
                    iC706MkIIGToolStripMenuItem.Checked = false;
                    iC706MkIIToolStripMenuItem.Checked = false;
                    iC706ToolStripMenuItem.Checked = true;
                    iC707ToolStripMenuItem.Checked = false;
                    iC718ToolStripMenuItem.Checked = false;
                    iC7200ToolStripMenuItem.Checked = false;
                    iC725ToolStripMenuItem.Checked = false;
                    iC726ToolStripMenuItem.Checked = false;
                    iC728ToolStripMenuItem.Checked = false;
                    iC729ToolStripMenuItem.Checked = false;
                    iC735ToolStripMenuItem.Checked = false;
                    iC736ToolStripMenuItem.Checked = false;
                    iC737ToolStripMenuItem.Checked = false;
                    iC738ToolStripMenuItem.Checked = false;
                    iC7400ToolStripMenuItem.Checked = false;
                    iC746ToolStripMenuItem.Checked = false;
                    iC751AToolStripMenuItem.Checked = false;
                    iC756ProIIIToolStripMenuItem.Checked = false;
                    iC756ProIIToolStripMenuItem.Checked = false;
                    iC756ProToolStripMenuItem.Checked = false;
                    iC756ToolStripMenuItem.Checked = false;
                    iC761ToolStripMenuItem.Checked = false;
                    iC765ToolStripMenuItem.Checked = false;
                    iC7700ToolStripMenuItem.Checked = false;
                    iC775ToolStripMenuItem.Checked = false;
                    iC7800ToolStripMenuItem.Checked = false;
                    iC781ToolStripMenuItem.Checked = false;
                    iC78ToolStripMenuItem.Checked = false;
                    iC820ToolStripMenuItem.Checked = false;
                    iC821ToolStripMenuItem.Checked = false;
                    iC910ToolStripMenuItem.Checked = false;
                    iC970ToolStripMenuItem.Checked = false;
                    iCX3ToolStripMenuItem.Checked = false;
                    iD1ToolStripMenuItem.Checked = false;
                    break;
                case 1:
                    iC1271ToolStripMenuItem.Checked = false;
                    iC1275ToolStripMenuItem.Checked = false;
                    iC271ToolStripMenuItem.Checked = false;
                    iC275ToolStripMenuItem.Checked = false;
                    iC375ToolStripMenuItem.Checked = false;
                    iC471ToolStripMenuItem.Checked = false;
                    iC475ToolStripMenuItem.Checked = false;
                    iC575ToolStripMenu.Checked = false;
                    iC7000ToolStripMenuItem.Checked = false;
                    iC703ToolStripMenuItem.Checked = false;
                    iC706MkIIGToolStripMenuItem.Checked = false;
                    iC706MkIIToolStripMenuItem.Checked = false;
                    iC706ToolStripMenuItem.Checked = false;
                    iC707ToolStripMenuItem.Checked = false;
                    iC718ToolStripMenuItem.Checked = false;
                    iC7200ToolStripMenuItem.Checked = false;
                    iC725ToolStripMenuItem.Checked = false;
                    iC726ToolStripMenuItem.Checked = false;
                    iC728ToolStripMenuItem.Checked = false;
                    iC729ToolStripMenuItem.Checked = false;
                    iC735ToolStripMenuItem.Checked = false;
                    iC736ToolStripMenuItem.Checked = false;
                    iC737ToolStripMenuItem.Checked = false;
                    iC738ToolStripMenuItem.Checked = false;
                    iC7400ToolStripMenuItem.Checked = false;
                    iC746ToolStripMenuItem.Checked = false;
                    iC751AToolStripMenuItem.Checked = false;
                    iC756ProIIIToolStripMenuItem.Checked = false;
                    iC756ProIIToolStripMenuItem.Checked = false;
                    iC756ProToolStripMenuItem.Checked = false;
                    iC756ToolStripMenuItem.Checked = false;
                    iC761ToolStripMenuItem.Checked = false;
                    iC765ToolStripMenuItem.Checked = false;
                    iC7700ToolStripMenuItem.Checked = false;
                    iC775ToolStripMenuItem.Checked = false;
                    iC7800ToolStripMenuItem.Checked = false;
                    iC781ToolStripMenuItem.Checked = false;
                    iC78ToolStripMenuItem.Checked = false;
                    iC820ToolStripMenuItem.Checked = false;
                    iC821ToolStripMenuItem.Checked = false;
                    iC910ToolStripMenuItem.Checked = false;
                    iC970ToolStripMenuItem.Checked = false;
                    iCX3ToolStripMenuItem.Checked = false;
                    iD1ToolStripMenuItem.Checked = true;
                    break;
                default:
                    iC1271ToolStripMenuItem.Checked = false;
                    iC1275ToolStripMenuItem.Checked = false;
                    iC271ToolStripMenuItem.Checked = false;
                    iC275ToolStripMenuItem.Checked = false;
                    iC375ToolStripMenuItem.Checked = false;
                    iC471ToolStripMenuItem.Checked = false;
                    iC475ToolStripMenuItem.Checked = false;
                    iC575ToolStripMenu.Checked = false;
                    iC7000ToolStripMenuItem.Checked = false;
                    iC703ToolStripMenuItem.Checked = false;
                    iC706MkIIGToolStripMenuItem.Checked = false;
                    iC706MkIIToolStripMenuItem.Checked = false;
                    iC706ToolStripMenuItem.Checked = false;
                    iC707ToolStripMenuItem.Checked = false;
                    iC718ToolStripMenuItem.Checked = false;
                    iC7200ToolStripMenuItem.Checked = false;
                    iC725ToolStripMenuItem.Checked = false;
                    iC726ToolStripMenuItem.Checked = false;
                    iC728ToolStripMenuItem.Checked = false;
                    iC729ToolStripMenuItem.Checked = false;
                    iC735ToolStripMenuItem.Checked = false;
                    iC736ToolStripMenuItem.Checked = false;
                    iC737ToolStripMenuItem.Checked = false;
                    iC738ToolStripMenuItem.Checked = false;
                    iC7400ToolStripMenuItem.Checked = false;
                    iC746ToolStripMenuItem.Checked = false;
                    iC751AToolStripMenuItem.Checked = false;
                    iC756ProIIIToolStripMenuItem.Checked = false;
                    iC756ProIIToolStripMenuItem.Checked = false;
                    iC756ProToolStripMenuItem.Checked = false;
                    iC756ToolStripMenuItem.Checked = false;
                    iC761ToolStripMenuItem.Checked = false;
                    iC765ToolStripMenuItem.Checked = false;
                    iC7700ToolStripMenuItem.Checked = false;
                    iC775ToolStripMenuItem.Checked = false;
                    iC7800ToolStripMenuItem.Checked = false;
                    iC781ToolStripMenuItem.Checked = false;
                    iC78ToolStripMenuItem.Checked = false;
                    iC820ToolStripMenuItem.Checked = false;
                    iC821ToolStripMenuItem.Checked = false;
                    iC910ToolStripMenuItem.Checked = false;
                    iC970ToolStripMenuItem.Checked = false;
                    iCX3ToolStripMenuItem.Checked = false;
                    iD1ToolStripMenuItem.Checked = false;
                    break;
            }
        }

        private void onlineHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://w1jeq.net/software/vrig/");
        }

        private void icomMenu(object sender, EventArgs e)
        {

            ToolStripMenuItem radioModel = sender as ToolStripMenuItem;
            string item = radioModel.Name.ToString();
            //errorProvider1.SetError(menuStrip1, item);
            switch (item)
            {
                case "iC1271ToolStripMenuItem":
                    rigAddress = 26;
                    break;
                case "iC1275ToolStripMenuItem":
                    rigAddress = 24;
                    break;
                case "iC271ToolStripMenuItem":
                    rigAddress = 32;
                    break;
                case "iC275ToolStripMenuItem":
                    rigAddress = 16;
                    break;
                case "iC375ToolStripMenuItem":
                    rigAddress = 18;
                    break;
                case "iC471ToolStripMenuItem":
                    rigAddress = 34;
                    break;
                case "iC475ToolStripMenuItem":
                    rigAddress = 20;
                    break;
                case "iC7000ToolStripMenuItem":
                    rigAddress = 112;
                    break;
                case "iC703ToolStripMenuItem":
                    rigAddress = 104;
                    break;
                case "iC706MkIIGToolStripMenuItem":
                    rigAddress = 88;
                    break;
                case "iC706MkIIToolStripMenuItem":
                    rigAddress = 78;
                    break;
                case "iC707ToolStripMenuItem":
                    rigAddress = 62;
                    break;
                case "iC718ToolStripMenuItem":
                    rigAddress = 94;
                    break;
                case "iC7200ToolStripMenuItem":
                    rigAddress = 188;
                    break;
                case "iC725ToolStripMenuItem":
                    rigAddress = 40;
                    break;
                case "iC726ToolStripMenuItem":
                    rigAddress = 48;
                    break;
                case "iC728ToolStripMenuItem":
                    rigAddress = 56;
                    break;
                case "iC729ToolStripMenuItem":
                    rigAddress = 58;
                    break;
                case "iC735ToolStripMenuItem":
                    rigAddress = 4;
                    break;
                case "iC736ToolStripMenuItem":
                    rigAddress = 64;
                    break;
                case "iC737ToolStripMenuItem":
                    rigAddress = 60;
                    break;
                case "iC738ToolStripMenuItem":
                    rigAddress = 68;
                    break;
                case "iC7400ToolStripMenuItem":
                    rigAddress = 102;
                    break;
                case "iC746ToolStripMenuItem":
                    rigAddress = 86;
                    break;
                case "iC751AToolStripMenuItem":
                    rigAddress = 28;
                    break;
                case "iC756ProIIIToolStripMenuItem":
                    rigAddress = 110;
                    break;
                case "iC756ProIIToolStripMenuItem":
                    rigAddress = 100;
                    break;
                case "iC756ProToolStripMenuItem":
                    rigAddress = 92;
                    break;
                case "iC756ToolStripMenuItem":
                    rigAddress = 80;
                    break;
                case "iC761ToolStripMenuItem":
                    rigAddress = 30;
                    break;
                case "iC765ToolStripMenuItem":
                    rigAddress = 44;
                    break;
                case "iC7700ToolStripMenuItem":
                    rigAddress = 116;
                    break;
                case "iC775ToolStripMenuItem":
                    rigAddress = 70;
                    break;
                case "iC7800ToolStripMenuItem":
                    rigAddress = 106;
                    break;
                case "iC781ToolStripMenuItem":
                    rigAddress = 38;
                    break;
                case "iC78ToolStripMenuItem":
                    rigAddress = 98;
                    break;
                case "iC820ToolStripMenuItem":
                    rigAddress = 66;
                    break;
                case "iC821ToolStripMenuItem":
                    rigAddress = 76;
                    break;
                case "iC910ToolStripMenuItem":
                    rigAddress = 96;
                    break;
                case "iC970ToolStripMenuItem":
                    rigAddress = 46;
                    break;
                case "iCX3ToolStripMenuItem":
                    rigAddress = 0;
                    break;
                case "iC575ToolStripMenu":
                    rigAddress = 22;
                    break;
                case "iC706ToolStripMenuItem":
                    rigAddress = 72;
                    break;
                case "iD1ToolStripMenuItem":
                    rigAddress = 1;
                    break;
            }
            icomRadioMenuSetCheck(rigAddress);
            init_radio();
        }

        private void SetSerialPort(string port)
        {
            try
            {
                int sPort = Int32.Parse(port.Substring(3));
                comPort = sPort;
            }
            catch
            {
                //oops
            }
            init_radio();
        }

        private void setBaudRate(object sender, EventArgs e)
        {
            ToolStripItem bRate = sender as ToolStripItem;
            string rate = bRate.Name.Remove(bRate.Name.IndexOf(","));
            try
            {
                baudrate = Int32.Parse(rate);
            }
            catch
            {
                //oops
            }
            init_radio();
        }

        private void yaesuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

    }
}
