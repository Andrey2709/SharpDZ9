// 64

  void counter(int m,int n){
for(int i = m; i<=n; i++ ){
Console.Write(i+" ");
}
};

counter(2,8);

Console.WriteLine(" ");
// 66
 int counterSum(int m,int n){
    int f= 0;
for(int i = m; i<=n; i++){
f+=i;
}
Console.WriteLine(f);
return f;
};


counterSum(4,8);
// 68
 int A(int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return A(n - 1, 1);
    else
      return A(n - 1, A(n, m - 1));
};

Console.WriteLine(A(2,3));



 UInt64 AckermannFunc(UInt64 m, UInt64 n) {
            if (m == 0)
                return n + 1;
            if (n == 0)
                return AckermannFunc(m - 1, 1);
            return AckermannFunc(m - 1, AckermannFunc(m, n - 1));
        }

Console.WriteLine(AckermannFunc(3,2));
