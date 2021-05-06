using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//help from https://www.youtube.com/watch?v=Gtw7VyuMdDc
public class HealthBar : MonoBehaviour
{
    private Transform bar;
    // Start is called before the first frame update
    private void Start()
    {
        bar = transform.Find("Bar");
    }

    public void SetHealth(float normalizedInput) {
        bar.localScale = new Vector3(normalizedInput, 1f);
    }


}
