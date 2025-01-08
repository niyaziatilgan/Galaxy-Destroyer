using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    [SerializeField] GameObject destroyedVFX;

 
    private void OnTriggerEnter(Collider other)
    {
        Instantiate(destroyedVFX, transform.position, Quaternion.identity);

        //Debug.Log("Hit" + other.name);
        Debug.Log(this.gameObject);
    }
}
