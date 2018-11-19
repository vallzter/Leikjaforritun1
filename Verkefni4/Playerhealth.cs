using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

namespace CompleteProject
{
    public class PlayerHealth : MonoBehaviour
    {
        public int startingHealth = 150;                            //Það sem maður byrjar með í líf, breytti því í 150, mér fannst original of lítið
        public int currentHealth;                                   // sýnir current líf
        public Slider healthSlider;                                 // Reference i health sliderinn.
        public Image damageImage;                                   // kallar í rautt flash sem kemur þegar playerinn slasast
        public AudioClip deathClip;                                 // audio klippa sem fylgdi
        public float flashSpeed = 5f;                               
        public Color flashColour = new Color(1f, 0f, 0f, 0.1f);     //liturinn sem kemur ef maður meiðist


        Animator anim;                                              
        AudioSource playerAudio;                                    // Reference í audiosourceið
        PlayerMovement playerMovement;                              // Reference í player movement scriptið
        PlayerShooting playerShooting;                              // Reference to the PlayerShooting scriptið.
        bool isDead;                                                //spyr hvort player er dáinn
        bool damaged;                                               // True þegar player slasast.


        void Awake ()
        {
            // uppsetning á referensunum
            anim = GetComponent <Animator> ();
            playerAudio = GetComponent <AudioSource> ();
            playerMovement = GetComponent <PlayerMovement> ();
            playerShooting = GetComponentInChildren <PlayerShooting> ();

            // bý til starting healt sem er í þessu tilviki 150
            currentHealth = startingHealth;
        }


        void Update ()
        {
            
            if(damaged)
            {
                 
                damageImage.color = flashColour;
            }
            
            else
            {
                
                damageImage.color = Color.Lerp (damageImage.color, Color.clear, flashSpeed * Time.deltaTime);
            }

            
            damaged = false;
        }

        //voidið fyrir að taka damage
        public void TakeDamage (int amount)
        {
            
            damaged = true;

            
            currentHealth -= amount;

            
            healthSlider.value = currentHealth;

            
            playerAudio.Play ();

           
            if(currentHealth <= 0 && !isDead)//ef current health er 0 þá kallast í skipunina "Death"
            {
               
                Death ();
            }
        }


        void Death ()
        {
            
            isDead = true;

            //slekkur á möguleikanum að skjóta ef "Death" gerist
            playerShooting.DisableEffects ();

            //kallar í animatorinn 
            anim.SetTrigger ("Die");

            
            playerAudio.clip = deathClip;
            playerAudio.Play ();

            // slekkur á shooting og movement
            playerMovement.enabled = false;
            playerShooting.enabled = false;
        }


        public void RestartLevel ()
        {
            //einfalt void sem kallar í scene manager til að restarta levelinu
            SceneManager.LoadScene (0);
        }
    }
}
