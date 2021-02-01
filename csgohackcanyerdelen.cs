public Memory(int processId)
{

    Handle = OpenProcess((uint)0x1F0FFF, false, processId);

}

~Memory()
{

    CloseHandle(Handle);

}
public byte[] ReadBytes(IntPtr address, int bufferSize)
{
    var buffer = new byte[bufferSize];
    int bytesRead;

    ReadProcessMemory(Handle, address, buffer, buffer.Length, out bytesRead);

    return buffer;
}
public int ReadInt(IntPtr address)
{

    return BitConverter.ToInt32(ReadBytes(address, 4), 0);

}
public vo id Write(IntPtr address, byte[] buffer)
{
    int bytesWrote;

    WriteProcessMemory(Handle, address, buffer, buffer.Length, out bytesWrote);
}
dwLocalPlayer = 0xAAFC3C
foreach (ProcessModule module in process.Modules) // Process, csgo'nun processi
{
   if (module.ModuleName == "client.dll")
   {
      clientAddress = module.BaseAddress;
   }
}
mem.ReadInt((IntPtr)(((int)clientAddress) + Offsets.dwLocalPlayer))
m_iTeamNum = 0xF0
mem.ReadInt((IntPtr)(localPlayer + Offsets.m_iTeamNum));
mem.WriteInt((IntPtr)((int)(clientAddress) + 0x4F23F08), 5);
mem.WriteInt((IntPtr)((int)(clientAddress) + 0x4F23F08), 4);
[System.Runtime.InteropServices.DllImport("User32.dll")]
private static extern short GetAsyncKeyState(System.Windows.Forms.Keys vKey);
if (GetAsyncKeyState(System.Windows.Forms.Keys.Space) != 0)
{
    //By Kolmetyo.
}