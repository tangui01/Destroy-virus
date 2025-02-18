using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/****************************************************
    文件：UnityExtension.cs
    作者：tg
    邮箱: 18178367954@139.com
    日期：#CreateTime#
    功能：unity扩展
*****************************************************/
public static class UnityExtension 
{
    public static T GetOrAddGetCompent<T>(this GameObject gameObject)where T:Component
    {
        var component = gameObject.GetComponent<T>();
        if (component==null)
        {
            component = gameObject.AddComponent<T>();    
        }
        return component;
    }

    public static int Add(this int self, int other)
    {
        return self + other;
    }
}
