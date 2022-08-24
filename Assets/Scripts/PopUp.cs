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

        // To Show FoodTitle
        comandPannel.transform.Find("FoodTitle").GetComponent<Text>().text = FoodTitle;

        // To Send FoodTitle to server
        comandPannel.transform.Find("Order").GetComponent<Order>().foodTitle = FoodTitle;

        this.GetComponentInParent<ScrollRect>().enabled = false;
    }
}
