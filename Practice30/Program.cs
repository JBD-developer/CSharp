using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Practice30
{
    class Program
    {
        private static SqlConnection _sqlCon;
        private static SqlCommand _sqlCmd;
        private static ConsoleKeyInfo _keyInfo;
        private static SqlDataReader _sqlReader;
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("-------MENU-------");
                Console.WriteLine("| C : Connection  |");
                Console.WriteLine("| R : READ        |");
                Console.WriteLine("| E : EXIT        |");
                Console.WriteLine("------------------");
                do
                {
                    _keyInfo = Console.ReadKey();
                    Console.WriteLine();
                    
                    switch (_keyInfo.Key.ToString())
                    {
                        case "C":
                            #region Database connection
                            if (LF_Connection())
                            {
                                Console.WriteLine("Successed");
                            }
                            else
                            {
                                Console.WriteLine("Failed");
                            }
                            #endregion
                            break;

                        case "R":
                            #region SELECT
                            LF_Basic_Sel();
                            #endregion
                            break;

                        case "E":
                            break;

                        default:
                            break;
                    }
                } while (_keyInfo.Key.ToString() != "E");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Message);
            }
        }

        private static bool LF_Connection()
        {
            bool bDBCheck = false;
             try
            {
                _sqlCon = new SqlConnection("Server=127.0.0.1; DataBase=Northwind; uid=sa; pwd=admin@Server");
                _sqlCon.Open();
                bDBCheck = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Message);
            }
            return bDBCheck;
        }

        private static List<string> LF_Basic_Sel()
        {
            List<string> listTemp = new List<string>();
            try
            {
                if (LF_Connection())
                {
                    
                    string sQuery = "SELECT *  FROM  CATEGORIES"; 
                    _sqlCmd = new SqlCommand(sQuery, _sqlCon);
                    _sqlReader = _sqlCmd.ExecuteReader();

                    while (_sqlReader.Read())
                    {
                        Console.WriteLine(_sqlReader["CATEGORYID"].ToString()+ " " +
                                          _sqlReader["CATEGORYNAME"].ToString()+ " " +
                                          _sqlReader["DESCRIPTION"].ToString());
                    }
                }
                else
                {
                    Console.WriteLine("Failed")
                }
                _sqlCon.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Message);
            }
            return listTemp; 
        }

    }
}
