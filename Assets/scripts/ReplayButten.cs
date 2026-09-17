using UnityEngine;
using UnityEngine.SceneManagement;

public class ReplayButten : MonoBehaviour
{
    public void Onclick()
    {
        SceneManager.LoadScene("Game");
    }    
}
