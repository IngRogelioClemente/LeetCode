public class Solution {
    public int[] SortedSquares(int[] nums) {
        
        int[] resultado = new int[nums.Length];
        
        //** Convertir a cuadrado **// 
        for (int i = 0; i < nums.Length; i++) //Evalua Array
        {
            nums[i] = nums[i] * nums[i];
        }
        
        //** Se organiza la matriz **//
        Array.Sort(nums); 
        resultado = nums;
        return resultado;
    }
}