#ifndef __MENU_H__
#define __MENU_H__

// main menu
typedef enum {
	MA_INPUT = 1,
	MA_SHOW,
	MA_DEL,
	MA_UPDATE,
	MA_SEARCH,
	MA_INIT,
	MA_EXIT
} MAIN_MENU;

extern int main_menu();

#endif
