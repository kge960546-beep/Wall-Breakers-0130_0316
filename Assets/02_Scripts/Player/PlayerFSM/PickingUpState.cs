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
        // 적재 시작
        // 지게에 자원이 쌓이는 애니메이션 재생 (추후)
    }

    public void Update()
    {
        // 매 프레임 적재 가능 여부 체크

        // 해야할 것 :
        // 1. 적재 대상 창고가 유효한지
        // 2. 창고에 남은 자원이 있는지
        // 3. 플레이어 지게가 가득 찼는지

        // 종료 조건 예시 :
        // if (isBackpackFull || isStorageEmpty)
        // {
        //     fsm.ChangeState(PlayerStateType.Free);
        // }
        // 지게와 창고 1대1 대응도 괜찮을 것 같음
        // 업그레이드를 통해서 지게와 창고의 허용량/수용치를 동시에 올리는 느낌
    }

    public void Exit()
    {
        Debug.Log("PickingUpState 종료");
        // 적재 종료
        // 적재 애니메이션 종료 (추후)
    }
}
