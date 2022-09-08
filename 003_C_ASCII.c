#include <stdio.h>

int main()
{
    // 문자형 정보에 대한 원활한 처리를 위해 아스키코드 존재
    // 아스키코드 : 우리가 사용하는 문자나 기호가 특정 숫자와 일대일 대응을 하여 표현된 코드
    // printf("문자: %c\n", 80);
    // printf("문자: %d\n", 80);

    char c;
    scanf("%c", &c);

    if (c >= 65 && c <= 90)
    {
        printf("%c\n", c + 32);
    }
    else if (c >= 97 && c <= 122)
    {
        printf("%c\n", c - 32);
    }
    else
    {
        printf("글자를 파악하지 못하였습니다.");
    }
}