using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WordJumble
{
    public partial class ScoresTable : Form
    {
        private ListView lst = null;
        ListViewGroup[] groups = new ListViewGroup[4];

        public ScoresTable()
        {
            InitializeComponent();
        }

        private void GenerationList()
        {
            if (lst == null)
            {                
                lst = new ListView();
                ColumnHeader[] cols = new ColumnHeader[5];                
                string[] colsName = { "Name", "Point", "Bonus", "Missed", "Time" };
                string[] groupsName = { "Beginner", "Average", "Expert", "Time Limited" };

                //Generation Column
                for (int i = 0; i < cols.Length; i++)
                {
                    cols[i] = new ColumnHeader();
                }

                //Generation Column's Properties
                for (int i = 0; i < colsName.Length; i++)
                {
                    cols[i].Text = colsName[i];
                    cols[i].Width = 60;
                }

                //Generation Group
                for (int i = 0; i < groups.Length; i++)
                {
                    groups[i] = new ListViewGroup();                    
                }

                //Generation Group's Header
                for (int i = 0; i < groupsName.Length; i++)
                {
                    groups[i].Header = groupsName[i];
                }

                //Generation ListView's Properties
                lst.Size = new Size(375, 262);
                lst.Location = new Point(7, 41);
                lst.View = View.Details;

                lst.Columns.AddRange(cols);
                lst.Groups.AddRange(groups);
                lst.Sorting = SortOrder.Ascending;
                lst.AllowColumnReorder = false;
                lst.FullRowSelect = true;                
                
                this.Controls.Add(lst);
            }
        }

        private void ItemLoading()
        {
            string[] files = new string[4] { "Beginner", "Average", "Expert", "TimeLimited" };
            string s = null;

            for (int i = 0; i < files.Length; i++)
            {
                if (File.Exists(@"Scores\" + files[i] + ".wjhs"))
                {
                    using (FileStream fs = new FileStream(@"Scores\" + files[i] + ".wjhs", FileMode.Open, FileAccess.Read, FileShare.Read))
                    {
                        StreamReader sReader = new StreamReader(fs);

                        while (!sReader.EndOfStream)
                        {
                            s = sReader.ReadLine();                        

                            int idx = 0;
                            string[] item = new string[5];
                            foreach (string s2 in s.Split(','))
                            {
                                item[idx] = s2;
                                idx++;
                            }
                            ListViewItem lstitem = new ListViewItem(item);

                            //lstitem.Group = groups[0];
                            groups[i].Items.Add(lstitem);
                        
                            lst.Items.Add(lstitem);
                            lst.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
                        }
                    }
                }
            }
        }

        private void ScoresTable_Load(object sender, EventArgs e)
        {
            GenerationList();
            ItemLoading();            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }        
    }
}
