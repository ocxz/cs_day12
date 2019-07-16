using System;
using System.IO;

namespace _01_directory目录
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             *   1、创建目录 Directory.CreateDirectory(path)
             *   2、删除目录 Directory.Delete(path,recursive)
             *   3、判断文件夹是否存在 Directory.Exists(path)
             *   4、文件夹的剪切操作 Directory.Move(要剪切的目录，剪到那个目录里）
             *   5、获得指定目录所有文件夹名称（不涉及递归）
             *   6、获得指定目录中所有文件名称（不涉及递归调用）没有返回空
             *   Directory.GetFile(path,"*.txt") 指定限定名查找 默认为查看全部
             * 
             */

            #region 1、创建文件夹

            //Directory.CreateDirectory("test");   // 创建一个文件夹，用来存放测试文件夹
            //for (int i = 0; i < 100; i++)
            //{
            //    // 循环创建名字为1-10是个文件夹
            //    Directory.CreateDirectory("test\\" + i);
            //    for (int j = 0; j < 100; j++)
            //    {
            //        // 每创建一个文件夹，在里面字创建1-10的文件夹
            //        Directory.CreateDirectory("test\\" + i + "\\" + j);
            //    }
            //    Console.WriteLine("两次文件夹{0}创建完成", i);
            //}
            //Console.WriteLine("全部创建完成");
            //Console.ReadKey();

            #endregion

            #region 2、删除文件夹 Directory.Delete(path,recursive)

            ////Directory.Delete(@"test\0\0");
            //Directory.Delete(@"test", true); // 强删除
            //Console.WriteLine("删除成功");
            //Console.ReadKey();

            #endregion

            #region 3、判断文件夹是否存在 Directory.Exists(path)

            //string dirPath = @"b\b\c";
            //if (Directory.Exists(dirPath))
            //{
            //    Console.WriteLine("{0}这个文件夹已经存在",dirPath);
            //}
            //else
            //{
            //    Directory.CreateDirectory(dirPath);
            //    Console.WriteLine("{0}文件夹不存在，已创建", dirPath);
            //}
            //Console.ReadKey();

            #endregion

            #region 4、文件夹的剪切操作

            //string msoruceDirName = @"b";
            //string mdestDirName = @"d\b";
            //Directory.Move(msoruceDirName, mdestDirName);
            //Console.WriteLine("文件夹剪切成功");
            //Console.ReadKey();

            #endregion

            #region 5、获得指定目录的所有文件夹名称（不涉及递归）

            //string[] dirs = Directory.GetDirectories("d");
            //foreach (var item in dirs)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadKey();

            #endregion

            #region 6、获得指定目录中所有文件名称（不涉及递归调用）没有返回空

            //string[] strs = Directory.GetFiles(@"F:\c#代码\第十二天\第十二天解决方案\_01_directory目录\bin\Debug\netcoreapp2.1", "*.json");
            //foreach (var item in strs)
            //{
            //    Console.WriteLine(Path.GetFileName(item.ToString()));
            //}
            //Console.ReadKey();

            #endregion
        }
    }
}
