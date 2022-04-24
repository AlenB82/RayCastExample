using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class RotateTowards : MonoBehaviour
{
    public float Turnspeed = 10;
    public float Distance = 20f;

    Vector3 touchPosition; 

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch     = Input.GetTouch(0);
            touchPosition   = Camera.main.ScreenToWorldPoint( new Vector3( touch.position.x, touch.position.y, Distance) );

            transform.LookAt( touchPosition, Vector3.up );            
        }
    }
}
