/*****************************
*
*  Author : TheNO.5
*
******************************/

using UnityEngine;
using UnityEditor;

public class LETools : Editor
{
    static public void XMLToSQLiteDatabase()
    {
        string path1 = EditorUtility.OpenFilePanel("选择xml文件", Application.dataPath + "/Tools/Example/Data","xml" );
        
        string path2 = EditorUtility.SaveFilePanel("选择保存SQLite DB文件的位置", null, "SQLiteDB","db");
        
        XMLOpration.XMLToSQLiteDatabase(path1, path2);
        
        AssetDatabase.Refresh();
    }
}