#include "pch.h"
#include <iostream>
#include <windows.h>

int main()
{
	int n;
	n = 0;
	std::cout << R"(
    ____          _              _                   
   /  ___\  _ _  (_)_ __    ___ | |___    
   | | __  | '_\ | | '_ \  / __||  __ \   
   | ||_ | | |   | | | | || (__ | | | |
   \_____/ |_|   |_|_| |_| \___||_| |_|
)";
	do {
		Beep(698, 300);
		Beep(698, 300);
		Beep(1046, 300);
		Beep(698, 300);
		Beep(698, 300);
		Beep(1244, 600);
		Beep(1108, 300);
	} while (n == 0);

}
