public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        
        //num2が空でなければ、num1の指定位置にnum2をコピーする。
        if(nums2==null)
        {
            //何も実行しない(num1がそのまま解となる)
        }
        else
        {
            //num1に結果をマージする
            Array.Copy(nums2, 0,nums1,m, n);

            //マージした結果を再度ソートしなおす。
            Array.Sort(nums1);
        }


    }
}