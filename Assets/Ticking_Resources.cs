using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Ticking_Resources : MonoBehaviour
{

    public float ticking_time;
    private bool pause = false;
    public int food;
    public int wood;
    public int gold;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ResourceTicking());
    }

    // Update is called once per frame
    void Update()
    {

    }

    public IEnumerator ResourceTicking()
    {
        while (true)
        {
        if (!pause)
            {
                Debug.Log("Tick: " + ticking_time + " s");
                yield return new WaitForSeconds(ticking_time);
            }
        }
    }
}
