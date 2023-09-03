using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Thirdweb;
public class SDK_Manger : MonoBehaviour
{
    // Start is called before the first frame update
    public static SDK_Manger Instance;
    public ThirdwebSDK SDK;
    private void Awake()
    {
        if (Instance != null)
            Destroy(gameObject);
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
    void Start()
    {
        SDK = new ThirdwebSDK("mumbai");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
