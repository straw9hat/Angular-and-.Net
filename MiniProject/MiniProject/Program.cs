using System;
using System.IO;
using System.Data;
using System.Data.OleDb;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace MiniProject
{
    class Complaint
    {
        DateTime dateReceived;
        string product;
        string subProduct;
        string issue;
        string subIssue;
        string company;
        string state;
        int zipCode;
        string submittedVia;
        DateTime dateFiled;
        string closedStatus;
        string timelyResponse;
        string consumerDisputed;
        int complaintId;

        public DateTime DateReceived { get; set; }
        public string Product { get; set; }
        public string SubProduct { get; set; }
        public string Issue { get; set; }
        public string SubIssue { get; set; }
        public string Company { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public string SubmittedVia { get; set; }
        public DateTime DateFiled { get; set; }
        public string ClosedStatus { get; set; }
        public string TimelyResponse { get; set; }
        public string ConsumerDisputed { get; set; }
        public int ComplaintId { get; set; }
        
        public Complaint()
        {
            Console.WriteLine("Fill the following details to file a complaint");
            Console.WriteLine("Product Name - ");
            Product = Console.ReadLine();
            Console.WriteLine("Sub-Product - ");
            SubProduct = Console.ReadLine();
            Console.WriteLine("Issue - ");
            Issue = Console.ReadLine();
            Console.WriteLine("Sub-Issue - ");
            SubIssue = Console.ReadLine();
            Console.WriteLine("Company Name - ");
            Company = Console.ReadLine();
            Console.WriteLine("State of residence - ");
            State = Console.ReadLine();
            Console.WriteLine("ZipCode - ");
            ZipCode = Convert.ToInt32(Console.ReadLine());
            new Retrieve().Importcsv("complaints.csv",1);
        }
    }
    class Retrieve
    {
        public void Importcsv(string s, int a)
        {
            string file = Path.GetFileName(s);
            string dir = Path.GetDirectoryName(s);
            string sConnection = "Provider=Microsoft.Jet.OLEDB.4.0;"
                                     + "Data Source=\"" + dir + "\\\";"
                                     + "Extended Properties=\"text;HDR=YES;FMT=Delimited\"";
            try
            {
                var objConn = new OleDbConnection(sConnection);
                objConn.Open();
                var ds = new DataSet();
                OleDbDataAdapter da;
                int choiceUS = 7;
                if (a == 0)
                {
                    Console.WriteLine("How do you want to view the complaints? \n 1.Sort by year \n 2.Sort by bank \n " +
                    "3.Sort by complaint id \n 4.Sort by time taken to resolve the issue \n 5.Complaints closed \n 6.Complaints that received a timely response");
                    choiceUS = Convert.ToInt32(Console.ReadLine());
                }
                switch (choiceUS)
                {
                    case 1:
                        Console.WriteLine("Enter the year you want to view");
                        int year = Convert.ToInt32(Console.ReadLine());
                        da = new OleDbDataAdapter("SELECT * FROM `" + file + "` where year(\"Date sent to company\") =" + year+";", sConnection);
                        break;
                    case 2:
                        Console.WriteLine("Enter the bank you want to view");
                        string bn = Console.ReadLine();
                        da = new OleDbDataAdapter("SELECT * FROM `" + file + "` where Company =" + bn + ";", sConnection);
                        break;
                    case 3:
                        Console.WriteLine("Enter the year you want to view");
                        int cId = Convert.ToInt32(Console.ReadLine());
                        da = new OleDbDataAdapter("SELECT * FROM `" + file + "` where \"Complaint ID\" =" + cId + ";", sConnection);
                        break;
                    case 4:
                        da = new OleDbDataAdapter("SELECT Company,Days FROM `" + file + "` set Days = DateDiff(\"Date sent to company\" ,\"Date received\");", sConnection);
                        break;
                    case 5:
                        da = new OleDbDataAdapter("SELECT * FROM `" + file + "` where \"Company response to consumer\" = \"Closed\" OR \"Company response to consumer\" = \"Closed with explanation\";", sConnection);
                        break;
                    case 6:
                        da = new OleDbDataAdapter("SELECT Company,Days FROM `" + file + "` where DateDiff(\"Date sent to company\", \"Date received\") > 7;", sConnection);
                        break;
                    case 7:
                        Complaint c = new Complaint();
                        da = new OleDbDataAdapter("Insert into `" + file + "` values("+c.DateReceived+","+c.Product+","+c.SubProduct+","+c.Issue+","+c.SubIssue+","+c.Company+","+c.State+","+c.ZipCode+","+
                            c.SubmittedVia+","+c.DateFiled+","+c.ClosedStatus+","+c.TimelyResponse+","+c.ConsumerDisputed+","+c.ComplaintId +");", sConnection);
                        break;
                    default:
                        da = new OleDbDataAdapter("SELECT * FROM `" + file + "`", sConnection);
                        break;
                }
                da.Fill(ds);
                DataTable dt = ds.Tables[s];
                foreach(DataRow row in dt.Rows)
                {
                    foreach (DataColumn col in dt.Columns)
                        Console.WriteLine(row[col]);
                    Console.WriteLine("".PadLeft(20, '='));
                }
                objConn.Close();
                
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.Message + ex.Source);
                
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Complaint Reports!!");
            int choice;
            do
            {
                Console.WriteLine(" 1.View Complaints \n 2.Add a complaint \n 3.Exit \n Select (1/2/3)");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        new Retrieve().Importcsv("complaints.csv", 0);
                        break;
                    case 2:
                        new Complaint(); 
                        break;
                    case 3:
                        break;
                }
            } while (choice != 3);
        }
    }
}
