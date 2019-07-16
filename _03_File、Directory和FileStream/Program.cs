using System;
using System.IO;
using System.Text;

namespace _03_File_Directory和FileStream
{
    class Program
    {
        static void Main(string[] args)
        {

            /**
             *    一：File:
             *    File.Exists(path) 判断文件释放存在
             *    File.Delete(path) 删除文件
             *    File.Move(源文件路径,目标文件路径)   文件剪切 源文件会删除
             *    File.Copy(源文件路径,目标文件路径）  文件复制 
             *    三种读取方法：1、byte[] buffer = File.ReadAllBytes(path); 
             *                 2、String[] strs = File.ReadAllLines(path);
             *                 3、File.ReadAllText(path);
             *                 
             *    三种写入方法：1、File.WriteAllBytes(path, byte[]);
             *                 2、File.WriteAllLines(path, new string[] { "你好", "我是" });   // 多行写入
             *                 3、File.WriteAllText(path, "今天天气真晴朗，处处好风光");   // 文本写入
             *                 
             *    两种追加方法：1、多行追加   File.AppendAllLines(path,字符串数组);
             *                 2、文本追加   File.AppendAllText(path,字符串); 
             *                 
             *    二：Directory:
             *    Directory.CreateDirectory(dirPath)  文件夹的创建  存在则不创建
             *    Directory.Delete(dirPath, false)  文件夹的删除 强/弱删除
             *    Directory.Exists(dirPath)    判断文件夹是否存在
             *    Directory.Move(dirPath,destDirPath)  文件夹剪切
             *    string[] strs = Directory.GetDirectories(dirPath) 获得文件夹所有子目录名
             *    string[] fileNames = Directory.GetFiles(dirPath)  获得文件夹所有子文件名
             *    
             *    三：FileStream  读操作：
             *    第一步：创建流对象 
             *    FileStream fsRead = new FileStream(path,File.Open,FileAccess.Read);
             *    第二步：创建缓冲区
             *    byte[] buffer = new byte[fsRead.Length];
             *    第三步：将数据读到缓冲区
             *    fsRead.Read(buffer,0,buffer.Length);
             *    第四步：操作读入的
             *    string str = Encoding.Default.GetString(buffer);
             *    Console.WriteLine(str); 
             *    第五步：关闭流、释放资源
             *    fsRead.Close();
             *    fsRead.Dispose (); 
             *    
             *    四：FileStream 读操作 using函数的使用
             *    可以自动关闭流、释放流的资源
             *    
             *    
             */
            #region 第一：文件相关操作
            //String path = @"new2.txt";
            //string destPath = @"new3.txt";
            ////File.Exists(path);    // 判断文件释放存在
            ////File.Delete(path);   // 删除文件
            ////File.Move(path,destPath);   // 文件剪切
            ////File.Copy(path, destPath);    // 文件复制 

            ////byte[] buffer = File.ReadAllBytes(path);   // 字节读取
            ////String[] strs = File.ReadAllLines(path);    // 多行读取
            ////string text = File.ReadAllText(path);    // 文本读取

            ////byte[] buffer = File.ReadAllBytes(path);   // 字节码读取
            ////File.WriteAllBytes(path, buffer);    // 字节码写入
            ////File.WriteAllLines(path, new string[] { "你好", "我是" });   // 多行写入
            ////File.WriteAllText(path, "今天天气真晴朗，处处好风光");   // 文本写入

            ////File.AppendAllLines(path, new string[] { "你好", "泰山" });   // 多行追加写入
            ////File.AppendAllText(path, "哈哈哈"); 
            #endregion

            #region 第二：文件夹相关操作

            //string dirPath = "myDir";
            //string destDirPath = "myDir2";

            // Directory.CreateDirectory(dirPath);   // 创建文件夹
            // Directory.Delete(dirPath, false);    // 删除文件夹 强/弱删除
            // Directory.Exists(dirPath);           // 判断文件夹是否存在
            //Directory.Move(dirPath, destDirPath);   // 文件夹的剪切

            //string[] dirs = Directory.GetDirectories(dirPath);   // 获得文件夹所有字目录名
            //string[] fileNames = Directory.GetFiles(dirPath);   // 获得文件夹下所有文件名



            #endregion

            #region 第三：FileStream 读操作

            //string path = @"new2.txt";
            //// 创建流对象
            //FileStream fsRead = new FileStream(path, FileMode.Open, FileAccess.Read);
            //// 创建缓冲区
            //byte[] buffer = new byte[fsRead.Length];
            //// 将数据读到缓冲区
            //int r = fsRead.Read(buffer, 0, buffer.Length);
            //// 操作读完后的缓冲区字节数组
            //string str = Encoding.Default.GetString(buffer);
            //Console.WriteLine(str);
            //// 关闭流、释放资源
            //fsRead.Close();
            //fsRead.Dispose();

            //Console.ReadKey();

            #endregion

            #region 第四：FileStream 读操作 使用using(){ }块，来避免少写、忘写关闭流或释放资源

            //string path = @"new2.txt";
            //using (FileStream fsRead = new FileStream(path, FileMode.Open, FileAccess.Read))
            //{
            //    // 创建缓冲区
            //    byte[] buffer = new byte[fsRead.Length];
            //    // 将数据读到缓冲区
            //    int r = fsRead.Read(buffer, 0, buffer.Length);
            //    // 操作读完后的缓冲区字节数组
            //    string str = Encoding.Default.GetString(buffer);
            //    Console.WriteLine(str);
            //}

            #endregion

            #region FileStrem 写操作

            //string path = @"new3.txt";
            //using(FileStream fsWriter = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
            //{
            //    string str = "写入的字符串";
            //    // 准备要写入的字节数组
            //    byte[] buffer = Encoding.Default.GetBytes(str);
            //    //将字节输入写入流中
            //    fsWriter.Write(buffer, 0, buffer.Length);
            //    Console.WriteLine("写入成功");
            //    Console.ReadKey();
            //}

            
            #endregion



        }
    }
}
