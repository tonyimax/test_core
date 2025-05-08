using System;
using System.Runtime.InteropServices;

[DllImport("/home/dev/Desktop/code/core/cmake-build-debug/libcore.so", CallingConvention = CallingConvention.Cdecl)]
static extern void Test();

[DllImport("/home/dev/Desktop/code/core/cmake-build-debug/libcore.so", CallingConvention = CallingConvention.Cdecl)]
static extern string w2c([MarshalAs(UnmanagedType.LPWStr)] string data);

[DllImport("/home/dev/Desktop/code/core/cmake-build-debug/libcore.so", CallingConvention = CallingConvention.Cdecl)]
static extern int CCustBase64_Encode(String data,int data_len,[MarshalAs(UnmanagedType.LPWStr)] string out_data,int out_data_len);

[DllImport("/home/dev/Desktop/code/core/cmake-build-debug/libcore.so", CallingConvention = CallingConvention.Cdecl)]
static extern Object createObject();

[DllImport("/home/dev/Desktop/code/core/cmake-build-debug/libcore.so", CallingConvention = CallingConvention.Cdecl)]
static extern void CCustBase64_Encode1();

Console.WriteLine("Hello, C# in Linux!");
String str = new String("Hello");

Test();
Console.WriteLine(w2c(str));
CCustBase64_Encode1();

int x = CCustBase64_Encode("Hello",5,str,128);
Console.WriteLine("===>CCustBase64_Encode:"+str);