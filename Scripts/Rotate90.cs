using UnityEngine;
using System.Collections;

public class Rotate90 : MonoBehaviour
{
    public bool _RotateInProgress = false;
    float _speed, _rotation;

    void Update()
    {
        // Controls
        // Q and E are for static speed rotation
        // I and P are for linearly increased rotation speed

        if (Input.GetKeyDown("q") && _RotateInProgress == false)
        {
            _RotateInProgress = true;
            Debug.Log("staattinen nopeus");
            StartCoroutine(rotate(-1));
        }
        if (Input.GetKeyDown("e") && _RotateInProgress == false)
        {
            _RotateInProgress = true;
            Debug.Log("staattinen nopeus");
            StartCoroutine(rotate(1));
        }
        if (Input.GetKeyDown("i") && _RotateInProgress == false)
        {
            _RotateInProgress = true;
            Debug.Log("lineaarinen nopeuden kasvu");
            StartCoroutine(rotate_linear_speed(-1));
        }
        if (Input.GetKeyDown("p") && _RotateInProgress == false)
        {
            _RotateInProgress = true;
            Debug.Log("lineaarinen nopeuden kasvu");
            StartCoroutine(rotate_linear_speed(1));
        }
    }

    IEnumerator rotate(int _direction_)
    {
        _speed = 3f;
        _rotation = 0;
        while (_rotation < 90)
        {
            transform.Rotate(_speed * _direction_, 0, 0);
            yield return new WaitForSeconds(0.01f);
            _rotation += _speed;
        }
        Debug.Log(_rotation);
        _RotateInProgress = false;
    }

    IEnumerator rotate_linear_speed(int _direction_)
    {
        _speed = 0.1f;
        _rotation = 0;

        while (_rotation < 90)
        {
            transform.Rotate(_speed * _direction_, 0, 0);
            yield return new WaitForSeconds(0.01f);
            _rotation += _speed;
            _speed += 0.1f;
        }
        transform.Rotate((90 - _rotation) * _direction_, 0, 0);
        _RotateInProgress = false;
        Debug.Log(_rotation);
        Debug.Log(_speed);
    }
}
