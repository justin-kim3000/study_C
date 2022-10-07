#include <stdio.h>
#include <string.h>

int main()
{
    char sign[10];
    int test;
    double num1, num2;
    double result11 = 10001.0;

    printf("1.+ // 2.- // 3.* // 4./ \n");
    scanf("%s", &sign);

    // printf("sign = %c\n", sign);
    printf("숫자를 넣으시오 : ");
    scanf("%lf %lf", &num1, &num2);

    if (strcmp(sign, "+") == 0)
    {
        result11 = num1 + num2;
    }
    else if (strcmp(sign, "-") == 0)
    {
        result11 = num1 - num2;
    }
    else if (strcmp(sign, "*") == 0)
    {
        result11 = num1 * num2;
    }
    else if (strcmp(sign, "/") == 0)
    {
        result11 = num1 / num2;
    }

    printf("결과 : %f\n", result11);
    return 0;
}