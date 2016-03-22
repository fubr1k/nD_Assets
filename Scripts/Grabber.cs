using UnityEngine;
using System.Collections;

public class Grabber : MonoBehaviour {

	public bool _bGrabbed = false;

	void Start () {
	
	}
	
	
	void Update () {
        
        if (_bGrabbed && Input.GetKeyDown("f") && gameObject.transform.root.gameObject.tag == "Player")
        {
            transform.parent = null;
            _bGrabbed = false;
        }

    }

    void OnTriggerStay(Collider _col_)
    {
       
        if (_col_.gameObject.tag == "Grabber" && Input.GetKeyDown("g") && !_bGrabbed)
        {
            gameObject.transform.parent = _col_.transform;
            _bGrabbed = true;
        }
        
    }
}
