using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/****************************************************
    文件：AircraftSupport.cs
    作者：tg
    邮箱: 18178367954@139.com
    日期：#CreateTime#
    功能：飞行器
*****************************************************/
public class Aircraft : EntityBase<Aircraft>
{
     public AircraftMoveMent MoveMent { get; private set;}
     public AircraftInputHandle InputHandle { get; private set; }
     public AircraftFire Firement { get; private set; }
     private void Awake()
     {
         MoveMent=gameObject.GetOrAddGetCompent<AircraftMoveMent>(); 
         InputHandle=gameObject.GetOrAddGetCompent<AircraftInputHandle>();
         Firement=gameObject.GetOrAddGetCompent<AircraftFire>();
     }

     private void Start()
     {
         Firement.Fire();
     }

     private void Update()
     {
        MoveMent.Move(InputHandle.GetMoveDirection());
     }
}
