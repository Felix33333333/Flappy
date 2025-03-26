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
        public string fråga;
        public string svar;

        public Card(string nyFråga, string nySvar)
        {
            fråga = nyFråga;
            svar = nySvar;
        }
    }


    public List<Card> flashcards = new List<Card>();
    public TextMeshProUGUI frågaText;
    public TextMeshProUGUI svarText;

    private int currentCardIndex = 0;
    private bool isAnswerVisible = false;

    void Start()
    {
        flashcards.Add(new Card("Vilka färger innehåller flaggan Sudan ?", "Röd, svart, vit, grön"));

    }
    void Update()
    {
        frågaText.text = flashcards[currentCardIndex].fråga;
        svarText.text = flashcards[currentCardIndex].svar;


       
    }

    public void VisaSvaret()
    {
        print("hej");
        frågaText.gameObject.SetActive(!frågaText.gameObject.activeSelf);//Stänger av frågetexten.
        svarText.gameObject.SetActive(!svarText.gameObject.activeSelf); //sätta ingång svarstexten.
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



