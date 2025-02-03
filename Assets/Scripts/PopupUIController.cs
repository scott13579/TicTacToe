using UnityEngine;
using UnityEngine.UI;

public class PopupUIController : MonoBehaviour
{
    public delegate void ConfirmAction();
    public static event ConfirmAction OnConfirmAction;

    
    [Header("UI References")]
    [SerializeField] private GameObject popupPanel; // 팝업 패널
    [SerializeField] private Button confirmButton;  // 확인 버튼
    [SerializeField] private Button closeButton;    // X 버튼
    
    private void Start()
    {
        // 버튼 클릭 이벤트 연결
        confirmButton.onClick.AddListener(OnConfirm);
        closeButton.onClick.AddListener(OnClose);

        // 초기 상태: 팝업 비활성화
        HidePopup();
    }

    // 팝업 표시
    public void ShowPopup()
    {
        popupPanel.SetActive(true);
    }

    // 팝업 숨기기
    public void HidePopup()
    {
        popupPanel.SetActive(false);
    }

    // X 버튼 클릭 시 호출
    private void OnClose()
    {
        Debug.Log("팝업 닫기");
        HidePopup();
    }
    private void OnConfirm()
    {
        OnConfirmAction?.Invoke(); // 외부에서 구독 가능한 이벤트
        HidePopup();
    }
}