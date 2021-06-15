using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AdvancedData
{
    public partial class Form1 : Form
    {

        private int deadlockA = 0;
        private int deadlockB = 0;
        private TimeSpan threadATotalTime;

        private TimeSpan threadBTotalTime;
        private int bTypeUserNumber;
        private int aTypeUserNumber;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            deadlockA = 0;
            deadlockB = 0;
 
            aTypeUserNumber = Int32.Parse(txtAuser.Text);

            bTypeUserNumber = Int32.Parse(txtBuser.Text);


            for (int i = 0; i < aTypeUserNumber; i++)
            {
                Thread t = new Thread(new ThreadStart(threadMethodA));

                t.Start();
                printOnList($"Thread A Started");
                t.Name = i + 1 + "th" + "Thread A";       
            }

            for (int i = 0; i < bTypeUserNumber; i++)
            {
                Thread t = new Thread(new ThreadStart(threadMethodB));

                t.Start();
                printOnList($"Thread B Started");
                t.Name = i + 1 + "th" + "Thread B";             
            }   
        }

        private void threadMethodA()
        {           
            var threadBeginTime = DateTime.Now;

            for (int i = 0; i < 100; i++)
            {
                SqlConnection conn = new SqlConnection(@"Data Source=PC;Initial Catalog=AdventureWorks2012;Integrated Security=True");
                conn.Open();
                SqlCommand command = conn.CreateCommand();
                SqlTransaction transaction = conn.BeginTransaction(IsolationLevel.RepeatableRead);

                command.Connection = conn;
                command.Transaction = transaction;

                try
                {
                    updateQuery(20110101, 20111231, command);
                    updateQuery(20110101, 20111231, command);
                    updateQuery(20110101, 20111231, command);
                    updateQuery(20110101, 20111231, command);
                    updateQuery(20110101, 20111231, command);

                    transaction.Commit();

                }
                catch (SqlException ex)
                {
                    if (ex.Number == 1205)
                    {                        
                        transaction.Rollback();
                        this.deadlockA++;                      
                        
                    }                
                }
                finally
                {              
                    command.Dispose();
                    transaction.Dispose();
                    conn.Close();
                    conn.Dispose();
                }
            }

            var threadEndTime = DateTime.Now;
            var threadAElapsedTime = threadEndTime - threadBeginTime;
          
            threadATotalTime += threadAElapsedTime;

            var avgTime = threadATotalTime / aTypeUserNumber;

            printOnList($"Thread A Finished at: {threadAElapsedTime.TotalMinutes}");
            printOnTextFieldA($"{avgTime.TotalMinutes}");
            printOnTextFieldDeadlockA($"{deadlockA}");         

        }

        private void threadMethodB()
        {
            var threadBBeginTime = DateTime.Now;

            for (int i = 0; i < 100; i++)
            {
                SqlConnection conn = new SqlConnection(@"Data Source=PC;Initial Catalog=AdventureWorks2012;Integrated Security=True");
                conn.Open();

                SqlCommand command = conn.CreateCommand();

                SqlTransaction transaction = conn.BeginTransaction(IsolationLevel.RepeatableRead);

                command.Connection = conn;
                command.Transaction = transaction;

                try
                {
                    selectQuery(20110101, 20111231, command);
                    selectQuery(20110101, 20111231, command);
                    selectQuery(20110101, 20111231, command);
                    selectQuery(20110101, 20111231, command);
                    selectQuery(20110101, 20111231, command);

                    transaction.Commit();

                }
                catch (SqlException ex)
                {
                    if (ex.Number == 1205)
                    {
                        transaction.Rollback();
                        this.deadlockB++;                    

                    }                
                }
                finally
                {                
                    command.Dispose();
                    transaction.Dispose();
                    conn.Close();
                    conn.Dispose();
                }
            }

            var threadBEndTime = DateTime.Now;
            var threadBElapsedTime = threadBEndTime - threadBBeginTime;
            threadBTotalTime += threadBElapsedTime;
            var threadBAvgTime = threadBTotalTime / bTypeUserNumber;
           
            printOnList($"Thread B Finished at: {threadBElapsedTime.TotalMinutes}");
            printOnTextFieldB($"{threadBAvgTime.TotalMinutes }");
            printOnTextFieldDeadlockB($"{deadlockB}");
        }

        public void updateQuery(int fromDate, int toDate, SqlCommand command)
        {
            Random rand = new Random();
            if (rand.NextDouble() < 0.5)
            {
                command.CommandText = "UPDATE Sales.SalesOrderDetail SET UnitPrice = UnitPrice * 10.0 / 10.0 WHERE UnitPrice > 100 AND EXISTS(SELECT * FROM Sales.SalesOrderHeader " +
                    "WHERE Sales.SalesOrderHeader.SalesOrderID = Sales.SalesOrderDetail.SalesOrderID AND Sales.SalesOrderHeader.OrderDate BETWEEN '" + fromDate + "' AND '" + toDate + "' " +
                    "AND Sales.SalesOrderHeader.OnlineOrderFlag = 1)";
                command.ExecuteNonQuery();
            }
        }

        public void selectQuery(int fromDate, int toDate, SqlCommand command)
        {
            Random rand = new Random();

            if (rand.NextDouble() < 0.5)
            {
                command.CommandText = "SELECT SUM(Sales.SalesOrderDetail.OrderQty) FROM Sales.SalesOrderDetail WHERE UnitPrice > 100 " +
                            "AND EXISTS(SELECT* FROM Sales.SalesOrderHeader WHERE Sales.SalesOrderHeader.SalesOrderID = Sales.SalesOrderDetail.SalesOrderID " +
                            "AND Sales.SalesOrderHeader.OrderDate BETWEEN '" + fromDate + "' AND '" + toDate + "' AND Sales.SalesOrderHeader.OnlineOrderFlag = 1)";            
                command.ExecuteNonQuery();
            }
        }         

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=PC;Initial Catalog=AdventureWorks2012;Integrated Security=True");

            try
            {
                conn.Open();
                Console.WriteLine("Database connected!");          

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message + "here");
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }

        private void printOnList(string bilmemne)
        {
            this.Invoke(new EventHandler(delegate
            {
                listBox1.Items.Add(bilmemne);
            }));
        }

        private void printOnTextFieldA(string txtA)
        {
            this.Invoke(new EventHandler(delegate
            {
               AvgTimeOfA.Text = txtA;

            }));
        }
        private void printOnTextFieldB(string txtB)
        {
            this.Invoke(new EventHandler(delegate
            {
                AvgTimeOfB.Text = txtB;

            }));
        }

        private void printOnTextFieldDeadlockA(string txtdA)
        {
            this.Invoke(new EventHandler(delegate
            {
                txtNumDeadlocksOfA.Text = txtdA;

            }));
        }

        private void printOnTextFieldDeadlockB(string txtdB)
        {
            this.Invoke(new EventHandler(delegate
            {
                txtNumDeadlocksOfB.Text = txtdB;

            }));
        }

    }
}
