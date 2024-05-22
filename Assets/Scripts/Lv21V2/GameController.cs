using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public List<Button> btns = new List<Button>();

    [SerializeField] private Sprite backgroundImage;

    public Sprite[] puzzles;

    public List<Sprite> gamePuzzles = new List<Sprite>();

    private bool firstGuess, secondGuess;

    private int countGuesses;
    private int countCorrectGuesses;
    private int gameGuesses;

    private int firstGuessIndex, secondGuessIndex;

    private string firstGuessPuzzle, secondGuessPuzzle;

    private void Start()
    {
        GetButtons();
        AddListeners();
        AddGamePuzzles();
        gameGuesses = gamePuzzles.Count/2;
        Shuffle(gamePuzzles);
    }

    void GetButtons()
    {
        GameObject[] objects = GameObject.FindGameObjectsWithTag("PuzzleButton");

        for(int i = 0; i < objects.Length; i++)
        {
            btns.Add(objects[i].GetComponent<Button>());
            btns[i].image.sprite = backgroundImage;
        }
    }

    void AddGamePuzzles()
    {
        int looper = btns.Count;
        int index = 0;

        for(int i = 0;i < looper;i++)
        {
            if(index == looper/2)
            {
                index = 0;
            }

            gamePuzzles.Add(puzzles[index]);

            index++;
        }
    }

    void AddListeners()
    {
        foreach (Button btn in btns)
        {
            btn.onClick.AddListener(() => PickAPuzzle());
        }
    }

    public void PickAPuzzle()
    {
        string name = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name;

        if (!firstGuess)
        {
            firstGuess = true;

            firstGuessIndex = int.Parse(name);

            firstGuessPuzzle = gamePuzzles[firstGuessIndex].name;

            btns[firstGuessIndex].image.sprite = gamePuzzles[firstGuessIndex];
        }
        else if(!secondGuess)
        {
            secondGuess = true;

            secondGuessIndex = int.Parse(name);

            secondGuessPuzzle = gamePuzzles[secondGuessIndex].name;

            btns[secondGuessIndex].image.sprite = gamePuzzles[secondGuessIndex];

            //countGuesses++;

            //if(firstGuessPuzzle == secondGuessPuzzle)
            //{
            //    Debug.Log("Matched");
            //}
            //else
            //{
            //    Debug.Log("Dont Match");
            //}

            StartCoroutine(CheckIfThePuzzlesMatch());
        }

        IEnumerator CheckIfThePuzzlesMatch()
        {
            yield return new WaitForSeconds(1f);

            if(firstGuessPuzzle == secondGuessPuzzle)
            {
                yield return new WaitForSeconds(.5f);

                btns[firstGuessIndex].interactable = false;
                btns[secondGuessIndex].interactable = false;

                btns[firstGuessIndex].image.color = new Color(0, 0, 0, 0);
                btns[secondGuessIndex].image.color = new Color(0, 0, 0, 0);

                CheckIfTheGameIsFinished();
            }
            else
            {
                btns[firstGuessIndex].image.sprite = backgroundImage;
                btns[secondGuessIndex].image.sprite = backgroundImage;
            }
            yield return new WaitForSeconds(.5f);

            firstGuess = secondGuess = false;

        }
    }

    void CheckIfTheGameIsFinished()
    {
        countCorrectGuesses++;

        if(countCorrectGuesses == gameGuesses)
        {
            Debug.Log("Game Finished");
        }
    }

    void Shuffle(List<Sprite> list)
    {
        for(int i =0; i< list.Count; i++)
        {
           Sprite temp = list[i];
            int randomIndex = Random.Range(0, list.Count);
            list[i] = list[randomIndex];
            list[randomIndex] = temp;
        }
    }
}
