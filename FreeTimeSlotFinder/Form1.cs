using MaterialSkin.Controls;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FreeTimeSlotFinder
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgv_table.ColumnCount = 2;
        

            dgv_table.Columns[0].Name = "From";
            dgv_table.Columns[1].Name = "To";
         

            DataGridViewImageColumn imgBtn1 = new DataGridViewImageColumn();
            Image image1 = Image.FromFile("del1.png");
            imgBtn1.Image = image1;
            imgBtn1.HeaderText = "";
            dgv_table.Columns.Add(imgBtn1);

        }


      
        private void Dgv_tableA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (dgv_table.Columns[e.ColumnIndex].Name == "")
            {
                DialogResult res = MessageBox.Show("Ary you sure want to Delete", "Confirmation",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                    dgv_table.Rows.RemoveAt(rowIndex);
                }
                if (res == DialogResult.Cancel)
                {
                    // no task
                }
            }
        }

       
        void findFreeTimeSlot(ArrayList dateList,DateTime startDate,DateTime endDate)
        {
            /*foreach(KeyValuePair<DateTime,DateTime> item in dateListA)
            {
                if((startDate.Date < item.Key.Date))
                {
                    
                }
            }*/

            Dictionary<DateTime, DateTime> freeTime = new Dictionary<DateTime, DateTime>();
            ArrayList arrayList = new ArrayList();
            //Console.WriteLine("DATES");
            for(DateTime i=startDate.Date;i<=endDate.Date;i = i.Date.AddDays(1))
            {
                if(dateList.Contains(i))
                {
                   // nothing
                }
                else
                {
                    arrayList.Add(i);
                }
            }

            Free_Time_Slots free_Time_Slots = new Free_Time_Slots(arrayList);
            free_Time_Slots.Show();


        }

        private void Btn_addTable_Click(object sender, EventArgs e)
        {
            String from, to;
            from = dtp_from.Value.ToShortDateString();
            to = dtp_to.Value.ToShortDateString();
            if ((Convert.ToDateTime(from).Date) < (Convert.ToDateTime(to).Date))
            {
                dgv_table.Rows.Add(from, to);
            }
            else
            {
                MessageBox.Show("Dates must be valid in range", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MaterialRaisedButton1_Click(object sender, EventArgs e)
        {
            DateTime startDate, endDate;

            //Dictionary<DateTime, DateTime> dateListA = new Dictionary<DateTime, DateTime>();
            //Dictionary<DateTime, DateTime> dateListB = new Dictionary<DateTime, DateTime>();

            ArrayList dateList = new ArrayList();

            startDate = dtp_startDate.Value.Date;
            endDate = dtp_endDate.Value.Date;

            if (startDate > endDate)
            {
                MessageBox.Show("Start Date and End Date must be in valid range", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (DataGridViewRow dataGridViewRow in dgv_table.Rows)
                {
                    DateTime date1 = Convert.ToDateTime(dataGridViewRow.Cells["From"].Value);
                    DateTime date2 = Convert.ToDateTime(dataGridViewRow.Cells["To"].Value);
                    //  int daysDiff = ((TimeSpan)(date2 - date1)).Days;
                    for (DateTime i = date1.Date; i <= date2.Date; i = i.Date.AddDays(1))
                    {
                        dateList.Add(i);
                    }
                }



                findFreeTimeSlot(dateList, startDate, endDate);
            }
        }
    }
}
