using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;


public class InputCommand : MonoBehaviour
{
    public TMP_InputField inputField;
    // Start is called before the first frame update
    void Start()
    {
        inputField.onEndEdit.AddListener(SubmitInput);
    }

    public void SubmitInput(string input)
    {
        Debug.Log("Submitted: " + input);
    }

    public void OnSubmit(BaseEventData eventData)
    {
        SubmitInput(inputField.text);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftControl) && Input.GetKeyDown(KeyCode.I))
        {
            // Activate the input field and set the focus to it
            inputField.ActivateInputField();
            inputField.Select();
        }
    }
}
