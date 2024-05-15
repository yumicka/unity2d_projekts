using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageScript : MonoBehaviour
{
    public GameObject bean;
    public GameObject teddy;
    public GameObject lady;
    public GameObject car;
    public GameObject leftToggle;
    public GameObject rightToggle;
    public Sprite[] spriteArray;
    public GameObject imageHolder;

    public void showBean(bool value)
    {
        bean.SetActive(value);
        leftToggle.GetComponent<Toggle>().interactable = value;
        rightToggle.GetComponent<Toggle>().interactable = value;
    }

    public void showTeddy(bool value)
    {
        teddy.SetActive(value);
    }

    public void showLady(bool value)
    {
        lady.SetActive(value);
    }

    public void showCar(bool value)
    {
        car.SetActive(value);
    }

    public void toLeft()
    {
        bean.transform.localScale = new Vector2(1, 1);
    }

    public void toRight()
    {
        bean.transform.localScale = new Vector2(-1, 1);
    }

    public void changeImage(int index)
    {
        if (index == 0)
            imageHolder.GetComponent<Image>().sprite = spriteArray[0];

        else if (index == 1)
            imageHolder.GetComponent<Image>().sprite = spriteArray[1];

        else if (index == 12)
            imageHolder.GetComponent<Image>().sprite = spriteArray[2];
    }

}
