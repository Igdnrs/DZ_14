using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpherePhys : MonoBehaviour
{
    public GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Spawn();
    }
    void Spawn()
    {
        if(gameObject.transform.position.y <= -5)
        {
            gameObject.transform.position = new Vector3(0,5,0);
        }
    }
}
