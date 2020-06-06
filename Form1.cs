using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TJproject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Button> list = new List<Button>();
            for (int i = 0; i < 200; i++)
            {
                Button b = new Button();
                b.Location = new Point(50 * i + 2, 0);//位置自bai己确定du一下zhi
                b.Size = new Size(40, 30);//按钮大小dao
                b.Text = i.ToString();
                list.Add(b);
            }
            this.panel1.Controls.AddRange(list.ToArray());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //RestClient client = new RestClient("http://localhost:7878/");
            //var result = client.Get("Interface/PC/GetPcStaff.ashx?informationNum=440221196011081611");
            //RootObject rb = JsonConvert.DeserializeObject<RootObject>(jsonText);  
            //Console.WriteLine(result);
            var str =GetFunction("http://localhost:7878/" + "Interface/PC/GetPcStaff.ashx?informationNum=440221196011081611");
            JavaScriptObject jsonObj = JavaScriptConvert.DeserializeObject<JavaScriptObject>(str);
            Console.WriteLine("");
        }

         private string GetFunction(string url)
        {

            System.Net.HttpWebRequest request;
            // 创建一个HTTP请求  
            request = (System.Net.HttpWebRequest)WebRequest.Create(url);
            request.Timeout = 5000;
            //request.Method="get";  
            System.Net.HttpWebResponse response;
            response = (System.Net.HttpWebResponse)request.GetResponse();
            System.IO.StreamReader myreader = new System.IO.StreamReader(response.GetResponseStream(), Encoding.UTF8);
            string responseText = myreader.ReadToEnd();
            myreader.Close();
            return responseText;
        }
      
    }
}
