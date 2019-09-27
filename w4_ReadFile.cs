using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // khai bao dia chi chua file can doc
            string FileName = "D:\\test.txt";
            //khai bao Filestream
            try
            {
                FileStream fs = new FileStream(FileName, FileMode.Open);
                StreamReader reader = new StreamReader(fs, Encoding.UTF8);
                Console.WriteLine("File {0} successfully opened!! ",FileName);
                Console.WriteLine("     __:");
                using (reader)//reader la bien cho san
                {
                    Console.WriteLine(reader.ReadToEnd());//reader.ReadToEnd() dung de doc tat ca du lieu co trong file.
                   // Console.WriteLine(reader.ReadLine());//reader.ReadLine() dung de doc 1 dong trong file du lieu
                }
            }
            //Xu ly ngoai le
            catch(FileNotFoundException ex)//xu ly ngoai le khi ko co ten tap tin
            {
                Console.Error.WriteLine("{0}", ex.Message);
            }
            catch (DirectoryNotFoundException dr)//xu ly ngoai le ko co ten thu muc
            {
                Console.Error.WriteLine("{0}", dr.Message);
            }
            catch(IOException e) //cac ngoai le khac
            {
                Console.Error.WriteLine("{0}", e.Message);
            }
            finally
            {
                Console.Read();
            }
            Console.ReadKey();
        }
    }
}
