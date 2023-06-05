using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
    public Image BackgroundImage;

    public void RandomizeImageColor()
    {
        var r = Random.value;
        var g = Random.value;
        var b = Random.value;
        BackgroundImage.color = new Color(r, g, b);
    }
}
