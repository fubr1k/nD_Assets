using UnityEngine;
using System.Collections;

public class UnParent : MonoBehaviour {

	
	void Start () {
	
	}
	
	
	void Update () {
        //Debug.Log(gameObject.transform.parent.GetComponent<Grabber>()._bGrabbed);
	}
    void OnTriggerStay(Collider _col_)
    {
        
        
        if (_col_.gameObject.tag == "Grabber" && gameObject.transform.parent.GetComponent<Grabber>()._bGrabbed)
        {
            Debug.Log("Unparented.");
            gameObject.transform.parent.parent = null;
            gameObject.transform.parent.GetComponent<Grabber>()._bGrabbed = false;
            

        }

    }
}
