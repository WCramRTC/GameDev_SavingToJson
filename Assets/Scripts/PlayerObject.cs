using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerObject : MonoBehaviour
{
    // Start is called before the first frame update

    // name
    //hp
    public string name;
    public int hp;

    public float lastX;
    public float lastY;
    public float lastZ;



    // equiped items


    void Start()
    {
        lastX = transform.position.x;
        lastY = transform.position.y;
        lastZ = transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
