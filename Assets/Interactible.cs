using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Interactible : MonoBehaviour
{
    private int _object;
    public Ticking_Resources _resources;
    public TextMeshProUGUI resourcetext;
    public int food_cost;
    public int wood_cost;
    public int gold_cost;
    public ObjectTypes objectType;
   // public float cost_augmenter = 1.1f;


    // Start is called before the first frame update
    void Start()
    {

    }



    public void RiseScore(int amount)
    {
        //if suffisamment de ressources requises
        if (_resources.food >= food_cost && _resources.wood >= wood_cost && _resources.gold >= gold_cost)
        {
         
            _resources.food -= food_cost;
            _resources.wood -= wood_cost;
            _resources.gold -= gold_cost;

            food_cost = food_cost * 110 / 100;
            wood_cost = wood_cost * 110 / 100;
            gold_cost = gold_cost * 110 / 100;
           /* Debug.Log(food_cost);
            Debug.Log(wood_cost);
            Debug.Log(gold_cost);*/
            switch (objectType)
            {
                case ObjectTypes.farmer:
                    _resources.farmers += amount;
                    _object = _resources.farmers;
                    break;
                case ObjectTypes.lumberjack:
                    _resources.lumberjacks += amount;
                    _object = _resources.lumberjacks;
                    break;
                case ObjectTypes.merchant:
                    _resources.merchants += amount;
                    _object = _resources.merchants;
                    break;
                case ObjectTypes.farm:
                    _resources.farms += amount;
                    _object = _resources.farms;
                    break;
                case ObjectTypes.sawmill:
                    _resources.sawmills += amount;
                    _object = _resources.sawmills;
                    break;
                case ObjectTypes.market:
                    _resources.markets += amount;
                    _object = _resources.markets;
                    break;
            }
            resourcetext.text = _object.ToString("");
        }

    }
}
