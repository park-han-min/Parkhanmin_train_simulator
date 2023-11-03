using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Placing : MonoBehaviour
{

    float PosX;
    float PosY;
    float PosZ;
    
    [SerializeField]public GameObject railPrefab;
    [SerializeField]public InputField posX;
    [SerializeField]public InputField posY;
    [SerializeField]public InputField posZ;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
 
    }
    public void place()
    {
        Instantiate(railPrefab,new Vector3(PosX,PosY,PosZ),Quaternion.identity);
    }
}
