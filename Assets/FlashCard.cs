using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using static FlashCard;


public class FlashCard : MonoBehaviour
{
    [System.Serializable]
    public class Card
    {
        public string fr�ga;
        public string svar;

        public Card(string nyFr�ga, string nySvar)
        {
            fr�ga = nyFr�ga;
            svar = nySvar;
        }
    }


    public List<Card> flashcards = new List<Card>();
    public TextMeshProUGUI fr�gaText;
    public TextMeshProUGUI svarText;

    private int currentCardIndex = 0;
    private bool isAnswerVisible = false;

    void Start()
    {
        flashcards.Add(new Card("Vilka f�rger inneh�ller flaggan Sudan ?", "R�d, svart, vit, gr�n"));

    }
    void Update()
    {
        fr�gaText.text = flashcards[currentCardIndex].fr�ga;
        svarText.text = flashcards[currentCardIndex].svar;


       
    }

    public void VisaSvaret()
    {
        print("hej");
        fr�gaText.gameObject.SetActive(!fr�gaText.gameObject.activeSelf);//St�nger av fr�getexten.
        svarText.gameObject.SetActive(!svarText.gameObject.activeSelf); //s�tta ing�ng svarstexten.
    }
    public void LoadScene(int index)
    {
        SceneManager.LoadScene(index);

    }

    public void Nextcard()
    {
        currentCardIndex += 1;
        
            if (currentCardIndex >= flashcards.Count)
            {
            currentCardIndex = flashcards.Count - 1;//flashcards.count - 1 = sista kortet
            }
        
      
    }
    public void PreviousCard()
    {
        currentCardIndex -= 1;
        if (currentCardIndex < 0)
        {
            currentCardIndex = 0;
        }
    }
        
      
}



