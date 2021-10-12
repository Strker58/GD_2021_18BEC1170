using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground_checker : MonoBehaviour
{
    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground") GameObject.Find("Player_Score").GetComponent<UI_Script>().score++;
    }
}
