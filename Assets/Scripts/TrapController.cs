using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class TrapController : MonoBehaviour
{
    public GameObject cubeTrap;
   public void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision");
        if(other.gameObject.tag == "Player")
        {
            AudioSource sound = GetComponent<AudioSource>();
            sound.Play();

            for(int i = 0; i < 7; i++)
            {
                float randomX = Random.Range(transform.position.x-15, transform.position.x+15);
                float randomZ = Random.Range(transform.position.z-15, transform.position.y+15);

                var cube = Instantiate(cubeTrap, new Vector3(randomX, 15, randomZ), Quaternion.identity);

                Destroy(cube, 5.0f);
            }
            
        }
    }
}
