#include <stdio.h>
int main()
{
    char str[10];
    int idx = 0;

    printf("문자열 입력: ");
    scanf("%s", str);
    printf("입력받은 문자열 : %s \n", str);

    printf("문자 단위 출력: ");
    while (str[idx] != '\0')
    {
        printf("%c", str[idx]);
        idx++;
    }

    printf("\n");

    return 0;
}