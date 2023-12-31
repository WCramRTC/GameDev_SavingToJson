using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PositionData
{

    public float x;
    public float y;
    public float z;

    public PositionData(Vector3 position)
    {
        x = position.x;
        y = position.y;
        z = position.z;
    }

    public Vector3 ToVector3()
    {
        return new Vector3(x, y, z);
    }

}
