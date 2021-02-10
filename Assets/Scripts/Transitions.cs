using UnityEngine;

/// <summary>
/// Control Puppy 1 by setting parameter values on the animator and using conditions to trigger transitions between animation clips.
/// This is the type of animation seen in the Lab 1 project folder: "2. 3D Animation".
/// </summary>

public class Transitions : MonoBehaviour
{
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
