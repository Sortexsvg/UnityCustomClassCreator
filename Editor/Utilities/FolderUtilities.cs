using System.Reflection;
using UnityEditor;
using UnityEngine;
using System;

namespace DevHelper
{
    public class FolderUtilities
    {
        public static string GetCurrentFolderPath()
        {
            Type projectWindowUtilType = typeof(ProjectWindowUtil);
            MethodInfo getActiveFolderPath = projectWindowUtilType.GetMethod("GetActiveFolderPath", BindingFlags.Static | BindingFlags.NonPublic);
            object obj = getActiveFolderPath.Invoke(null, new object[0]);
            string pathToCurrentFolder = obj.ToString();
            return pathToCurrentFolder;
        }
    }
}