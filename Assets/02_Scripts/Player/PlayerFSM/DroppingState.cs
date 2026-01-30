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
        // 내려놓기 시작
        // 지게에서 아이템이 빠지는 애니메이션 재생 (추후)
    }

    public void Update()
    {
        // 매 프레임 내려놓기 가능 여부 체크

        // 해야할 것: 
        // 1. 플레이어 지게에 내려놓을 아이템이 있는지
        // 2. 대상(판매대 / 가공기계)이 유효한지
        // 3. 대상이 더 이상 받을 수 없는 상태인지

        // 종료 조건 예시:
        // if (isBackpackEmpty || isTargetFull)
        // {
        //     fsm.ChangeState(PlayerStateType.Free);
        // }
    }

    public void Exit()
    {
        Debug.Log("DroppingState 종료");
        // 내려놓기 종료
        // 내려놓기 애니메이션 종료 (추후)
    }
}
