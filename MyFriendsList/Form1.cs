using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFriendsList
{
    public partial class Form1 : Form
    {   
        List<string>  myfriends = new List<string>() ;
        BindingSource bs = new BindingSource() ;

        public Form1()
        {
            InitializeComponent();
            bs.DataSource = myfriends ;
        }

        private void btn_AddFriend_Click(object sender, EventArgs e)
        {

           // listBox1.Items.Add(txt_newFriend.Text);
           myfriends.Add(txt_newFriend.Text);
            listBox1.DataSource = bs;
            bs.ResetBindings(false);
            label1.Text = "There are " + myfriends.Count + " people in the list";
        }

        private void btn_addFive_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = bs;
            myfriends.Add ("Steven");
            myfriends.Add ("Jon");
            myfriends.Add("Yaw");
            myfriends.Add("George");
            myfriends.Add("Sam");
            bs.ResetBindings(false );
            label1.Text = "There are " + myfriends.Count + " people in the list";



        }

        private void btn_sortAscending_Click(object sender, EventArgs e)
        {
            myfriends.Sort();
            bs.ResetBindings(false ) ;
        }

        private void btn_sortDescending_Click(object sender, EventArgs e)
        {
            myfriends.Sort();
            myfriends.Reverse();
            bs.ResetBindings(false);

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
           
            myfriends.Clear();
            txt_newFriend.Clear();
            label1.Text = "";
            bs.ResetBindings(false);
        }
    }
}
