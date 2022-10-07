#include <stdio.h>
#include <limits.h>

int main()
{
    int num1 = 75;
    printf("\n");
    // printf("2진수 입니다 :%d\n", num1);
    printf("8진수 입니다 :%#o\n", num1);
    printf("16진수 입니다 :%#x\n", num1);

    int x = 5;
    int max_int = __INT_MAX__;
    double max_double = __LONG_LONG_MAX__;
    double y = 1000000.5;
    long long z = 100000000000000.2;
    printf("변수 x의 메모리 크기는 %dByte 입니다. \n", sizeof(x));
    printf("변수 max_ int의 최대값은 %d 입니다. \n", max_int);
    printf("변수 max_ int의 최솟값은 %d 입니다. \n", max_int + 1);
    printf("변수 max_double의 최대값은 %llf 입니다. \n", max_double);
    printf("변수 max_double의 최대값은 %d 입니다. \n", sizeof(max_double));
    printf("변수 y의 메모리 크기는 %dByte 입니다. \n", sizeof(y));
    printf("변수 z의 메모리 크기는 %dByte 입니다. \n", sizeof(z));
    return 0;
}
