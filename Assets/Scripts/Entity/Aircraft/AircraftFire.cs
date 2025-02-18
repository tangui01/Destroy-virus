using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/****************************************************
    文件：AircraftFire.cs
    作者：tg
    邮箱: 18178367954@139.com
    日期：#CreateTime#
    功能：飞行器发射子弹
*****************************************************/
public class AircraftFire : MonoBehaviour
{
    public Transform fireTransform;
    
    private float mFireOnceDuration;//子弹的持续时间
    private float mFireOnceBullets;//攻击一次发射的子弹数
    private float mFireOnceCD;//攻击一次所用的CD
    private float mFirePower;//子弹的攻击力
    private float mFireSpeed;//子弹的飞行速度
    
    public bool IsFiring { get; private set; }

    private void FireOnce()
    {
        Debug.Log("FireOnce");
    }
    public void Fire()
    {
        IsFiring = true;
    }

    public void HoldFire()
    {
        IsFiring = false;
    }
    private void Update()
    {
        if (IsFiring)
        {
            if (mFireOnceCD <= 0)
            {
                FireOnce();
                mFireOnceCD = mFireOnceDuration;
            }
        }
        else
        {
            
        }
    }
}
