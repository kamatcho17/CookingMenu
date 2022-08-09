using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopUp : MonoBehaviour
{
    [SerializeField]
    string FoodTitle;

    [SerializeField]
    GameObject comandPannel;


    public void ShowPanel()
    {
        comandPannel.SetActive(true);

        comandPannel.transform.Find("FoodTitle").GetComponent<Text>().text = FoodTitle;

        this.GetComponentInParent<ScrollRect>().enabled = false;
    }
}
