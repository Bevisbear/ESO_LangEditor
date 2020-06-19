﻿using ESO_LangEditorLib.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using static System.Convert;

namespace ESO_LangEditorLib
{
    public class ExportFromDB
    {
        public async Task ExportAsText()
        {

            var outputIDFile = new List<string>();
            var outputTextFile = new List<string>();

            var db = new LangDbController();

            var dbData = await db.GetAllLangsListAsync();

            if (!Directory.Exists("_tmp"))
                Directory.CreateDirectory("_tmp");

            foreach (var d in dbData)
            {
                outputIDFile.Add(d.UniqueID);
                outputTextFile.Add(d.Text_ZH);
            }

            using (StreamWriter sw = new StreamWriter("_tmp/ID.txt"))
            {
                foreach (string s in outputIDFile)
                {
                    sw.WriteLine(s);
                }
                sw.Flush();
                sw.Close();
            }

            using (StreamWriter sw = new StreamWriter("_tmp/Text.txt"))
            {
                foreach (string s in outputTextFile)
                {
                    sw.WriteLine(s);
                }
                sw.Flush();
                sw.Close();
            }

        }

        public void ExportLangListFullColumnAsText(List<LangText> data, string directory, string fileName)
        {
            var outputText = new List<string>();


            if (!Directory.Exists(directory))
                Directory.CreateDirectory(directory);

            foreach (var d in data)
            {
                //能找到个合适的分隔符真鸡巴难，\v = 匹配垂直制表符，\u000B
                //备用替代"`"
                int translate = 2;
                outputText.Add(d.UniqueID
                    + "\v" + d.ID
                    + "\v" + d.Unknown
                    + "\v" + d.Lang_Index
                    + "\v" + d.Text_EN
                    + "\v" + d.Text_ZH
                    + "\v" + d.UpdateStats
                    + "\v" + translate
                    + "\v" + d.RowStats);
            }

            using (StreamWriter sw = new StreamWriter(directory + "/" + fileName))
            {
                foreach (string s in outputText)
                {
                    sw.WriteLine(s);
                }
                sw.Flush();
                sw.Close();
            }

        }

        public void ExportLangListFullColumnAsText(List<LuaUIData> data, string directory, string fileName)
        {
            var outputText = new List<string>();


            if (!Directory.Exists(directory))
                Directory.CreateDirectory(directory);

            foreach (var d in data)
            {
                //能找到个合适的分隔符真鸡巴难，\v = 匹配垂直制表符，\u000B
                //备用替代"`"
                int translate = 2;
                outputText.Add(d.UniqueID
                    + "\v" + d.Text_EN
                    + "\v" + d.Text_ZH
                    + "\v" + translate
                    + "\v" + d.RowStats);
            }

            using (StreamWriter sw = new StreamWriter(directory + "/" + fileName))
            {
                foreach (string s in outputText)
                {
                    sw.WriteLine(s);
                }
                sw.Flush();
                sw.Close();
            }

        }

        //public void ExportIDArray(int[] ID_Array)
        //{
        //    var outputFile = new List<string>();
        //    var connDB = new SQLiteController();
        //    var dbData = connDB.FullSearchData(false);

        //    if (!Directory.Exists("_tmp"))
        //        Directory.CreateDirectory("_tmp");

        //    foreach (var item in dbData)
        //    {
        //        if (ID_Array.Contains(ToInt32(item.ID_Type)))
        //            outputFile.Add(item.ID_Type
        //                + "-"
        //                + item.ID_Unknown
        //                + "-"
        //                + item.ID_Index
        //                + "&"
        //                + item.Text_EN
        //                + "&"
        //                + item.Text_SC);
        //    }
        //    using (StreamWriter sw = new StreamWriter("_tmp/ExportIDArray.txt"))
        //    {
        //        foreach (string s in outputFile)
        //        {
        //            sw.WriteLine(s);
        //        }

        //        sw.Flush();
        //        sw.Close();
        //    }

        //}

