using UnityEngine;
using UnityEngine.EventSystems;

public class VirtualJoystick : MonoBehaviour
{
    [Header("UI")]
    [SerializeField] private RectTransform joystickRoot;
    [SerializeField] private RectTransform background;
    [SerializeField] private RectTransform handle;

    [Header("Settings")]
    [SerializeField] private float maxRadius = 100f;

    [Header("Reference")]
    [SerializeField] private PlayerMove playerMove;

    private Vector2 startPos;
    private bool isDragging;

    private void Start()
    {
        joystickRoot.gameObject.SetActive(false);
    }

    private void Update()
    {
        HandleInput();
    }

    private void HandleInput()
    {
        // 클릭 시작
        if (Input.GetMouseButtonDown(0))
        {
            isDragging = true;
            startPos = Input.mousePosition;

            joystickRoot.position = startPos;
            handle.anchoredPosition = Vector2.zero;

            joystickRoot.gameObject.SetActive(true);
        }

        // 드래그 중
        if (Input.GetMouseButton(0) && isDragging)
        {
            Vector2 currentPos = Input.mousePosition;
            Vector2 delta = currentPos - startPos;

            Vector2 clamped = Vector2.ClampMagnitude(delta, maxRadius);
            handle.anchoredPosition = clamped;

            Vector2 normalized = clamped / maxRadius;
            Vector3 moveDir = new Vector3(normalized.x, 0f, normalized.y);

            playerMove.SetMoveDirection(moveDir);
        }

        // 클릭 종료
        if (Input.GetMouseButtonUp(0))
        {
            isDragging = false;
            joystickRoot.gameObject.SetActive(false);
            playerMove.SetMoveDirection(Vector3.zero);
        }
    }
}
