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
    public GameObject sizeSlider;
    public GameObject rotationSlider;

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

    public void changeSize()
    {
        float size = sizeSlider.GetComponent<Slider>().value;
        imageHolder.transform.localScale = new Vector2(1F * size, 1F * size);
    }

    public void changeRotation()
    {
        float rotation = rotationSlider.GetComponent<Slider>().value;
        imageHolder.transform.localRotation = Quaternion.Euler(0, 0, rotation*360);
    }
}
