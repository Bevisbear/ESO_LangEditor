﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Convert;
using System.IO;

namespace ESO_Lang_Editor.Model
{
    class ExportFromDB
    {
        public void ExportAsText()
        {

            var outputIDFile = new List<string>();
            var outputTextFile = new List<string>();

            var connDB = new SQLiteController();

            var dbData = connDB.FullSearchData();

            foreach (var item in dbData)
            {
                outputIDFile.Add(item.ID_Type + "-" + item.ID_Unknown + "-" + item.ID_Index);
                outputTextFile.Add(item.Text_SC);
            }

            using (StreamWriter sw = new StreamWriter("ID.txt"))
            {
                foreach (string s in outputIDFile)
                {
                    sw.WriteLine(s);
                }
                sw.Flush();
                sw.Close();
            }

            using (StreamWriter sw = new StreamWriter("Text.txt"))
            {
                foreach (string s in outputTextFile)
                {
                    sw.WriteLine(s);
                }
                sw.Flush();
                sw.Close();
            }

        }

    }

}
