using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Chapter1
{
    public class Welcome : MonoBehaviour
    {
        private string myString = "Welcome!";
        private Text textWelcome;
        public GameObject canvasWelcome;
        private float waitTime = 0.5f;

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
            StartCoroutine(DisableCanvas(waitTime));
        }

        IEnumerator DisableCanvas(float waitTime)
        {
            yield return new WaitForSeconds(waitTime);
            canvasWelcome.SetActive(false);
        }

    }
}
