using System;
class Pet
{
    static string name;
    static int health;
    static int happiness;
    static int boredom;
    static int hunger;
    static int mental;
    //Get and set for all the variables
    /*
    Because of the way XAML interacts with the C#, 
    I can't actually use functions or XAML objects in this class, 
    so it only stores these variables
    */
    static public void setName (string val)
    {
        Pet.name = val;
    }
    static public void setHealth (int val)
    {
        Pet.health = val;
    }
    static public void setHappiness(int val)
    {
        Pet.happiness = val;
    }
    static public void setBoredom(int val)
    {
        Pet.boredom = val;
    }
    static public void setHunger(int val)
    {
        Pet.hunger = val;
    }
    static public void setMental(int val)
    {
        Pet.mental = val;
    }

    static public string getName()
    {
        return Pet.name;
    }
    static public int getHealth()
    {
        return Pet.health;
    }
    static public int getHappiness()
    {
        return Pet.happiness;
    }
    static public int getBoredom()
    {
        return Pet.boredom;
    }
    static public int getHunger()
    {
        return Pet.hunger;
    }
    static public int getMental()
    {
        return Pet.mental;
    }

    public Pet()
    {
        health = 100;
        happiness = 50;
        boredom = 50;
        hunger = 50;
        mental = 100;

    }
}
