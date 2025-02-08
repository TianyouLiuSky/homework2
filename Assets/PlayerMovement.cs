using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speeed;
    public float rotationSpeed;      

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) {transform.Translate(0, 0, speeed);}
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) {transform.Translate(0, 0, -speeed);}
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) {transform.Translate(-speeed, 0, 0);}
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) {transform.Translate(speeed, 0, 0);}
        */

        // delta time
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) {transform.Translate(0, 0, speeed * Time.deltaTime);}
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) {transform.Translate(0, 0, -speeed * Time.deltaTime);}
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) {transform.Translate(-speeed * Time.deltaTime, 0, 0);}
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) {transform.Translate(speeed * Time.deltaTime, 0, 0);}



        // mouse movement
        float mouseX = Input.GetAxis("Mouse X");
        transform.Rotate(0, mouseX * rotationSpeed * Time.deltaTime, 0);

    }
}
