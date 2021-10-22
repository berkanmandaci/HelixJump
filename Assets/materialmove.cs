using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class materialmove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public int speed;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0,Time.deltaTime*speed,0));
    }
}
