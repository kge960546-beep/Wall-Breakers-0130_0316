using UnityEngine;

public class DropTrigger : MonoBehaviour
{
    [SerializeField] private DropType dropType;

    private void OnTriggerEnter(Collider other)
    {
        if (!other.TryGetComponent<PlayerFSM>(out var fsm))
            return;

        fsm.EnterDropping(dropType);
    }
}
