using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SearchScript : MonoBehaviour
{
    public Image Rigging;
    public Image UIUX;
    public Image SoftwareArchitecture;
    public Image NoMatchFound;
    string textToCompare = null;
    Button button;
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(ChangeScreen);
    }

    // Update is called once per frame

    public void ChangeText(string text)
    {
        textToCompare = text;
    }

    public void ChangeScreen()
    {
        if (textToCompare == "rigging" || textToCompare == "Rigging")
        {
            GetComponent<CanvasSwitcher>().OnScreenChange(CanvasType.ExploreTopic);
        }
        else
        if (textToCompare == "UIUX" || textToCompare == "uiux" || textToCompare == "ui ux" || textToCompare == "UI UX")
        {
            GetComponent<CanvasSwitcher>().OnScreenChange(CanvasType.UIUXExplore);
        }
        else if (textToCompare == "Software Architecture" || textToCompare == "software architecture")
        {
            GetComponent<CanvasSwitcher>().OnScreenChange(CanvasType.SoftwareArchitectureExplore);
        }
        else
        {
            GetComponent<CanvasSwitcher>().OnScreenChange(CanvasType.nothingToShow);
        }

    }
}
