using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComandBack : MonoBehaviour
{
    [SerializeField]
    Transform Scroll;

    public void HidePanel()
    {
        this.transform.parent.gameObject.SetActive(false);

        Scroll.GetComponentInParent<ScrollRect>().enabled = true;
    }
}
