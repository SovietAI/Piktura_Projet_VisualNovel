using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class StartupFakeWallpaper : MonoBehaviour
{
    public RawImage RawImage; //On déclare la rawimage sur laquelle on appliquera la texture du fond d'écran
    private const UInt32 SPI_SETDESKWALLPAPER = 0x73;
    private const int MAX_PATH = 260;
        
    [DllImport("user32.dll", CharSet = CharSet.Auto)]
    private static extern int SystemParametersInfo(UInt32 uiAction, int uiParam, String lpParam, int fWinIni);
    
    void Start()
    {
        RawImage.texture = LoadTextureFromPath(GetCurrentDesktopWallpaperPath()); // Au start, on change la texture avec la fonction
    }

    private Texture2D LoadTextureFromPath(string path)
    {
        Texture2D texture = new Texture2D(2, 2);
        texture.LoadImage(System.IO.File.ReadAllBytes(path));
        return texture;
    }

    private string GetCurrentDesktopWallpaperPath()
    {
        string currentWallpaper = new string('\0', MAX_PATH);
        SystemParametersInfo(SPI_SETDESKWALLPAPER, currentWallpaper.Length,currentWallpaper,0);
        return currentWallpaper.Substring(0, currentWallpaper.IndexOf('\0'));
    }
}
