using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class movesystem : MonoBehaviour
{   
    [SerializeField] Slider slider;
    public int Accel_number=0;
    public int Brake_number=0;
    public float Addspeed=0.0f;
    public float Minusspeed=0.0f;
    public float speed=0.0f;
    public bool leftmove=false;
    public bool rightmove=false;
    public bool upmove=false;
    public bool downmove=false;
    public bool frontmove=false;
    public bool backmove=false;
    // Start is called before the first frame update
    void Start()
    {
        Addspeed=Accel_number*0.1f;
        Minusspeed=Brake_number*0.1f;
    }

    // Update is called once per frame
    void Update()
    {
        speedchangex();
        Accelation();
        if (leftmove==true)
        {
            transform.position += new Vector3(-10,0,0);
        }
        if (rightmove==true)
        {
            transform.position += new Vector3(10,0,0);
        }
        if (upmove==true)
        {
            transform.position += new Vector3(0,10,0);
        }
        if (downmove==true)
        {
            transform.position += new Vector3(0,-10,0);
        }
        if (frontmove==true)
        {
            transform.position += new Vector3(0,0,10);
        }
        if (backmove==true)
        {
            transform.position += new Vector3(0,0,-10);
        }
    } 
    public void Accelation()
    {
        speed += Addspeed;
        speed += Minusspeed;
    }
    public void speedchangex()
    {
        transform.position += new Vector3(0,0,speed);      
    }
    public void buttondown(string type)
    {
        switch (type) {
            case "up":
                upmove=true;
                break;
            case "down":
                downmove=true;
                break;
            case "left":
                leftmove=true;
                break;
            case "right":
                rightmove=true;
                break;
            case "front":
                frontmove=true;
                break;
            case "back":
                backmove=true;
                break;   
        }
    }
    public void buttonup(string type)
    {
        switch (type) {
            case "up":
                upmove=false;
                break;
            case "down":
                downmove=false;
                break;
            case "left":
                leftmove=false;
                break;
            case "right":
                rightmove=false;
                break;
            case "front":
                frontmove=false;
                break;
            case "back":
                backmove=false;
                break;
        }
    }
}
