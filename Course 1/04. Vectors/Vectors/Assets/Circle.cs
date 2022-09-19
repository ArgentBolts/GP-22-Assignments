using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : ProcessingLite.GP21
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public Vector2 circlePosition; //Vector that saves x and y values for circle position.
    public float diameter = 1.5f; //Variable that determines how big the circle is.
    public float sum;
    Vector2 vectorDiff;
    Vector2 velocity;



    // Update is called once per frame    
    void Update()
    {

        Background(0); // Set background color to black (0).
        
        Circle(circlePosition.x, circlePosition.y, diameter); //Draws a circle on the screen.

        //if (Input.GetMouseButtonDown(0)) //Teleports circle to mouse on button press.
        //{
        //    circlePosition.x = MouseX;
        //    circlePosition.y = MouseY;

        //}

        circlePosition += (velocity * 3) * Time.deltaTime;

        if (Input.GetMouseButton(0)) //Draw a line from circle to mouse pointer while button is pressed down.
        {
            
            Line(circlePosition.x, circlePosition.y, MouseX, MouseY);
            vectorDiff  = circlePosition - new Vector2(MouseX, MouseY); //Store the difference of two vectors in a new vetor
            circlePosition = Vector2.MoveTowards(circlePosition, new Vector2(MouseX, MouseY), (vectorDiff.magnitude * 3) * Time.deltaTime);
           

            
        }
        else if (Input.GetMouseButtonUp(0))
        {

            velocity = new Vector2(MouseX, MouseY) - circlePosition;
            //circlePosition = Vector2.MoveTowards(circlePosition, new Vector2(MouseX, MouseY), (vectorDiff.magnitude * 3) * Time.deltaTime);

        }
        if (Input.GetMouseButtonDown(0))
        {
            velocity = Vector2.zero;
        }

        if (circlePosition.x > Width)
        {
            velocity = Vector2.Reflect(velocity, Vector2.right);
        }

        if (circlePosition.y > Height)
        {
            velocity = Vector2.Reflect(velocity, Vector2.down);
        }
        if (circlePosition.x < 0)
        {
            velocity = Vector2.Reflect(velocity, Vector2.left);
        }
        if (circlePosition.y < 0)
        {
            velocity = Vector2.Reflect(velocity, Vector2.up);
        }
    }
}
            

           
            
              
                

            
            
        
