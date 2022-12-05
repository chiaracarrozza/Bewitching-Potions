using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ingredients : MonoBehaviour
{
    private int slime = 0;
    [SerializeField] private Text slimetext;

    private int bottle = 0;
    [SerializeField] private Text bottletext;

    private int egg = 0;
    [SerializeField] private Text eggtext;

    private int ruby = 0;
    [SerializeField] private Text rubytext;

    private int score;

    [SerializeField] private AudioSource collectsfx;

    [SerializeField] Text Cleared;
    [SerializeField] private AudioSource clearsfx;
    [SerializeField] MenuManager menu;

    private void OnTriggerEnter2D(Collider2D collision)

    {
        if (collision.gameObject.tag == "Slime")
        {
            collectsfx.Play();
            Destroy(collision.gameObject); //making the ingredient disappear when it collides with the player
            slime++; //adding 1 unity of that particular ingredient
            slimetext.text = "Monster component: " + slime; //making the text that represents the list of ingredients upgrade
            score++;
        }

        if (collision.gameObject.tag == "Bottle") //same case of what decribed above but with a different ingredient
        {
            collectsfx.Play();
            Destroy(collision.gameObject);
            bottle++;
            bottletext.text = "Empty Bottle: " + bottle;
            score++;
        }
        if (collision.gameObject.tag == "Egg")//same case of what decribed above but with a different ingredient
        {
            collectsfx.Play();
            Destroy(collision.gameObject);
            egg++;
            eggtext.text = "Someething round and shiny: " + egg;
            score++;
        }
        if (collision.gameObject.tag == "Ruby") //same case of what decribed above but with a different ingredient
        {
            collectsfx.Play(); //to make the collect ingredient sound effect play
            Destroy(collision.gameObject);
            ruby++;
            rubytext.text = "A Jewel: " + ruby;
            score++;
        }
        if (score == 4) //if the player manges to get all the intgredients(maximum score) a cleared level menu will appear
        {
            clearsfx.Play(); //to make the level clear sound effect play once the menu appears
            Cleared.text = "Level Cleared!";
            menu.gameObject.SetActive(true);
        }
    }
        
}
