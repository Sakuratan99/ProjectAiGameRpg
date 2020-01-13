using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TreasureChest : Interactable 
{
    public Item contents;
    public bool isOpen;
    public Invetory playerInventory;  
    public Signal raiseItem;
    public GameObject dialogBox;
    public Text dialogText;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && playerInRange)
        {
            if (!isOpen)
            {
                //openChest
                OpenChest();
            }
            else
            {
                //chest already open
                ChaseAlreadyOpen();
            }
        }
    }
    public void OpenChest()
    {
        //Dialog Window on
        dialogBox.SetActive(true);
        //dilog text  = contents text
        dialogText.text = contents.itemDescription;
        //add content to the inventory
        playerInventory.AddItem(contents);
        playerInventory.currentItem = contents;
        //raise the signal  to the player to animate
        raiseItem.Raise();
        //raise  the content clue
        context.Raise();
        isOpen = true;
        anim.SetBool("opened", true);
    }

    public void ChaseAlreadyOpen()
    {
       
         //Dialog off
         dialogBox.SetActive(false);
         
         //raise the signal to the player to stop animatian
         raiseItem.Raise();
           
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !other.isTrigger && !isOpen)
        {
            context.Raise();
            playerInRange = true;
        }

    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !other.isTrigger && !isOpen)
        {
            context.Raise();
            playerInRange = false;

        }
    }
}
