/*****************************
*
*  Author : TheNO.5
*
******************************/


using UnityEditor;

public class MainMenu : EditorWindow
{
    [MenuItem("Tools/Open ToolsTemplate")]
    static void OpenTools()
    {
        ToolsGUI.InitToolsWindow();
    }
}