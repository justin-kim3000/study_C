#include <stdio.h>
int main()
{
    // int arr[100];
    // arr[0] = 100;
    // arr[9] = 0;

    // for (int i = 0; i < 100; i++)
    // {
    //     arr[i] = i;
    //     printf("%d \t", arr[i]);
    // }
    // printf("%d", arr);

    // int arr2[3][2]; // 3x2
    // for (int i = 0; i < 3; i++)
    // {
    //     for (int j = 0; j < 2; j++)
    //     {
    //         arr2[i][j] = 10;
    //         printf("arr[%d][%d] = [%d] ", i, j, arr2[i][j]);
    //     }
    //     printf("\n");
    // }

    int arr2[2][3] = {
        {1, 2, 3},
        {4, 5, 6}};

    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            printf("%d, ", arr2[i][j]);
        }
        printf("\n");
    }

    return 0;
}
