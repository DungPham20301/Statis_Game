using System.Collections;
using System.Collections.Generic;
using System.Resources;
using UnityEngine;
using UnityEngine.UI;

public class UiBubble : MonoBehaviour
{
    //[SerializeField] private Sprite[] sprites; // tao mang chua anh vo va anh chua vo
    //[SerializeField] private Image image; // tao image luu anh can thay doi (neu muon thay nhieu anh thi tao mang hoac list de luu)
    //[SerializeField] private List<Image> images;
    [SerializeField] public GameObject GameObject;

    //private void Start()
    //{

    //}

    //private void Update()
    //{
    //    for (int i = 0; i < images.Count; i++)
    //    {
    //        if (Input.GetMouseButtonDown(0))
    //            ChangeSprite(i, 1);
    //    }
    //    if (Input.GetMouseButtonDown(0))
    //        ChangeSprite();
    //}

    //goi code thi no se thay sprite thu 2 trong mang vao
    //public void ChangeSprite(int indexImage, int idSprite)
    //{
    //    images[indexImage].sprite = sprites[idSprite];
    //    vi du anh thu 2 la anh vo thi index la 1
    //    image.SetNativeSize(); // neu anh goi cai nay thi no se theo size cai sprite anh thay
    //    neu khong goi thi no se theo ti le mac dinh cua nos
    //    day neu khong goi no se theo size anh cai
    //    the la a bi nguoc dung ko
    //     khong goi thi theo gia tri cai, goi thif no tra ve gia tri mac dinh cua no(neu goi thi no se thay theo cai ti le sprite dang o trong image ay) khong goi thi no khong thay ti le, nen anh no khac ti le thi se bi meo
    //}

}
