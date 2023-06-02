using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DummyScript : MonoBehaviour
{
    public Image image;

    public void ColourChangeOnClick(){
        image.color = Color.red;
    }
}
