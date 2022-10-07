#include <stdio.h>
#include "013_C_def.h"

typedef struct _STUDENT
{
    char name[10];
    int kor;
    int eng;
    int math;
    int hap;
    double avg;
    char score;
} STUDENT;

int main()
{
    STUDENT st;
    // printf("이름: ");
    // scanf("%s", st.name);
    // printf("국어: ");
    // scanf(" %d", st.kor);
    // printf("영어: ");
    // scanf(" %d", st.eng);
    // printf("수학: ");
    // scanf(" %d", st.math);
    // // 총점
    // st.hap = st.kor + st.eng + st.math;
    // // 평균
    // st.avg = st.hap / 3.0;
    // printf("총점은 : %d\n", st.hap);
    // printf("평균은 : %lf\n", st.avg);

    // 포인터 변수일 경우 -> 로 접근
    // pst->kor = 50;
    STUDENT stArr[3] = {
        0,
    };
    for (int i = 0; i < 3; i++)
    {
        printf("이름: ");
        scanf("%s", stArr[i].name);
        printf("국어: ");
        scanf(" %d", &stArr[i].kor);
        printf("영어: ");
        scanf(" %d", &stArr[i].eng);
        printf("수학: ");
        scanf(" %d", &stArr[i].math);
    }

    for (int i = 0; i < 2; i++)
    {
        printf("이름: %s\n", stArr[i].name);
        printf("국어: %d\n", stArr[i].kor);
        printf("영어: %d\n", stArr[i].eng);
        printf("수학: %d\n", stArr[i].math);
    }
}