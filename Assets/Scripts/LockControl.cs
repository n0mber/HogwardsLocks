using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockControl : MonoBehaviour
{
    public GameObject RotatingCircle; //either big or small circle
    
    private int Direction; //circle rotating direction

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Q) && RotatingCircle.name == "BigCircle")
        {
            Direction = 1; //rotate to the left
            RotateAroundCenterPoint();
        }
        else if (Input.GetKey(KeyCode.E) && RotatingCircle.name == "BigCircle")
        {
            Direction = -1; //rotate to the right
            RotateAroundCenterPoint();
        }
        else if (Input.GetKey(KeyCode.A) && RotatingCircle.name == "SmallCircle")
        {
            Direction = 1;
            RotateAroundCenterPoint();
        }
        else if (Input.GetKey(KeyCode.D) && RotatingCircle.name == "SmallCircle")
        {
            Direction = -1;
            RotateAroundCenterPoint();
        }
    }
    void RotateAroundCenterPoint()
    {
        Vector3 circlePosition = RotatingCircle.transform.position;
        Vector3 axis = new Vector3(0, 0, Direction);
        transform.RotateAround(circlePosition, axis, Time.deltaTime * 10);
    }
}

