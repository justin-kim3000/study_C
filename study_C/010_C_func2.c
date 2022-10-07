#include <stdio.h>

int simple()
{
    // 전역변수 성질이지만 함수 내에서만 접근 가능
    static int num1 = 0;
    // 속도 가장 빠르다
    register int num2 = 0;
}

int factorial(int N)
{
    if (N == 0)
    {
        return 1;
    }
    else
    {
        return N * factorial(N - 1);
    }
}

int factorial2(int N)
{
    int temp = 1;
    for (int i = 1; i <= N; i++)
    {
        temp *= i;
    }
    return temp;
}

int main()
{
    printf("%d\n", factorial(5));
    printf("%d\n", factorial2(5));
}