using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Doofus_Script : MonoBehaviour
{
    public float speed = 8f;
    private Rigidbody playerBody;
    public Text Score_UI;
    private int Score = 0;
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
    void OnCollisionEnter(Collision target)
    {
        print("Collision Detected");
        if (target.gameObject.tag == "Ground")
        {
            Score++;
            Score_UI.text = "Score: " + Score;
        }
    }
    IEnumerator PlayerDied()
    {
        yield return new WaitForSecondsRealtime(2f);
        SceneManager.LoadScene("SampleScene");
    }
}
