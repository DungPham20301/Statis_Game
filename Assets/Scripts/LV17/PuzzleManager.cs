using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PuzzleManager : MonoBehaviour
{
    [SerializeField] private List<PuzzleSlot> _slotPrefabs;
    [SerializeField] private PuzzlePiece _piecePrefab;
    [SerializeField] private Transform _slotParent, _pieceParent;

    private void Start()
    {
        Spawn();
    }


    private void Spawn()
    {
        //var randomSet = _slotPrefabs.OrderBy(s => Random.value).Take(3). ToList();

        for(int i = 0; i< _slotPrefabs.Count/*randomSet.Count*/; i++)
        {
            var spawnedSlot = Instantiate(_slotPrefabs[i]/*randomSet[i]*/, _slotParent.GetChild(i).position,Quaternion.identity);

            var spawnedPiece = Instantiate(_piecePrefab, _pieceParent.GetChild(i).position, Quaternion.identity);
            spawnedPiece.Init(spawnedSlot);
        }
    }
}
