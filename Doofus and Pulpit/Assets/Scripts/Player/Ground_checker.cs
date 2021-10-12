using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Ground_checker : MonoBehaviour
{
    public Text Score_UI;
    private int Score=0;
    // Update is called once per frame
    void OnCollisionEnter(Collision target) 
    {
        print("Collision Detected");
        if (target.gameObject.tag == "Ground")
        {
            Score++;
            Score_UI.text = "Score: " + Score;
        }
        
    }
}
