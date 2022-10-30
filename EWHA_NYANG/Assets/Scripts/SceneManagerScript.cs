using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour
{
    public void btn_play()
    {
        SceneManager.LoadScene("Marker Scene");
    }

    public void btn_inventory()
    {
        SceneManager.LoadScene("Inventory Scene");
    }

    public void btn_check()
    {
        Scene game = SceneManager.GetSceneByName("Marker Scene");
        GameObject[] obj = game.GetRootGameObjects();
    }
}
