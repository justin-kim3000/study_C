#include <stdio.h>

int main()
{
    int num;
    printf("1~n단 까지 구구단을 출력합니다. n을 넣으시오 : ");
    scanf("%d", &num);

    for (int i = 1; i <= num; i++)
    {
        for (int j = 1; j < 10; j++)
        {
            printf("%d * %d = %d\n", i, j, i * j);
        }
        printf("%d단 입니다.\n", i);
    }

    // printf("n단 구구단을 입력하시오 : ");
    // scanf("%d", &num);
    // for (int j = 1; j <= 9; j++)
    // {
    //     printf("%d * %d = %d\n", num, j, num * j);
    // }
    // return 0;

    printf("n단 구구단을 입력하시오 : ");
    scanf(" %d", &num);
    int j = 1;
    while (j <= 9)
    {
        printf("%d * %d = %d\n", num, j, num * j);
        j++;
    }

    return 0;
}