using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Resources;

public class Ticking_Resources : MonoBehaviour
{

    public float ticking_time;
    private bool pause = false;
    public int food;
    public int wood;
    public int gold;
    public int farmers;
    public int lumberjacks;
    public int merchants;
    public int farms;
    public int sawmills;
    public int markets;
    public TextMeshProUGUI resources_food;
    public TextMeshProUGUI resources_wood;
    public TextMeshProUGUI resources_gold;
    public TextMeshProUGUI production_food;
    public TextMeshProUGUI production_wood;
    public TextMeshProUGUI production_gold;
    private int food_yield;
    private int wood_yield;
    private int gold_yield;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ResourceTicking());
    }

    public IEnumerator ResourceTicking()
    {
        while (true)
        {
            if (!pause)
            {

                //production 
                food_yield = farmers * (1 + farms / 10);
                wood_yield = lumberjacks * (1 + sawmills / 10);
                gold_yield = merchants * (1 + markets / 10);
                //resource ticking
                food += food_yield;
                wood += wood_yield;
                gold += gold_yield;
                //update UI stockpiles
                resources_food.text = food.ToString("");
                resources_wood.text = wood.ToString("");
                resources_gold.text = gold.ToString("");
                //update UI production
                production_food.text = food_yield.ToString("");
                production_wood.text = wood_yield.ToString("");
                production_gold.text = gold_yield.ToString("");
                yield return new WaitForSeconds(ticking_time);
            }
        }
    }
}
