using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class LoginManager : MonoBehaviour
{
    [SerializeField] private TMP_InputField usernameInputField;
    [SerializeField] private TMP_InputField passwordInputField;
    [SerializeField] private TMP_Text warningText;

    /// <summary>
    /// Logs in the user.
    /// Is called when Login Button is clicked.
    /// </summary>
    public void LoginUser()
    {
        if(string.IsNullOrWhiteSpace(usernameInputField.text) || string.IsNullOrWhiteSpace(passwordInputField.text))
        {
            warningText.gameObject.SetActive(true);
        }
        else
        {
            if (warningText.IsActive() == true)
            {
                warningText.gameObject.SetActive(false);
            }
        }
    }
}
