自己制作的小工具模板，以后要做工具直接拖进unity，省不少时间

小工具图，从顶部菜单打开，包括图片、文字、折叠栏、按键等等。可以停靠在任意标签栏旁边
![这里写图片描述](http://img.blog.csdn.net/20160224225034238)

文件目录结构图
![这里写图片描述](http://img.blog.csdn.net/20160224225259661)

#**编辑器工具脚本图，本文最核心的三个类**
![这里写图片描述](http://img.blog.csdn.net/20160224225442802)


----------


**模板涉及到的知识：**（本文核心）
1.编辑器中打开 资源管理器获取文件路径

```
string path1 = EditorUtility.OpenFilePanel("选择xml文件", Application.dataPath + "/Tools/Example/Data","xml" );
//   参数： 对话框标题，打开对话框时所在路径，文件格式（扩展名）
```

2.获取保存路径并保存文件：

```
tring path2 = EditorUtility.SaveFilePanel("选择保存SQLite DB文件的位置", null, "SQLiteDB","db");
//   参数： 对话框标题，打开对话框时所在路径（null,可以保存到桌面），默认保存文件名，文件格式（扩展名）
```

3.添加菜单：

```
 [MenuItem("Tools/Open ToolsTemplate")]//  添加菜单
    static void OpenTools()//  点击菜单执行此方法
    {
        ToolsGUI.InitToolsWindow();//  调用方法，弹出工具窗口
    }
```

4.工具窗口UI设计

代码太长，不粘贴了，后面放出下载地址。
主要用到GUILayout和EditorGUILayout
EditorGUILayout参照    [圣典](http://www.ceeger.com/Script/EditorGUILayout/EditorGUILayout.html)


**以下为模板中实例相关知识，可以不看**
本文主要是熟悉如何编写自已的unity 小工具，而数据库信息可以在 Navicat  中直接创建，本实例是在Excel中编辑信息后导出xml再转成SQLite数据库文件，不太重要

5.XML相关知识
http://blog.csdn.net/liushida00/article/details/50608245

6.SQLite相关知识
后续会写到，这里推荐篇神作  [雨松MOMO](http://www.xuanyusong.com/archives/831) 



##[模板+实例下载地址点我（代码中注释写的很详细）](http://download.csdn.net/detail/liushida00/9442644)

##[SQLite工具Navicat中文破解版（直接装，装完不要更新！！）](http://download.csdn.net/detail/liushida00/9442647)

###欢迎大家留言，共同学习！！！

