#include <stdio.h>

int main()
{
    char name_student[10], name_teacher[10], group[10], gender;
    int year_student;
    float career;

    printf("학생 정보 - 이름, 나이, 성별(M, F)\n");
    scanf("%s", &name_student);
    rewind(stdin);
    scanf("%d", &year_student);
    rewind(stdin);
    scanf("%c", &gender);

    printf("교사 정보 - 이름, 소속, 경력\n");
    scanf("%s", &name_teacher);
    rewind(stdin);
    scanf("%s", &group);
    rewind(stdin);
    scanf("%f", &career);

    printf("--- 학생 정보 ---\n");
    printf("이름: %s\n", name_student);
    printf("나이: %d\n", year_student);
    printf("성별: %c\n", gender);

    printf("--- 교사 정보 ---\n");
    printf("이름: %s\n", name_teacher);
    printf("소속: %s\n", group);
    printf("경력: %.2f\n", career);

    return 0;
}