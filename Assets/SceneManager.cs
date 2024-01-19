using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Resources;

public class SceneManager : MonoBehaviour
{
    public Interactible interactibles;
    public float ticking_time;
    private float timer;
    public Animator logoCycleSpeed;
    private bool pause = false;
    public int push_score, commit_score, branch_score, collaborator_score, conflict_score;
    // Start is called before the first frame update
    void Start()
    {
        timer = ticking_time;
    }

    public IEnumerator Autoclick()
    {
        while (true)
        {
            interactibles.RiseScore(1+conflict_score);
            Debug.Log(timer);
            yield return new WaitForSeconds(timer);
        }
    }

    public void Newtimer()
    {
        StopCoroutine(Autoclick());
        if (collaborator_score > 0)
        {
            timer = (Mathf.Log(collaborator_score) / (ticking_time));
            logoCycleSpeed.SetFloat("Speed", timer);
            StartCoroutine(Autoclick());
        }



    }



}
