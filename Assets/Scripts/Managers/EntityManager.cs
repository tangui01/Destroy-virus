using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/****************************************************
    文件：EntityManager.cs
    作者：tg
    邮箱: 18178367954@139.com
    日期：#CreateTime#
    功能：Nothing
*****************************************************/
[Serializable]
public class PooledPrefab
{
    public GameObject prefab;
    public Transform root;
}
public class EntityManager : Singleton<EntityManager>
{
    public List<PooledPrefab> pooledPrefabs=new List<PooledPrefab>();
    private Dictionary<Type, List<EntityBase>> mInstanceDict = new Dictionary<Type, List<EntityBase>>();


    static long sUidCounter;

    private EntityBase create(Type t)
    {
        if (!typeof(EntityBase).IsAssignableFrom(t))
        {
            Debug.LogError($"Create Entity Failed , {t.Name} is not Assignable To EntityBase");
            return null;
        }

        if (pooledPrefabs==null || pooledPrefabs.Count==0)
        {
            Debug.LogError("pooledPrefabs为空");
            return null;
        }
        PooledPrefab? _pooledPrefab = null;
        foreach (var pp in pooledPrefabs)
        {
            if (pp.prefab.GetComponent<EntityBase>().GetType() == t)
            {
                _pooledPrefab = pp;
                break;
            }
        }

        if (_pooledPrefab == null)
        {
            Debug.LogError($"Create Entity Failed , {t.Name} is not pooled");
            return null;
        }

        var entity = Instantiate(_pooledPrefab.prefab, _pooledPrefab.root).GetComponent<EntityBase>();
        entity.uid = ++sUidCounter;
        if (_pooledPrefab.root != null
            && _pooledPrefab.root != entity.transform.parent)
        {
            entity.transform.SetParent(_pooledPrefab.root);
            entity.transform.localScale = Vector3.one;
            entity.transform.localPosition = Vector3.zero;
            entity.transform.localRotation = Quaternion.identity;
        }

        var type = entity.GetType();
        if (!mInstanceDict.ContainsKey(type))
        {
            mInstanceDict.Add(type, new List<EntityBase>());
        }

        mInstanceDict[type].Add(entity);
        return entity;
    }

    private T create<T>() where T : EntityBase
    {
        var entity = create(typeof(T)) as T;
        return entity;
    }
    #region Scripts API
    public static T Create<T>() where T : EntityBase
    {
        return Instance.create<T>();
    }

    public static EntityBase Create(Type type)
    {
        return Instance.create(type);
    }
    #endregion
    
    
    
}