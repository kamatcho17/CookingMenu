using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class Order : MonoBehaviour
{
    [SerializeField]
    string url = "http://localhost/cook/";

    [SerializeField]
    InputField TableInputField, QuantiteInputField;

    [HideInInspector]
    public string foodTitle;

    string TableTitle;
    string Quantites;

    [System.Obsolete]
    public void MakeOrder() => StartCoroutine(PostData_Coroutine());

    [System.Obsolete]
    IEnumerator PostData_Coroutine()
    {
        TableTitle = TableInputField.text;
        Quantites = QuantiteInputField.text;


        WWWForm form = new WWWForm();
        form.AddField("Table", TableTitle);
        form.AddField("Name", foodTitle);
        form.AddField("Quantites", Quantites);

        using (UnityWebRequest request = UnityWebRequest.Post(url, form))
        {
            yield return request.SendWebRequest();
            if(request.isNetworkError || request.isHttpError)
            {
                Debug.Log("ERROR");
            }
            else
            {
                Debug.Log(TableTitle);
                Debug.Log(foodTitle);
                Debug.Log(Quantites);
            }
        }
    }
}
