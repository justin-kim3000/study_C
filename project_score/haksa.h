#ifndef __HAKSA_H__
#define __HAKSA_H__

// 수강신청 학생
typedef struct _STUDENT {
	int std_id;		// 학번
	char name[20];	// 이름
	int age;		// 나이
	char major[20];	// 전공
	char tel[20];	// 전화
	char addr[40];	// 주소
	char email[20]; // 이메일
} STUDENT;

typedef struct _PROFESSOR {
	char name[20];
	char major[20];
	char tel[20];
	char email[20];
} PROFESSOR;

typedef struct _MAJOR_SUBJECT {
	char name[30];
	int hakjum;
} MAJOR_SUBJECT;

typedef struct _LECTURE {
	STUDENT std;
	PROFESSOR prof;
	MAJOR_SUBJECT major[3];
	char date[30];
	char class_room[20];
} LECTURE;

extern void std_lecture_input();
extern void std_lect_show(LECTURE lect);

#endif
