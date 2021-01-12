#include <iostream>
#include <Windows.h>
#include <TlHelp32.h>
#include <vector>
#include <string>

using namespace std;

uintptr_t GetModuleBaseAddress(DWORD procId, const wchar_t* modName)
{
    uintptr_t modBaseAddr = 0;
    HANDLE hSnap = CreateToolhelp32Snapshot(TH32CS_SNAPMODULE | TH32CS_SNAPMODULE32, procId);
    if (hSnap != INVALID_HANDLE_VALUE)
    {
        MODULEENTRY32 modEntry;
        modEntry.dwSize = sizeof(modEntry);
        if (Module32First(hSnap, &modEntry))
            do
            {
                if (!_wcsicmp(modEntry.szModule, modName))
                {
                    modBaseAddr = (uintptr_t)modEntry.modBaseAddr;
                    break;
                }
            } while (Module32Next(hSnap, &modEntry));
    }
CloseHandle(hSnap);
return modBaseAddr;

}

uintptr_t FindDMAAddy(HANDLE hProc, uintptr_t ptr, vector<unsigned int> offsets)
{
    uintptr_t addr = ptr;
    for (unsigned int i = 0; i < offsets.size(); ++i)
    {
        ReadProcessMemory(hProc, (BYTE*)addr, &addr, sizeof(addr), 0);
        addr += offsets[i];
    }
    return addr;
}

uintptr_t doALL(HANDLE hProcess, intptr_t module, DWORD addr, vector<unsigned int> offsets) {
    uintptr_t mfbaseaddr = module + addr;
    uintptr_t getthatshit = FindDMAAddy(hProcess, mfbaseaddr, offsets);
    return getthatshit;
}

string ascii = R"(
  _________ __     __  __   
 /   _____/|  |__ |__|/  |_ 
 \_____  \ |  |  \|  \   __\
 /        \|   Y  \  ||  |  
/_______  /|___|  /__||__|  
        \/      \/          

    )";


void printfuck(float speed, bool impostor, bool noclip, float killcd, int killd, int maxplayer, int particount) {

    system("cls");
    cout << ascii << endl;
    cout << "Speed = " << speed << endl;
    cout << "Impostor = " << impostor << endl;
    cout << "NoClip = " << noclip << endl;
    cout << "Kill CD = " << killcd << endl;
    cout << "Kill Distance = " << killd << endl;
    cout << "Max Player = " << maxplayer << endl;
    cout << "Participant Count = " << particount << endl;
    string thit = R"(
NUMLOCK_1 = Speed
NUMLOCK_2 = Impostor
NUMLOCK_3 = NoClip
NUMLOCK_4 = KillCD
NUMLOCK_5 = Kill Distance
NUMLOCK_6 = Max Player
NUMLOCK_7 = Participant Count
NUMLOCK_8 = Teleport

)";
cout << thit<<endl;
}

