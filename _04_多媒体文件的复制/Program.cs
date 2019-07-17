using System;
using System.IO;

namespace _04_多媒体文件的复制
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 利用FileStream实现多媒体文件复制

            string srcFilePath = @"F:\c#代码\第十一天\第十一天解决方案\_17_File类的写操作\bin\Debug\netcoreapp2.1\new2.txt";
            string destFilePath = @"new3.txt";

            FileCopy(srcFilePath, destFilePath);
            Console.WriteLine("文件{0}复制完成", Path.GetFileName(srcFilePath));
            Console.ReadKey();

            #endregion

            #region MyRegion

            //string srcFilePath = @"F:\c#代码\第十一天\第十一天解决方案\_17_File类的写操作\bin\Debug\netcoreapp2.1\new2.txt";
            //string destFilePath = @"new3.txt";

            //FileCopyTwo(srcFilePath, destFilePath);
            //Console.WriteLine("{0}复制完成", Path.GetFileName(srcFilePath));
            //Console.ReadKey();

            #endregion
        }

        /// <summary>
        /// 多媒体文件的复制
        /// </summary>
        /// <param name="sorucePath">源文件路径</param>
        /// <param name="destPath">目标文件路径</param>
        public static void FileCopy(string srcFilePath, string destFilePath)
        {
            using (FileStream fsRead = new FileStream(srcFilePath, FileMode.Open, FileAccess.Read))
            {
                using (FileStream fsWrite = new FileStream(destFilePath, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    // 创建缓冲区
                    byte[] buffer = new byte[1024 * 1024];   // 1M的缓冲区

                    while (true)
                    {
                        // 读入缓冲区,返回读到的字节数 当读取完成后，返回r=0
                        int r = fsRead.Read(buffer, 0, buffer.Length);

                        if (r == 0)   // 读入完成，直接退出当前方法
                        {
                            return;
                        }
                        else
                        {
                            fsWrite.Write(buffer, 0, r);   // r表示实际读到的字节数，写入时不能多写
                        }
                    }
                    
                }
            }
        }

        public static void FileCopyTwo(string srcFilePath,string destFilePath)
        {
            byte[] buffer = File.ReadAllBytes(srcFilePath);

            File.WriteAllBytes(destFilePath, buffer);
        }
    }

}
