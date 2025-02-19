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
    public RectTransform fireTransform;
    
    private float mFireOnceDuration=ConstantGameData.InitFireCD;//子弹的持续时间
    private float mFireOnceBullets=1;//攻击一次发射的子弹数
    private float mFireOnceCD;//攻击一次所用的CD
    private float mFirePower=ConstantGameData.InitFirePower;//子弹的攻击力
    private float mFireSpeed=ConstantGameData.InitFireSpeed;//子弹的飞行速度
    
    public bool IsFiring { get; private set; }

    private void Awake()
    {
        if (fireTransform==null)
            fireTransform = transform.Find("fireTransform").GetComponent<RectTransform>();
        if (fireTransform == null)
            Debug.LogError("fireTransform为空，请创建这个物体");
    }

    private void FireOnce()
    {
        for (int i = 0; i < mFireOnceBullets; i++)
        {
            Bullet bullet=Bullet.Create();
            bullet.Init(UIUtil.GetUIPos(fireTransform),1,1,mFireSpeed); 
        }
          
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
            mFireOnceCD = this.UpdateCD(mFireOnceCD);
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
