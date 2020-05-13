using System;

namespace OOYA
{ 
  class Profile
  {
    private string name;
    private int age;
    private string city;
    private string country;
    private string pronouns;
    private string[] hobbies;

    // Constructors
    public Profile(string name, int age, string city, string country, string pronouns = "they/them")
    {
       //this helps differentiate the paramenters form the instance fields
       this.name = name;
       this.age = age;
       this.city = city;
       this.country = country;
       this.pronouns = pronouns;
    }

    // Methods
    public string ViewProfile()
    {
      return $"Name: {name} \nAge: {age} \nCity: {city} \nCountry: {country} \nHobbies: {String.Join(", ",hobbies)}"; //String.Join() allows me to loop through the string array
    }

    public void SetHobbies(string[] hobbies)
    {
      this.hobbies = hobbies;
    }
    
  }
}
