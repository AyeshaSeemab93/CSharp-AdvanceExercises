namespace Exercise001
{
    using System;
    public class Die
    {
        private Random random;
        private int numberOfFaces;

        public Die(int numberOfFaces)
        {
            this.random = new Random();
            this.numberOfFaces = numberOfFaces;


        }
        public int ThrowDie()
        { //range needed 1(not 0) to numof Faces. if 50 is numOF then random wont add it in randowm number, to also include it make upper limit 51
            int randomNumber = random.Next(1, this.numberOfFaces + 1);
            return randomNumber;
        }
    }
}