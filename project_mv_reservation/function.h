#ifndef __MENU_H__
#define __MENU_H__

extern void intro();

//���� �޴� ȣ��
extern int main_menu();

//��ȭ ��� ���, ������ ��ȭ ����
extern int print_List();
extern void choose_List(int count);

//�¼� ����
extern void seatselect(char* movie, int many);

//����
extern void payment(char* movie, char seat[][5], int many);
extern void payment_mem(char* id, char* pass, char* movie, char seat[][5], int many);

//���� ���� Ȯ��, ���� ���
extern void checkIn(); //ȸ��, ��ȸ�� ��ȸ ����
extern void check(); //��ȸ�� ��ȸ
extern void check_mem(); //ȸ�� ��ȸ
extern void delete_name(char* name, char* phone, char* movie, char* seat); //��ȸ�� �������
extern void delete_mem(char* id, char* pass, char* movie, char* seat); //ȸ�� �������

//��ȭ ��õ�ޱ�
extern void my_rec();

//�帣�� �˻�
extern void search();

//�α���
extern void Login(char* id, char* passwd);
extern int check_ID(char* ID, char* PASSWORD);

//ȸ������
extern void SignUP();
extern void SAVE_ID(LOGIN);

//����
extern void quit();

//�����ڸ޴�
extern void admin_menu(); //�޴�ǥ��&����
extern void admin_NOW_MV_input(); //���� �Է�
extern void admin_REC_MV_input(); //��õ�� DB �Է�
extern void NOW_MV_del(); //���� ����
extern void REC_MV_del(); //��õ�� DB ����
extern void NOW_MV_read(); //���� ǥ��
extern void REC_MV_read(); //��õ�� DB ǥ��
extern void book_init(); //���ų��� �ʱ�ȭ

extern void help();

#endif