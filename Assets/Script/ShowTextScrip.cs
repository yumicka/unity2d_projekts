using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowTextScrip : MonoBehaviour
{
    /*
     // Start is called before the first frame update
     void Start()
     {
         Debug.Log("Uzstartēts!"); 
     }

     public int kadrs = 0;
     // Update is called once per frame
     void Update()
     {
         kadrs++;
         Debug.Log(kadrs);
     }
    */

    string text;
    public GameObject inputField;
    public GameObject displayField;
    string[] words = { "Sveiki ", "Jauku dienu ", "Labrīt ", "Prieks Tevi redzēt " };
    int randomNumb;


    //Šeit papildināsim ar Random
    public void getText()
    {
        randomNumb = Random.Range(0, words.Length);
        text = inputField.GetComponent<Text>().text;
        displayField.GetComponent<Text>().text =
                                words[randomNumb] + text.ToLower() + "!";
    }

}
