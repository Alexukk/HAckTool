using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace Csharp_studies
{
    internal class HackTool
    {
        public static void Hack()
        {
            var intrusionLog = new List<string>
{
    "Initializing secure shell [SSH]...",
    "Scanning network perimeter for exposed ports...",
    "Target host resolved: IP [192.168.1.1]...",
    "Attempting passive DNS zone transfer...",
    "Enumerating common service banners...",
    "Analyzing firewall state table...",
    "Sending SYN flood probe (1/10)...",
    "Sending SYN flood probe (2/10)...",
    "Sending SYN flood probe (3/10)...",
    "Sending SYN flood probe (4/10)...",
    "Sending SYN flood probe (5/10)...",
    "Sending SYN flood probe (6/10)...",
    "Sending SYN flood probe (7/10)...",
    "Sending SYN flood probe (8/10)...",
    "Sending SYN flood probe (9/10)...",
    "Sending SYN flood probe (10/10)...",
    "Port 22/TCP detected: Running OpenSSH...",
    "Launching bruteforce module: Hydra-X v3.1...",
    "Loading common password list (Dictionary.lst)...",
    "Attempt 001/100: User 'admin' -> Password failed.",
    "Attempt 002/100: User 'root' -> Password failed.",
    "Attempt 003/100: User 'guest' -> Password failed.",
    "Attempt 004/100: User 'oracle' -> Password failed.",
    "Attempt 005/100: User 'user' -> Password failed.",
    "Attempt 006/100: User 'dev' -> Password failed.",
    "Attempt 007/100: User 'operator' -> Password failed.",
    "Attempt 008/100: User 'test' -> Password failed.",
    "Attempt 009/100: User 'jdoe' -> Password failed.",
    "Attempt 010/100: User 'service' -> Password failed.",
    "Attempt 011/100: Found valid credentials: 'svc_user'...",
    "Access granted. Session established.",
    "Elevating process privileges to root...",
    "Searching file system for sensitive keywords...",
    "Data structure located: /var/lib/data/keys.dat",
    "Initiating data exfiltration (10%)...",
    "Initiating data exfiltration (20%)...",
    "Initiating data exfiltration (30%)...",
    "Initiating data exfiltration (40%)...",
    "Initiating data exfiltration (50%)...",
    "Initiating data exfiltration (60%)...",
    "Initiating data exfiltration (70%)...",
    "Initiating data exfiltration (80%)...",
    "Initiating data exfiltration (90%)...",
    "Data transfer complete: 1.44 GB extracted.",
    "Wiping session logs and command history...",
    "Removing trace files and temporary payloads...",
    "Executing time-delay wipe protocol...",
    "Session terminated. Connection closed.",
    "System status: Operation successful."
};
            var systemAnnihilation = new List<string>
{
    // --- 1. INITIALIZATION AND ACCESS ---
    "EXECUTING LEVEL 5 PRIVILEGED INSTRUCTION SET...",
    "INITIATING UNRECOVERABLE DATA ANNIHILATION PROTOCOL...",
    "WARNING: SYSTEM INTEGRITY THREAT LEVEL: MAXIMUM.",
    "Bypassing Windows Resource Protection (WRP)...",
    "Bypassing File System Protection (FSP) using kernel hook...",
    "Acquiring lock on critical OS kernel (ntoskrnl.exe)...",
    "Allocating 512MB RAM buffer for payload execution...",
    "Setting target permissions: DELETE / OVERWRITE / FORCE...",
    "Locating base system directory: C:\\Windows\\System32...",
    "Session Authentication: ROOT/SYSTEM",
    "--------------------------------------------------",

    // --- 2. CORE OS COMPONENT REMOVAL (Windows Boot/Kernel) ---
    "TARGETING CRITICAL BOOT SECTOR AND KERNEL FILES:",
    "Deleting Master Boot Record (MBR) backup...",
    "Deleting UEFI Boot Configuration Data (BCD) store...",
    "Deleting Critical Boot Component: winload.efi...",
    "Deleting OS loader: bootmgr...",
    "Deleting core system module: ntdll.dll...",
    "Deleting essential hardware abstraction layer (hal.dll)...",
    "Deleting crucial Executive subsystem files...",
    "Deleting Primary Kernel Image: ntoskrnl.exe...",
    "Deleting essential kernel stub: kernel32.dll...",
    "Deletion complete: Boot/Kernel components (100%)",
    "--------------------------------------------------",
    
    // --- 3. DRIVER AND SYSTEM SERVICE REMOVAL ---
    "TARGETING HARDWARE AND SERVICE LAYER:",
    "Scanning for DLL dependencies (1/20)...",
    "Scanning for DLL dependencies (2/20)...",
    "Scanning for DLL dependencies (3/20)...",
    "Scanning for DLL dependencies (4/20)...",
    "Scanning for DLL dependencies (5/20)...",
    "Scanning for DLL dependencies (6/20)...",
    "Scanning for DLL dependencies (7/20)...",
    "Scanning for DLL dependencies (8/20)...",
    "Scanning for DLL dependencies (9/20)...",
    "Scanning for DLL dependencies (10/20)...",
    "Scanning for DLL dependencies (11/20)...",
    "Scanning for DLL dependencies (12/20)...",
    "Scanning for DLL dependencies (13/20)...",
    "Scanning for DLL dependencies (14/20)...",
    "Scanning for DLL dependencies (15/20)...",
    "Scanning for DLL dependencies (16/20)...",
    "Scanning for DLL dependencies (17/20)...",
    "Scanning for DLL dependencies (18/20)...",
    "Scanning for DLL dependencies (19/20)...",
    "Scanning for DLL dependencies (20/20)...",
    "Deleting essential graphics driver: igfxmtc.sys...",
    "Deleting network stack driver: tcpip.sys...",
    "Deleting NTFS filesystem driver: ntfs.sys...",
    "Deleting primary audio subsystem driver...",
    "Deleting core process file: services.exe...",
    "Deleting core print spooler service file...",
    "Deleting system policy configuration file...",
    "Termination complete: Drivers/Services (100%)",
    "--------------------------------------------------",

    // --- 4. SHELL AND USER ENVIRONMENT DESTRUCTION ---
    "TARGETING USER ENVIRONMENT AND INTERFACE:",
    "Deleting primary shell executable: explorer.exe...",
    "Deleting user profile registry data...",
    "Deleting security credential cache (LSA)...",
    "Deleting System Policy Configuration file...",
    "Deleting Windows Management Instrumentation files...",
    "Deleting cached user interface files...",
    "Deleting local account database (SAM file)...",
    "Deleting essential font libraries...",
    "Deletion complete: Shell/UI (100%)",
    "--------------------------------------------------",

    // --- 5. REGISTRY AND CONFIGURATION WIPES ---
    "TARGETING SYSTEM REGISTRY HIVES:",
    "Acquiring exclusive write lock on Registry...",
    "Deleting core registry hive: HKEY_LOCAL_MACHINE (1/5)...",
    "Deleting core registry hive: HKEY_LOCAL_MACHINE (2/5)...",
    "Deleting core registry hive: HKEY_LOCAL_MACHINE (3/5)...",
    "Deleting core registry hive: HKEY_LOCAL_MACHINE (4/5)...",
    "Deleting core registry hive: HKEY_LOCAL_MACHINE (5/5)...",
    "Deleting user registry hive: HKEY_USERS...",
    "Deleting system restore point data...",
    "Deleting legacy boot record: boot.ini...",
    "Zeroing out system configuration file: config.sys...",
    "Deletion complete: Registry/Config (100%)",
    "--------------------------------------------------",

    // --- 6. DISK SANITIZATION AND TRACE REMOVAL (Phase 1) ---
    "TARGETING VIRTUAL MEMORY AND LOGS:",
    "Clearing hibernation file (hiberfil.sys)...",
    "Removing virtual memory swap file (pagefile.sys)...",
    "Wiping Event Log entries (Application)...",
    "Wiping Event Log entries (Security)...",
    "Wiping Event Log entries (System)...",
    "Wiping Event Log entries (Hardware)...",
    "Wiping Event Log entries (DNS/DHCP)...",
    "Zeroing disk metadata pointers (MFT/FAT)...",
    "Trace Removal Phase 1 complete.",
    "--------------------------------------------------",
    
    // --- 7. DEEPER FILE SYSTEM DESTRUCTION ---
    "TARGETING RECOVERY AND NON-OS DATA:",
    "Deleting all files in C:\\Program Files\\ (1/10)...",
    "Deleting all files in C:\\Program Files\\ (2/10)...",
    "Deleting all files in C:\\Program Files\\ (3/10)...",
    "Deleting all files in C:\\Program Files\\ (4/10)...",
    "Deleting all files in C:\\Program Files\\ (5/10)...",
    "Deleting all files in C:\\Program Files\\ (6/10)...",
    "Deleting all files in C:\\Program Files\\ (7/10)...",
    "Deleting all files in C:\\Program Files\\ (8/10)...",
    "Deleting all files in C:\\Program Files\\ (9/10)...",
    "Deleting all files in C:\\Program Files\\ (10/10)...",
    "Deleting all files in C:\\Users\\ (1/5)...",
    "Deleting all files in C:\\Users\\ (2/5)...",
    "Deleting all files in C:\\Users\\ (3/5)...",
    "Deleting all files in C:\\Users\\ (4/5)...",
    "Deleting all files in C:\\Users\\ (5/5)...",
    "Deleting all files in C:\\temp\\...",
    "Deletion complete: Non-OS/User Data (100%)",
    "--------------------------------------------------",

    // --- 8. FINAL SANITIZATION PASSES (DOOD 5220.22-M) ---
    "INITIATING DOD 5220.22-M SEVEN-PASS SANITIZATION:",
    "Applying disk surface sanitization Pass 1/7: Writing 0x00...",
    "Applying disk surface sanitization Pass 2/7: Writing 0xFF...",
    "Applying disk surface sanitization Pass 3/7: Writing Random...",
    "Applying disk surface sanitization Pass 4/7: Writing 0x00...",
    "Applying disk surface sanitization Pass 5/7: Writing 0xFF...",
    "Applying disk surface sanitization Pass 6/7: Writing Random...",
    "Applying disk surface sanitization Pass 7/7: Writing Verify...",
    "Sanitization Complete: Data integrity zeroed.",
    "--------------------------------------------------",

    // --- 9. FINAL STATUS ---
    "Initiating final file index rebuild...",
    "Attempting to re-establish kernel link...",
    "System Integrity Status: CRITICAL - NO KERNEL.",
    "System Stability Check: FAILED.",
    "System Partition Check: UNMOUNTABLE.",
    "STATUS: WINDOWS ANNIHILATION COMPLETE.",
    "CORE PROCESSES FAILED. FORCED REBOOT REQUIRED.",
    "Rebooting system with limited functionality...",
    "SYSTEM HALT IMMINENT. GOODBYE."
};



            Random random = new Random();
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Hacking in progress...");
            Console.WriteLine("Enter Username..");
            var username = Console.ReadLine();
            Console.WriteLine("Url to DDos web app.. ");
            var url = Console.ReadLine();
            Console.WriteLine($"Hack Started {username}!");
            Console.Clear();
            Console.WriteLine("DDOS progress for: " + url);
            for (int i = 0; i <= 100; i += 1)
            {
                Console.WriteLine($"\rProgress: {i}%");
                Thread.Sleep(random.Next(1, 200));
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Loading("Status Check", 4);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("STATUS: SATISFIED");
            Thread.Sleep(500);
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("Start deep logs comparison? Y/n");
            var input = Console.ReadLine();
            Console.Clear();
            if (input != null && (input.ToLower() == "y" || input.ToLower() == "yes"))
            {
                Console.WriteLine("Starting Deep logs research...");
            }
            else
            {
                Console.WriteLine("Fuck you broski I'll do it anyways)))");
            }
            Console.ForegroundColor = ConsoleColor.Blue;
            Loading("Prepearing", 3);
            Console.WriteLine("------------------------------");

            Console.ForegroundColor = ConsoleColor.Yellow;
            foreach (var item in intrusionLog)
            {
                Console.WriteLine(item);
                Thread.Sleep(300);
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("SIDE SSH CONNECTION DETECTED!");
            Thread.Sleep(1400);
            Console.WriteLine("Fuck! Man you really didn't set up a VPN before HACK?");
            Thread.Sleep(2800);
            Console.WriteLine("THEY FOUND YOU!");
            Thread.Sleep(1300);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Loading("Getting Admin Rights", 2);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("VANISHING SYSTEM:");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Loading("Checking for system details", 3);
            Thread.Sleep(300);
            Console.ForegroundColor = ConsoleColor.Red;
            foreach (var item in systemAnnihilation)
            {
                Console.WriteLine(item);
                Thread.Sleep(100);
            }
            Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://youtu.be/xvFZjo5PgG0?si=-4jufGciLZMY-yFF",
                UseShellExecute = true 
            });
        }


        public static void Loading(string text, int amountOfIterations)
        {
            int cursorX = Console.CursorLeft;
            int cursorY = Console.CursorTop;

            for (int i = 0; i < amountOfIterations; i++)
            {
                Console.SetCursorPosition(cursorX, cursorY);

                Console.Write($"{text}.   ");
                Thread.Sleep(500);

                Console.SetCursorPosition(cursorX, cursorY);

                Console.Write($"{text}..  ");
                Thread.Sleep(500);


                Console.SetCursorPosition(cursorX, cursorY);


                Console.Write($"{text}...");
                Thread.Sleep(500);

            }
            Console.WriteLine();
        }

    }
}
