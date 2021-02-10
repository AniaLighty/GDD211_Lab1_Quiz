using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Trying to see if copying the code and readding it in a new scprit works
    [SerializeField] private Animator puppy1Animator;

    private void Update()
    {
        float input = Input.GetAxisRaw("Vertical");

        if (input > 0f) //Walk
        {
            transform.position += new Vector3(Time.deltaTime * 0.3f, 0f);

        }
        else //Idle
        {
            puppy1Animator.SetFloat("MoveSpeed", Mathf.Abs(input));
        }
    }
}
