using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/****************************************************
    文件：Singleton.cs
    作者：tg
    邮箱: 18178367954@139.com
    日期：#CreateTime#
    功能：单例模式父类
*****************************************************/
public class Singleton<T>: MonoBehaviour where T : Singleton<T>
{
    private static T instance;

    public static T Instance
    {
        get
        {
            if (instance == null)
            {
                T[] managers = FindObjectsOfType(typeof(T)) as T[];
                if (managers.Length!=0)
                {
                    if (managers.Length==1)
                    {
                        instance = managers[0];
                        instance.gameObject.name = typeof(T).Name;
                        return instance;
                    }
                    else
                    {
                        Debug.LogError("Class " + typeof(T).Name + " exists multiple times in violation of singleton pattern. Destroying all copies");
                        //销毁除第一个以外的单例
                        for (int i = 1; i < managers.Length; i++)
                        {
                            Destroy(managers[i]);
                        }
                    }
                }
                var go = new GameObject(typeof(T).Name, typeof(T));
                instance = go.GetComponent<T>();
                DontDestroyOnLoad(go);
            }
            return instance;
        }
    }
}
