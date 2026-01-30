using UnityEngine;

// 드롭 트리거
public class DropTrigger : MonoBehaviour
{
    [SerializeField] private DropType dropType;

    private void OnTriggerEnter(Collider other)
    {
        if (!other.TryGetComponent<PlayerFSM>(out var fsm))
            return;

        fsm.EnterDropping(dropType);
    }

    private void OnTriggerExit(Collider other)
    {
        if (!other.TryGetComponent<PlayerFSM>(out var fsm))
            return;

        fsm.ExitDropping();
    }
}
