using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/****************************************************
    文件：GameExtension.cs
    作者：tg
    邮箱: 18178367954@139.com
    日期：#CreateTime#
    功能：游戏扩展方法
*****************************************************/
public static class  GameExtension 
{
    public static float UpdateCD(this MonoBehaviour monoBehaviour, float value, float scale = 1f)
    {
        return Mathf.Max(0,value-Time.deltaTime*scale);
    }

    public static void SetImage(this Image img, Sprite sprite)
    {
        img.sprite = sprite;
        if (img.type == Image.Type.Simple)
        {
            img.SetNativeSize();
        }
    }
}
