using UnityEngine;

// 플레이어 FSM 본체
public class PlayerFSM : MonoBehaviour
{
    public PlayerStateType CurrentStateType => currentState.StateType;

    private IPlayerState currentState;

    // 상태 인스턴스들
    private FreeState freeState;
    private MiningState miningState;
    private PickingUpState pickingUpState;
    private DroppingState droppingState;
    private LockedState lockedState;

    private void Awake()
    {
        // 상태 인스턴스 생성 (FSM 참조 넘김)
        // GC 부담 없앰
        freeState = new FreeState(this);
        miningState = new MiningState(this);
        pickingUpState = new PickingUpState(this);
        droppingState = new DroppingState(this);
        lockedState = new LockedState(this);
    }

    private void Start()
    {
        ChangeState(PlayerStateType.Free);
    }

    private void Update()
    {
        currentState?.Update();
    }

    // 상태 변경
    public void ChangeState(PlayerStateType newState)
    {
        currentState?.Exit();

        currentState = newState switch
        {
            PlayerStateType.Free => freeState,
            PlayerStateType.Mining => miningState,
            PlayerStateType.PickingUp => pickingUpState,
            PlayerStateType.Dropping => droppingState,
            PlayerStateType.Locked => lockedState,
            _ => freeState
        };

        currentState.Enter();
    }
}
