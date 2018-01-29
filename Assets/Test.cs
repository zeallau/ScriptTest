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
        /* for my own testing purpose, please ignore 
        for(int mp = 53; mp >= 5; mp -= 5)
        {
            Debug.Log("魔法攻撃をした。残りMPは" + mp);
        }
        Debug.Log("MPが足りないため魔法が使えない。");
        */

        //decrease mp when spell
        //Left hand side is before spelling mp -= spell cost
        this.mp -= spell;

        
     if(mp >= 0) //Here is after spelling MP, so mp >= 0 
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
        boss.Magic();

        


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