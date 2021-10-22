using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomError : MonoBehaviour
{
    public GameObject[] CircleParts;
    private GameObject ErrorCirclePart;
    private int _errorCount;
    private int _falsePartCount;
    private int rnd;
    
    void Awake()
    {
        //Random error sayısı
        _errorCount = Random.Range(1, 3);
        //Random false object sayısı
        _falsePartCount = Random.Range(1, 2);

      //
        while (_errorCount>=0)
        {
            rnd = Random.Range(0, 16);
            foreach (Renderer renderer in CircleParts[rnd].GetComponentsInChildren<Renderer>())
            {
                renderer.material.color=Color.red;
                CircleParts[rnd].transform.GetChild(1).gameObject.AddComponent<Error>();
            }
            _errorCount--;
        }
        
        
        

       

        for (int i = 0; i < _falsePartCount; i++)
        {
            rnd = Random.Range(0, 14);
            CircleParts[rnd].SetActive(false);
            CircleParts[rnd+1].SetActive(false);
            
        }
        
    }
    
}
