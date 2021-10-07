using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makeCubesDisappear : MonoBehaviour
{
    public GameObject[] cubes=new GameObject[9];
    public float min_pulpit_destroy_time = 4f;
    public float max_pulpit_destroy_time = 5f;
    public float pulpit_spawn_time = 2.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Activate()
    {
        yield return new WaitForSecondsRealtime(pulpit_spawn_time);
        
    }
}
