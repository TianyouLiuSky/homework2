using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject prefab;
    public GameObject shootingPoint;

    void Update() 
    {
        if (Input.GetKeyDown(KeyCode.Mouse0)) 
        { 
            Instantiate(prefab, transform.position, transform.rotation);
        }
    }
    
}
