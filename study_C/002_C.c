// stdio : standard input and output (기본 입출력) -> 이것을 포함해야 입출력 명령문 사용
// #define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>

// 프로그램 실행시 반드시 가장 먼저 실행
// int main(), void main()
int main()
{
    // 출력문 printf()
    // 변수를 선언 할때 scanf()도 사용 가능

    printf("hellow univercity!\n");

    int age; // 정수형 변수 age 선언

    char gender;   //문자형 변수('M','F')
    char name[10]; // 문자형 변수가 10개 있는 name 문자열 선언

    printf("나이를 입력하세요. ");
    scanf("%d", &age);
    rewind(stdin);

    printf("성별을 입력하세요.(M,F)");
    scanf("%c", &gender);
    printf("이름을 입력하세요.");
    scanf("%s", &name);

    printf("입학을 환영합니다!\n");
    printf("이름: %s\n", name);
    printf("나이: %d\n", age);
    printf("성별: %c\n", gender);

    return 0;
}