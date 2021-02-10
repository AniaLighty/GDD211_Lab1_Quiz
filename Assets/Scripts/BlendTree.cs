using UnityEngine;

/// <summary>
/// Control Puppy 2 by setting parameter values on the animator and using a blend tree to control the motion.
/// This is the type of animation seen in the Lab 1 project folder: "3. Blend Trees".
/// </summary>

public class BlendTree : MonoBehaviour
{
	[SerializeField] private Animator puppy2Animator;
	private float speed;
    private float move = 0f;

	private void Update()
	{
        float input = Input.GetAxisRaw("Vertical");

        if (input > 0f) //Walk
		{
            move = Mathf.Lerp(move, input * speed, Time.deltaTime);
            move = Mathf.Clamp(move, -speed, speed);
		}
		else //Idle
		{
            move = Mathf.Lerp(move, 0f, Time.deltaTime * 5f);
        }

		transform.position += new Vector3(Time.deltaTime * 0.32f * move, 0f);

        puppy2Animator.SetFloat("Blend", Mathf.Abs(move));
    }
}
