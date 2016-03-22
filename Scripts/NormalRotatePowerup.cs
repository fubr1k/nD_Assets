using UnityEngine;
using System.Collections;

public class NormalRotatePowerup : MonoBehaviour {

	void Start ()
    {
	}
	
	void Update ()
    {
	
	}

    void OnCollisionEnter(Collision col)
    {
        Debug.Log(col.gameObject.name);
        if (col.gameObject.tag == "Player")
        {
            Debug.Log(col.gameObject.name);
            Destroy(gameObject);
        }
    }
}
