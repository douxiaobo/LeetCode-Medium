// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

public class Solution {
    public double MyPow(double x, int n) {
        if(n<0){
            x=1.0/x;
            n=-n;
        }
        return fast_pow(x,n);
    }

    public double fast_pow(double x, int n) {
        if(n==0) {
            return 1.0;
        }

        double half=fast_pow(x,n/2);

        if(n%2==0) {
            return half*half;
        } else {
            return half*half*x;
        }
    }
}