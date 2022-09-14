using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assignment : ProcessingLite.GP21
{
    // Start is called before the first frame update
    void Start()
    {

        Background(0);

    }

    void Update() // Update is called once per frame
    {

        Stroke(0, 255, 0);
        Line(1, 8, 1, 2);
        Line(1, 8, 3, 8);
        Line(1, 5, 3, 5);
        Line(1, 2, 3, 2);

        Stroke(0, 255, 0);
        Line(4, 8, 4, 2);
        Line(4, 8, 6, 8);
        Line(6, 8, 6, 5);
        Line(6, 5, 4, 5);
        Line(4, 5, 6, 2);

        Stroke(0, 255, 0);
        Line(7, 8, 7, 2);

        Stroke(0, 255, 0);
        Line(8, 8, 8, 2);
        Line(8, 5, 10, 8);
        Line(8, 5, 10, 2);
                  
        NoStroke();
        Fill(255, 0, 0);          // Setting the interior of a shape (fill) to red
        Rect(12, 2, 16, 5);
        
        NoStroke();
        Fill(0, 0, 255);
        Rect(11, 5, 17, 8);      
                
    }

}

