using System;
using System.Diagnostics;
using UnityEditor;

namespace Utilities.Editor
{
    public static class InvokePublicize
    {
        [MenuItem("Modding/Publicize Assembly-CSharp.dll")]
        public static void Publicize()
        {
            var info = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = "/c publicize.bat",
                WorkingDirectory = Environment.CurrentDirectory,
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = false,
                RedirectStandardError = false,
            };

            using var process = Process.Start(info);
            process!.WaitForExit();
            EditorUtility.DisplayDialog("Publicization", "Publicization should be complete!", "Ok");
        }
    }
}