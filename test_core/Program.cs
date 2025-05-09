using System;
using System.Runtime.InteropServices;
using System.Text;

[DllImport("/home/dev/Desktop/code/core/cmake-build-debug/libcore.so", CallingConvention = CallingConvention.Cdecl)]
static extern void Test();

[DllImport("/home/dev/Desktop/code/core/cmake-build-debug/libcore.so", CallingConvention = CallingConvention.Cdecl)]
static extern string w2c([MarshalAs(UnmanagedType.LPWStr)] string data);

[DllImport("/home/dev/Desktop/code/core/cmake-build-debug/libcore.so", CallingConvention = CallingConvention.Cdecl)]
static extern int CCustBase64_Encode(String data,int data_len,[MarshalAs(UnmanagedType.LPWStr)] string out_data,int out_data_len);

[DllImport("/home/dev/Desktop/code/core/cmake-build-debug/libcore.so", CallingConvention = CallingConvention.Cdecl)]
static extern int CCustBase64_Decode([MarshalAs(UnmanagedType.LPWStr)] string data,int data_len,[MarshalAs(UnmanagedType.LPWStr)] string out_data,int out_data_len);

[DllImport("/home/dev/Desktop/code/core/cmake-build-debug/libcore.so", CallingConvention = CallingConvention.Cdecl)]
static extern int CCustBase64_Decode_CS(string data,int data_len,[MarshalAs(UnmanagedType.LPWStr)] string out_data,int out_data_len);

[DllImport("/home/dev/Desktop/code/core/cmake-build-debug/libcore.so", CallingConvention = CallingConvention.Cdecl)]
static extern void CCustBase64_Encode1();

Console.WriteLine("Hello, C# in Linux!");
String str="Hello";

Test();
Console.WriteLine(w2c(str));
CCustBase64_Encode1();


int x = CCustBase64_Encode(str,str.Length,str,128); 
string ret = w2c(str);
Console.WriteLine(ret);

Console.WriteLine("===>tmp_base64== {0}", ret);
int y = CCustBase64_Decode_CS(ret,x,ret,128);
Console.WriteLine(w2c(ret));