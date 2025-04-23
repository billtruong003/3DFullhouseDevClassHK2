using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModifiCentroid : MonoBehaviour
{
    [SerializeField] private Animator anim;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
            anim.SetFloat("centroid", -1);
        else if (Input.GetKeyDown(KeyCode.RightArrow))
            anim.SetFloat("centroid", 1);
        else if (Input.GetKeyDown(KeyCode.UpArrow))
            anim.SetFloat("centroid", 0.5f);
    }
}
