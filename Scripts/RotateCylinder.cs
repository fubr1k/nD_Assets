using UnityEngine;
using System.Collections;

public class RotateCylinder : MonoBehaviour {

    bool _rotateInProgress = false;

    void Update()
    {

        if (Input.GetKeyDown("q") && _rotateInProgress == false)
        {
            _rotateInProgress = true;
            StartCoroutine(rotate(4.5f));
        }
        if (Input.GetKeyDown("e") && _rotateInProgress == false)
        {
            _rotateInProgress = true;
            StartCoroutine(rotate(-4.5f));
        }
    }

    IEnumerator rotate(float _direction_)
    {
        float i = 0;
        while (i < 22.5f)
        {
            transform.Rotate(0, _direction_, 0);
            yield return new WaitForSeconds(0.03f);
            i = i + 5;
        }
        _rotateInProgress = false;
    }

}
