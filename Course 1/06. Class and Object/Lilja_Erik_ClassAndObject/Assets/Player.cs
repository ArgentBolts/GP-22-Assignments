using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : ProcessingLite.GP21
{
 
    public float x1;
    public float y1;
    public float x2;
    public float y2;
    public float diameter = 0.5f;
    public int acceleration = 25;
    public float velocityX;
    public float velocityY;
    public float deceleration = 2000;

    public void DrawPlayer()
    {
        
        Stroke(255);
        Circle(x2, y2, diameter);
    }

    public void UpdatePosPlayer()
    {
        x1 = Input.GetAxisRaw("Horizontal");
        y1 = Input.GetAxisRaw("Vertical");
        Vector2 diagonal2 = new Vector2(x1, y1);
        diagonal2.Normalize();
        velocityX += acceleration * diagonal2.x * Time.deltaTime;
        velocityY += acceleration * diagonal2.y * Time.deltaTime;
        x2 += velocityX * Time.deltaTime;
        y2 += velocityY * Time.deltaTime;
        Circle(x2, y2, diameter);

        if (Input.GetAxisRaw("Horizontal") == 0)
        {

            velocityX /= Mathf.Pow(deceleration, Time.deltaTime);
        }
        if (Input.GetAxisRaw("Vertical") == 0)
        {

            velocityY /= Mathf.Pow(deceleration, Time.deltaTime);
        }
    }
   
}
