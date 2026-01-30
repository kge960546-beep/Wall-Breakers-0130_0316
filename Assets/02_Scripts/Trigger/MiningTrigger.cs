using UnityEngine;

// Ã¤±¼ Æ®¸®°Å
public class MiningTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (!other.TryGetComponent<PlayerFSM>(out var fsm))
            return;

        fsm.EnterMining();
    }
}
