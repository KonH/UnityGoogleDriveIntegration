using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;
using System.Text;

using GDataDB;
using GDataDB.Linq;

using UnityQuickSheet;

///
/// !!! Machine generated code !!!
///
[CustomEditor(typeof(TestWorkSheet))]
public class TestWorkSheetEditor : BaseGoogleEditor<TestWorkSheet>
{	    
    public override bool Load()
    {        
        TestWorkSheet targetData = target as TestWorkSheet;
        
        var client = new DatabaseClient("", "");
        string error = string.Empty;
        var db = client.GetDatabase(targetData.SheetName, ref error);	
        var table = db.GetTable<TestWorkSheetData>(targetData.WorksheetName) ?? db.CreateTable<TestWorkSheetData>(targetData.WorksheetName);
        
        List<TestWorkSheetData> myDataList = new List<TestWorkSheetData>();
        
        var all = table.FindAll();
        foreach(var elem in all)
        {
            TestWorkSheetData data = new TestWorkSheetData();
            
            data = Cloner.DeepCopy<TestWorkSheetData>(elem.Element);
            myDataList.Add(data);
        }
                
        targetData.dataArray = myDataList.ToArray();
        
        EditorUtility.SetDirty(targetData);
        AssetDatabase.SaveAssets();
        
        return true;
    }
}
