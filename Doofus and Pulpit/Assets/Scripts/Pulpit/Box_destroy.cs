using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box_destroy : MonoBehaviour
{
    public float min_pulpit_destroy_time = 4f;
    public float max_pulpit_destroy_time = 5f;
    // Start is called before the first frame update
    void FixedUpdate()
    {
        StartCoroutine(destroyed());
    }
    IEnumerator destroyed()
    {
        yield return new WaitForSeconds(Random.Range(min_pulpit_destroy_time, max_pulpit_destroy_time));
        GameObject.Find("Pulpit").GetComponent<makeCubesDisappear>().count--;
        Destroy(gameObject);
    }
}
