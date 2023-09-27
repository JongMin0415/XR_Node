using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TabInputField : MonoBehaviour
{
    public InputField[] InputFields;           // tab키로 이동할 inputfield 배열

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Tab))
        {
            InputField currentInputField = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.GetComponent<InputField>();

            if(currentInputField != null)
            {
                int currentIndex = System.Array.IndexOf(InputFields, currentInputField);
                int nextIndex = (currentIndex + 1) % InputFields.Length;

                InputFields[nextIndex].Select();
                InputFields[nextIndex].ActivateInputField();
            }
        }
    }
}
