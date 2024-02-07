using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public GameObject VaseOnPlayer;

    // Start is called before the first frame update
    void Start()
    {
        VaseOnPlayer.SetActive(false);
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player") 
        {
            if (Input.GetKey(KeyCode.E))
            {
                this.gameObject.SetActive(false);

                VaseOnPlayer.SetActive(true);
            }
        }
    }
}
