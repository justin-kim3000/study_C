#include <stdio.h>

int main()
{

    char ch = 'A';
    char *p = NULL;
    p = &ch;
    printf("ch가 가지는 값: %c\n", ch);
    printf("ch 주소 값: %p\n", &ch);
    printf("p가 가지는 값: %p\n", p);
    printf("p가 참조하는 주소의 데이터값: %c\n", *p);

    int arr[] = {10, 20, 30, 40};
    int *pArr = arr;

    printf("pArr[0]=%d\n", pArr[2]);
    printf("*pArr=%d\n", *pArr);
    printf("*(pArr+0)=%d\n", *(pArr + 2));
}