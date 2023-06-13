using UnityEngine;

public class MooseController : MonoBehaviour
{
    [SerializeField] private float walkSpeed = 5f;
    [SerializeField] private Transform targetPosition;
    [SerializeField] private Transform startPosition;
    private Animator animator;
    private bool isWalking = false;

    private void Start()
    {
        animator = GetComponent<Animator>();
        isWalking = true;

        transform.position = startPosition.position;
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
                animator.SetBool("IsWalking", false);
                transform.position = startPosition.position; // Reset position to the start position
                isWalking = true; // Start walking again
            }
        }
    }

    public void StartWalking()
    {
        animator.SetBool("IsWalking", true);
        targetPosition = GameObject.Find("TargetPosition").transform;
        isWalking = true;
    }
}
