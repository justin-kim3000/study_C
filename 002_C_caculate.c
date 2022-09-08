#include <stdio.h>

int main()
{
    // 산술 연산자 : +,-,*,/,%
    int a = 1, b = 5, result;
    result = a + b;
    printf("덧셈 결과:%d\n", result);

    result = a - b;
    printf("뺄셈 결과:%d\n", result);

    result = a * b;
    printf("곱셈 결과:%d\n", result);

    result = a / b;
    printf("나눗셈 결과:%d\n", result);

    result = a % b;
    printf("나머지 결과:%d\n", result);

    // 산술연산자 합친 형태
    printf("number 초기값은 0, n은 4\n");
    int number = 0;
    int n = 4;

    number += n;
    printf("nuber += n결과 %d\n", number);
    number *= n;
    printf("nuber *= n결과 %d\n", number);
    number /= n;
    printf("nuber /= n결과 %d\n", number);
    number %= n;
    printf("nuber %%= n결과 %d\n", number);

    // 대입 연산자 : =  -> 어떤 메모리에 값을 집어 넣는다.
    // 비교 연산자 : >, <, <=, >=, ==(같다), !=(같지않다.)
    // 논리 연산자 : &(그리고) &&, (또는) |, ||
    // if (){}<- 조건을 만족하면 중괄호 안의 명령문을 수행

    int num1, num2, num3;
    scanf("%d %d %d", &num1, &num2, &num3);
    printf("num1: %d\n", num1);
    printf("num2: %d\n", num2);
    printf("num3: %d\n", num3);

    // 논리연산자 사용(&,&&,|,||)
    if (num1 > num2 && num1 > num3)
    {
        printf("num1이 가장 큽니다.\n");
    }
    else if (num2 > num1 && num2 > num3)
    {
        printf("num1이 가장 큽니다.\n");
    }
    else if (num3 > num1 && num3 > num2)
    {
        printf("num3가 가장 큽니다. \n");
    }

    // if (num1 > num2)
    // {
    //     printf("num1 > num2\n");
    // }
    // else if (num1 = num2)
    // {
    //     printf("num1 = num2");
    // }
    // else
    // {
    //     printf("num1은 num2 보다 크지않다.\n");
    // }

    // 증감 연산자: ++, --
}