using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CatScript : MonoBehaviour
{
    public Text text;
    //public GameObject cat;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(touch.position);
            Physics.Raycast(ray, out hit);

            if (hit.collider.tag == "cat")
            {
                text.text = "포획 성공!";
                hit.collider.gameObject.SetActive(false);
            }

        }
    }

    //private void OnCollisionEnter(Collision collision)
    //{
    //    Touch touch = Input.GetTouch(0);
    //    RaycastHit hit;
    //    Ray ray = Camera.main.ScreenPointToRay(touch.position);
    //    Physics.Raycast(ray, out hit);

    //    if (hit.collider.tag == "cat")
    //    {
    //        text.text = "포획 성공!";
    //        Destroy(collision.gameObject);
    //        gameObject.SetActive(false);
    //    }
    //}
}
