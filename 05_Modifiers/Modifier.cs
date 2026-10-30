


class AccessModifier
{
    internal void DoSomething()
    {
        //internal gives access within a project

        //note:you can also use modifiers in class.By default class has internal access modifier
        //our class AccessModifier is internal by default

    }

    public void DoAnotherThing()
    {
        //gives access outside this project.
    }
}

class ModifierDemo
{
    public void DoSomething()
    {
        AccessModifier aa = new AccessModifier();
        aa.
    }
}