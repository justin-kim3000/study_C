#include <stdio.h>

int main()
{
    int korea, math, english;
    scanf("%d %d %d", &korea, &math, &english);
    int sum = 0;

    if (korea >= 50)
        sum += korea;
    if (math >= 50)
        sum += math;
    if (english >= 50)
        sum += english;

    double average = (double)(sum) / 3;

    printf("평균은 %.3f\n", average);

    if (average >= 90)
    {
        printf("성적이 우수합니다.\n");
    }
    else if (average >= 75)
    {
        printf("성적이 평범합니다.\n");
    }
    else
    {
        printf("성적이 저조합니다.\n");
    }
}