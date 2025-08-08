using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

[System.Serializable]
public class SpriteMatchDisplayPair
{
    public Sprite cardIcon;
    public Sprite matchDisplay;
    public string matchText;
}


public class CardsController : MonoBehaviour
{
    [SerializeField] Card cardPrefab;
    [SerializeField] Transform gridTransform;
    //[SerializeField] GameObject gridLayoutObject;
    [SerializeField] Sprite[] sprites;
    //public MatchDisplay matchDsp;
    public DisplayController displayController;
    public GameObject displayPrefab;
    private List<Sprite> spritePairs;
    public List<SpriteMatchDisplayPair> spriteDisplayPairs;
    public EndGame endGame;
    public ScoreSystem score;
    public AudioSource audioSource;

    Card firstSelected;
    Card secondSelected;


    private void Start()
    {
        PrepareSprites();
        CreateCards();
    }
    private void PrepareSprites()
    {
        spritePairs = new List<Sprite>();
        for(int i = 0; i < sprites.Length; i++)
        {
            // adding sprite 2 times to make it a pair
            spritePairs.Add(sprites[i]);
            spritePairs.Add(sprites[i]);
            
        }

        ShuffleSprites(spritePairs);
    }

    void CreateCards()
    {
        for(int i = 0; i < spritePairs.Count; i++)
        {
            Card card = Instantiate(cardPrefab, gridTransform, false);
            //LayoutRebuilder.ForceRebuildLayoutImmediate(gridLayoutObject.GetComponent<RectTransform>());
            card.SetIconSprite(spritePairs[i]);
            endGame.matchesLeft++;
            card.controller = this;
        }
    }

    private Sprite GetDisplaySpriteForIcon(Sprite icon)
    {
        foreach (var pair in spriteDisplayPairs)
        {
            
            if (pair.cardIcon == icon)
            {
                
                return pair.matchDisplay;
            }
        }

        return null;
    }

    private string GetDisplayTextForIcon(Sprite icon)
    {
        foreach (var pair in spriteDisplayPairs)
        {
            if (pair.cardIcon == icon)
            {
                return pair.matchText;
            }
        }

        return null;
    }
    public void SetSelected(Card card)
    {
        if(card.isSelected == false)
        {
            card.Show();
            audioSource.Play();

            if (firstSelected == null) 
            {
                firstSelected = card;
                return;
            }

            if (secondSelected == null)
            {
                secondSelected = card;
                StartCoroutine(CheckMatching(firstSelected, secondSelected));
                firstSelected = null;
                secondSelected = null;
            }
        }
    }

    IEnumerator CheckMatching(Card a, Card b)
    {
        yield return new WaitForSeconds(.3f);
        if (a.iconSprite == b.iconSprite)
        {
            TagAllCardsWithSprite(a.iconSprite);
            Sprite displaySprite = GetDisplaySpriteForIcon(a.iconSprite);
            string displayText = GetDisplayTextForIcon(a.iconSprite);
            score.matchCounter++;
            score.ScoreMultiplier();
            



            if (displaySprite != null)
            {
                displayController.CreateDisplay(displaySprite, displayText);
                
            }          
            //displayController.displayActive = true;
        }
        else
        {
            a.Hide();
            b.Hide();
            audioSource.Play();
            score.matchCounter = 0f;
            score.scoreMult = 1f;
        }
    }

    void ShuffleSprites(List<Sprite> spriteList)
    {
        for (int i = spriteList.Count - 1; i > 0; i--)
        {
            int randomIndex = Random.Range(0, i + 1);

            
            Sprite temp = spriteList[i];
            spriteList[i] = spriteList[randomIndex];
            spriteList[randomIndex] = temp;
        }
    }

    public GameObject TagAllCardsWithSprite(Sprite matchedSprite)
    {
        Card[] allCards = FindObjectsOfType<Card>();

        foreach (Card card in allCards)
        {
            if (card.iconSprite == matchedSprite)
            {
                card.gameObject.tag = "Matched";
            }
        }

        return null;
    }

    public void ShowAllCards()
    {
        Card[] allCards = FindObjectsOfType<Card>();

        foreach (Card card in allCards)
        {
            if (card.gameObject.tag != "Matched")
            {
                card.Show();
            }
        }
    }

    public void HideAllCards()
    {
        Card[] allCards = FindObjectsOfType<Card>();

        foreach (Card card in allCards)
        {
            if (card.gameObject.tag != "Matched")
            {
                card.Hide();
            }
        }
    }

}
