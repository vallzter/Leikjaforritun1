using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour {


    bool gameHasEnded = false;

    public void EndGame()//bý til end game 
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER");//poppar upp í console 
            Restart();//Kalla í restart void og gerir allt sem er í henni, í þessu tilviki restartar mappinu
        }
      
    }

    void Restart()
    {
        SceneManager.LoadScene("Main");//restarta mappinu ef ég lendi á rauðum platform
    }
	
}
