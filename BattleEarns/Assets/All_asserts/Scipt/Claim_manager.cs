using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Thirdweb;
using System.Threading.Tasks;

public class Claim_manager : MonoBehaviour
{

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public async Task ClaimNFT()
    {
        Contract contract = SDK_Manger.Instance.SDK.GetContract("0xa69Be7646D1AF269593d71f2C91F20C463bb21dB");

        await contract.ERC721.Claim(1);

    }

    public async void Claim()
    {
        await ClaimNFT();

    }


    public void openRL()
    {

        Application.OpenURL("https://opensea.io/");
    }
}
