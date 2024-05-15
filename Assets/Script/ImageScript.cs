using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageScript : MonoBehaviour
{
    public GameObject bean;
    public GameObject teddy;
    public GameObject lady;
    public GameObject car;

    public void showBean(bool value)
    {
        bean.SetActive(value);
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


}
