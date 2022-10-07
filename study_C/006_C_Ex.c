#include <stdio.h>

void sum(int num1, int num2)
{
    printf("%d\n", num1 + num2);
}

void calculate(int num1, int num2, int num3)
{
    printf("%d\n", num1 * num2 + num3);
}

void squa(int num1)
{
    printf("%d\n", num1 * num1);
}

void divide(int num1, int num2)
{
    printf("몫은 %d입니다.\n", num1 / num2);
    printf("나머지는 %d입니다.\n", num1 % num2);
}

void calculate2(int num1, int num2, int num3)
{
    printf("%d\n", (num1 - num2) * (num2 + num3) * (num3 % num1));
}

int main()
{
    int number1, number2, number3;
    printf("더하기 연산자 :");
    scanf("%d %d", &number1, &number2);
    sum(number1, number2);

    printf("계산 연산자 :");
    scanf("%d %d %d", &number1, &number2, &number3);
    calculate(number1, number2, number3);

    printf("제곱할 숫자 입력 :");
    scanf(" %d", &number1);
    squa(number1);

    printf("몫 나머지 연산자 :");
    scanf("%d %d", &number1, &number2);
    divide(number1, number2);

    printf("계산 연산자2 :");
    scanf("%d %d %d", &number1, &number2, &number3);
    calculate2(number1, number2, number3);
}