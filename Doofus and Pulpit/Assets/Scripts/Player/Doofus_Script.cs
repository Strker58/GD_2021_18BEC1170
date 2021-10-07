using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Doofus_Script : MonoBehaviour
{
    public float speed = 8f;
    private Rigidbody playerBody;
    private bool isdead=false;
    private bool isGround = true;
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
            PlayerDied();
        }
    }
    void playerMovement()
    {
        if (isGround)
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
    }
    private void OnCollisionEnter(Collision target)
    {
        if (target.gameObject.tag == "Dead")
        {
            isdead = true;
        }
        if(target.gameObject.tag=="Ground")
        {
            isGround = true;
        }
    }
    IEnumerator PlayerDied()
    {
        yield return new WaitForSecondsRealtime(2f);
        SceneManager.LoadScene("SampleScene");
    }
}
