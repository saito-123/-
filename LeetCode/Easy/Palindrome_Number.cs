public class Solution {
    public bool IsPalindrome(int x) {

    //判定結果    
    bool result =true;

    //ローカル用変数
    int x_input=x;
    int x_input_reverse=0;
    int digit=0;


    //入力値の各桁を計算していき、入力値を逆転した整数を生成する
    while(x_input>0)
    {
        digit=x_input%10;
        x_input_reverse=x_input_reverse*10+digit;
        x_input=x_input/10;
    }

    //生成した結果を元の数値と比較
    if(x!=x_input_reverse)
    {
        result=false;
    }

    return result;

    }
}