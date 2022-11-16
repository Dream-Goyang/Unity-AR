using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManageScript : MonoBehaviour
{
    public void catch_cat1()
    {
        PlayerPrefs.SetString("Cat1", "Yes");
    }

    public void catch_cat2()
    {
        PlayerPrefs.SetString("Cat2", "Yes");
    }

    public void catch_cat3()
    {
        PlayerPrefs.SetString("Cat3", "Yes");
    }

    public void catch_cat4()
    {
        PlayerPrefs.SetString("Cat4", "Yes");
    }

    public void delete_all ()
    {
        PlayerPrefs.DeleteAll();
    }
}
