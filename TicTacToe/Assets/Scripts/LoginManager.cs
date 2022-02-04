using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class LoginManager : MonoBehaviour
{
    [SerializeField] TMP_InputField usernameInputField;
    [SerializeField] TMP_InputField passwordInputField;

    public void LoginUser()
    {
        if(usernameInputField.text != "" && passwordInputField.text != "")
        {
        }
        else
        {
            Debug.Log("Username or Password empty!");
        }
    }
}
