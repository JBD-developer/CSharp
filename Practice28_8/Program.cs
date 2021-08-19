#region 
// ====================================================================== 

// ======================================================================
#endregion

using System;
using System.IO;
using System.Data;
using System.Collections.Generic;

namespace Practice28_8
{
    class Program
    {
        static void Main(string[] args)
        {
            DataSet ds = new DataSet();
            ds.Tables.Add("WMS_TEST_TABLE");
            ds.Tables["WMS_TEST_TABLE"].Columns.Add("OID");
            ds.Tables["WMS_TEST_TABLE"].Columns.Add("LOCATION_D_ID");
            ds.Tables["WMS_TEST_TABLE"].Columns.Add("LOADSTATE_PCT");
            ds.Tables["WMS_TEST_TABLE"].Columns.Add("LOASSTATE_PIXEL_COUNT");
            ds.Tables["WMS_TEST_TABLE"].Columns.Add("CREATE_DATE");
            ds.Tables["WMS_TEST_TABLE"].Columns.Add("IMG_PATH");

            ds.Tables["WMS_TEST_TABLE"].Rows.Add("30", "FA001", "100", "4000", "2021-08-17 오후 6:01:47", @"E:\workSpace_Etc\TestFile\202108\13\2021-08-17-18-01-46.txt");
            ds.Tables["WMS_TEST_TABLE"].Rows.Add("30", "FA001", "100", "4000", "2021-08-17 오후 6:01:47", @"E:\workSpace_Etc\TestFile\202108\16\2021-08-17-18-01-46.txt");
            ds.Tables["WMS_TEST_TABLE"].Rows.Add("30", "FA001", "100", "4000", "2021-08-17 오후 6:01:47", @"E:\workSpace_Etc\TestFile\202108\16\2021-08-17-18-01-46.txt");
            ds.Tables["WMS_TEST_TABLE"].Rows.Add("30", "FA001", "100", "4000", "2021-08-17 오후 6:01:47", @"E:\workSpace_Etc\TestFile\202108\17\2021-08-17-18-01-46.txt");
            ds.Tables["WMS_TEST_TABLE"].Rows.Add("31", "FA002", "100", "5000", "2021-08-17 오후 6:01:50", @"E:\workSpace_Etc\TestFile\202108\17\2021-08-17-18-01-49.txt");
            ds.Tables["WMS_TEST_TABLE"].Rows.Add("32", "FA003", "100", "5000", "2021-08-17 오후 6:01:53", @"E:\workSpace_Etc\TestFile\202108\17\2021-08-17-18-01-51.txt");
            ds.Tables["WMS_TEST_TABLE"].Rows.Add("33", "FA004", "100", "5000", "2021-08-17 오후 6:01:55", @"E:\workSpace_Etc\TestFile\202108\17\2021-08-17-18-01-54.txt");
            ds.Tables["WMS_TEST_TABLE"].Rows.Add("34", "FA001", "100", "4000", "2021-08-18 오전 9:51:01", @"E:\workSpace_Etc\TestFile\202108\18\2021-08-18-09-51-00.txt");
            ds.Tables["WMS_TEST_TABLE"].Rows.Add("35", "FA002", "100", "5000", "2021-08-18 오전 9:51:03", @"E:\workSpace_Etc\TestFile\202108\18\2021-08-18-09-51-03.txt");
            ds.Tables["WMS_TEST_TABLE"].Rows.Add("36", "FA003", "100", "5000", "2021-08-18 오전 9:51:06", @"E:\workSpace_Etc\TestFile\202108\18\2021-08-18-09-51-05.txt");
            ds.Tables["WMS_TEST_TABLE"].Rows.Add("37", "FA004", "100", "5000", "2021-08-18 오전 9:51:09", @"E:\workSpace_Etc\TestFile\202108\18\2021-08-18-09-51-08.txt");


            List<string> listFilePath = new List<string>();
            List<string> listDirPath = new List<string>();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    if (ds.Tables[0].Columns.Contains("IMG_PATH"))
                    {
                        if (!listFilePath.Contains(ds.Tables[0].Rows[i]["IMG_PATH"].ToString()))
                        {
                            listFilePath.Add(ds.Tables[0].Rows[i]["IMG_PATH"].ToString());

                            if (!listDirPath.Contains((ds.Tables[0].Rows[i]["IMG_PATH"].ToString()).Substring(0, 35)))
                            {
                                listDirPath.Add((ds.Tables[0].Rows[i]["IMG_PATH"].ToString()).Substring(0, 35));
                            }
                        }
                    }
                }
            }
            //LF_FilePath_Check(listFilePath);    
            LF_DirPath_Delete(listDirPath);
            Console.ReadLine();
        }

        /// <summary>
        /// Delete Folder
        /// </summary>
        /// <param name="p_listDirPath"></param>
        private static void LF_DirPath_Delete(List<string> p_listDirPath)
        {
            try
            {
                for (int i = 0; i < p_listDirPath.Count; i++)
                {
                    DirectoryInfo directoryInfo = new DirectoryInfo(p_listDirPath[i].ToString());

                    if (directoryInfo.Exists)
                    {
                        directoryInfo.Delete(true);
                        Console.WriteLine("Deleted Folder");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Delete File
        /// </summary>
        /// <param name="p_listTemp"></param>
        private static void LF_FilePath_Check(List<string> p_listTemp)
        {
            string sFilePath = string.Empty;
            string sFileName = string.Empty;

            try
            {
                for (int i = 0; i < p_listTemp.Count; i++)
                {
                    FileInfo fileInfo = new FileInfo(p_listTemp[i].ToString());

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