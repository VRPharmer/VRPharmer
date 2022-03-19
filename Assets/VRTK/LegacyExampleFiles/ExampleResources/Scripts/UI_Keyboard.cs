namespace VRTK.Examples
{
    using UnityEngine;
    using UnityEngine.UI;

    public class UI_Keyboard : MonoBehaviour
    {
        private InputField input;
        public InputField inputPdb;

        public void Start()
        {
            input = GetComponentInChildren<InputField>();
        }

        public void ClickKey(string character)
        {
            input.text += character.ToLower();
            inputPdb.text += character.ToLower();
        }

        public void Backspace()
        {
            if (input.text.Length > 0)
            {
                input.text = input.text.Substring(0, input.text.Length - 1);
                inputPdb.text = input.text;
            }
        }

        public void Enter()
        {
            //VRTK_Logger.Info("You've typed [" + input.text + "]");
            input.text = "";
        }

        
    }
}