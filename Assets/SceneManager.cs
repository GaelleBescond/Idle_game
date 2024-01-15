using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Resources;

public class SceneManager : MonoBehaviour
{

    public float ticking_time;
    private bool pause = false;
    public TextMeshProUGUI score, resources;
    public int push_score, commit_score, branch_score, collaborator_score, conflict_score;
    // Start is called before the first frame update
    void Start()
    {
      //  StartCoroutine(ResourceTicking());
    }

    public IEnumerator Autoclick()
    {
        while (true)
        {
            if (!pause)
            {
            
            }
        }
    }


}
