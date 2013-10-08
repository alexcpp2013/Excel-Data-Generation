using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;
using System.IO;

using System.Diagnostics;
using Microsoft.Office.Interop.Excel;

namespace GenerateExcelData
{

    //TODO
    //1. Сделать подтягивание шапки из шаблона документа
    //2. Записывать шапку в тот же массив, что и данные

    public partial class Form1 : Form
    {
        //----------------------------------------

        string code = "";
        string file = "";
        bool simple = false;
        int start = 0;
        int count = 0;

        CancellationTokenSource cts = null;

        //bool StopFlag = false;
        
        const int CashElementsWrite = 100;
        const int CashElementsView = 10;

        public Microsoft.Office.Interop.Excel.Application excel = null;

        public _Workbook workbook = null;
        public _Worksheet worksheet = null;

        //----------------------------------------
        
        public Form1()
        {
            InitializeComponent();
        }

        protected void CreateExcel()
        {
            InitExcel();
            const int FirstRow = 2;
            int columns = 0;
            int RowCount = 0;

            try
            {
                columns = GetNewHeader();
                if (columns <= 0)
                    throw (new Exception("Ошибка в формате описания таблицы."));

                if (simple)
                {
                    NewToExcelOneValue(FirstRow, ref RowCount);
                }
                else
                {
                    RowCount = AllToExcelDifferentValue(FirstRow, columns, RowCount);
                }
            }
            catch (Exception err)
            {
                throw (err);
            }
            finally
            {
                SetText(RowCount.ToString());
                //SaveExcel(workbook, file);
                //CheckExcel(excel, workbook, worksheet);
            }
        }
        
        //------------------------------New Data--------------------------------
        protected int GetNewHeader()
        {
            int columns = 0;

            worksheet.Cells[1, ++columns] = "Название";

            return columns;
        }

        private int AllToExcelDifferentValue(int FirstRow, int columns, int RowCount)
        {
            object[,] myArray = new object[count, columns];
            RowCount = NewCreateArray(columns, RowCount, myArray);
            Range range = worksheet.get_Range("A" + FirstRow.ToString(), Type.Missing);
            range = range.get_Resize(count, columns);

            cts.Token.ThrowIfCancellationRequested();
            range.set_Value(Type.Missing, myArray);

            //worksheet.Cells[1, 5].NumberFormat = "0,00";
            return RowCount;
        }

        private int NewCreateArray(int columns, int RowCount, object[,] myArray)
        {
            int local = start;
            for (int i = 0, j = 0; i < count && j < columns; ++i, ++RowCount, j = 0)
            {
                var str = (local++).ToString();

                myArray[i, j] = code + str;
                cts.Token.ThrowIfCancellationRequested();

                if (((int)(i + 1) % CashElementsView) == 0)
                    SetText((i + 1).ToString());

                /*if ((i + 1) % Cash == 0)
                    workbook.Save();*/
            }
            return RowCount;
        }

        private void NewToExcelOneValue(int FirstRow, ref int RowCount)
        {
            var range = worksheet.get_Range("A" + FirstRow.ToString(), Type.Missing);
            int n = FirstRow - 1 + count;
            range = worksheet.Range[worksheet.Cells[FirstRow, 1], worksheet.Cells[n, 1]];
            range.Value = code;
            cts.Token.ThrowIfCancellationRequested();

            RowCount = count;
        }

        //--------------------------------------------------------------------

        private void InitExcel()
        {
            excel = new Microsoft.Office.Interop.Excel.Application();
            workbook = (_Workbook)(excel.Workbooks.Add(Type.Missing));
            worksheet = (_Worksheet)workbook.ActiveSheet;
        }

        protected bool Check(string n)
        {
            if (n == "")
                return false;
            else
                return true;
        }

        protected void CheckExcel()
        {
            ReleaseObject(excel);
            ReleaseObject(workbook);
            ReleaseObject(worksheet);
        }

