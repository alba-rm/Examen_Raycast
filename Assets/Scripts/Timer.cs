using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text _text;
    //public TextMesh tiempo;
    void Start()
    {
        _text = GameObject.Find("Canvas").GetComponentInChildren<Text>();
        StartCoroutine(Tiempo());
    }
    
    IEnumerator Tiempo()
    {
        if (_text != null)
        {
        yield return new WaitForSeconds(1f);
        _text.text = "5";
        yield return new WaitForSeconds(1f);
        _text.text = "4";
        yield return new WaitForSeconds(1f);
        _text.text = "3";
        yield return new WaitForSeconds(1f);
        _text.text = "2";
        yield return new WaitForSeconds(1f);
        _text.text = "1";
        yield return new WaitForSeconds(1f);
        _text.text = "0";
        }
    }
}
