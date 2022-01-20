using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KVLS2_C1
{
    public partial class Form1 : Form
    {
        public enum DEVICE_IDX
        {
            SBC = 0,
            SSD,
            NETWORK,
            USB,
            COM
        }

        ListViewItem sbcLVI;
        ListViewItem ssdLVI;
        ListViewItem netLVI;
        ListViewItem usbLVI;
        ListViewItem comLVI;

        string[] DEVICE = new string[] { "SBC", "SSD", "NETWORK", "USB", "COM" };
        public Form1()
        {
            InitializeComponent();


            listView1.View = View.Details;


            // Columns resize
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listView1.Columns[0].Width = -2;
            listView1.Columns[0].Width = 150;

            listView1.Columns[1].Width = -2;
            listView1.Columns[1].Width = 350;


            // SBC
            sbcLVI = new ListViewItem(DEVICE[(int)DEVICE_IDX.SBC]);
            
            sbcLVI.SubItems.Add("-");
            sbcLVI.SubItems.Add("-");
            listView1.Items.Add(sbcLVI);
            //listView1.Items[0].SubItems[2].Text = "5555";

            // SSD
            ssdLVI = new ListViewItem(DEVICE[(int)DEVICE_IDX.SSD]);
            ssdLVI.SubItems.Add("-");
            ssdLVI.SubItems.Add("-");
            listView1.Items.Add(ssdLVI);
         

            // NETWORK
            netLVI = new ListViewItem(DEVICE[(int)DEVICE_IDX.NETWORK]);
            netLVI.SubItems.Add("-");
            netLVI.SubItems.Add("-");
            listView1.Items.Add(netLVI);

            // USB
            usbLVI = new ListViewItem(DEVICE[(int)DEVICE_IDX.USB]);
            usbLVI.SubItems.Add("-");
            usbLVI.SubItems.Add("-");
            listView1.Items.Add(usbLVI);

            // COM
            comLVI = new ListViewItem(DEVICE[(int)DEVICE_IDX.COM]);
            comLVI.SubItems.Add("-");
            comLVI.SubItems.Add("-");
            listView1.Items.Add(comLVI);





            //listView1.BeginUpdate();
            //listView1.Refresh();

            //string[] data = new string[3];
            //data[0] = "12";
            //data[1] = "34";
            //data[2] = "45";
            //ListViewItem lvi = new ListViewItem(data);
            //    //lvi.SubItems.Add("TEST");

            //    listView1.Items.Add(lvi);


            //listView1.Columns.Add("Name", 100, HorizontalAlignment.Center);
            //listView1.Columns.Add("Value", 300, HorizontalAlignment.Left);
            //listView1.Columns.Add("Status", 50, HorizontalAlignment.Center);



        }

    }
}
