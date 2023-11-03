using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_rotate : MonoBehaviour
{
    // Start is called before the first frame update
    public float RotSpeed = 200.0f;
    public float CamRotX = Input.GetAxis("Mouse Y");
    public float CamRotY = Input.GetAxis("Mouse X");
    void Start()
    {
            
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void CamRotSel()
    {
        Vector3 dir = new Vector3(CamRotX,CamRotY,0);
        Vector3 angle = transform.eulerAngles;
        angle += dir*RotSpeed*Time.deltaTime;
        transform.eulerAngles = angle;    
    }
}
