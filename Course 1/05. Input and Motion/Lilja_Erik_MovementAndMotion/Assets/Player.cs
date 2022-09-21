using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : ProcessingLite.GP21
{

    float x;
    float y;
    float x2;
    float y2;
    float x3;
    float y3;
    float x4;
    float y4;
    float diameter = 1;
    float speed = 10;
    int acceleration = 15;
    float velocityX;
    float velocityY;
    public float deceleration = 2000;
    
    // Update is called once per frame
    void Update()
    {

        Background(0); //Sets background to black
                       
        //Player1
        x = Input.GetAxisRaw("Horizontal");
        y = Input.GetAxisRaw("Vertical");
        Vector2 diagonal = new Vector2(x, y);
        diagonal.Normalize();
        x2 += diagonal.x * speed * Time.deltaTime;
        y2 += diagonal.y * speed * Time.deltaTime;

        //Player2
        x3 = Input.GetAxisRaw("Horizontal");
        y3 = Input.GetAxisRaw("Vertical");
        Vector2 diagonal2 = new Vector2(x3, y3);
        diagonal2.Normalize();
        velocityX += acceleration * diagonal2.x * Time.deltaTime;
        velocityY += acceleration * diagonal2.y * Time.deltaTime;
        x4 += velocityX * Time.deltaTime;
        y4 += velocityY * Time.deltaTime;
        Circle(x2, y2, diameter); //Draws a circle on screen
        Circle(x4, y4, diameter);

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
