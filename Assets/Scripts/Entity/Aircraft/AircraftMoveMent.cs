using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

/****************************************************
    文件：AircraftSupportMoveMent.cs
    作者：tg
    邮箱: 18178367954@139.com
    日期：#CreateTime#
    功能：飞行器移动
*****************************************************/
public class AircraftMoveMent : MonoBehaviour
{
    private RectTransform mRectTransform;
    private Vector2 mTargetDir = Vector2.zero;
    public float baseMoveSpeed { get; set; } = 100000;

    private void Awake()
    {
        mRectTransform = GetComponent<RectTransform>();
    }
    public void Move(Vector2 direction)
    {
        mTargetDir+=direction;
    }
    private void Update()
    {
        if (mTargetDir.Equals(Vector2.zero)) return;
        var movespeed = baseMoveSpeed;
        var climpDelta = Vector2.ClampMagnitude(mTargetDir,Time.deltaTime * movespeed);
        mTargetDir = Vector2.zero;
        var targetPos = mRectTransform.anchoredPosition + climpDelta;
        targetPos.x = Mathf.Clamp(targetPos.x, ConstantGameData.MoveMinX, ConstantGameData.MoveMaxX);
        targetPos.y = Mathf.Clamp(targetPos.y, ConstantGameData.MoveMinY, ConstantGameData.MoveMaxY);
        mRectTransform.anchoredPosition = targetPos;
    }

   
}
