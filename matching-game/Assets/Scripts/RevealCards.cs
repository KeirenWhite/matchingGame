using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class RevealCards : MonoBehaviour
{
    public CardsController card;
    public Button revealButton;

    private void Start()
    {
        Reveal();
    }
    IEnumerator WaitSeconds(float seconds)
    {
        yield return new WaitForSeconds(seconds);

        card.HideAllCards();
        revealButton.gameObject.SetActive(false);
    }
    public void Reveal()
    {
        revealButton.onClick.AddListener(() =>
        { 
            card.ShowAllCards();
            StartCoroutine(WaitSeconds(2f));         
        });
    }
}
