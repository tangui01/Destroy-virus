using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

/****************************************************
    文件：Bullet.cs
    作者：tg
    邮箱: 18178367954@139.com
    日期：#CreateTime#
    功能：子弹
*****************************************************/
public class Bullet : EntityBase<Bullet>
{
    public Image icon;
    public float bornCD = 0.03f;

    protected float mSpeed;
    protected float mDamage;
    protected float mSpeedMul;

    public void Init(Vector2 position, float offsetX, float damage, float speed)
    {
        rectTransform.anchoredPosition = position;
        mSpeed = speed;
        mDamage = damage;
        mSpeedMul = 0 ;
    }

    private void Update()
    {
        // Vector2 uiPos = UIUtil.GetUIPos(rectTransform);
        // if (uiPos.y > UIUtil.height + BULLET_HEIGH
        //     || uiPos.x > UIUtil.width + BULLET_WIDTH || uiPos.x < -BULLET_WIDTH)
        // {
        //     Recycle();
        //     isAlive = false;
        // }
        //
        // mSpeedMul = 1;
        rectTransform.anchoredPosition+=Time.deltaTime*mSpeed*Vector2.up ;
        // rectTransform.anchoredPosition += Vector2.up * mSpeed * mSpeedMul * GlobalData.slowDownFactor * Time.deltaTime;
    }
}
