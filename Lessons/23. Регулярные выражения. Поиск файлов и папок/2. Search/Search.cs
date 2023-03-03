using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace CSharpApplication.SearchInFiles
{
    // ����� ��� ������ ������ � ������, �������� DOS'����� ������
    class Search
    {
        /*
         class Directory https://msdn.microsoft.com/ru-ru/library/system.io.directory(v=vs.110).aspx
         class DirectoryInfo https://msdn.microsoft.com/ru-ru/library/system.io.directoryinfo(v=vs.110).aspx
         class File https://msdn.microsoft.com/ru-ru/library/system.io.file(v=vs.110).aspx
         class FileInfo https://msdn.microsoft.com/ru-ru/library/system.io.fileinfo(v=vs.110).aspx
         */
        static void Main()
        {
            Console.Write("������� ���� � ��������: ");
            string Path = Console.ReadLine();
            Console.Write("������� ����� ��� ������: ");
            string Mask = Console.ReadLine();
            Console.Write("������� ����� ��� ������ � ������: ");
            string Text = Console.ReadLine();

            // ���������� ���� (� ������ ��� ����������)
            if(Path[Path.Length - 1] != '\\')
                Path += '\\';

            // �������� ������� �� ������ ���������� ����
            DirectoryInfo di = new DirectoryInfo(Path);
            // ���� ���� �� ����������
            if(!di.Exists)
            {
                Console.WriteLine("������������ ����!!!");
                return;
            }
            
            // ����������� ��������� ����� ��� ������ 
            // � ���������� ���������

            // �������� . �� \.
            Mask = Mask.Replace(".", @"\.");
            // �������� ? �� .
            Mask = Mask.Replace("?", ".");
            // �������� * �� .*
            Mask = Mask.Replace("*", ".*");
            // ���������, ��� ��������� ����� ������ ������������ �����
            Mask = "^" + Mask + "$";
            
            // �������� ������� ����������� ���������
            // �� ������ �����
            Regex regMask = new Regex(Mask, RegexOptions.IgnoreCase);
            
            // ���������� ����������� �� ��������� ������
            Text = Regex.Escape(Text);
            // �������� ������� ����������� ���������
            // �� ������ ������
            Regex regText = Text.Length == 0 ? null : new Regex(Text, RegexOptions.IgnoreCase);
            try
            {
                // �������� ������� ������
                ulong Count = FindTextInFiles(regText, di, regMask);
                Console.WriteLine("����� ���������� ������: {0}.", Count);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        // ������� ������
        static ulong FindTextInFiles(Regex regText, DirectoryInfo di, Regex regMask)
        {
            // ����� ��� ������ �� �����
            StreamReader sr = null;
            // ������ ��������� ����������
            MatchCollection mc = null;
            
            // ���������� ������������ ������
            ulong CountOfMatchFiles = 0;

            FileInfo [] fi = null;
            try
            {
                // �������� ������ ������
                fi = di.GetFiles();
            }
            catch
            {
                return CountOfMatchFiles;
            }
        
            // ���������� ������ ������
            foreach(FileInfo f in fi)
            {
                // ���� ���� ������������� �����
                if(regMask.IsMatch(f.Name))
                {
                    // ����������� �������
                    ++CountOfMatchFiles;
                    Console.WriteLine("File " + f.Name);
                    if (regText != null)
                    {
                        // ��������� ����
                        sr = new StreamReader(di.FullName + @"\" + f.Name,
                            Encoding.Default);
                        // ��������� �������
                        string Content = sr.ReadToEnd();
                        // ��������� ����
                        sr.Close();
                        // ���� �������� �����
                        mc = regText.Matches(Content);
                        // ���������� ������ ���������
                        foreach (Match m in mc)
                        {
                            Console.WriteLine("����� ������ � ������� {0}.", m.Index);
                        }
                    }
                }
            }
                              
            // �������� ������ ������������
            DirectoryInfo [] diSub  = di.GetDirectories();
            // ��� ������� �� ��� �������� (����������)
            // ��� �� ������� ������
            foreach(DirectoryInfo diSubDir in diSub)
                CountOfMatchFiles += FindTextInFiles(regText, diSubDir, regMask);

            // ������� ���������� ������������ ������
            return CountOfMatchFiles;
        }
    }
}