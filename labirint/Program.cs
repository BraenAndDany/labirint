Console.WriteLine("Vvedite razmer massiva");
int n= Convert.ToInt32(Console.ReadLine());
int[,] lab=new int[n,n];
int a, b;
int copy;
Random rng = new Random();
for (int i=0;i<n-1;i++)
{
    for (int j=0;j<n-1;j++)
    {   if(j==n-2&&i==n-2)
        {
            lab[i, j - 1] = 0;
            lab[i - 1, j] = 0;
        }
        else if (i==n-2)
        {
            lab[i, j+1] = rng.Next(2);
        }
        else if (j==n-2)
        {
            lab[i + 1, j] = rng.Next(2);
        }

        else if (i==0&&j==0)
        {
            lab[i, j] = 8;
            lab[i, j + 1] = 0;
            lab[i + 1, j] = 0;
            //if (lab[i, j + 1] == 1)
            //{
            //    lab[i + 1, j] = 0;
            //}
            //else
            //{
            //    lab[i + 1, j] = 1;
            //}

        }
        else if (lab[i, j] == 0)
        {
            lab[i, j + 1] =  rng.Next(2);
            if(lab[i, j + 1]==1)
            {
                lab[i + 1, j] = 0;
            }
            else
            {
                lab[i + 1, j] = 1;
            }
        }
        else if (lab[i, j] == 1)
        {
            lab[i, j + 1] = rng.Next(2);
            if (lab[i, j + 1] == 1)
            {
                lab[i + 1, j] = 0;
            }
            else
            {
                lab[i + 1, j] = 1;
            }
        }
    if((i>0&&j>0)&&(lab[i-1, j] == 1 && lab[i, j-1] == 1))
    {
            lab[i, j - 1] = rng.Next(2);
            if (lab[i, j + 1] == 1)
            {
                lab[i + 1, j] = 0;
            }
            else
            {
                lab[i + 1, j] = 1;
            }
        }
    }
}
copy = lab[0, 0];
for (int i = 0; i < 2;)
{
    Console.WriteLine("Vvedite kuda hotite peremestica");
    a =Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(" ");
    b = Convert.ToInt32(Console.ReadLine());
    if (copy - lab[a,b]==8)
    {
        
        if ()
        {

        }
        copy = lab[a, b];
    }
}
Console.WriteLine("");
for (int i = 0;i < n;i++)
{
    for(int j = 0;j<n;j++)
    {
        if (lab[i, j] == 8)
        {
            Console.Write("♥");
        }
        else if (lab[i, j] == 1)
        {
            Console.Write("■");
        }
        else if (lab[i, j] == 0)
        {
            Console.Write(".");
        }
        
        Console.Write(" ");
       
    }
    Console.WriteLine("");
}