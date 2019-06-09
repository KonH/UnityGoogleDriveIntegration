using UnityEngine;
using UnityEditor;
using System.IO;
using UnityQuickSheet;

///
/// !!! Machine generated code !!!
/// 
public partial class GoogleDataAssetUtility
{
    [MenuItem("Assets/Create/Google/TestWorkSheet")]
    public static void CreateTestWorkSheetAssetFile()
    {
        TestWorkSheet asset = CustomAssetUtility.CreateAsset<TestWorkSheet>();
        asset.SheetName = "TestSheet";
        asset.WorksheetName = "TestWorkSheet";
        EditorUtility.SetDirty(asset);        
    }
    
}