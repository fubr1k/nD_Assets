using UnityEngine;
using System.Collections;

public class ChangeParent : MonoBehaviour {

    private GameObject _parentChangeTarget;      
   

    void Start ()
    {
        _parentChangeTarget = gameObject;

    }
	
	void Update ()
    {
      

    }

    void OnTriggerStay (Collider _col_)
    {

        if (_col_.gameObject.tag == "OrbitEmpty")
        {
            if(!_parentChangeTarget.transform.parent.GetComponent<Rotate90>()._RotateInProgress)
                _parentChangeTarget.transform.parent = _col_.transform;
        }

    }
}
