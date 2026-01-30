using UnityEngine;

// 픽업 트리거
// 가공품, 돈, 광물 등 픽업시 사용
public class PickupTrigger : MonoBehaviour
{
    [SerializeField] private PickupType pickupType;

    private void OnTriggerEnter(Collider other)
    {
        if (!other.TryGetComponent<PlayerFSM>(out var fsm))
            return;

        fsm.EnterPickingUp(pickupType);
    }

    private void OnTriggerExit(Collider other)
    {
        if (!other.TryGetComponent<PlayerFSM>(out var fsm))
            return;

        fsm.ExitPickingUp();
    }
}

