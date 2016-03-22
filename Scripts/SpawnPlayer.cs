using UnityEngine;
using System.Collections;

public class SpawnPlayer : MonoBehaviour
{
    private Transform _SpawnPos;
    public GameObject _Player;

    // Use this for initialization
    void Start()
    {
        _SpawnPos = gameObject.transform;
        Instantiate(_Player, _SpawnPos.position, _SpawnPos.rotation);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
