class Array
{
    void Learn1DArray()
    {
        //if we have to define intiger array;
        int[] ages1 = new int[10];
        double[] ages2 = new double[10];

        ages1[0] = 12;
        ages1[5] = 23;


        //if we alredy the items of the array
        float[] numbers = new float[] { 12.1f, 121.23f, 1.21f };
        //or you can simply do
        float[] numbers1 = { 12.1f, 121.23f, 1.21f };

    }

    void LearnMultiDArray()
    {
        //To define 2D Array
        int[,] twoDArray = new int[3, 4];//3 rows and 4 columns
        twoDArray[0, 0] = 12;
        twoDArray[4, 4] = 12;//gives run time error as there are only 3 rows but we assign value in row no 4. which doesnot exits

        string[,] names = new string[,] { { "John", "Alice" }, { "Alex", "Tina" } };



        //To define 3D Array
        int[,,] threeDArray = new int[5, 15, 5];//This Array creates 5 diffrent Array with each array a 2D Array
        threeDArray[0, 1, 1] = 43;//in first array with postion first row and first column 

        //note in multiDimenationl array size of row always remains same
        //so if we have condition where row's  size if differ then we have to use JaggedArray concept


    }

    void JaggedArray()
    {
        //we have numbers like
        // 3,3,4,5
        // 6,4,6
        // 9,5,4,2
        byte[][] personAges = new byte[3][];//means we have 3 rows but columns differ
        personAges[0] = new byte[2] { 34, 56 };
        personAges[2] = new byte[] { 34, 56, 45 };//not need to mention size insize byte[]
    }
}