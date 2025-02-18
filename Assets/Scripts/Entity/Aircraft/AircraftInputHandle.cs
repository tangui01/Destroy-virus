using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/****************************************************
    文件：AircraftInputHandle.cs
    作者：tg
    邮箱: 18178367954@139.com
    日期：#CreateTime#
    功能：飞行器输入处理器
*****************************************************/
public class AircraftInputHandle : MonoBehaviour
{
    private Vector2 MoveDirection = Vector2.zero;
    private void Update()
    {
        MoveDirection.x = Input.GetAxis("Horizontal");
        MoveDirection.y = Input.GetAxis("Vertical");
    }

    public Vector2 GetMoveDirection()
    {
        return MoveDirection;
    }
}
