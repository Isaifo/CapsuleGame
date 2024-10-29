using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletControllet : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Enemy"){
       
       Destroy(other.gameObject);
       float RandomX = UnityEngine.Random.Range(-10, 10);
       float RandomZ = UnityEngine.Random.Range(-10, 10);

       GameObject enemy = Instantiate(Resources.Load("Georgi", typeof(GameObject))) as GameObject;
       enemy.transform.position = new Vector3(RandomX, 1, RandomZ);
       enemy.transform.rotation = Quaternion.Euler(0, UnityEngine.Random.Range(0, 360), 0);
       Destroy(gameObject);
       }}}
