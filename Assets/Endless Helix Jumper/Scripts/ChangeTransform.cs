using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeTransform : MonoBehaviour
{
    
    public GameObject nextBase;
    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.CompareTag("Next"))
        {
            nextBase.transform.position = new Vector3(0, nextBase.transform.position.y - 48, 0);
        }
    }
}
