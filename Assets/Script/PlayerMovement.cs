using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float velMov = 5.0f;
    public float velRot = 200.0f;
    private Animator ani;
    public float x, y;
    void Start()
    {
        ani = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        transform.Rotate(0, x * Time.deltaTime * velRot, 0);
        transform.Translate(0, 0, y * Time.deltaTime * velMov);

        ani.SetFloat("VelX", x);
        ani.SetFloat("VelY", y);
        
    }
}
