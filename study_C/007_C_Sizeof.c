#include <stdio.h>

int main()
{
    char ch = 9;
    int inum = 1052;
    double dnum = 3.1415;
    printf("변수 ch의 크기: %d \n", sizeof(ch));
    printf("변수 inum의 크기: %d \n", sizeof(inum));
    printf("변수 dnum의 크기: %d \n", sizeof(dnum));

    printf("char의 크기: %d \n", sizeof(char));
    printf("int의 크기: %d \n", sizeof(int));
    printf("long의 크기: %d \n", sizeof(long));
    printf("long long의 크기: %d \n", sizeof(long long));
    printf("float 크기: %d \n", sizeof(float));
    printf("double의 크기: %d \n", sizeof(double));

    // double rad;
    // double area;
    // printf("원의 반지름 입력: ");
    // scanf("%lf", &rad);

    // area = rad * rad * 3.1415;
    // printf("원의 넓이 : %lf\n", area);

    double a = 4.0;
    int b = 3;

    printf("3/4 연산결과 %.2lf", b / a);
    return 0;
}