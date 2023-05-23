namespace Exercise004
{
    public abstract class Box
    {
        //2 abstract/incomplete methods to use everywhere
        public abstract void Add(Item item);
        public abstract bool IsInBox(Item item);

        //abstract methods declared in abstract class and will be initialize in every derived class
    }
}