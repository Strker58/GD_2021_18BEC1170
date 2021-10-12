using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UI_Script : MonoBehaviour
{
    public Text Score_Count;
    public int score=0;
    // Start is called before the first frame update
    //void Start()
    //{
    //    Score_Count.text = "Score: " + score;
    //}

    // Update is called once per frame
    void Update()
    {
        Score_Count.text = "Score: " + score;
    }
}
