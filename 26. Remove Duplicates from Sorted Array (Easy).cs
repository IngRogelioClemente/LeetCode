namespace ConsoleApp1
{
    class Program
    {
        // Método Main
        static void Main(string[] args) 
        {
            int Output1;
            int Output2;

            int[] EjArr1Main = {1,1,2}; //Input 1
            int[] EjArr2Main = {0,0,1,1,1,2,2,3,3,4}; //Input 2

            Output1 = RemoveDuplicates(EjArr1Main); // Array 1
            Output2 = RemoveDuplicates(EjArr2Main); //Array 2

            Console.WriteLine("Output 1: {0}", Output1);                        
            Console.WriteLine("Output 2: {0}", Output2);
        }

        // Método 
        public static int RemoveDuplicates(int[] nums)
        {
            int k = 0;

            for(int i = 0; i < nums.Length; i++) //Evaluador de array
            {
                if(i < nums.Length - 1 && nums[i] == nums[i + 1]) // Si el elemnto continuo es igual al siguiente, escapa
                {
                    continue;
                }
                nums[k] = nums[i]; //count guarda la cantidad de valores que cumplen con la condición al evaluar el array
                k++;
            }
            return k;
        }
    }
}