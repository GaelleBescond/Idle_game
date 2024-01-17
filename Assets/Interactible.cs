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
                if (sceneManager.push_score > (10 + sceneManager.commit_score) * (2 + sceneManager.commit_score))
                {
                    sceneManager.commit_score++;
                    resourcetext.text = sceneManager.commit_score.ToString("");
                }
                break;

            case ObjectTypes.branch:
                if (sceneManager.commit_score > (10 + sceneManager.branch_score) * (1 + sceneManager.branch_score))
                {
                    sceneManager.branch_score++;
                    resourcetext.text = sceneManager.branch_score.ToString("");
                }
                break;

            case ObjectTypes.collaborator:
                if (sceneManager.commit_score > (10 + 10 * sceneManager.collaborator_score)
                    && (sceneManager.branch_score) > (10 + sceneManager.collaborator_score))
                {
                    sceneManager.commit_score -= 10 + 10 * sceneManager.collaborator_score;
                    sceneManager.branch_score -= 10 + sceneManager.collaborator_score;
                    sceneManager.collaborator_score++;
                    resourcetext.text = sceneManager.collaborator_score.ToString("");
                }
                sceneManager.Newtimer();
                break;

            case ObjectTypes.resolve:
                if (sceneManager.push_score > 100 * (sceneManager.commit_score + sceneManager.branch_score))
                {
                    sceneManager.conflict_score++;
                    resourcetext.text = sceneManager.conflict_score.ToString("");
                }

                break;
        }


    }


}
