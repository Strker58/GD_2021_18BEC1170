using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makeCubesDisappear : MonoBehaviour
{
    public float min_pulpit_destroy_time = 4f;
    public float max_pulpit_destroy_time = 5f;
    public float pulpit_spawn_time = 2.5f;
    public float[] possiblepossitionsx = {0f, -1.003f, 1.003f};
    public float[] possiblepossitionsz = { 0f, -1.008f, 1.008f };
    public GameObject reference;
    private int possiblecube = 2;
    private int count=0;
    // Start is called before the first frame update
    void Awake()
    {
        StartCoroutine(Spawn());
    }

    // Update is called once per frame
    void Update()
    {
        if (count < 2) StartCoroutine(Spawn());
        else StartCoroutine(destroyed());
    }
    IEnumerator Spawn()
    {
       yield return new WaitForSeconds(pulpit_spawn_time);
        Instantiate(reference, new Vector3(Random.Range(), transform.position.y, transform.position.z), Quaternion.identity);
        count++;
    }
    private void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Ground")
        {
            destroyed();
            target.gameObject.SetActive(false);
            count--;
        }
    }
    IEnumerator destroyed()
    {
        yield return new WaitForSeconds(Random.Range(min_pulpit_destroy_time, max_pulpit_destroy_time));
    }
}
