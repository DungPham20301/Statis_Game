using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bubble : MonoBehaviour
{
    [SerializeField] private Sprite[] sprites; // tao mang chua anh vo va anh chua vo
    [SerializeField] private Image image; // tao image luu anh can thay doi (neu muon thay nhieu anh thi tao mang hoac list de luu)
    [SerializeField] private Button btnClick;

    private void Start()
    {
        btnClick.onClick.AddListener(ChangeSprite);  // đăng ki sự kiện khi click (mỗi lần click nó sẽ gọi vào hàm này)
    }

    private void ChangeSprite()
    {
        image.sprite = sprites[1];
    }
}
