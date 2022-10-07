#include <stdio.h>

int main()
{
    int A, B;
    scanf("%d %d", &A, &B);

    for (int i = 0; i < A; i++)
    {
        if (i % 2 == 0)
        {
            printf("*");
        }
        else
        {
            printf(".");
        }
    }

    for (int i = 0; i < B; i++)
    {
        for (int j = 0; j < i; j++)
        {
            printf("*");
        }
        printf("\n");
    }
}