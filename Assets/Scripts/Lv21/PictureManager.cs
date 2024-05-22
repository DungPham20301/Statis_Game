using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering;

public class PictureManager : MonoBehaviour
{
    public Picture PicturePrefabs;

    private List<Material> _materialList = new List<Material>();
    private List<string> _texturePathList = new List<string>();
    private Material _firstMaterial;
    private string _firstTexturePath;



    private void Start()
    {
        LoadMaterials();
    }

    private void LoadMaterials()
    {
        var materialFilePath = GameSettings.instance.GetMaterialDirectoryName();
        var textureFilePath = GameSettings.instance.GetPuzzleCategoryTextureDirectoryName();
        var pairNumber = (int)GameSettings.instance.GetPairNumber();

        const string matBaseName = "Pic";
        var firstMaterialName = "Back";

        for(var index = 1; index <= pairNumber; index++)
        {
            var currentFilePath = materialFilePath + matBaseName + index;
            Material mat = Resources.Load(currentFilePath, typeof(Material)) as Material;
            _materialList.Add(mat);

            var currentTextureFilePath = textureFilePath + matBaseName + index;
            _texturePathList.Add(currentFilePath);

        }

        _firstTexturePath = textureFilePath + firstMaterialName;
        _firstMaterial = Resources.Load(materialFilePath + firstMaterialName, typeof(Material)) as Material;
    }
}
