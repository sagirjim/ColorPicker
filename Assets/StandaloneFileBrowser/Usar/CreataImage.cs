using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEditor;
using System.IO;
using SFB;

public class CreataImage : MonoBehaviour 
{
    public string Title = "";
    public string Directory = "";
    public string FileName = "";
    public string Extension = "";

    string path;
    public void Take_ScreenShoot()
    {
        StartCoroutine(UploadPNG());
    }

    IEnumerator UploadPNG()
    {
        yield return new WaitForEndOfFrame();

        int width = Screen.width;
        int height = Screen.height;
        Texture2D tex = new Texture2D(width, height, TextureFormat.RGB24, false);

        tex.ReadPixels(new Rect(0, 0, width, height), 0, 0);
        tex.Apply();

        byte[] bytes = tex.EncodeToPNG();
        Object.Destroy(tex);

        //path = UnityEditor.EditorUtility.SaveFilePanel("Save texture as PNG","","SavedScreen.png","png");
        var path = StandaloneFileBrowser.SaveFilePanel(Title, Directory, FileName, Extension);
        if (!string.IsNullOrEmpty(path))
        {
            File.WriteAllBytes(path, bytes);
        }
    }
}
