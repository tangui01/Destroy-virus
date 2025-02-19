using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/****************************************************
    文件：VirusRoot.cs
    作者：tg
    邮箱: 18178367954@139.com
    日期：#CreateTime#
    功能：病毒基类
*****************************************************/
public class VirusBase : EntityBase
{
     private Text HpText;
     protected Animator animator;
     
     
     public ParticleSystem cureEffect { get; private set; }
     public ParticleSystem stunEffect { get; private set; }
     private void Awake()
     {
         HpText = transform.Find("virus_base/text").GetComponent<Text>();
         animator = GetComponentInChildren<Animator>();
         cureEffect = transform.Find("virus_base/cure_buff").GetComponent<ParticleSystem>();
         cureEffect.Stop(true);
         stunEffect = transform.Find("virus_base/stun_effect").GetComponent<ParticleSystem>();
         stunEffect.Stop(true);
     }

     public void Init(int hp)
     {
         
     }
}
