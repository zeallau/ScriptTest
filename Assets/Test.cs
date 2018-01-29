using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Test : MonoBehaviour
{

    void Start()
    {
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
        

    }



    // Update is called once per frame
    void Update()
    {

    }
}