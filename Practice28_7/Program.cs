#region 
// ====================================================================== 
 
// ======================================================================
#endregion

using System;
using System.IO;
using System.Data;
using System.Collections.Generic;

namespace Practice28_7
{
    class Program
    {
        private static List<string> _fileList = new List<string>();
        static void Main(string[] args)
        {
            string sPath = @"E:\workSpace_Etc\TestFile\data.txt";
            string sFilePath = @"E:\workSpace_Etc\TestFile\202108\18\";
            string sFileName = (Path.GetFileName(sPath)).Substring(0, 5);
            string sFileExt = Path.GetExtension(sPath);

            //Duplicate File 
            for (int i = 0; i < 100; i++)
            {
                File.Copy(sPath, sFilePath + sFileName + i + sFileExt);
                _fileList.Add((sFilePath + sFileName + i + sFileExt).ToString());
            }

            DataSet ds = new DataSet();
            ds.Tables.Add("Table_Name");
            ds.Tables["Table_Name"].Columns.Add("FILE_PATH");


            for (int i = 0; i < _fileList.Count; i++)
            {
                ds.Tables[0].Rows.Add(_fileList[i]);
            }

            LF_FilePath_Delete();
            Console.ReadLine();
        }

        /// <summary>
        /// Delete File
        /// </summary>
        private static void LF_FilePath_Delete()
        {
            try
            {
                for (int i = 0; i < _fileList.Count; i++)
                {
                    FileInfo fileInfo = new FileInfo(_fileList[i].ToString());

                    if (fileInfo.Exists)
                    {
                        fileInfo.Delete();
                        Console.WriteLine("Deleted File");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Message);
            }
        }
    }
}