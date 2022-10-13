#ifndef __CUI_H__
#define __CUI_H__

typedef enum {
	NOCURSOR,
	SOLID_CURSOR,
	NORMAL_CURSOR
} CURSOR_TYPE;

typedef enum {
	BLACK,
	BLUE,
	GREEN,
	CYAN,
	RED,
	PURPLE,
	YELLOW,
	WHITE,
	GRAY,
	LIGHT_BLUE,
	LIGHT_GREEN,
	LIGHT_CYAN,
	LIGHT_RED,
	LIGHT_PURPLE,
	LIGHT_YELLOW,
	LIGHT_GRAY
} FONT_COLOR;

extern void gotoxy(int x, int y);
extern void title();
extern void set_cursor_type(CURSOR_TYPE type);
extern void fontcolor(FONT_COLOR color);

#endif