int main() {
    
    HWND ourconsole = GetConsoleWindow();
    if (ourconsole != NULL) { MoveWindow(ourconsole,50,144,345,575,TRUE); ShowScrollBar(ourconsole, SB_BOTH, FALSE);}



    SetConsoleTitle(TEXT("AmongUS Sucks"));
    

    cout << ascii<<endl;

    HWND hwnd = FindWindowA(NULL, "Among Us");
    DWORD procID;
    GetWindowThreadProcessId(hwnd, &procID);

    intptr_t modulebase = GetModuleBaseAddress(procID, L"GameAssembly.dll");
    intptr_t playerbase = GetModuleBaseAddress(procID, L"UnityPlayer.dll");

    HANDLE hProcess = OpenProcess(PROCESS_ALL_ACCESS, FALSE, procID);

    uintptr_t speedpointer = doALL(hProcess, modulebase, 0x01BC7D88, { 0x8,0xB74 });//float
    uintptr_t killcdpointer = doALL(hProcess, modulebase, 0x01BB6A6C, { 0x4,0x80 });//float
    uintptr_t impostorpointer = doALL(hProcess, modulebase, 0x01C57F7C, { 0x5C,0x0,0x34,0x28 });//int (1 = ON,0 = Off)
    uintptr_t kdpointer = doALL(hProcess, modulebase, 0x01BC7D88, { 0x8,0xBA0 });//int (0 = Short,1 = Medium,2 = Long)
    uintptr_t maxplayerpointer = doALL(hProcess, modulebase, 0x01BB6A6C, { 0x4,0x68 });//int
    uintptr_t participantcount = doALL(hProcess, modulebase, 0x01C5FC88, { 0x734 });
    uintptr_t noclippointer = playerbase + 0x960CA6;//int (133 = ON,132 = Off)
    uintptr_t playerX = doALL(hProcess, playerbase, 0x01277F00, { 0x20,0x2C,0x3EC });//float
    uintptr_t playerY = doALL(hProcess, playerbase, 0x01277F00, { 0x20,0x2C,0x3F0 });//float
    

    float killcd = 0, playerx, playery,speed = 0;
    int killd = 0, maxplayer = 0,particount = 0,fuckimp,fucknoclip;
    bool noclip = false, impostor = false;
    
    printfuck(speed, impostor, noclip, killcd, killd, maxplayer, particount);




    while (true)
    {
        if (GetAsyncKeyState(VK_NUMPAD1) & 1)
        {
            cout << "Speed: ";
            cin >> speed;
            WriteProcessMemory(hProcess, (LPVOID)speedpointer, &speed, sizeof(speed), 0);
            printfuck(speed, impostor, noclip, killcd, killd, maxplayer, particount);
        }

        else if (GetAsyncKeyState(VK_NUMPAD2) & 1)
        {
            impostor = !impostor;
            if (impostor) { fuckimp = 1; WriteProcessMemory(hProcess, (LPVOID)impostorpointer, &fuckimp, sizeof(fuckimp), 0); }
            else { fuckimp = 0; WriteProcessMemory(hProcess, (LPVOID)impostorpointer, &fuckimp, sizeof(fuckimp), 0); }
            printfuck(speed, impostor, noclip, killcd, killd, maxplayer, particount);
        }

        else if (GetAsyncKeyState(VK_NUMPAD3) & 1)
        {
            noclip = !noclip;
            if (noclip) { fucknoclip = 133; WriteProcessMemory(hProcess, (LPVOID)noclippointer, &fucknoclip, sizeof(byte), 0); }
            else { fucknoclip = 132; WriteProcessMemory(hProcess, (LPVOID)noclippointer, &fucknoclip, sizeof(byte), 0); }
            printfuck(speed, impostor, noclip, killcd, killd, maxplayer, particount);
            
        }

        else if (GetAsyncKeyState(VK_NUMPAD4) & 1)
        {
            cout << "Kill Cool Down: ";
            cin >> killcd;
            WriteProcessMemory(hProcess, (LPVOID)killcdpointer, &killcd, sizeof(killcd), 0);
            printfuck(speed, impostor, noclip, killcd, killd, maxplayer, particount);
        }

        else if (GetAsyncKeyState(VK_NUMPAD5) & 1)
        {
            cout << "Kill Distance(0 = Short,1 = Medium,2 = Long) : ";
            cin >> killd;
            if (killd != 0 || 1 || 2)
            {
                system("cls");
                cout << "SOMETHING WENT WRONG"<<endl;
            }
            WriteProcessMemory(hProcess, (LPVOID)kdpointer, &killd, sizeof(killd), 0);
            printfuck(speed, impostor, noclip, killcd, killd, maxplayer, particount);
        }

        else if (GetAsyncKeyState(VK_NUMPAD6) & 1)
        {
            cout << "Max Player: ";
            cin >> maxplayer;
            WriteProcessMemory(hProcess, (LPVOID)maxplayerpointer, &maxplayer, sizeof(maxplayer), 0);
            printfuck(speed, impostor, noclip, killcd, killd, maxplayer, particount);
        }

        else if (GetAsyncKeyState(VK_NUMPAD7) & 1)
        {
            cout << "Participant count: ";
            cin >> particount;
            WriteProcessMemory(hProcess, (LPVOID)participantcount, &particount, sizeof(particount), 0);
            printfuck(speed, impostor, noclip, killcd, killd, maxplayer, particount);
        }

        else if (GetAsyncKeyState(VK_NUMPAD8) & 1)
        {
            cout << "X cordinate(enter to skip): ";
            cin >> playerx;
            cout << "Y cordinate(enter to skip): ";
            cin >> playery;
            WriteProcessMemory(hProcess, (LPVOID)playerX, &playerx, sizeof(playerx), 0); 
            WriteProcessMemory(hProcess, (LPVOID)playerY, &playery, sizeof(playery), 0); 
            printfuck(speed, impostor, noclip, killcd, killd, maxplayer, particount);
        }

    }

    return 0;
}