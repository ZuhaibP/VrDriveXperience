using UnityEngine;

public class MooseController : MonoBehaviour
{
    [SerializeField] private float walkSpeed = 5f;
    [SerializeField] private Transform targetPosition;
    [SerializeField] private Transform startPosition;
    [SerializeField] private Transform mooseActivator; // New position for activating the moose
    private Animator animator;
    private bool isWalking = false;
    private bool isActive = false;

    private void Start()
    {
        animator = GetComponent<Animator>();
        isWalking = true;
        transform.position = startPosition.position;
    }

    private void Update()
    {
        if (isActive && isWalking)
        {
            Vector3 direction = (targetPosition.position - transform.position).normalized;
            transform.position += direction * walkSpeed * Time.deltaTime;

            if (transform.position.x >= targetPosition.position.x)
            {
                isWalking = false;
                animator.SetBool("IsWalking", false);
                Destroy(gameObject);
            }
        }
    }

    public void StartWalking()
    {
        animator.SetBool("IsWalking", true);
        targetPosition = GameObject.Find("TargetPosition").transform;
        isWalking = true;
    }

    public void ActivateMoose()
    {
        isActive = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Car") && mooseActivator != null)
        {
            if (other.gameObject.transform.position == mooseActivator.position)
            {
                StartWalking();
            }
        }
    }
}
