using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doofus_Script : MonoBehaviour
{
    public float speed = 8f;
    private Rigidbody playerBody;
    public bool isdead=false;
    // Start is called before the first frame update
    void Start()
    {
        playerBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        playerMovement();
        if(isdead)
        {
            
        }
    }
    void playerMovement()
    {
        if (Input.GetAxisRaw("Vertical") > 0.5 || Input.GetAxisRaw("Vertical") < -0.5)
        {
                playerBody.velocity += transform.forward * speed * Input.GetAxisRaw("Vertical");
        }
        if (Input.GetAxisRaw("Horizontal") > 0.5 || Input.GetAxisRaw("Horizontal") < -0.5)
        { 

               playerBody.velocity += transform.right * speed * Input.GetAxisRaw("Horizontal");
        }

    }
    private void OnCollisionEnter(Collision target)
    {
        if(target.gameObject.tag=="Dead")
        {
            isdead = true;
        }
    }
}
