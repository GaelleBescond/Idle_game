using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Interactible : MonoBehaviour
{
    private int _object;
    public SceneManager sceneManager;
    public TextMeshProUGUI resourcetext;
    public ObjectTypes objectType;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void RiseScore(int amount)
    {

        switch (objectType)
        {
            case ObjectTypes.push:
                sceneManager.push_score += (1 + sceneManager.commit_score) * (1 + sceneManager.branch_score);
                resourcetext.text = sceneManager.push_score.ToString("");
                break;

            case ObjectTypes.commit:
                sceneManager.commit_score++;
                resourcetext.text = sceneManager.commit_score.ToString("");
                break;

            case ObjectTypes.collaborator:
                sceneManager.collaborator_score++;
                resourcetext.text = sceneManager.collaborator_score.ToString("");
                break;

            case ObjectTypes.branch:
                sceneManager.branch_score++;
                resourcetext.text = sceneManager.branch_score.ToString("");
                break;
            case ObjectTypes.resolve:
                if (sceneManager.conflict_score < 30)
                {
                    sceneManager.conflict_score++;
                    resourcetext.text = sceneManager.conflict_score.ToString("");
                    sceneManager.Newtimer();
                }
                break;
        }


    }


}
