using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Resources;

public class SceneManager : MonoBehaviour
{
    public Interactible interactibles;
    public float ticking_time;
    public float timer;
    private bool pause = false;
    public int push_score, commit_score, branch_score, collaborator_score, conflict_score;
    // Start is called before the first frame update
    void Start()
    {
        timer = ticking_time;
        StartCoroutine(Autoclick());
    }

    public IEnumerator Autoclick()
    {
        while (true)
        {
            for (int i = 0; i < collaborator_score; i++)
            {
                interactibles.RiseScore(1);
            }

            yield return new WaitForSeconds(timer);
        }
    }

    public void Newtimer()
    {
        timer -= Mathf.Log(conflict_score)/ ticking_time;
        
    }



}
