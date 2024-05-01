using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootstepsController : MonoBehaviour
{
    public AudioSource woodSteps, stoneSteps;
    public float raycastDistance = 1f; // Adjust this value based on your scene

    void Update()
    {
        RaycastHit hit;

        


        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {

            if (Physics.Raycast(transform.position, Vector3.down, out hit, raycastDistance))
            {

                Debug.DrawRay(transform.position, Vector3.down * raycastDistance, Color.green);
                string floorTag = hit.collider.tag;
                // You can use floorTag to determine which surface the player is walking on
                Debug.Log("Floor Tag: " + floorTag);

                if (hit.collider.tag == "Stone Surface")
                {
                    woodSteps.enabled = false;
                    stoneSteps.enabled = true;
                }
                else if (hit.collider.tag == "Wood Surface")
                {
                    woodSteps.enabled = true;
                    stoneSteps.enabled = false;
                }
            }
            else
            {
                Debug.Log("VOLANDO");
                woodSteps.enabled = false;
                stoneSteps.enabled = false;
            }

        }
        else
        {
            woodSteps.enabled = false;
            stoneSteps.enabled = false;
        }

        //else
        //{
        //    woodSteps.enabled = false;
        //    stoneSteps.enabled = false;
        //}
    }
}
