using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using libZPlay;

namespace RelayMgr
{
    public partial class frmAction : frmBase
    {
        public frmAction()
        {
            InitializeComponent();
        }

        private string str_Action = string.Empty;

        private void frmAction_Load(object sender, EventArgs e)
        {

        }


        public string GetAction()
        {
            return str_Action;
        }

        public void SetAction(string Action)
        {
            try
            {
                string[] temp = Action.Split(';');


                if (temp[0] == "PLAYSOUND")
                {
                    rb_PlaySound.Checked = true;
                    txt_Sound.Text = temp[1];
                }
                if (temp[0] == "EXEC")
                {
                    rb_RunProgram.Checked = true;
                    txt_Program.Text = temp[1];
                }

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

         private void btn_OK_Click(object sender, EventArgs e)
        {
            try
            {
                if (rb_PlaySound.Checked)
                {
                    str_Action = "PLAYSOUND;" + txt_Sound.Text;
                }
                if (rb_RunProgram.Checked)
                {
                    str_Action = "EXEC;" + txt_Program.Text;
                }
                DialogResult = DialogResult.OK;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btn_Sound_Click(object sender, EventArgs e)
        {
            if (ofd_OpenFile.ShowDialog() == DialogResult.OK)
            {
                txt_Sound.Text = ofd_OpenFile.FileName;

            }
        }

        private void btn_Program_Click(object sender, EventArgs e)
        {
            if (ofd_OpenFile.ShowDialog() == DialogResult.OK)
            {
                txt_Program.Text = ofd_OpenFile.FileName;

            }
        }

        private void btn_Play_Click(object sender, EventArgs e)
        {
            ZPlay player = new ZPlay();
            // open file
            if (player.OpenFile(txt_Sound.Text, TStreamFormat.sfAutodetect) == false)
            {
                MessageBox.Show(player.GetError());
                return;
            }

            if (btn_Play.Text == "播放")
            {

                // start playing
                player.StartPlayback();
                btn_Play.Text = "停止";
            }
            else
            {
                player.StopPlayback();
                btn_Play.Text = "播放";
            }
        }


        private void ItemCheckedChange(object sender, EventArgs e)
        {
            gb_PlaySound.Enabled = rb_PlaySound.Checked;
            gb_Program.Enabled = rb_RunProgram.Checked;
        }



    }
}
