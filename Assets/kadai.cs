﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kadai : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        // 要素数5の配列を初期化する
        int[] points = new int[5];

        // 配列の各要素に値を代入する
        points[0] = 300;
        points[1] = 10;
        points[2] = 500;
        points[3] = 1;
        points[4] = 8;

        // 配列の要素をすべて表示する
        for (int i = 4 ; i >= 0　; i--)
        {
            Debug.Log(points[i]);
        }
    }

   

// Use this for initialization

	
	// Update is called once per frame
	void Update () {
		
	}
}
