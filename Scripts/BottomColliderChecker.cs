using UnityEngine;
using System.Collections;

public class BottomColliderChecker : MonoBehaviour {


    [SerializeField]
    private Collider _bottomTrigger;
    [SerializeField]
    private Collider _mainCollider;


    void Start () {
        _bottomTrigger = gameObject.GetComponent<Collider>();
        _mainCollider = gameObject.GetComponent<Collider>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerStay()
    {
        _mainCollider.enabled = false;


    }
    void OnTriggerExit()
    {
        _mainCollider.enabled = true;
    }
}
