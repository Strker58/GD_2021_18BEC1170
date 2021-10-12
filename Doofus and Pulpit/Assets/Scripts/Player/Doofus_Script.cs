using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Doofus_Script : MonoBehaviour
{
    public float speed = 8f;
    private Rigidbody playerBody;
    // Start is called before the first frame update
    void Start()
    {
        playerBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        playerMovement();
        if(gameObject.transform.position.y<-2)
        {
            StartCoroutine(PlayerDied());
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
    IEnumerator PlayerDied()
    {
        yield return new WaitForSecondsRealtime(2f);
        SceneManager.LoadScene("SampleScene");
    }
}
