using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
public class get_boomerang : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject boomerang_hand;
    public GameObject boomerang_hand_out;
    public AudioSource sound;
    public TextMeshPro princess_text;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< HEAD
        
=======
        if (princess_text.text == "THANK YOU!!")
        {
            boomerang_hand.SetActive(false);
        }
>>>>>>> 82f1d521a44515bc68bb857cf2274c6b961d62a6
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Enter " + collision.gameObject.name);
        sound.Play();
        if (collision.gameObject.name == "Root")
        {
            boomerang_hand.SetActive(true);
            boomerang_hand_out.SetActive(false);
            princess_text.text = "YA!!";
        }


    }
    

}