#ifndef __STRUCT_H__
#define __STRUCT_H__

typedef struct _BOOK { //��ȸ�� ���ų��� �����, �¼����� Ȯ�ο�
	char name[20];
	char phone[20];
	char movie[40];
	char seat1[5];
	char seat2[5];
	char seat3[5];
	int price;
} BOOK;

typedef struct _BOOK_MEM { //ȸ�� ���ų��� �����
	char id[20];
	char pass[20];
	char movie[40];
	char seat1[5];
	char seat2[5];
	char seat3[5];
	int price;
} BOOK_MEM;

typedef struct _NOWMOVIE { //�������
	char name[40];
	char genre[20];
} NOW;

typedef struct _RECOMMEND { //��ȭ��õ DB �����
	char name[40];
	char genre[20];
	char director[30];
	char actor[60];
} RECOM;

typedef struct _MEMBER {
	char id[20];
	char password[20];
} MEMBER;

typedef struct _LOGIN {
	char ID[20];		// ID �Է�
	char PHONE[20];		// ��ȭ��ȣ �Է�
	char EMAIL[40];		// �̸��� �Է�
	char PASSWORD[40];	// ��й�ȣ �Է�
} LOGIN;

typedef enum {
	HELP = 0,
	RESERVATION = 1,
	CHECK,
	RECOMMEND,
	GENRE_SEARCH,
	MANAGE,
	QUIT
}menu_select;

#endif