using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Proyecto26;
using UnityEngine.UI;


public class DataBase : MonoBehaviour
{
    public string database_url = "";
    [SerializeField]InputField name;
    [SerializeField] InputField number;
    [SerializeField] InputField address;
     User user = new User();
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void savedata_toFirebase()
    {
        user.Name = name.text;
        user.Address = address.text;
        user.Number = number.text;
        
        RestClient.Post(database_url + "/" + name.text + ".json", user);
    }
    /*public void read_data()
    {
        RestClient.Get<User>(database_url + "/" + name.text + ".json").Then(response =>
        {
            user= response;

            print(user.Email);
        });
    }*/
  

    // Update is called once per frame
    void Update()
    {
        
    }
}
