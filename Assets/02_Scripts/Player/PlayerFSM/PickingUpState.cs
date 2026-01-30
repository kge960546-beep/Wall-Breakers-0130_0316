using UnityEngine;

// 싣는 중 상태
public class PickingUpState : IPlayerState
{
    public PlayerStateType StateType => PlayerStateType.PickingUp;

    private PlayerFSM fsm;

    public PickingUpState(PlayerFSM fsm)
    {
        this.fsm = fsm;
    }

    public void Enter()
    {
        Debug.Log("PickingUpState 시작");
        // 적재 상태 진입
        // 실제 수량 증가 / 애니메이션 / 연출은 외부에서 처리
        fsm.RaisePickingUpStarted();
    }

    public void Update()
    {
        // 이 State의 Update 책임:
        // - 적재 상태를 유지할 수 있는지 조건만 판단
        // - 실제 적재 처리에는 관여하지 않음

        // 체크 항목:
        // 1. 픽업 대상이 여전히 유효한지
        // 2. 지게가 가득 찼는지
        // 3. 픽업 대상(창고/보상 등)에 더 이상 가져올 것이 남아있는지

        // pickup 타입에 따른 종료 조건 판단은
        // 외부 시스템이 수량을 갱신한 결과를 기준으로 함

        // 종료 조건 예시:
        // if (fsm.IsBackpackFull || !fsm.HasRemainingPickupResource)
        // {
        //     fsm.ChangeState(PlayerStateType.Free);
        // }
    }

    public void Exit()
    {
        Debug.Log("PickingUpState 종료");
        // 적재 상태 종료
        fsm.RaisePickingUpEnded();
        fsm.ClearPickupContext();
    }
}
