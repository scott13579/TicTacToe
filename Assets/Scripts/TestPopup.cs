using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPopup : MonoBehaviour
{
    [SerializeField] private PopupUIController popupController;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            popupController.ShowPopup(); // 스페이스바로 팝업 표시
        }
    }
}
