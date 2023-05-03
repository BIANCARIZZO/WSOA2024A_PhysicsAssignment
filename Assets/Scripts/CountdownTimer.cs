using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class CountdownTimer : MonoBehaviour
{
    public int countdownTime;
    public TextMeshProUGUI countdownDisplay;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CountdownToStart());

        IEnumerator CountdownToStart()
        {
            while (countdownTime > 0)
            {
                countdownDisplay.text = countdownTime.ToString();

                yield return new WaitForSeconds(1f);

                countdownTime--;
            }

            countdownDisplay.text = "GO";

            yield return new WaitForSeconds(1f);

            countdownDisplay.gameObject.SetActive(false);

            SceneManager.LoadScene("SampleScene");
        }
    }

   

    

    // Update is called once per frame
    void Update()
    {
       
    }
}
