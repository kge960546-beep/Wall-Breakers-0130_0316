using UnityEngine;

// 채굴 중 상태
public class MiningState : IPlayerState
{
    public PlayerStateType StateType => PlayerStateType.Mining;

    private PlayerFSM fsm;

    public MiningState(PlayerFSM fsm)
    {
        this.fsm = fsm;
    }

    public void Enter()
    {
        Debug.Log("MiningState 시작");
        // 채굴 상태 진입 알림
        fsm.RaiseMiningStarted();
    }

    public void Update()
    {
        // 이 State의 Update 책임:
        // - "채굴 상태를 유지할 수 있는지" 조건만 판단
        // - 실제 채굴 처리, 수량 변화, 애니메이션은 관여하지 않음

        // 체크 대상 (판단만 수행):
        // 1. 채굴 대상이 여전히 유효한지
        //    - 트리거 이탈
        //    - 채굴 오브젝트 비활성화
        //
        // 2. 채굴을 계속할 수 있는 상태인지
        //    - 채굴 결과가 쌓이는 창고가 가득 찼는지
        //    - 강제 중단 상황이 발생했는지
        //
        // 3. 위 조건 중 하나라도 만족하면
        //    → "채굴 상태를 종료해야 함" 이라는 판단만 내림

        // 유의할점:
        // State 내부에서는 ChangeState를 직접 호출하지 않는다.
        // 종료 판단 결과는 FSM 외부 로직(Trigger, Controller 등)에서
        // FreeState 전환 요청으로 처리한다.

        // 예시(개념):
        // if (!fsm.HasValidMiningTarget || fsm.IsMiningStorageFull)
        // {
        //     // 종료 조건 만족 (실제 전환은 외부에서)
        // }
    }

    public void Exit()
    {
        Debug.Log("MiningState 종료");
        // 채굴 상태 종료 알림
        fsm.RaiseMiningEnded();
    }
}
