using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoginMaster : MonoBehaviour
{
    public InputField inputfield;
    private string contras = "holi";

    public void Boton()
    {
        if (inputfield.text == contras)
        {
            Debug.Log("Access garanted");
        }

        else
        {
            Debug.Log("Access denied"); 
        }
    }
}
