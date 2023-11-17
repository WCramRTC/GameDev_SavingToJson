using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    public float moveSpeed = 5.0f;


    // equiped items


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        transform.Translate(movement * moveSpeed * Time.deltaTime, Space.World);
    }

    public void UpdateLocation(Vector3 newLocation)
    {
        transform.position = newLocation;
    }
}
