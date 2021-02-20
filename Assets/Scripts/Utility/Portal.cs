using UnityEngine;

public class Portal : MonoBehaviour
{
    [SerializeField] private Transform portalDestination;

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<IPlayableCharacter>() != null)
            other.transform.position = portalDestination.transform.position;
    }
}
