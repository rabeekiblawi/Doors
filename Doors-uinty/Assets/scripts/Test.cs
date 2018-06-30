using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Utils;
using UniRx;
public class Test : MonoBehaviour
{

    public string url = "https://cdn.pixabay.com/photo/2016/10/27/22/53/heart-1776746_1280.jpg";

    void Start()
    {

        FileLoader.Instance.LoadFile(url).Subscribe(www =>
        {
            
            LoadImage(www[0]);
        });
    }

    private void ParseData() {


    }


    public void LoadImage(WWW raw)
    {
        Renderer renderer = GetComponent<Renderer>();
        renderer.material.mainTexture = raw.texture;
    }

}

