using UnityEngine;

// 완전 제어 불가 상태
// 퀘스트 연출, 컷씬, 해금 연출 등 플레이어 조작을 막아야 할 때 사용
public class LockedState : IPlayerState
{
    public PlayerStateType StateType => PlayerStateType.Locked;

    private PlayerFSM fsm;

    public LockedState(PlayerFSM fsm)
    {
        this.fsm = fsm;
    }

    public void Enter()
    {
        Debug.Log("LockedState 시작");
        // 입력 차단
        // 연출 시작 (추후)
    }

    public void Update()
    {
        // 의도적으로 아무 것도 하지 않음
        // 외부 시스템에서 상태 해제 시까지 유지
    }

    public void Exit()
    {
        Debug.Log("LockedState 종료");
        // 입력 복구
        // 연출 종료 (추후)
    }
}
