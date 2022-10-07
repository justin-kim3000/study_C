#include <stdio.h>

void fun1(int start, int end)
{
    if (start == end)
        return;
    if (start % 3 == 0 || start % 4 == 0)
        printf("%d ", start);
    fun1(start + 1, end);
}

int main()
{
    for (int i = 1; i < 100; i++)
    {
        if (i % 3 == 0 || i % 4 == 0)
            printf("%d ", i);
    }
    printf("\n\n");
    fun1(1, 100);

    printf("\n");
    int abs, num1, num2;
    printf("정수를 입력하시오. ");
    scanf("%d", &num1);

    abs = num1 > 0 ? num1 : num1 * (-1);

    printf("정수 값의 절대값은 : %d 입니다.\n", abs);
    return 0;
}