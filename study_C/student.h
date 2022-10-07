#ifndef __STUDENT_H__
#define __STUDENT_H__

typedef struct student
{
    char name[10];
    int kor;
    int eng;
    int math;
    int hap;
    double avg;
    char score;
} ST;

ST st; // 구조체의 변수 선언(전역변수)

extern void init_stduent(); //함수 프로토 타입
// void show_student();
#endif