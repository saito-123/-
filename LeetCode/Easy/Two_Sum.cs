public class Solution {
    public int[] TwoSum(int[] nums, int target) 
    {
        //出力するインデックスの定義
        int index_count=2;
        int [] index_result=new int[index_count];

        index_result[0]=-1;
        index_result[1]=-1;

        //iとjの初期値
        int i_index=0;
        int j_index=1;

        //組み合わせの数だけ計算すればいいので、初期値は調整する
        for(int i=i_index ; i<nums.Length ;i++)
        {
            for(int j=j_index ;j<nums.Length ;j++)
            {
                if(nums[i]+nums[j]==target)
                {
                    index_result[0]=i;
                    index_result[1]=j;

                }
              
                
            }
            i_index++;
            j_index++;
        }

         return index_result;
    
    }                    
                   
}