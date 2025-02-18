using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
/****************************************************
    文件：AircraftSupportGearRotate.cs
    作者：tg
    邮箱: 18178367954@139.com
    日期：#CreateTime#
    功能：飞行器的齿轮旋转
*****************************************************/
public class AircraftSupportGearRotate : MonoBehaviour
{
    private void Start()
    {
        transform.DORotate(new Vector3(0,0,-360),0.5f,RotateMode.FastBeyond360).SetEase(Ease.Linear).SetLoops(-1, LoopType.Restart);
    }
}
