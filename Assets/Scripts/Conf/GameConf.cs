using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/****************************************************
    文件：GameConf.cs
    作者：tg
    邮箱: 18178367954@139.com
    日期：#CreateTime#
    功能：游戏资源配置
*****************************************************/
[CreateAssetMenu(fileName = "Conf", menuName = "游戏配置/游戏资源")]
public class GameConf:ScriptableObject
{
    [Tooltip("子弹预制体")]public  GameObject Bullet_PreFab;
    
}
