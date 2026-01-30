using UnityEngine;

// 내려놓는 중 상태
public class DroppingState : IPlayerState
{
    public PlayerStateType StateType => PlayerStateType.Dropping;

    private PlayerFSM fsm;

    public DroppingState(PlayerFSM fsm)
    {
        this.fsm = fsm;
    }

    public void Enter()
    {
        Debug.Log("DroppingState 시작");
        // 내려놓기 상태 진입
        // 실제 수량 감소 / 애니메이션 / 연출은 외부에서 처리
        fsm.RaiseDroppingStarted();
    }

    public void Update()
    {
        // 이 State의 Update 책임:
        // - 내려놓기 상태를 유지할 수 있는지 조건만 판단
        // - 실제 내려놓기 처리에는 관여하지 않음

        // 체크 항목:
        // 1. 지게에 내려놓을 수 있는 아이템이 남아있는지
        // 2. 대상(판매대 / 가공기계)이 여전히 유효한지
        // 3. 대상이 더 이상 받을 수 없는 상태인지

        // 종료 조건 예시:
        // if (fsm.IsBackpackEmpty || !fsm.HasValidDropTarget)
        // {
        //     fsm.ChangeState(PlayerStateType.Free);
        // }
    }

    public void Exit()
    {
        Debug.Log("DroppingState 종료");
        // 내려놓기 상태 종료
        fsm.RaiseDroppingEnded();
        fsm.ClearDropContext();
    }
}
