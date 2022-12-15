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
using System.Xml;

namespace ClipBoard
{
    public partial class ClipBoard : Form
    {
        public ClipBoard()
        {
            InitializeComponent();
        }
        
        public MyStack Data = new MyStack();// Sử dụng lưu dữ liệu vào trong stack để quản lí 
        public MyStack DataTemp = new MyStack();// Sử dụng lưu dữ liệu để cho việc hiển thị dự liệu theo thứ tự dựa trên nguyên tắc LIFO ở HistoryofDataBox
        public MyStack DataTemp1 = new MyStack();// Sử dụng lưu dữ liệu của DataTemp mỗi khi DataTemp có sự thay đổi, đưa dữ liệu vào lại Datatemp để dữ liệu trong DataTemp vẫn tuân theo LIFO
        public string temp;// Sử dụng lưu dữ liệu của BoxCopyData hiện có để Push vào stack Data và DataTemp
        public object temp1;// Sử dụng lưu dữ liệu lấy ra khỏi Stack DataTemp, sau đó đưa vào HistoryofDataBox để hiển thị, Push vào Datatemp1 để không làm mất dữ liệu 
        public object temp2;//  Sử dụng lưu dữ liệu lấy ra khỏi Stack DataTemp1, Push vào Datatemp để không làm mất dữ liệu 

        public void CopyButton_Click(object sender, EventArgs e)// Button Copy --> Copy dữ liệu từ BoxCopyData để rồi hiển thị ở HistoryofDataBox
        { 
                if (BoxCopyData.Text != "")// kiểm tra xem BoxCopyData có văn bản hay không 
                {
                    HistoryOfDataBox.Clear(); // Xóa hết dữ liệu hiển thị để sắp xếp dữ liệu thứ tự in mỗi khi có một dữ liệu mới cần copy từ boxcopydata
                    if (Data.IsEmpty())
                    {
                        temp = BoxCopyData.Text;
                        Data.Push(temp);
                        DataTemp.Push(temp);
                        HistoryOfDataBox.Text = temp;
                    }
                    else
                    {
                        temp = BoxCopyData.Text;
                        Data.Push(temp);
                        DataTemp.Push(temp);
                        while (!DataTemp.IsEmpty())
                        {
                            temp1 = DataTemp.Pop().data;
                            HistoryOfDataBox.Text += temp1 + Environment.NewLine;
                            DataTemp1.Push(temp1);
                        }
                        while (!DataTemp1.IsEmpty())
                        {
                            temp2 = DataTemp1.Pop().data;
                            DataTemp.Push(temp2);
                        }
                    }
                }
        }
        public void PasteButton_Click(object sender, EventArgs e)
        {
            if (!Data.IsEmpty())
            {
                HistoryOfDataBox.Clear();
                if (!DataTemp.IsEmpty())
                {
                    DataTemp.Pop();
                    while (!DataTemp.IsEmpty())
                    {
                        temp1 = DataTemp.Pop().data;
                        HistoryOfDataBox.Text += temp1 + Environment.NewLine;
                        DataTemp1.Push(temp1);
                    }
                    while (!DataTemp1.IsEmpty())
                    {
                        temp2 = DataTemp1.Pop().data;
                        DataTemp.Push(temp2);
                    }
                }
                if (DisplayBox.SelectedText != "") DisplayBox.SelectedText = string.Empty;
                DisplayBox.Text += Convert.ToString(Data.Pop().data) + Environment.NewLine; 
            }
            else MessageBox.Show("The Empty of ClipBoard's Data","CẢNH BÁO",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BoxCopyData.SelectedText != "")
            {
                HistoryOfDataBox.Clear();
                if (Data.IsEmpty())
                {
                    temp = BoxCopyData.SelectedText;
                    Data.Push(temp);
                    DataTemp.Push(temp);
                    HistoryOfDataBox.Text = temp;
                }
                else
                {
                    temp = BoxCopyData.SelectedText;
                    Data.Push(temp);
                    DataTemp.Push(temp);
                    while (!DataTemp.IsEmpty())
                    {
                        temp1 = DataTemp.Pop().data;
                        HistoryOfDataBox.Text += temp1 + Environment.NewLine;
                        DataTemp1.Push(temp1);
                    }
                    while (!DataTemp1.IsEmpty())
                    {
                        temp2 = DataTemp1.Pop().data;
                        DataTemp.Push(temp2);
                    }
                }
            }
            else if (DisplayBox.SelectedText != "")
            {
                HistoryOfDataBox.Clear();
                if (Data.IsEmpty())
                {
                    temp = DisplayBox.SelectedText;
                    Data.Push(temp);
                    DataTemp.Push(temp);
                    HistoryOfDataBox.Text = temp;
                }
                else
                {
                    temp = DisplayBox.SelectedText;
                    Data.Push(temp);
                    DataTemp.Push(temp);
                    while (!DataTemp.IsEmpty())
                    {
                        temp1 = DataTemp.Pop().data;
                        HistoryOfDataBox.Text += temp1 + Environment.NewLine;
                        DataTemp1.Push(temp1);
                    }
                    while (!DataTemp1.IsEmpty())
                    {
                        temp2 = DataTemp1.Pop().data;
                        DataTemp.Push(temp2);
                    }
                }
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            if (BoxCopyData.SelectedText != "")
            {
                BoxCopyData.SelectedText = String.Empty;
            }
            else if (DisplayBox.SelectedText != "")
            {
                DisplayBox.SelectedText = String.Empty;
            }
            else BoxCopyData.Clear();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BoxCopyData.SelectedText != "")
            {
                BoxCopyData.SelectedText = String.Empty;
            }
            else if (DisplayBox.SelectedText != "")
            {
                DisplayBox.SelectedText = String.Empty;
            }
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
           if (MessageBox.Show("Bạn có chắc muốn thoát không?", "CẢNH BÁO !!!", MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();
        }

        private void cLearAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BoxCopyData.Focused) BoxCopyData.Clear();
            if (DisplayBox.Focused) DisplayBox.Clear();
        }
    }
   
}
