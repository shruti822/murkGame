using UnityEngine;
using UnityEngine.UI;
using System;

public class headerMenu : MonoBehaviour
{
    bool isOpen = false;

    public GameObject headerMenuUI;
    public Image upDownArrow;

    public Sprite[] upDown;


    public void openCloseMenu()
    {
        if(isOpen == true)
        {
            //openToClose
            headerMenuUI.GetComponent<Animator>().Play("headerMenuClose");
            isOpen = false;
            upDownArrow.GetComponent<Image>().sprite = upDown[0];

        }
        else if(isOpen == false)
        {
            //closeToOpen
            headerMenuUI.GetComponent<Animator>().Play("headerMenuOpen");
            isOpen = true;
            upDownArrow.GetComponent<Image>().sprite = upDown[1];

        }
    }
}
