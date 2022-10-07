#include <stdio.h>

int add1(int a, int b, char c)
{
    int res;
    if (c == '+')
    {
        res = a + b;
    }
    else if (c == '-')
    {
        res = a - b;
    }
    else if (c == '*')
    {
        res = a * b;
    }
    else if (c == '/')
    {
        res = a / b;
    }

    return res;
}

int main()
{
    int num1, num2;
    char op = 0;

    printf("숫자1 입력: ");
    scanf("%d", &num1);
    printf("숫자2 입력: ");
    scanf("%d", &num2);

    printf("연산자 입력: ");
    scanf(" %c", &op);

    int result = add1(num1, num2, op);
    printf("%d\n", result);
}