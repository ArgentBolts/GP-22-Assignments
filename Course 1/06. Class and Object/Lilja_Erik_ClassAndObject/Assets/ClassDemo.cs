using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassDemo : ProcessingLite.GP21
{

    Ball myBall;
    public Player myPlayer;
    int numberOfBalls = 10;
    Ball[] balls;
    bool isGameOver = false;


    // Start is called before the first frame update
    void Start()
    {

        balls = new Ball[numberOfBalls];
        for (int i = 0; i < balls.Length; i++)
        {
            balls[i] = new Ball(Random.Range(0f, 10f), Random.Range(0f, 10f));
        }
        myPlayer = new Player();
       
    }

    // Update is called once per frame
    void Update()
    {

        Background(0);

        for (int i = 0; i < balls.Length; i++)
        {
            
            balls[i].UpdatePos();
            balls[i].Draw();

        }
        
        myPlayer.DrawPlayer();
        myPlayer.UpdatePosPlayer();

        for (int i = 0; i < balls.Length; i++)
        {
            if (CircleCollision(balls[i].position.x, balls[i].position.y, balls[i].size / 2, myPlayer.x2, myPlayer.y2, myPlayer.diameter / 2))
            {

                isGameOver = true;
                
            }
            
        }
        
        if (isGameOver == true)
        {
            Fill(255, 0, 0);
            Text("Game Over, you collided with a ball!", Width / 2, Height / 2);
        }

    }
    bool CircleCollision(float x1, float y1, float size1, float x2, float y2, float size2)
    {
        float maxDistance = size1 + size2;

        //first a quick check to see if we are too far away in x or y direction
        //if we are far away we don't collide so just return false and be done.
        if (Mathf.Abs(x1 - x2) > maxDistance || Mathf.Abs(y1 - y2) > maxDistance)
        {
            return false;
        }
        //we then run the slower distance calculation
        //Distance uses Pythagoras to get exact distance, if we still are to far away we are not colliding.
        else if (Vector2.Distance(new Vector2(x1, y1), new Vector2(x2, y2)) > maxDistance)
        {
            return false;
        }
        //We now know the points are closer then the distance so we are colliding!
        else
        {
            return true;
        }
    }
}
