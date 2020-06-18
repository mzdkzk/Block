using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StateText : MonoBehaviour
{
    private Text _label;
    void Start()
    {
        _label = GetComponent<Text>();
    }

    void Update()
    {
        if (GameController.State == GameState.Finish)
        {
            _SetText("CLEAR");
        }
    }

    private void _SetText(string str)
    {
        if (_label.text != str)
        {
            _label.text = str;
        }
    }
}
