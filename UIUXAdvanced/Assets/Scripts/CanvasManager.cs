﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEditor;
using System.Text;
using TMPro;

public enum CanvasType
{
   News,
   Explore,
   ExploreTopic,
   ExploreRigging,
   EnrollRigging,
   CoursesNeutral,
   CoursesSelected,
   SoftwareArchitecture,
   SoftwareArchitectureExplore,
   UIUXExplore,
   nothingToShow,
   RecordedLectureChat,
   RecordedLectureDescription
}


public class CanvasManager : MonoBehaviour
{
    List<CanvasController> canvasControllerList;
    CanvasController lastActiveCanvas;
    private void Awake()
    {
        canvasControllerList = GetComponentsInChildren<CanvasController>().ToList();
        foreach (CanvasController item in canvasControllerList)
        {
            item.gameObject.SetActive(false);
        }
        SwitchCanvas(CanvasType.News);
    }

    public void SwitchCanvas(CanvasType _type)
    {
        Debug.Log("Switch");
        if (lastActiveCanvas != null)
        {
            lastActiveCanvas.gameObject.SetActive(false);
        }
        CanvasController desiredScreen = canvasControllerList.Find(x => x.type == _type);
        if (desiredScreen != null)
        {
            desiredScreen.gameObject.SetActive(true);
            lastActiveCanvas = desiredScreen;
        }
    }


    public CanvasController GetCurrentCanvas()
    {
        return lastActiveCanvas;
    }
}
