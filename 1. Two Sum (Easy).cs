public class Solution 
{
    public int[] TwoSum(int[] nums, int target) 
    {
        int[] resultado = new int[2]; //Se instanciando la matriz del resultado.
        
        Dictionary<int, int> myDict = new Dictionary<int,int>();
        
        //** Ciclo for que evalua cada elemento de la matriz para encontrar el resultado **//
        for (int i = 0; i < nums.Length; i++)
        {
            if (myDict.ContainsKey(target-nums[i])) 
            {
                 resultado[1]=i;
                 resultado[0]=myDict[target-nums[i]];
                 break;
            }
            
            else if(!myDict.ContainsKey(nums[i])) myDict.Add(nums[i], i);
        }
        
        //** Regresa el resultado **//
        return resultado;
    }
}