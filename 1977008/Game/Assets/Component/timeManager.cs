using UnityEngine;

public class timeManager : MonoBehaviour
{
    public float slowdownFactor = 0.05f;
    public float slowdownLenght = 2f;
 
    void Update()
    {
        Time.timeScale += (1f / slowdownLenght) * Time.unscaledDeltaTime;
        Time.timeScale = Mathf.Clamp(Time.timeScale, 0f, 1f);
        if(Input.GetButtonDown("Jump"))
        {
            DoSlowmotion();
        }
    }    

    public void DoSlowmotion ()
    {
        Time.timeScale = slowdownFactor;
        Time.fixedDeltaTime = Time.timeScale * 0.02f;
    }
}
