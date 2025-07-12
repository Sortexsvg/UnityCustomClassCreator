using System.IO;
using UnityEditor;

namespace DevHelper.CustomScripts
{
    public class CustomCSharpScriptCreator
    {
        protected const string TEMPLATE_PATH = "Assets/Editor/CustomScripts/Template/";
        protected const string MENU_ITEM_PREFIX = "Assets/Create/C#_Custom_Scripts/";
        protected const int ORDER = 80;

        [MenuItem(MENU_ITEM_PREFIX + "Emplty_C#_Class", false, ORDER)]
        public static void CreateEmtptyCSharpClass()
        {
            CreateScriptInCurrentFolder("210_C#_NewEmptyClass.txt","NewEmptyClass");
        }

        [MenuItem(MENU_ITEM_PREFIX + "Emplty_Singleton_C#_Class", false, ORDER)]
        public static void CreateEmtptySingletonCSharpClass()
        {
            CreateScriptInCurrentFolder("211_C#_NewEmptySingletonClass.txt", "NewEmptySingletonClass");
        }

        [MenuItem(MENU_ITEM_PREFIX + "Monobehaviour_C#_Class", false, ORDER)]
        public static void CreateMonoBehaviourCSharpClass()
        {
            CreateScriptInCurrentFolder("212_C#_NewMonobehaviourClass.txt", "NewMonobehaviourClass");
        }

        [MenuItem(MENU_ITEM_PREFIX + "Monobehaviour_Singleton_C#_Class", false, ORDER)]
        public static void CreateMonoBehaviourSingletonCSharpClass()
        {
            CreateScriptInCurrentFolder("213_C#_NewMonobehaviour_Singleton_Class.txt", "NewMonobehaviourSingletonClass");
        }

        [MenuItem(MENU_ITEM_PREFIX + "Interface", false, ORDER)]
        public static void CreateInterface()
        {
            CreateScriptInCurrentFolder("214_C#_NewInterface.txt","NewInterface");
        }

        protected static void CreateScriptInCurrentFolder(string inTemplateFileName,string inFileName)
        {
            string templateFileRelativePath = Path.Combine(TEMPLATE_PATH, inTemplateFileName);
            string currentFolder = FolderUtilities.GetCurrentFolderPath();
            string outputFileName = inFileName+".cs";
            string outputFilePath = Path.Combine(currentFolder, outputFileName);
            ProjectWindowUtil.CreateScriptAssetFromTemplateFile(templateFileRelativePath, outputFilePath);
        }
    }
}