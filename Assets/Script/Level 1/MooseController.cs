using UnityEngine;

public class MooseController : MonoBehaviour
{
    [SerializeField] private float walkSpeed = 5f;
    [SerializeField] private Transform targetPosition;
    private Animator animator;
    private bool isWalking = false;

    private void Start()
    {
        animator = GetComponent<Animator>();
        isWalking = true;
    }

    private void Update()
    {
        if (isWalking)
        {
            Vector3 direction = (targetPosition.position - transform.position).normalized;
            transform.position += direction * walkSpeed * Time.deltaTime;

            if (transform.position.x >= targetPosition.position.x)
            {
                isWalking = false;
                animator.SetBool("IsWalking", false); // Update the animation parameter
            }
        }
    }

    public void StartWalking()
    {
        animator.SetBool("IsWalking", true); // Update the animation parameter
        targetPosition = GameObject.Find("TargetPosition").transform; // Replace "TargetPosition" with the actual name of the GameObject representing the target position
        isWalking = true;
    }
}
