using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(MaterialColorChange))]
public class ButtonCallbacks : MonoBehaviour
{
    
    [SerializeField] private Button colorChangeButton;
    [SerializeField] private Button hatButton;
    [SerializeField] private Button headButton;
    [SerializeField] private  MaterialColorChange hatColorChanger;
    [SerializeField] private MaterialColorChange headColorChanger;
    private MaterialColorChange _matChange;

    [SerializeField] private TMP_InputField headRedComponent;
    private void Awake()
    {
        Debug.Assert(headRedComponent != null);
        Debug.Assert(headButton != null);
        Debug.Assert(hatButton != null);
        _matChange = GetComponent<MaterialColorChange>();
        Debug.Assert(colorChangeButton != null);
        colorChangeButton.onClick.AddListener(_matChange.ChangeColor);
        headButton.onClick.AddListener((headColorChanger.ChangeColor));
        hatButton.onClick.AddListener((hatColorChanger.ChangeColor));
        headRedComponent.onEndEdit.AddListener(UpdateHeadColorChanger);
    }

    private void UpdateHeadColorChanger(string newText)
    {
        headColorChanger.color = new Color(float.Parse(newText),0f,0f,255);
        headColorChanger.ChangeColor();
    }
}
