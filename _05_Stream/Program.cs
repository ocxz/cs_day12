using System;
using System.IO;
using System.Text;

namespace _05_Stream
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             *   使用StreamReader 来读取数据
             *   注意：FileStream读的是字节、Stream文件流读的是字符
             *   第一种方法：利用FileStream来读取文件，然后利用StreamReader来读取流
             *   第二种方法：直接用StreamReader来读取文件
             *   
             *   使用StreamWrite 来写数据
             * 
             */


            #region 一、读  第一种方法：利用FileStream来读取文件，然后利用StreamReader来读取流
            ////使用FileStream读取文件
            //string srcFilePath = @"F:\c#代码\第十一天\第十一天解决方案\_17_File类的写操作\bin\Debug\netcoreapp2.1\new22.txt";
            //using (FileStream fsRead = new FileStream(srcFilePath, FileMode.Open, FileAccess.Read))
            //{
            //    using (StreamReader sr = new StreamReader(fsRead, Encoding.Default))    // 使用Stream读取流
            //    {
            //        while (!sr.EndOfStream)   // 流还没结束 就循环读取
            //        {
            //            Console.WriteLine(sr.ReadLine());
            //        }
            //    }
            //}
            //Console.ReadKey();
            #endregion

            #region 一、读  第二种方法 直接用StreamReader来读取文件
            ////第二种方法 直接用StreamReader来读取文件

            //string srcFilePath = @"F:\c#代码\第十一天\第十一天解决方案\_17_File类的写操作\bin\Debug\netcoreapp2.1\new22.txt";

            //using (StreamReader sr = new StreamReader(srcFilePath, Encoding.Default))
            //{
            //    while (!sr.EndOfStream)
            //    {
            //        Console.WriteLine(sr.ReadLine());
            //    }
            //}
            //Console.ReadKey();

            #endregion

            #region 二、写  第一种方法：利用fsWriter写入到文件 利用StreamWriter写入到fsWriter流中 部分覆盖

            //string filePath = @"text.txt";
            //using (FileStream fsWriter = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write))
            //{
            //    using (StreamWriter sw = new StreamWriter(fsWriter, Encoding.Default))
            //    {
            //        sw.Write("是呀，我们一起出去旅行吧！");
            //    }
            //}

            //Console.WriteLine("写入{0}文件成功", Path.GetFileName(filePath));
            //Console.ReadKey();

            #endregion

            #region  二、写  第二种方法：直接利用StreamWriter写入到文件中 全覆盖

            //string filePath = @"text.txt";
            //using (StreamWriter sw = new StreamWriter(filePath, true, Encoding.Default))
            //{
            //    sw.WriteLine("啦啦啦，我是卖报的小当家");
            //}

            //Console.WriteLine("写入{0}文件成功", Path.GetFileName(filePath));
            //Console.ReadKey();

            //#endregion
        }
    }
}
