#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include "struct.h"
#include "function.h"
#include <Windows.h>
#include <conio.h>
#include <string.h>

void my_rec() {
	int act = 0, hor = 0, comid = 0, drama = 0, fan = 0, crime = 0;
	char a = 0;
	int score = 0;
	int select = 0;
	system("cls");
	printf("======================================================================================================\n");
	printf("                ___   _  _______    _______  ___  __    _  _______  __   __  _______\n");
	printf("               |   | | ||  _    |  |       ||   ||  |  | ||       ||  |_|  ||   _   |\n");
	printf("               |   |_| || |_|   |  |       ||   ||   |_| ||    ___||       ||  |_|  |\n");
	printf("               |      _||       |  |       ||   ||       ||   |___ |       ||       |\n");
	printf("               |     |_ |  _   |   |      _||   ||  _    ||    ___||       ||       |\n");
	printf("               |    _  || |_|   |  |     |_ |   || | |   ||   |___ | ||_|| ||   _   |\n");
	printf("               |___| |_||_______|  |_______||___||_|  |__||_______||_|   |_||__| |__|\n");
	printf("\n");
	printf("======================================================================================================\n");
	printf("\n\n");
	printf("                                      KB 시네마 영화 추천 시스템\n");
	printf("\n\n");
	printf("                       지금부터 장르별로 '명작'이라 불리는 영화 10개를 보여드립니다.\n");
	printf("                 고객님께서 각 영화에 점수를 매겨주시면 해당 데이터를 기반으로 현재 상영작 중\n");
	printf("                              고객님의 취향에 맞는 영화를 추천해 드립니다.\n");
	printf("\n\n");
	printf("                             ┌─────────────┐             ┌─────────────┐\n");
	printf("                             │ 1. 시작     │             │ 2. 돌아가기 │\n");
	printf("                             └─────────────┘             └─────────────┘\n");
	printf("\n\n");
	printf("                                                                            기능 선택: ");
	gotoxy(87, 25);
	scanf("%d", &select);
	while (1) {
		if (select == 1) {
			break;
		}
		else if (select == 2) {
			return;
		}
		else {
			gotoxy(0, 25);
			printf("                                                                            기능 선택:    ");
			gotoxy(87, 25);
			scanf("%d", &select);
		}
	}

	system("cls");
	printf("======================================================================================================\n");
	printf("                ___   _  _______    _______  ___  __    _  _______  __   __  _______\n");
	printf("               |   | | ||  _    |  |       ||   ||  |  | ||       ||  |_|  ||   _   |\n");
	printf("               |   |_| || |_|   |  |       ||   ||   |_| ||    ___||       ||  |_|  |\n");
	printf("               |      _||       |  |       ||   ||       ||   |___ |       ||       |\n");
	printf("               |     |_ |  _   |   |      _||   ||  _    ||    ___||       ||       |\n");
	printf("               |    _  || |_|   |  |     |_ |   || | |   ||   |___ | ||_|| ||   _   |\n");
	printf("               |___| |_||_______|  |_______||___||_|  |__||_______||_|   |_||__| |__|\n");
	printf("\n");
	printf("======================================================================================================\n");
	printf("\n\n");
	printf("                                      KB 시네마 영화 추천 시스템\n");
	printf("\n\n");

	FILE* fpr = fopen("d:/REC_MV_LIST.txt", "rb");
	if (fpr == NULL) {
		printf("                                      현재 등록된 DB가 없습니다.\n");
		printf("                                     아무 키나 누르면 돌아갑니다.\n");
		_getch();
		return;
	}
	RECOM rec = { 0, };            // 저장된 추천 영화 목록 출력
	int count = 1;
	char genre[10] = { 0, };

	while (fread(&rec, sizeof(rec), 1, fpr) == 1) {
		gotoxy(33, 27); printf("                                                 ");
		gotoxy(25, 15); printf("┌──────────────────────────────────────────────────┐\n");
		gotoxy(25, 16); printf("│                                                  │\n");
		gotoxy(25, 17); printf("│                      질문                        │\n");
		gotoxy(53, 17); printf("%d\n", count++);
		gotoxy(25, 18); printf("│                                                  │\n");
		gotoxy(25, 19); printf("│     제목:                                        │");
		gotoxy(25, 20); printf("│     장르:                                        │");
		gotoxy(25, 21); printf("│     감독:                                        │");
		gotoxy(25, 22); printf("│     주연:                                        │");
		gotoxy(25, 23); printf("│                                                  │");
		gotoxy(25, 24); printf("└──────────────────────────────────────────────────┘\n");
		gotoxy(37, 19); printf("                                       ");
		gotoxy(37, 19); printf("<%s>", rec.name);
		gotoxy(37, 20); printf("                                       ");
		gotoxy(37, 20); printf("%s", rec.genre);
		gotoxy(37, 21); printf("                                       ");
		gotoxy(37, 21); printf("%s", rec.director);
		gotoxy(37, 22); printf("                                       ");
		gotoxy(37, 22); printf("%s", rec.actor);
		gotoxy(33, 27);	printf("이 영화를 보신 적이 있나요?(Y/N): ");
		scanf(" %c", &a);
		while (1) {
			if (a == 'Y' || a == 'y') {
				gotoxy(33, 27);
				printf("점수를 매긴다면 몇 점인가요?(1~5): ");
				scanf("%d", &score);
				getchar();
				if (score == 1 || score == 2 || score == 3 || score == 4 || score == 5) {
				}
				else {
					gotoxy(33, 27);
					printf("점수를 매긴다면 몇 점인가요?(1~5):     ");
					gotoxy(33, 27);
					printf("점수를 매긴다면 몇 점인가요?(1~5): ");
					rewind(stdin);
					continue;
				}
				if (strcmp(rec.genre, "액션") == 0) {
					act += score;
				}
				else if (strcmp(rec.genre, "코미디") == 0) {
					comid += score;
				}
				else if (strcmp(rec.genre, "공포") == 0) {
					hor += score;
				}
				else if (strcmp(rec.genre, "드라마") == 0) {
					drama += score;
				}
				else if (strcmp(rec.genre, "판타지") == 0) {
					fan += score;
				}
				else if (strcmp(rec.genre, "범죄") == 0) {
					crime += score;
				}
				break;
			}
			else if (a == 'N' || a == 'n' && count != 11) {
				break;
			}
			else {
				gotoxy(33, 27); printf("이 영화를 보신 적이 있나요?(Y/N):         ");
				gotoxy(33, 27);	printf("이 영화를 보신 적이 있나요?(Y/N): ");
				scanf(" %c", &a);
			}
		}
	}
		

	

	if (act > hor && act > comid && act > drama && act > fan && act > crime) {
		strcpy(genre, "액션");
	}
	else if (hor > act && hor > comid && hor > drama && hor > fan && hor > crime) {
		strcpy(genre, "공포");
	}
	else if (comid > act && comid > hor && comid > drama && comid > fan && comid > crime) {
		strcpy(genre, "코미디");
	}
	else if (drama > act && drama > hor && drama > comid && drama > fan && drama > crime) {
		strcpy(genre, "드라마");
	}
	else if (fan > act && fan > hor && fan > comid && fan > drama && fan > crime) {
		strcpy(genre, "판타지");
	}
	else if (crime > act && crime > hor && crime > drama && crime > comid && crime > fan) {
		strcpy(genre, "범죄");
	}
	else
	{
		system("cls");
		printf("======================================================================================================\n");
		printf("                ___   _  _______    _______  ___  __    _  _______  __   __  _______\n");
		printf("               |   | | ||  _    |  |       ||   ||  |  | ||       ||  |_|  ||   _   |\n");
		printf("               |   |_| || |_|   |  |       ||   ||   |_| ||    ___||       ||  |_|  |\n");
		printf("               |      _||       |  |       ||   ||       ||   |___ |       ||       |\n");
		printf("               |     |_ |  _   |   |      _||   ||  _    ||    ___||       ||       |\n");
		printf("               |    _  || |_|   |  |     |_ |   || | |   ||   |___ | ||_|| ||   _   |\n");
		printf("               |___| |_||_______|  |_______||___||_|  |__||_______||_|   |_||__| |__|\n");
		printf("\n");
		printf("======================================================================================================\n");
		printf("\n\n");
		printf("                                      KB 시네마 영화 추천 시스템\n");
		printf("\n\n");
		printf("                    선호 장르가 너무 많거나, 입력하신 데이터가 부족해 추천이 불가능합니다.\n");
		printf("                                      처음부터 다시 시작해주세요.\n");
		printf("                                     아무 키나 누르면 돌아갑니다.\n");
		_getch();
		return;
	}

	fpr = fopen("d:/NOW_MV_LIST.txt", "rb");            // 여러 장르중 값이 가장 높은 장르가 출력되도록 설정
	if (fpr == NULL) {
		printf("파일을 읽을수가 없습니다.\n");
		return;
	}

	NOW now = { 0, };          // 위 정보를 바탕으로 현재 상영작 중에 내가 선호하는 영화를 추천 받는다.
	int i = 0;
	int count2 = 0;
	if (genre[0] != 0) {
		system("cls");
		printf("======================================================================================================\n");
		printf("                ___   _  _______    _______  ___  __    _  _______  __   __  _______\n");
		printf("               |   | | ||  _    |  |       ||   ||  |  | ||       ||  |_|  ||   _   |\n");
		printf("               |   |_| || |_|   |  |       ||   ||   |_| ||    ___||       ||  |_|  |\n");
		printf("               |      _||       |  |       ||   ||       ||   |___ |       ||       |\n");
		printf("               |     |_ |  _   |   |      _||   ||  _    ||    ___||       ||       |\n");
		printf("               |    _  || |_|   |  |     |_ |   || | |   ||   |___ | ||_|| ||   _   |\n");
		printf("               |___| |_||_______|  |_______||___||_|  |__||_______||_|   |_||__| |__|\n");
		printf("\n");
		printf("======================================================================================================\n");
		printf("\n\n");
		printf("                                      KB 시네마 영화 추천 시스템\n");
		printf("\n\n");
		while (fread(&now, sizeof(now), 1, fpr) == 1) {
			if (strcmp(now.genre, genre) == 0) {
				gotoxy(25, 15 + i); printf("┌──────────────────────────────────────────────────┐\n");
				gotoxy(25, 16 + i); printf("│                                                  │\n");
				gotoxy(25, 17 + i); printf("│     제목:                                        │");
				gotoxy(25, 18 + i); printf("│     장르:                                        │");
				gotoxy(25, 19 + i); printf("│                                                  │");
				gotoxy(25, 20 + i); printf("└──────────────────────────────────────────────────┘\n");
				gotoxy(37, 17 + i); printf("                                       ");
				gotoxy(37, 17 + i); printf("<%s>", now.name);
				gotoxy(37, 18 + i); printf("                                       ");
				gotoxy(37, 18 + i); printf("%s", now.genre);
				count2++; i += 6;
			}
		}
		printf("\n\n\n\n");
		printf("                        고객님의 선호 장르는 %s이며, 위와 같은 영화를 추천합니다.\n", genre);
		printf("                                    아무 키나 누르면 돌아갑니다.\n");
		_getch();
		return;
	}
	else if (count2 == 0)
	{
		system("cls");
		printf("======================================================================================================\n");
		printf("                ___   _  _______    _______  ___  __    _  _______  __   __  _______\n");
		printf("               |   | | ||  _    |  |       ||   ||  |  | ||       ||  |_|  ||   _   |\n");
		printf("               |   |_| || |_|   |  |       ||   ||   |_| ||    ___||       ||  |_|  |\n");
		printf("               |      _||       |  |       ||   ||       ||   |___ |       ||       |\n");
		printf("               |     |_ |  _   |   |      _||   ||  _    ||    ___||       ||       |\n");
		printf("               |    _  || |_|   |  |     |_ |   || | |   ||   |___ | ||_|| ||   _   |\n");
		printf("               |___| |_||_______|  |_______||___||_|  |__||_______||_|   |_||__| |__|\n");
		printf("\n");
		printf("======================================================================================================\n");
		printf("\n\n");
		printf("                                      KB 시네마 영화 추천 시스템\n");
		printf("\n\n");
		printf("                        현재 상영작 중 고객님의 선호 장르에 해당하는 영화가 없습니다.\n");
		printf("                                      처음부터 다시 시작해주세요.\n");
		printf("                                     아무 키나 누르면 돌아갑니다.\n");
		_getch();
		return;
	}
	fclose(fpr);
}