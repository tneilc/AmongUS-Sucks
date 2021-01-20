using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory;
using System.Threading;
using System.Diagnostics;

namespace AmongusCS
{
    public partial class Form1 : Form
    {
        Mem memory = new Mem();
        bool impostor = false, noclip = false,process = false;
        float speed,killcd,playerx,playery;
        int killd,maxplayer;
        
        

        public Form1()
        {
            InitializeComponent();
        }

        void readall()
        {
            impostor = Convert.ToBoolean(memory.ReadInt("GameAssembly.dll+01C57F7C,5C,0,34,28"));
            int noclipint = memory.ReadByte("UnityPlayer.dll+960CA6");
            if(noclipint == 133) { noclip = true; }
            else if(noclipint == 132) { noclip = false; }
            speed = memory.ReadFloat("GameAssembly.dll+01C68F58,5C,E4,14");
            killd = memory.ReadInt("GameAssembly.dll+01BC7D88,8,ba0");
            killcd = memory.ReadFloat("GameAssembly.dll+01C59378,5c,8c,20");
            playerx = memory.ReadFloat("UnityPlayer.dll+01277F00,20,2c,3ec");
            playery = memory.ReadFloat("UnityPlayer.dll+01277F00,20,2c,3f0");
            maxplayer = memory.ReadInt("GameAssembly.dll+01BC8698,8,C18");
            
            string menu = $@"Impostor = {impostor}
Noclip = {noclip}
Speed = {speed}
Kill Distance = {killd}
Kill Cooldown = {killcd}
Max Player = {maxplayer}
PlayerX = {playerx}
PlayerY = {playery}
";
            label6.Text = menu;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            process = memory.OpenProcess("Among US");
            if (!process)
            {
                MessageBox.Show("Please open AmongUS first");
                Application.Exit();
            }

        }


        private void KillcdGO_Click(object sender, EventArgs e)
        {
            if (KillCDText.Text != "")
            {
                memory.WriteMemory("GameAssembly.dll+01C59378,5c,8c,20", "float", KillCDText.Text);
                KillCDText.Clear();
                readall();
            }
            
            
        }

        private void maxbar_Scroll(object sender, EventArgs e)
        {
            Count.Text = maxbar.Value.ToString();
        }



        private void Form1_Shown(object sender, EventArgs e)
        {


        }

        private void MaxPlayerbtn_Click(object sender, EventArgs e)
        {
            memory.WriteMemory("GameAssembly.dll+01BC8698,8,C18", "int", maxbar.Value.ToString());
            maxbar.Value = maxbar.Minimum;
            Count.Text = "";
            readall();
        }

        private void Speedbtn_Click(object sender, EventArgs e)
        {
            if (Speedtext.Text != "")
            {
                memory.WriteMemory("GameAssembly.dll+01C68F58,5C,e4,14", "float", Speedtext.Text);
                Speedtext.Clear();
                readall();
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            memory.WriteMemory("GameAssembly.dll+01BC7D88,8,ba0", "int", comboBox1.SelectedIndex.ToString());
            readall();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                memory.WriteMemory("GameAssembly.dll+01C57F7C,5C,0,34,28", "int","1");
            }
            else
            {
                memory.WriteMemory("GameAssembly.dll+01C57F7C,5C,0,34,28", "int", "0");
            }
            readall();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (noclipcheck.Checked)
            {
                memory.WriteMemory("UnityPlayer.dll+960CA6", "byte", "0x85");
            }
            else
            {
                memory.WriteMemory("UnityPlayer.dll+960CA6", "byte", "0x84");
            }
            readall();
        }

        private void Teleportbtn_Click(object sender, EventArgs e)
        {
            if (Xtext.Text != "" & Ytext.Text == "")
            {
                memory.WriteMemory("UnityPlayer.dll+01277F00,20,2c,3ec", "float", Xtext.Text);
            }
            else if (Xtext.Text == "" & Ytext.Text != "")
            {
                memory.WriteMemory("UnityPlayer.dll+01277F00,20,2c,3f0", "float", Ytext.Text);
            }
            else if (Xtext.Text != "" & Ytext.Text != "")
            {
                memory.WriteMemory("UnityPlayer.dll+01277F00,20,2c,3ec", "float", Xtext.Text);
                memory.WriteMemory("UnityPlayer.dll+01277F00,20,2c,3f0", "float", Ytext.Text);
            }
            Xtext.Clear();
            Ytext.Clear();
            readall();
        }
    }
}
