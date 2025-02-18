using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/****************************************************
    文件：ConstantGameData.cs
    作者：tg
    邮箱: 18178367954@139.com
    日期：#CreateTime#
    功能：游戏的常量数据
*****************************************************/
public static class ConstantGameData
{
    //地图范围
    public static float MoveMaxX = 1075;
    public static float MoveMaxY = 818;
    public static float MoveMinX = 50;
    public static float MoveMinY = 50;
    
    //子弹
    public static float InitFireSpeed = 500;//初始发射子弹速度
    public static float InitFirePower = 1f;//初始子弹伤害
    public static float InitFireCD = 0.5f;//初始子弹CD
    //资源配置路径
    public static string GameConfPath = "Data/GameConf";
}
