namespace lab10._1_graph_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(@"C:\Users\������ Vlad\Documents\tempWinF"))   //�������� ������������� ����� temp
            {
                Directory.CreateDirectory(@"C:\Users\������ Vlad\Documents\tempWinF"); //�������� ����� temp
            }
            Directory.CreateDirectory(@"C:\Users\������ Vlad\Documents\tempWinF\K1");   //�������� ����� �1
            Directory.CreateDirectory(@"C:\Users\������ Vlad\Documents\tempWinF\K2");   //�������� ����� �2
            StreamWriter sw = new StreamWriter(@"C:\Users\������ Vlad\Documents\tempWinF\K1\t1.txt");       //������ ������ � ����
            sw.Write("���������� ���� ���������, 2004 ���� ��������, ����� ���������� �. ��������");
            sw.Close();
            sw = new StreamWriter(@"C:\Users\������ Vlad\Documents\tempWinF\K1\t2.txt");
            sw.Write("��������� ������� ���������, 2004 ���� ��������, ����� ���������� �. ��������");
            sw.Close();
            sw = new StreamWriter(@"C:\Users\������ Vlad\Documents\tempWinF\K2\t3.txt");    //�������� ����� t3
            StreamReader sr = new StreamReader(@"C:\Users\������ Vlad\Documents\tempWinF\K1\t1.txt");   //���������� ������ �� t1
            sw.WriteLine(sr.ReadToEnd());    //���������� ���� �������� 
            sr.Close();
            sr = new StreamReader(@"C:\Users\������ Vlad\Documents\tempWinF\K1\t2.txt");     //���������� ������ �� t2
            sw.WriteLine(sr.ReadToEnd());
            sr.Close();
            sw.Close();
            //�������� ������
            DirectoryInfo dir1 = new DirectoryInfo(@"C:\Users\������ Vlad\Documents\tempWinF\K1");
            DirectoryInfo dir2 = new DirectoryInfo(@"C:\Users\������ Vlad\Documents\tempWinF\K2");
            FileInfo[] info = dir1.GetFiles();
            //Console.WriteLine("���������� � ������ � ����� K1\n");
            foreach (FileInfo fi in info)
            {
                textBox1.Text += "���� � �����: " + fi.FullName.ToString() + Environment.NewLine + "��� �����: " + fi.Name.ToString() + Environment.NewLine +
                   "���������� �����: " + fi.Extension.ToString() + Environment.NewLine + "����� �������� �����: " + fi.CreationTime.ToString();

            }
            //Console.WriteLine();
            FileInfo[] info2 = dir2.GetFiles();
            //Console.WriteLine("\n���������� � ������ � ����� K2\n");
            foreach (FileInfo fi in info2)
            {
                textBox2.Text += "���� � �����: " + fi.FullName.ToString() + Environment.NewLine + "��� �����: " + fi.Name.ToString() + Environment.NewLine +
                   "���������� �����: " + fi.Extension.ToString() + Environment.NewLine + "����� �������� �����: " + fi.CreationTime.ToString();
                //Console.WriteLine("\n");
            }

            File.Move(@"C:\Users\������ Vlad\Documents\tempWinF\K1\t2.txt",
                @"C:\Users\������ Vlad\Documents\tempWinF\K2\t2.txt");  //������� ����� t2.txt � ����� K2.
            File.Copy(@"C:\Users\������ Vlad\Documents\tempWinF\K1\t1.txt",
                @"C:\Users\������ Vlad\Documents\tempWinF\K2\t1.txt");  //����������� ����� t1.txt � ����� K2.
            Directory.Move(@"C:\Users\������ Vlad\Documents\tempWinF\K2",
                @"C:\Users\������ Vlad\Documents\tempWinF\ALL");     //�������������� K2 � ALL
            Directory.Delete(@"C:\Users\������ Vlad\Documents\tempWinF\K1", true);   //�������� ����� �1
            DirectoryInfo dinf = new DirectoryInfo(@"C:\Users\������ Vlad\Documents\tempWinF\ALL");  //���������� � ������
            FileInfo[] finf = dinf.GetFiles();
            // Console.WriteLine("\n���������� � ������ � ����� ALL\n");
            foreach (FileInfo fi in finf)
            {
                textBox3.Text += "���� � �����: " + fi.FullName.ToString() + Environment.NewLine + "��� �����: " + fi.Name.ToString() + Environment.NewLine +
                   "���������� �����: " + fi.Extension.ToString() + Environment.NewLine + "����� �������� �����: " + fi.CreationTime.ToString();
                //Console.WriteLine("\n");

            }
        }
    }
}