using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Thirdweb;
using System.Threading.Tasks;
using UnityEngine.SceneManagement;

public class Buy_Script : MonoBehaviour
{
    public Behaviour Canva;
    int ind = 0;
    void Start()
    {
        Canva.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
            SceneManager.LoadScene("Fire");
      
        display();
    }
    void display()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Canva.enabled= !Canva.enabled;
            if (ind % 2 == 0)
            {
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }
            else
            {
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
            }
            ind++;
        }
    }
    public async Task transfer()
    {
        var data = SDK_Manger.Instance.SDK.wallet.Transfer("0xE685972800D350F5087ca385C6877ED7e778A7bA", "0.3");
    }
    public async void Trans()
   {
       await transfer();
   }

}
