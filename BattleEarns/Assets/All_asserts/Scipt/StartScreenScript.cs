using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

public class StartScreenScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ToggleScreen(GameObject ConnectedState, GameObject DisconnectedState)
    {
        
        ConnectedState.SetActive(true);
        DisconnectedState.SetActive(false);

    }
}