        public string ExportTranslateDB(List<LangText> SearchData)
        {
            //var connDB = new SQLiteController();
            string filName = GetTimeToFileName();
            List<LangText> data = SearchData;

            if (!Directory.Exists("Export"))
                Directory.CreateDirectory("Export");

            string dbPath = @"Export\Translate_" + filName + ".LangDB";

            if (File.Exists(dbPath))
            {
                ExportTranslateDB(data);
            }
            else
            {
                ExportLangListFullColumnAsText(SearchData, "Export", "Translate_" + filName + ".LangDB");
            }

            return dbPath;
        }

        public string ExportTranslateDB(List<LuaUIData> SearchData)
        {
            //var connDB = new SQLiteController();
            string filName = GetTimeToFileName();
            List<LuaUIData> data = SearchData;

            if (!Directory.Exists("Export"))
                Directory.CreateDirectory("Export");

            string dbPath = @"Export\Translate_" + filName + ".LangUI";

            if (File.Exists(dbPath))
            {
                ExportTranslateDB(data);
            }
            else
            {
                ExportLangListFullColumnAsText(SearchData, "Export", "Translate_" + filName + ".LangUI");
            }

            return dbPath;
        }

        //public string ExportTranslateDB(List<UIstrFile> Data)
        //{
        //    var connDB = new UI_StrController();
        //    string number = GetRandomNumber();
        //    //List<UIstrFile> data = SearchData;

        //    if (!Directory.Exists("Export"))
        //        Directory.CreateDirectory("Export");

        //    string dbPath = @"Export\Translate_Str_" + number + ".db";

        //    if (File.Exists(dbPath))
        //    {
        //        ExportTranslateDB(Data);
        //    }
        //    else
        //    {
        //        connDB.CreateTranslateStrDBwithData(Data, dbPath);
        //    }

        //    return dbPath;
        //}

        public async Task ExportStrDB()
        {
            List<string> luaClientData = new List<string>();
            List<string> luaPregameData = new List<string>();

            var db = new LangDbController();
            string line;

            var data = await db.GetAllLuaLangsListAsync() ;

            StreamReader file = new StreamReader(@"Data\FontLib.txt");

            while ((line = file.ReadLine()) != null)
            {
                luaClientData.Add(line);
                luaPregameData.Add(line);
            }
            file.Close();

            foreach (var d in data)
            {
                //if(d.DataEnum == 3)

                switch(d.DataEnum)
                {
                    case 1:
                        luaPregameData.Add("[" + d.UniqueID + "]"
                        + " = "
                        + "\"" + d.Text_ZH + "\"");
                        break;
                    case 2:
                        luaClientData.Add("[" + d.UniqueID + "]"
                        + " = "
                        + "\"" + d.Text_ZH + "\"");
                        break;
                    case 3:
                        luaPregameData.Add("[" + d.UniqueID + "]"
                        + " = "
                        + "\"" + d.Text_ZH + "\"");
                        luaClientData.Add("[" + d.UniqueID + "]"
                        + " = "
                        + "\"" + d.Text_ZH + "\"");
                        break;
                }
                     





                //if (TableName.Contains(d.UI_Table))
                //{
                //    exportData.Add("[" + d.UI_ID + "]"
                //        + " = "
                //        + "\"" + d.UI_ZH + "\"");
                //}
            }

            if (!Directory.Exists("Export"))
                Directory.CreateDirectory("Export");

            using (StreamWriter sw = new StreamWriter(@"Export\zh_client.str"))
            {

                foreach (string s in luaClientData)
                {
                    sw.WriteLine(s);
                }

                sw.Flush();
                sw.Close();
            }
            using (StreamWriter sw = new StreamWriter(@"Export\zh_pregame.str"))
            {

                foreach (string s in luaPregameData)
                {
                    sw.WriteLine(s);
                }

                sw.Flush();
                sw.Close();
            }


        }

        private string GetRandomNumber()
        {
            Random rnd = new Random();
            string number = rnd.Next(1234, 9876).ToString();
            return number;
        }

        private string GetTimeToFileName()
        {
            return DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss");
        }
    }

}
