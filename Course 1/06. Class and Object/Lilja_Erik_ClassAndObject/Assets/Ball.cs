using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : ProcessingLite.GP21
{
    
    //Class variables
    public Vector2 position; //Ball position
    Vector2 velocity; //Ball direction
    public float size = Random.Range(1, 2);
    int r = Random.Range(0, 256);
    int g = Random.Range(0, 256);
    int b = Random.Range(0, 256);

    //Ball Constructor, called when we type new Ball(x, y);
    public Ball(float x, float y)
    {

        position = new Vector2(x, y);

        velocity = new Vector2();
        velocity.x = Random.Range(-6, 6);
        velocity.y = Random.Range(-6, 6);
        
    }

    //Draw our ball
    public void Draw()
    {

        for (int i = 0; i < 10; i++)
        {
            if (i % 3 == 0)
            {
                Stroke(r, g, b);
            }
            else
            {
                Stroke(255);
            }

            Circle(position.x, position.y, size);
        }

    }

    public void UpdatePos()
    {

        position += velocity * Time.deltaTime;
        
        if (position.x > Width)
        {
            velocity = Vector2.Reflect(velocity, Vector2.right);
        }
        if (position.y > Height)
        {
            velocity = Vector2.Reflect(velocity, Vector2.down);
        }
        if (position.x < 0)
        {
            velocity = Vector2.Reflect(velocity, Vector2.left);
        }
        if (position.y < 0)
        {
            velocity = Vector2.Reflect(velocity, Vector2.up);
        }

    }

}