        protected void ReleaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception err)
            {
                obj = null;
                throw (new Exception("Произошла ошибка во время работы с Excel: \n" + err.Message));
            }
            finally
            {
                GC.Collect();
            }
        }

        //На данный момент - сохранят файл целиком без промежуточного осхранения данных
        protected void SaveExcel()
        {
            try
            {
                //workbook.Save();
                workbook.SaveAs(@file);
                workbook.Close();
            }
            catch (Exception err)
            {
                throw (new Exception("Произошла ошибка во время сохранения: \n" + err.Message));
            }
        }

        protected void OpenExcel(_Workbook workbook, string file)
        {
            try
            {
                workbook.SaveAs(@file);
            }
            catch (Exception err)
            {
                throw (new Exception("Произошла ошибка во время создания: \n" + err.Message));
            }
        }

        delegate void SetTextCallback(string text);

        private void SetText(string text)
        {
            if (this.Elements.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.Elements.Text = text;
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Clear()
        {
            FilePath.Text = "";
            ProgressBar.Visible = false;
        }

        private bool CheckForm()
        {
            if (FilePath.Text == "")
                return false;
            else 
                return true;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (CheckForm() == false)
            {
                MessageBox.Show("Заполнены не все обязательные поля. \n", "Информационное сообщение",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            StartComputing();
            DateTime begin = DateTime.UtcNow;
            DateTime end = DateTime.UtcNow;   

            int tmp = await Task<int>.Run(() =>
            {
                int result = 0;
                try
                {
                    //CheckExcel(excel, workbook, worksheet);
                    Thread.Sleep(100);
                    CreateExcel();

                    cts.Token.ThrowIfCancellationRequested();
                    SaveExcel();
                    
                    //Дополнительная првоерка, войдет в учет времени дважды
                    CheckExcel();
                    end = DateTime.UtcNow;

                    MessageBox.Show("Генерация и запись Excel прошла успешно.\n",
                                "Инофрмация",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);   
                }
                catch (Exception err)
                {
                    MessageBox.Show("Произошла ошибка во время работы программы: \n\n" +
                                    err.Message, "Ошибка",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    CheckExcel();
                }
                return result;
            });

            //end = DateTime.UtcNow;
            StopComputing();
            Time.Text = (end-begin).TotalSeconds.ToString();
        }

        private void StopComputing()
        {
            ProgressBar.Visible = false;
            GenerateButton.Enabled = true;
            OpenButton.Enabled = true;
            CancelExcelButton.Enabled = false;

            code = "";
            file = "";
            simple = false;
            start = 0;
            count = 0;

            cts = null;
        }

        private void StartComputing()
        {            
            Elements.Clear();
            Time.Clear();
            GenerateButton.Enabled = false;
            OpenButton.Enabled = false;
            ProgressBar.Visible = true;
            CancelExcelButton.Enabled = true;

            code = GCode.Text;
            file = FilePath.Text;
            simple = SimpleCheck.Checked;
            start = (int)StartElement.Value;
            count = (int)ElementsCount.Value;

            cts = new CancellationTokenSource();
        }    

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        FilePath.Clear();
                        FilePath.Text = saveFileDialog1.FileName;
                    }
                    catch (Exception ex)
                    {
                        FilePath.Clear();
                        MessageBox.Show("Hе возможно считать файл: \n" + ex.Message, 
                                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                Refresh();
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка при сохранении. \n" + err.Message,
                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Open_Click(object sender, EventArgs e)
        {      
            CheckForm();
            
            try
            {
                Process proc = new Process();
                proc.StartInfo.FileName = FilePath.Text;
                proc.StartInfo.Arguments = "";
                proc.Start();
                //proc.WaitForExit();
            }
            catch(Exception err)
            {
                MessageBox.Show("Ошибка при открытии файла: " + FilePath.Text + "\n" + err.Message, 
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SimpleCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (SimpleCheck.Checked == true)
                StartElement.Enabled = false;
            else
                StartElement.Enabled = true;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Отменить генерацию файла?", "Подтверждение отмены",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (cts != null)
                    cts.Cancel();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            CheckForm();

            if (MessageBox.Show("Удалить файл?", "Подтверждение удаления файла", 
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    File.Delete(@FilePath.Text);
                    MessageBox.Show("Файл удален.", "Инофрмационное сообщение",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (IOException err)
                {
                    MessageBox.Show("Произошла ошибка во время удаления файл " + 
                                    FilePath.Text + ": \n" +
                                    err.Message, "Ошибка",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
