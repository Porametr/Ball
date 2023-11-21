using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [SerializeField]private int playerscore;
    [SerializeField]private GameObject ballPrefab;
    [SerializeField]private GameObject[] ballPosition;
    
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        
        //set ball on the table
        Setballs(BallColors.White, 0);
        Setballs(BallColors.Red, 1);
        Setballs(BallColors.Pink, 2);
        Setballs(BallColors.Blue, 3);
        Setballs(BallColors.Green, 4);
        Setballs(BallColors.Yellow, 5);
        Setballs(BallColors.Brown, 6);
        Setballs(BallColors.Black, 7);
    }

    void Setballs(BallColors colors , int pos)
    {
        GameObject ball = Instantiate(ballPrefab,ballPosition[pos].transform.position,Quaternion.identity);
        Ball b = ball.GetComponent<Ball>();
        b.SetColorAndPoint(colors);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

