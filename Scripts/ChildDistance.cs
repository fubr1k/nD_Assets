using UnityEngine;
using System.Collections;

public class ChildDistance : MonoBehaviour {

    //Leave these to 0 to replicate inherited position
    public float _DistanceX;
    public float _DistanceY;
    public float _DistanceZ;

    void Start ()
    {
        set_relative_distance();
	}
	
	void Update ()
    {
	
	}

    //Sets distance from parent object
    void set_relative_distance()
    {
        transform.localPosition = new Vector3(_DistanceX, _DistanceY, _DistanceZ);
    }
}
