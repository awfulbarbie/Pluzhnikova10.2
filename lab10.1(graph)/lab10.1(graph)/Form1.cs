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
            if (!Directory.Exists(@"C:\Users\Просто Vlad\Documents\tempWinF"))   //проверка существования папки temp
            {
                Directory.CreateDirectory(@"C:\Users\Просто Vlad\Documents\tempWinF"); //создание папки temp
            }
            Directory.CreateDirectory(@"C:\Users\Просто Vlad\Documents\tempWinF\K1");   //создание папки к1
            Directory.CreateDirectory(@"C:\Users\Просто Vlad\Documents\tempWinF\K2");   //создание папки к2
            StreamWriter sw = new StreamWriter(@"C:\Users\Просто Vlad\Documents\tempWinF\K1\t1.txt");       //запись текста в файл
            sw.Write("Плужникова Анна Андреевна, 2004 года рождения, место жительства г. Владимир");
            sw.Close();
            sw = new StreamWriter(@"C:\Users\Просто Vlad\Documents\tempWinF\K1\t2.txt");
            sw.Write("Плужников Дмитрий Андреевич, 2004 года рождения, место жительства г. Владимир");
            sw.Close();
            sw = new StreamWriter(@"C:\Users\Просто Vlad\Documents\tempWinF\K2\t3.txt");    //создание файла t3
            StreamReader sr = new StreamReader(@"C:\Users\Просто Vlad\Documents\tempWinF\K1\t1.txt");   //считывание текста из t1
            sw.WriteLine(sr.ReadToEnd());    //считывание всех символов 
            sr.Close();
            sr = new StreamReader(@"C:\Users\Просто Vlad\Documents\tempWinF\K1\t2.txt");     //считывание текста из t2
            sw.WriteLine(sr.ReadToEnd());
            sr.Close();
            sw.Close();
            //описание файлов
            DirectoryInfo dir1 = new DirectoryInfo(@"C:\Users\Просто Vlad\Documents\tempWinF\K1");
            DirectoryInfo dir2 = new DirectoryInfo(@"C:\Users\Просто Vlad\Documents\tempWinF\K2");
            FileInfo[] info = dir1.GetFiles();
            //Console.WriteLine("Информация о файлах в папке K1\n");
            foreach (FileInfo fi in info)
            {
                textBox1.Text += "Путь к файлу: " + fi.FullName.ToString() + Environment.NewLine + "Имя файла: " + fi.Name.ToString() + Environment.NewLine +
                   "Расширение файла: " + fi.Extension.ToString() + Environment.NewLine + "Время создания файла: " + fi.CreationTime.ToString();

            }
            //Console.WriteLine();
            FileInfo[] info2 = dir2.GetFiles();
            //Console.WriteLine("\nИнформация о файлах в папке K2\n");
            foreach (FileInfo fi in info2)
            {
                textBox2.Text += "Путь к файлу: " + fi.FullName.ToString() + Environment.NewLine + "Имя файла: " + fi.Name.ToString() + Environment.NewLine +
                   "Расширение файла: " + fi.Extension.ToString() + Environment.NewLine + "Время создания файла: " + fi.CreationTime.ToString();
                //Console.WriteLine("\n");
            }

            File.Move(@"C:\Users\Просто Vlad\Documents\tempWinF\K1\t2.txt",
                @"C:\Users\Просто Vlad\Documents\tempWinF\K2\t2.txt");  //перенос файла t2.txt в папку K2.
            File.Copy(@"C:\Users\Просто Vlad\Documents\tempWinF\K1\t1.txt",
                @"C:\Users\Просто Vlad\Documents\tempWinF\K2\t1.txt");  //копирование файла t1.txt в папку K2.
            Directory.Move(@"C:\Users\Просто Vlad\Documents\tempWinF\K2",
                @"C:\Users\Просто Vlad\Documents\tempWinF\ALL");     //переименование K2 в ALL
            Directory.Delete(@"C:\Users\Просто Vlad\Documents\tempWinF\K1", true);   //удаление папки К1
            DirectoryInfo dinf = new DirectoryInfo(@"C:\Users\Просто Vlad\Documents\tempWinF\ALL");  //информация о файлах
            FileInfo[] finf = dinf.GetFiles();
            // Console.WriteLine("\nИнформация о файлах в папке ALL\n");
            foreach (FileInfo fi in finf)
            {
                textBox3.Text += "Путь к файлу: " + fi.FullName.ToString() + Environment.NewLine + "Имя файла: " + fi.Name.ToString() + Environment.NewLine +
                   "Расширение файла: " + fi.Extension.ToString() + Environment.NewLine + "Время создания файла: " + fi.CreationTime.ToString();
                //Console.WriteLine("\n");

            }
        }
    }
}