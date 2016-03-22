using UnityEngine;
using System.Collections;

public class PassThroughBlock : MonoBehaviour
{

    private GameObject _thisBlock;
    [SerializeField]
    private Collider _mainCollider;
    [SerializeField]
    private Collider _passThruCollider;
    

    // Use this for initialization
    void Start()
    {
        _thisBlock = gameObject;

        _mainCollider = gameObject.GetComponent<Collider>();
        _passThruCollider = gameObject.GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {





    }


    void OnTriggerEnter()
    {
        _mainCollider.enabled = false;

    }
    void OnTriggerStay()
    {

        _mainCollider.enabled = false;

    }

    //void OnTriggerExit()
    //{
    //    Debug.Log("asd");
    //    _mainCollider.enabled = true;
    //}


}
