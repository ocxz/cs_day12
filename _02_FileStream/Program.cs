using System;
using System.IO;
using System.Text;

namespace _02_FileStream
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             *   文件流 FileStream fsRead = new FileStream(@"new2.txt,FileMode.Open,FileAccess.Read)
             *   参数：第一个为路径
             *   第二个为文件操作模式（FileMode.Open 打开、FileMode.Create创建、FileMode.OpenOrCreate打开或创建
             *   、FileMode.Append追加
             *   第三个为文件的使用 （FileAccess.Read 读、FileAccess.Write写、FileAccess.ReadWrite读写）
             *   
             *   创建缓冲区大小
             * 
             */

            // 创建FileStream对象
            FileStream fsRead = new FileStream(@"new2.txt",FileMode.Open,FileAccess.Read);
            long FileSize = fsRead.Length;

            // 创建缓存区的大小 写多少，满了之后，在读出
            byte[] buffer = new byte[FileSize];    // 缓冲区大小为5Mb
             
            // 开始读取数据  返回读取到的数据
            int r = fsRead.Read(buffer, 0, buffer.Length);

            // 将字节数组转化为字符串
            string str = Encoding.Default.GetString(buffer);

            // 关闭流、且释放资源
            fsRead.Close();   // 关闭流
            fsRead.Dispose();   // 释放资源
            // 输出
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("文件大小为{0}", FileSize);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(str);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.ReadKey();
        }
    }
}
