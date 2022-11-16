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

            Debug.Log("touch");

            if (hit.collider.tag == "cat")
            {
                Debug.Log("Catch cat");
                text.text = "포획 성공!";
                Destroy(hit.collider.gameObject);
                hit.collider.gameObject.SetActive(false);

                //몇초 뒤 다시 텍스트 변환
                StartCoroutine(delayTime());
                text.text = "고양이를 찾아보자!";

                PlayerPrefs.SetString(hit.collider.gameObject.name, "Yes");
                Debug.Log(hit.collider.gameObject.name + " -> made data!!");
            }
            else
            {
                Debug.Log("not cat");
            }
        }
    }

    IEnumerator delayTime()
    {
        yield return new WaitForSeconds(5);
        Debug.Log("time = " + Time.time);
    }
    
}
