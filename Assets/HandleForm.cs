using System.Collections.Generic;
using CandyCoded.Forms;
using Newtonsoft.Json;
using UnityEngine;

public enum Type
{

    Admin = 0,

    User = 1

}

public class Profile
{

    public string firstName;

    public string lastName;

    public string age;

    public bool active;

    public Type type;

}

public class HandleForm : MonoBehaviour
{

    [SerializeField]
    private Form _form;

    public void Start()
    {

        _form.LoadFormValues(new Profile
        {
            firstName = "Scott",
            lastName = "Doxey",
            age = "36",
            active = true,
            type = Type.User
        });

    }

    public void SubmitForm(Dictionary<string, object> formFields)
    {

        Debug.Log(JsonConvert.SerializeObject(formFields));

    }

}
