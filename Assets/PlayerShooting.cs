using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerShooting : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject prefab;
    public GameObject shootingPoint;
    public ParticleSystem  muzzleEffect;



    void Update() 
    {
        if (Input.GetKeyDown(KeyCode.Mouse0)) 
        { 
            Instantiate(prefab, transform.position, transform.rotation);
        }
    }

    public void OnFire(InputValue value)
    {
        if(value.isPressed){
            GameObject clone = Instantiate(prefab);
            clone. transform.position = shootingPoint.transform.position;
            clone. transform.rotation = shootingPoint.transform.rotation;
            muzzleEffect.Play();
        }
    }
    
}
