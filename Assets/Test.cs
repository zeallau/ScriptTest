using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Boss
{
    private int mp = 53;
    private int spell = 5;

    //Magic function
    public void Magic()
    {
        //decrease mp when spell
        this.mp -= spell;

        
     if(mp >= 5)
     {
         Debug.Log("魔法攻撃をした。残りMPは" + mp);
     }
     else
     {
         Debug.Log("MPが足りないため魔法が使えない。");
     }
     

    }


}


public class Test : MonoBehaviour
{



    void Start()
    {
        Boss boss = new Boss();

        boss.Magic();
        boss.Magic();
        boss.Magic();
        boss.Magic();
        boss.Magic();
        boss.Magic();
        boss.Magic();
        boss.Magic();
        boss.Magic();
        boss.Magic();

        //そんな馬鹿に10回貼り付けじゃないでしょう？


        /*
        int[] points = { 3, 6, 9, 12, 15 };
        for (int i = 0; i < points.Length; i++)
        {
            Debug.Log(points[i]);
        }

        Debug.Log(points.Length);

        
        for (int i = points.Length - 1; i >= 0; i--)
        {
            Debug.Log(points[i]);
        }
        */

    }



    // Update is called once per frame
    void Update()
    {

    }
}