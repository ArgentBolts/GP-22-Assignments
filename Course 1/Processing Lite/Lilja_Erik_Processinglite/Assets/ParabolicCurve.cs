using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParabolicCurve : ProcessingLite.GP21
{
    // Start is called before the first frame update
    void Start()
    {
        Background(0);
        Application.targetFrameRate = 5; // Limits the framerate in-game
    }

    public float spaceBetweenLines = 0.3f;
    // Update is called once per frame
    void Update()
    {
        //Line(1, 9, 1, 1);
        //Line(1, 8.5f, 1.5f, 1);
        //Line(1, 8, 2, 1);
        //Line(1, 7.5f, 2.5f, 1);
        //Line(1, 7, 3, 1);
        //Line(1, 6.5f, 3.5f, 1);
        //Line(1, 6, 4, 1);
        //Line(1, 5.5f, 4.5f, 1);
        //Line(1, 5, 5, 1);
        //Line(1, 4.5f, 5.5f, 1);
        //Line(1, 4, 6, 1);
        //Line(1, 3.5f, 6.5f, 1);
        //Line(1, 3, 7, 1);
        //Line(1, 2.5f, 7.5f, 1);
        //Line(1, 2, 8, 1);
        //Line(1, 1.5f, 8.5f, 1);
        //Line(1, 1, 9, 1);

        for (int i = 0; i < Height/spaceBetweenLines; i++) // Parabolic Curve 
        {
            if (i % 3 == 0)
            {
                int r = Random.Range(0, 256);
                int g = Random.Range(0, 256);
                int b = Random.Range(0, 256);
                Stroke(r, g, b);
            }
            else
            {
                Stroke(255);
            }
            
            Line(0, Height - i * spaceBetweenLines, Width * i / (Height / spaceBetweenLines), 0);
        }
       
    }
}
