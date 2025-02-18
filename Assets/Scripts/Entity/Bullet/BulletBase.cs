using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/****************************************************
    文件：BulletBase.cs
    作者：tg
    邮箱: 18178367954@139.com
    日期：#CreateTime#
    功能：子弹基类
*****************************************************/
public enum BulletType
{
    Common_bullet,//普通子弹
    Fire_bullet,//火焰子弹
    Ice_bullet,//冰冻子弹
    Split_bullet//分裂子弹
}

public class BulletBase : EntityBase<BulletBase>
{
    protected Image Icon;

    private void Awake()
    {
        Icon = GetComponentInChildren<Image>();
    }
}
