#include <stdio.h>
int main()
{
    int arr1[10] = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
    int arr2[] = {1, 2, 3, 4, 5, 6, 7};
    int arr3[5] = {1, 2};
    int ar1len, ar2len, ar3len;

    ar1len = sizeof(arr1) / sizeof(int);
    ar2len = sizeof(arr2) / sizeof(int);
    ar3len = sizeof(arr3) / sizeof(int);

    for (int i = 0; i < ar1len; i++)
    {
        printf("%d ", arr1[i]);
    }
    printf("\n");

    for (int i = 0; i < ar2len; i++)
    {
        printf("%d ", arr2[i]);
    }
    printf("\n");
    for (int i = 0; i < ar3len; i++)
    {
        printf("%d ", arr3[i]);
    }
    printf("\n");

    // 배열 크기
    printf("%d\n", sizeof(arr1));
    printf("%d\n", sizeof(arr2));
    printf("%d\n", sizeof(arr3));
    // 배열 길이
    printf("%d\n", sizeof(arr1) / sizeof(int));
    return 0;
}