using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropDownSetter : MonoBehaviour
{
    [SerializeField] Vector2Int range;
    [SerializeField] Dropdown dropDown;

    [ContextMenu("setRange")]
    public void SetDropDown()
    {
        dropDown.options = new List<Dropdown.OptionData>();
        for(int i = range.x; i <= range.y; i++)
        {
            dropDown.options.Add(new Dropdown.OptionData(i.ToString()));
        }
    }
}
