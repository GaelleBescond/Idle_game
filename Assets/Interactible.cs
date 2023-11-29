using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Interactible : MonoBehaviour
{
    private int _resource;

    public TextMeshProUGUI resourcetext;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RiseScore(int amount)
    {
        _resource += amount;
        resourcetext.text = _resource.ToString("");
    }
}
