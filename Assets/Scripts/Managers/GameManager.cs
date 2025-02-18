using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/****************************************************
    文件：GameManager.cs
    作者：tg
    邮箱: 18178367954@139.com
    日期：#CreateTime#
    功能：Nothing
*****************************************************/
public class GameManager : Singleton<GameManager>
{
    private GameConf gameconf;
    public GameConf gameConf
    {
        get
        {
            if (gameconf==null)
            {
                gameconf = Resources.Load<GameConf>(ConstantGameData.GameConfPath);
            }
            return gameconf;
        }
    }
}
