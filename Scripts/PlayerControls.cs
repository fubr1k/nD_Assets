using UnityEngine;
using System.Collections;

public class PlayerControls : MonoBehaviour {

    //public variables
    public GameObject _Player;
    public GameObject _ReturnPos;


    
    


    //private variables
    private int _speed = 250;
    private int _maxSpeed = 50;
    private bool _isFalling;
    private Rigidbody _PlayerRB;
    private int _jumpSpeed = 5;
    private Vector3 _jumpVector = new Vector3(0, 0, 0);
    private bool _isColliding;
    private Collider _playerColl;
    private bool _canJump = true;
    RaycastHit hit;


    void Start () {

        _PlayerRB = _Player.GetComponent<Rigidbody>();
        _playerColl = _Player.GetComponent<Collider>();
        

        Instantiate(_ReturnPos, _Player.transform.position, _Player.transform.rotation);
        //_ReturnPos.transform.position = _Player.transform.position;
        //_ReturnPos.transform.rotation = _Player.transform.rotation;
        _ReturnPos = GameObject.Find("ReturnPos(Clone)");


    }

    void FixedUpdate()
    {
        


    }
	
	void Update () {

        //Debug.Log("collider object = " + _playerColl);

        RespawnPosFollowPlayer();
       // Debug.Log("isfalling = " + _isFalling);

        if ((Input.GetKey(KeyCode.D)))
        {
            if (Physics.Raycast(transform.position, Vector3.right, out hit))
            {
               // print("Found an object - distance: " + hit.distance);
                if (hit.distance < 0.5f)
                {
                    _canJump = false;
                }
                else
                {
                    _canJump = true;
                }
                    
            }
                
            _Player.transform.Translate(0.1f, 0, 0);
        }
        if ((Input.GetKey(KeyCode.A)))
        {
            if (Physics.Raycast(transform.position, Vector3.left, out hit))
            {
                // print("Found an object - distance: " + hit.distance);
                if (hit.distance < 0.5f)
                {
                    _canJump = false;
                }
                else
                {
                    _canJump = true;
                }

            }
            _Player.transform.Translate(-0.1f, 0, 0);
        }

        if (Input.GetKey(KeyCode.Space) && _canJump != false)
        {
           
            if(_isFalling == false)
            {
                _jumpVector = new Vector3(_PlayerRB.velocity.x, _jumpSpeed, 0);
                _PlayerRB.velocity = _jumpVector;
                _isFalling = true;
            }
            
            
            

        }
       


        if (_PlayerRB.velocity.magnitude > _maxSpeed)
        {
            _PlayerRB.velocity = _PlayerRB.velocity.normalized * _maxSpeed;
            

        }

    }


    void OnCollisionStay ()          
    {
        _isFalling = false;
        _isColliding = true;
    }
    void OnCollisionExit()
    {
        _isFalling = true;
        _isColliding = false;
    }




    void RespawnPosFollowPlayer()
    {
        
        if (_isFalling == false)
        {
            _ReturnPos.transform.position = transform.position;
            _ReturnPos.transform.rotation = transform.rotation;

        }

    }

    void RespawnAfterDeath()
    {
        _Player.transform.position = _ReturnPos.transform.position;
        _Player.transform.rotation = _ReturnPos.transform.rotation;

    }

    void OnTriggerEnter(Collider col)
    {

        
        //Needed this if to avoid problems with grabber and in general it's better like this, right? -Jan
        if (col.gameObject.tag == "Floor")
            RespawnAfterDeath();

        //How about we just compare to "deadly" objects and then respawn to not cause problems? -Jan
        //if (col.gameObject.tag != "PassThrough")
        //    RespawnAfterDeath();

    }


    void CheckIfFalling()
    {
        if (Physics.Raycast(transform.position, Vector3.down, out hit))
        {
            if (hit.distance > 0.5f)
            {
                _isFalling = true;
            }
            else
            {
                _isFalling = false;
            }
        }

    }
}

