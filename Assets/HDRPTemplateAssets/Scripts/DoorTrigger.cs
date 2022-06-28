using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    [SerializeField]
    private GameObject _door;
    [SerializeField]
    private GameObject _doorLight;

    private Animator _doorAnim;

    private bool _canOpen;

    private void Start()
    {
        if (_door != null)
        {
            _doorAnim = _door.GetComponent<Animator>();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            //Display UI
            Debug.Log("Press E");

            _canOpen = true;
        }
    }

    private void Update()
    {
        if (_canOpen == true && Input.GetKeyDown(KeyCode.E))
        {
            _doorAnim.SetTrigger("openDoor");
            //Change Light Emission
        }
    }
}
