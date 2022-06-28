using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChairTrigger : MonoBehaviour
{
    [SerializeField]
    private GameObject _chair;

    private bool _canTrigger;

    private Vector3 _playerPos;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            //Trigger UI
            Debug.Log("Press E");
            _canTrigger = true;
            _playerPos = other.transform.position;
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            //Rotate chair towards Player
            Debug.Log("Rotating Chair");
        }
    }
}
