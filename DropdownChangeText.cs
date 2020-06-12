//Attach this script to Dropdown GameObject

using UnityEngine;
using UnityEngine.UI;

public class DropdownChangeText : MonoBehaviour
{
    Dropdown m_Dropdown;
    //This is the string that stores the current selection m_Text of the Dropdown
    public static string m_Message;
    int m_DropdownValue;

    void Start()
    {
        //Fetch the DropDown component from the GameObject
        m_Dropdown = GetComponent<Dropdown>();
    }

    void Update()
    {
        //Keep the current index of the Dropdown in a variable
        m_DropdownValue = m_Dropdown.value;
        //Change the message to say the name of the current Dropdown selection using the value
        m_Message = m_Dropdown.options[m_DropdownValue].text;
    }
}