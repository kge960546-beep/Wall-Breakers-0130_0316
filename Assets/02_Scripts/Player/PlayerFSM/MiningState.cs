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
        // 채굴 시작
        // 채굴 애니메이션 시작 (추후)
    }

    public void Update()
    {
        // 매 프레임 채굴 가능 여부 체크

        // 집어넣을 것 :
        // 1. 채굴 대상이 유효한지
        // 2. 창고 수용량이 가득 찼는지
        // 3. 채굴이 중단되어야 하는 상황인지

        // 예시 흐름:
        // if (storage.IsFull)
        // {
        //     fsm.ChangeState(PlayerStateType.Free);
        // }
    }

    public void Exit()
    {
        Debug.Log("MiningState 종료");
        // 채굴 종료
        // 채굴 애니메이션 종료 (추후)
    }
}
