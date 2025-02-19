using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/****************************************************
    文件：EntityBase.cs
    作者：tg
    邮箱: 18178367954@139.com
    日期：#CreateTime#
    功能：物体基类
*****************************************************/
public class EntityBase : MonoBehaviour
{
    public long uid { get; set; } = -1;
    public bool isAlive { get; protected set; } = false;

    private RectTransform mRectTransform = null;
    public RectTransform rectTransform
    {
        get
        {
            if (mRectTransform == null)
                mRectTransform = GetComponent<RectTransform>();
            return mRectTransform;
        }
    }
   //回收物体
    public void Recycle<T>(T t) where T : EntityBase
    {
       PoolManager.Instance.PushObj(typeof(T).ToString(),gameObject);
    }
}

public class EntityBase<T>:  EntityBase where T : EntityBase<T>
{
    public static T Create()
    {
        return EntityManager.Create<T>();
    }
}