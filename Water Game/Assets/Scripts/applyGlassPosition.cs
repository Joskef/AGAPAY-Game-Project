using UnityEngine;
using System.Collections;

public class applyGlassPosition : MonoBehaviour
{
    float x;
    float y;
    float z;
    public GameObject Target;

    // Use this for initialization
    void Start()
    {
        x = 0;
        y = (float)1.5;
        z = (float)-1.8;
    }

    // Update is called once per frame
    public void UpdateX(float sliderValue)
    {
        x = sliderValue;
    }

    public void UpdateY(float sliderValue)
    {
        y = sliderValue;
    }

    public void UpdateZ(float sliderValue)
    {
        z = sliderValue;
    }

    public void Apply()
    {
        Target.transform.position = new Vector3(x, y, z);
    }

    public void Revert()
    {
        x = 0;
        y = (float)1.5;
        z = (float)-1.8;
        Target.transform.position = new Vector3(x, y, z);
    }
}
