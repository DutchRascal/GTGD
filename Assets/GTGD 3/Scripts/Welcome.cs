using UnityEngine;
using UnityEngine.UI;

namespace Chapter1
{
    public class Welcome : MonoBehaviour
    {
        private string myString = "Welcome!";
        private Text textWelcome;

        private void Start()
        {
            SetInitiaReferences();
            MyWelcomeMessage();
        }

        void SetInitiaReferences()
        {
            textWelcome = GameObject.Find("TextWelcome").GetComponent<Text>();
        }

        void MyWelcomeMessage()
        {
            if (textWelcome != null)
            {
                textWelcome.text = myString;
            }
            else
            {
                Debug.Log("welcomeText not assigned!");
            }
        }
    }
}
