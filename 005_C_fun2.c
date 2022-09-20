#include <stdio.h>
int main()
{
    printf("동전 교환 프로그램\n");

    int money;
    printf("교환할 금액을 입력하시오.\n");
    scanf("%d", &money);

    int money500 = money / 500;
    int money100 = (money - 500 * money500) / 100;
    int money50 = (money - 500 * money500 - 100 * money100) / 50;
    int money10 = (money - 500 * money500 - 100 * money100 - 50 * money50) / 10;

    printf("500원 %d개 입니다.\n", money500);
    printf("100원 %d개 입니다.\n", money100);
    printf("50원 %d개 입니다.\n", money50);
    printf("10원 %d개 입니다.\n", money10);
    printf("바꾸지 못하는 동전 계수: %d\n", money % 10);

    // if (money % 500 == 0)
    // {
    //     printf("500원 %d개 입니다.\n", money500);
    // }
    // else if (money % 100 == 0)
    // {
    //     printf("500원 %d개 입니다.\n", money500);
    //     printf("100원 %d개 입니다.\n", money100);
    // }
    // else if (money % 50 == 0)
    // {
    //     printf("500원 %d개 입니다.\n", money500);
    //     printf("100원 %d개 입니다.\n", money100);
    //     printf("50원 %d개 입니다.\n", money50);
    // }
    // else if (money % 10 == 0)
    // {
    //     printf("500원 %d개 입니다.\n", money500);
    //     printf("100원 %d개 입니다.\n", money100);
    //     printf("50원 %d개 입니다.\n", money50);
    //     printf("10원 %d개 입니다.\n", money10);
    // }
    // else
    // {
    //     printf("500원 %d개 입니다.\n", money500);
    //     printf("100원 %d개 입니다.\n", money100);
    //     printf("50원 %d개 입니다.\n", money50);
    //     printf("10원 %d개 입니다.\n", money10);
    //     printf("바꾸지 못하는 동전 계수: %d\n", money % 10);
    // }
}