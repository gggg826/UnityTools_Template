/*****************************
*
*  Author : TheNO.5
*
******************************/


using UnityEngine;
using UnityEditor;

public class ToolsGUI : EditorWindow
{
    private Vector2 scrollPos;  // 滚动条位置
    private Texture logo;     
    private bool show1;     //   第一个折叠箭头
    private bool show2;     //   第二个折叠箭头
    private string str1 = "打开工具";
    private bool isToggle;    //   大勾选框
    private bool[] toggle = new bool[] { true, true, false }; //    小勾选框
    private string text;
    private int layerNO;


    // 打开工具窗口
    static public void InitToolsWindow()
    {
        EditorWindow.GetWindow(typeof(ToolsGUI));
    }


    void Awake()
    {
        logo = Resources.Load<Texture>("littlelogo");
    }


    void OnGUI()
    {

        //   添加滑动条，高度不够时会自动隐藏
        scrollPos = EditorGUILayout.BeginScrollView(scrollPos, GUILayout.Width(Screen.width), GUILayout.Height(Screen.height));

        #region 这里是显示最上面图片和字符串的
        GUI.DrawTexture(new Rect(20, 20, logo.width, logo.height), logo);

        GUILayout.Label("\n");
        GUILayout.Label("\n");
        GUILayout.Label("\n");
        GUILayout.Label("\n");

        string title = "\n" +
                       "   ==============" + "\n" +
                       "   **********************" + "\n" +
                       "   *  Author : TheNO.5   *" + "\n" +
                       "   **********************" + "\n" +
                       "   ==============";

        GUIStyle lableStyle = new GUIStyle();
        lableStyle.normal.background = null;
        lableStyle.normal.textColor = new Color(0, 1, 0);
        lableStyle.fontSize = 20;
        GUILayout.Label(title, lableStyle);
        GUILayout.Label("\n");
        #endregion



        #region  打开工具

        //  第一个折叠箭头控制
        show1 = EditorGUILayout.Foldout(show1, str1);
        if (show1)
        {
            if (GUILayout.Button("Change XML To SQLiteDB"))
            {
                LETools.XMLToSQLiteDatabase();
            }
        }
        #endregion


        EditorGUILayout.Space(); //  插入小缝隙，避免两个控件相邻太近。也可用GUILayout.Label("\n");
        EditorGUILayout.Space();
        EditorGUILayout.Space();


        #region  打开示例
        GUILayout.Label("以下是编辑器UI示例(点击打开)", lableStyle);
        GUILayout.Label("（按下示例箭头，右侧出现滚动条）");

        //  第二个折叠箭头控制
        show2 = EditorGUILayout.Foldout(show2, "打开示例");
        if (show2)
        {
            GUILayout.Label("\n");

            EditorGUILayout.BeginHorizontal();
            GUILayout.Label("我是文本输入框");
            string text = EditorGUILayout.TextField("Write something");
            EditorGUILayout.EndHorizontal();

           
            isToggle = EditorGUILayout.BeginToggleGroup("我是Toggle", isToggle);
            toggle[0] = EditorGUILayout.Toggle("X", toggle[0]);
            toggle[1] = EditorGUILayout.Toggle("Y", toggle[1]);
            toggle[2] = EditorGUILayout.Toggle("Z", toggle[2]);
            EditorGUILayout.EndToggleGroup();

            EditorGUILayout.BeginHorizontal();
            EditorGUILayout.PrefixLabel("选择渲染层");
            LayerMask layer = EditorGUILayout.LayerField(layerNO);
            EditorGUILayout.EndHorizontal();


            GUILayout.Label("\n");
            GUILayout.Label("\n");

            EditorGUILayout.LabelField("更多UI设置，请参考：", lableStyle);
            EditorGUILayout.Space();
            EditorGUILayout.TextField("http://www.ceeger.com/Script/EditorGUILayout/EditorGUILayout.html");

            GUILayout.Label("\n");
        }

        #endregion
        EditorGUILayout.EndScrollView();
    }



    void OnInspectorUpdate()
    {
        this.Repaint();
    }
}