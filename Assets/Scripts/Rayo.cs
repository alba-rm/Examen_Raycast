using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Rayo : MonoBehaviour
{
void FixedUpdate()
{
    if(Input.GetButtonDown("Fire1"))
    {
        Raycast();
    }
}
void Raycast()
{
    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    RaycastHit hit;

    if(Physics.Raycast(ray, out hit, Mathf.Infinity))
    {
        if(hit.transform.gameObject.tag == "Box")
        {
            Debug.Log(hit.transform.name);
            SceneManager.LoadScene(1);
            //StartCoroutine(Timer());
        }

        if(hit.transform.gameObject.tag == "Box2")
        {
            Debug.Log(hit.transform.name);
            SceneManager.LoadScene(2);
            //StartCoroutine(Timer());
        }

        if(hit.transform.gameObject.tag == "Sphere")
        {
            Debug.Log(hit.transform.name);
            SceneManager.LoadScene(3);
            //StartCoroutine(Timer());
        }
    }
    Debug.DrawRay(transform.position, transform.forward * 10, Color.black);
}

 /*IEnumerator Timer()
    {
        print(Time.time);
        yield return new WaitForSeconds(5f);
    }*/
}