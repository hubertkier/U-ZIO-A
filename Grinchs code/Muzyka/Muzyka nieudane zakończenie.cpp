
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
		Beep(220, 1350);
		Beep(195, 1350);
		Beep(220, 1350);
		Beep(195, 1350);


	} while (n == 0);

}
