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
    public partial class Free_Time_Slots : MaterialForm
    {
        ArrayList arrayList;

        public Free_Time_Slots(ArrayList arrayList)
        {
            InitializeComponent();
            this.arrayList = arrayList;
            
            
        }

        private void Free_Time_Slots_Load(object sender, EventArgs e)
        {
            dgv_freeTimeSlots.ColumnCount = 2;
            dgv_freeTimeSlots.Columns[0].Name = "From";
            dgv_freeTimeSlots.Columns[1].Name = "To";

            setContent();
        }

        void setContent()
        {
            ArrayList array = new ArrayList();
            if (arrayList.Count > 0)
            {
                DateTime sDate = Convert.ToDateTime(arrayList[0]);
                int length = arrayList.Count;
                DateTime eDate = Convert.ToDateTime(arrayList[length - 1]);
                array.Add(sDate);
                DateTime i = sDate.Date;
                int flag = 0;
                while (i <= eDate.Date)
                {

                    if (flag == 0)
                    {
                        if (!arrayList.Contains(i))
                        {
                            flag = 1;
                            DateTime temp = i.Date.AddDays(-1);
                            array.Add(temp);
                        }
                        else
                        {
                            flag = 0;
                        }
                    }
                    else
                    {
                        if (arrayList.Contains(i))
                        {
                            flag = 0;
                            array.Add(i);
                        }
                    }

                    i = i.Date.AddDays(1);
                }

                array.Add(eDate);

                String t1, t2;

                for (int j = 0; j < (array.Count - 2); j += 2)
                {
                    t1 = Convert.ToDateTime(array[j]).ToShortDateString();
                    t2 = Convert.ToDateTime(array[j + 1]).ToShortDateString();
                    dgv_freeTimeSlots.Rows.Add(t1, t2);
                }
                t1 = Convert.ToDateTime(array[array.Count - 2]).ToShortDateString();
                t2 = Convert.ToDateTime(array[array.Count - 1]).ToShortDateString();
                dgv_freeTimeSlots.Rows.Add(t1, t2);
            }



        }
    }
}
