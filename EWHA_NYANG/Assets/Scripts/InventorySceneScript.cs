using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySceneScript : MonoBehaviour
{
    public GameObject cat1, cat2, cat3, cat4;
    public GameObject cat1_m, cat2_m, cat3_m, cat4_m;

    public GameObject cat1_txt, cat2_txt, cat3_txt, cat4_txt;
    public GameObject cat1_txt_m, cat2_txt_m, cat3_txt_m, cat4_txt_m;

    // Start is called before the first frame update
    void Start()
    {
        call_Cat();
    }

    // Update is called once per frame
    void Update()
    {
        call_Cat();
    }

    void call_Cat()
    {
        if (PlayerPrefs.HasKey("Cat1"))
        {
            cat1.SetActive(true);
            cat1_m.SetActive(false);

            cat1_txt.SetActive(true);
            cat1_txt_m.SetActive(false);

        }

        if (PlayerPrefs.HasKey("Cat2"))
        {
            cat2.SetActive(true);
            cat2_m.SetActive(false);

            cat2_txt.SetActive(true);
            cat2_txt_m.SetActive(false);
        }

        if (PlayerPrefs.HasKey("Cat3"))
        {
            cat3.SetActive(true);
            cat3_m.SetActive(false);

            cat3_txt.SetActive(true);
            cat3_txt_m.SetActive(false);
        }

        if (PlayerPrefs.HasKey("Cat4"))
        {
            cat4.SetActive(true);
            cat4_m.SetActive(false);

            cat4_txt.SetActive(true);
            cat4_txt_m.SetActive(false);
        }
    }
}
